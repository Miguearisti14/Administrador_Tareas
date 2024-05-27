using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminTareasAvanzado
{
    public partial class Form1 : Form
    {
        //Atributos
        private List<Tarea> tareas = new List<Tarea> { };
        private string nombre;
        private DateTime fecha_vencimiento;
        private string prioridad;
        private bool estado;
        private string comentario;
        private int posicion;
        private List<Tarea> lista_prioridad = new List<Tarea>();
        private List<Tarea> lista_incompletas = new List<Tarea>();
        private List<Tarea> lista_completas = new List<Tarea>();
        private List<Tarea> orden_fecha = new List<Tarea>();

        //Eventos
        public event EventHandler<string> TareaAñadida;
        public event EventHandler<string> TareaModificada;
        public event EventHandler<string> TareaEliminada;
        public event EventHandler<string> TareaCompletada;


        public Form1()
        {
            InitializeComponent();

            //Inicializamos para que la fecha minima sea la de hoy
            boxFecha.MinDate = DateTime.Now.Date;

            

            //Al menos se debe agregar una tarea para activar estas opciones
            tslBuscar.Enabled = false;
            tslEliminar.Enabled = false;
            tslModificar.Enabled = false;
            tslCompletada.Enabled = false;

            
            //Suscripciones a los eventos

            TareaAñadida += FuncionesEventos.tarea_añadida;

            TareaModificada += FuncionesEventos.tarea_modificada;

            TareaEliminada += FuncionesEventos.tarea_eliminada;

            TareaCompletada += FuncionesEventos.tarea_completada;
        }

        #region eventos_botones

        //Evento del botón agregar
        private void tslAgregar_Click(object sender, EventArgs e)
        {
            //Validación de que el usuario si ingrese un nombre
            if (ValidarNombre() == false)
            {
                return;
            }
            //Validación de que el usuario si seleccione una prioridad
            if (ValidarPrioridad() == false)
            {
                return;
            }
            //Validación de que no se ingresen tareas con el mismo nombre
            if (NombreEnUso(boxNombre.Text))
            {
                error.SetError(boxNombre, "La tarea con ese nombre ya está registrada");
                LimpiarBox();
                boxNombre.Focus();
                return;
            }
            error.SetError(boxNombre, "");

            //Se agrega la tarea

            //Se guardan las selecciones del usuario en variables
            nombre = boxNombre.Text;
            fecha_vencimiento = boxFecha.Value;
            prioridad = boxPrioridad.SelectedItem.ToString();
            estado = false;
            comentario = boxComentario.Text;

            //Se añade la tarea a la lista
            tareas.Add(new Tarea(nombre, fecha_vencimiento, prioridad, comentario));

            //Se pone la tarea agregada en el campo para ello y se muestran las tareas segun el filtro
            dgvTareas.DataSource = null;
            
            switch (boxOrdenar.SelectedIndex)
            {
                case 3:

                    dgvTareas.DataSource = lista_incompletas;

                    break;

                case 4:

                    dgvTareas.DataSource = lista_completas;

                    break;

                default:

                    dgvTareas.DataSource = tareas;

                    break;

            }

            //Metodo para limpiar los  textBoxs
            LimpiarBox();

            //Para que el cursor vuelva a salir en el campo de nombre
            boxNombre.Focus();

            //Una vez se agregue una tarea, se habilita este botón
            tslBuscar.Enabled = true;

            //Se dispara el evento
            if (TareaAñadida != null)
            {
                TareaAñadida(this, "");
            }

        }


        //Evento para el botón de Salir
        private void tslSalir_Click(object sender, EventArgs e)
        {
            //Cierra el programa
            Application.Exit();
        }


        //Evento de la opción Buscar
        private void tslBuscar_Click(object sender, EventArgs e)
        {
            //Validar el nombre de la tarea. Si la validación falla, salir del método
            if (ValidarNombre() == false)
            {
                return;
            }

            //Busca la tarea por el nombre ingresado
            Tarea miTarea = GetTarea(boxNombre.Text);

            //Si la tarea no se encuentra, mostrar un mensaje de error y limpiar los cuadros de texto
            if (miTarea == null)
            {
                error.SetError(boxNombre, "La tarea no se encuentra registrada");
                LimpiarBox();
                boxNombre.Focus();
                return;
            }
            else
            {
                error.SetError(boxNombre, "");

                //Llenar los controles con los datos de la tarea encontrada
                boxNombre.Text = miTarea.Nombre;
                boxFecha.Value = miTarea.Fecha_Vencimiento;
                boxPrioridad.SelectedItem = miTarea.Prioridad;
                boxComentario.Text = miTarea.Comentario;

                //Se habilita el botón eliminar
                tslEliminar.Enabled = true;
                tslModificar.Enabled = true;
                tslCompletada.Enabled = true;

            }
        }


        //Evento de la opción eliminar
        private void tslEliminar_Click(object sender, EventArgs e)
        {
            //Verifica si el cuadro de texto está vacío
            if (boxNombre.Text == null)
            {
                error.SetError(boxNombre, "Debe buscar la tarea a eliminar");
                LimpiarBox();
                boxNombre.Focus();
                tslEliminar.Enabled = true;
                return;
            }
            else
            {
                error.SetError(boxNombre, "");

                //Mostrar un cuadro de diálogo de confirmación
                DialogResult Respuesta = MessageBox.Show("¿Estás seguro que quieres eliminar la tarea?",
                                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2);

                //Si el usuario confirma que desea eliminar la tarea
                if (Respuesta == DialogResult.Yes)
                {
                    //Recorre la lista de tareas para encontrar y eliminar la tarea correspondiente
                    foreach (Tarea miTarea in tareas)
                    {
                        if (miTarea.Nombre == boxNombre.Text)
                        {
                            //Elimina la tarea
                            tareas.Remove(miTarea);
                            break;
                        }
                    }
                    LimpiarBox();

                    //Desactiva los botones nuevamente
                    tslEliminar.Enabled = false;
                    tslModificar.Enabled = false;
                    tslCompletada.Enabled = false;

                    //Actualiza el DataGridView para reflejar la eliminación segun el filtro
                    dgvTareas.DataSource = null;

                    switch (boxOrdenar.SelectedIndex)
                    {
                        case 3:

                            dgvTareas.DataSource = lista_incompletas;

                            break;

                        case 4:

                            dgvTareas.DataSource = lista_completas;

                            break;

                        default:

                            dgvTareas.DataSource = tareas;

                            break;

                    }

                    //Se dispara el evento
                    if (TareaEliminada != null)
                    {
                        TareaEliminada(this, "");
                    }
                }

            }
        }


        //Evento de la opción Modificar
        private void tslModificar_Click(object sender, EventArgs e)
        {
            Tarea miTarea = GetTarea(boxNombre.Text);

            //Verifica si el cuadro de texto está vacío
            if (boxNombre.Text == null)
            {
                error.SetError(boxNombre, "Debe buscar la tarea a eliminar");
                LimpiarBox();
                boxNombre.Focus();
                tslEliminar.Enabled = true;
                return;
            }
            else
            {
                error.SetError(boxNombre, "");


                miTarea.Nombre = boxNombre.Text;
                miTarea.Fecha_Vencimiento = boxFecha.Value;
                miTarea.Prioridad = boxPrioridad.SelectedItem.ToString();
                miTarea.Comentario = boxComentario.Text;


                LimpiarBox();
                //Desactiva los botones nuevamente
                tslEliminar.Enabled = false;
                tslModificar.Enabled = false;
                tslCompletada.Enabled = false;

                //Actualiza el DataGridView para reflejar la modificación segun el filtro
                dgvTareas.DataSource = null;

                switch (boxOrdenar.SelectedIndex)
                {
                    case 3:

                        dgvTareas.DataSource = lista_incompletas;

                        break;

                    case 4:

                        dgvTareas.DataSource = lista_completas;

                        break;

                    default:

                        dgvTareas.DataSource = tareas;

                        break;

                }

                //Se dispara el evento
                if (TareaModificada != null)
                {
                    TareaModificada(this, "");
                }
            }
        }


        //Evento para la opción de marcar tarea como completada
        private void tslCompletada_Click(object sender, EventArgs e)
        {
            Tarea miTarea = GetTarea(boxNombre.Text);

            //Verifica si el cuadro de texto está vacío
            if (boxNombre.Text == null)
            {
                error.SetError(boxNombre, "Debe buscar la tarea a completar");
                LimpiarBox();
                boxNombre.Focus();
                tslEliminar.Enabled = true;
                return;
            }
            else
            {
                error.SetError(boxNombre, "");

                miTarea.Estado = true;


                LimpiarBox();
                //Desactiva los botones nuevamente
                tslEliminar.Enabled = false;
                tslModificar.Enabled = false;
                tslCompletada.Enabled = false;

                //Actualiza el DataGridView para reflejar el cambio segun el filtro
                dgvTareas.DataSource = null;

                switch (boxOrdenar.SelectedIndex)
                {
                    case 3:

                        dgvTareas.DataSource = lista_incompletas;

                        break;

                    case 4:

                        dgvTareas.DataSource = lista_completas;

                        break;

                    default:

                        dgvTareas.DataSource = tareas;

                        break;

                }

                //Se dispara el evento
                if (TareaCompletada != null)
                {
                    TareaCompletada(this, "");
                }
            }
        }


        //Evento para ordenar
        private void boxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxOrdenar.SelectedIndex)
            {
                //Para mostrarlas todas
                case 1:
                    dgvTareas.DataSource = null;
                    dgvTareas.DataSource = tareas;
                    break;

                //Para ordenarlas por prioridad
                case 2:
                    lista_prioridad = tareas.OrderBy(tarea => tarea.Prioridad).ToList();
                    dgvTareas.DataSource = null;
                    dgvTareas.DataSource = lista_prioridad;
                    break;

                //Para mostrar solo las incompletas
                case 3:
                    lista_incompletas = tareas.Where(tarea => tarea.Estado == false).ToList();
                    dgvTareas.DataSource = null;
                    dgvTareas.DataSource = lista_incompletas;
                    break;

                //Para mostrar solo las completas
                case 4:
                    lista_completas = tareas.Where(tarea => tarea.Estado == true).ToList();
                    dgvTareas.DataSource = null;
                    dgvTareas.DataSource = lista_completas;
                    break;

                //Para ordenarlas por la fecha de vencimiento
                case 5:
                    orden_fecha = tareas.OrderBy(tarea => tarea.Fecha_Vencimiento).ToList();
                    dgvTareas.DataSource = null;
                    dgvTareas.DataSource = orden_fecha;
                    break;
            }
        }

        #endregion

        #region Metodos

        //Metodo que valida que no ingresen tareas con el mismo nombre
        private bool NombreEnUso(string nombre)
        {
            foreach (Tarea miTarea in tareas)
            {
                if (miTarea.Nombre == nombre)
                {
                    return true;
                }
            }
            return false;
        }


        //Metodo para validar la prioridad
        private bool ValidarPrioridad()
        {
            //Se verifica que el usuario si ingrese una prioridad
            if (string.IsNullOrEmpty(boxPrioridad.Text))
            {
                error.SetError(boxPrioridad, "Debe seleccionar una prioridad");
                return false;
            }
            else
            {
                error.SetError(boxPrioridad, "");
                return true;
            }

        }


        //Metodo para validar el nombre
        private bool ValidarNombre()
        {
            //Se verifica que el usuario si ingrese un nombre
            if (string.IsNullOrEmpty(boxNombre.Text))
            {
                error.SetError(boxNombre, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                error.SetError(boxNombre, "");
                return true;
            }

        }


        //Metodo para limpiar los textBoxs
        private void LimpiarBox()
        {
            boxNombre.Clear();
            boxPrioridad.SelectedIndex = 0;
            boxComentario.Clear();
        }
                

        //Metodo obtener o buscar tarea
        public Tarea GetTarea(string nombre)
        {
            //Busca la tarea que contenga el nombre

            //Para buscar solamente en las que está mostrando en el DataGridView
            switch (boxOrdenar.SelectedIndex)
            { 
                case 3:

                    return lista_incompletas.Find(tarea => tarea.Nombre.Contains(nombre));

                    break;

                case 4:

                    return lista_completas.Find(tarea => tarea.Nombre.Contains(nombre));

                    break;

                default:

                    return tareas.Find(tarea => tarea.Nombre.Contains(nombre));

                    break;

            }

            
        }



        #endregion

        
    }
}
