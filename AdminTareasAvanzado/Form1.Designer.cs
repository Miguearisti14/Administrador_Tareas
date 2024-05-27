namespace AdminTareasAvanzado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TituloAdmin = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.fechaVencimiento = new System.Windows.Forms.Label();
            this.textPrioridad = new System.Windows.Forms.Label();
            this.boxPrioridad = new System.Windows.Forms.ComboBox();
            this.boxFecha = new System.Windows.Forms.DateTimePicker();
            this.textComentario = new System.Windows.Forms.Label();
            this.boxComentario = new System.Windows.Forms.TextBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslAgregar = new System.Windows.Forms.ToolStripLabel();
            this.tslBuscar = new System.Windows.Forms.ToolStripLabel();
            this.tslEliminar = new System.Windows.Forms.ToolStripLabel();
            this.tslModificar = new System.Windows.Forms.ToolStripLabel();
            this.tslCompletada = new System.Windows.Forms.ToolStripLabel();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.textOrdenar = new System.Windows.Forms.Label();
            this.boxOrdenar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloAdmin
            // 
            this.TituloAdmin.AutoSize = true;
            this.TituloAdmin.BackColor = System.Drawing.Color.Transparent;
            this.TituloAdmin.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold);
            this.TituloAdmin.Location = new System.Drawing.Point(334, 33);
            this.TituloAdmin.Name = "TituloAdmin";
            this.TituloAdmin.Size = new System.Drawing.Size(640, 49);
            this.TituloAdmin.TabIndex = 0;
            this.TituloAdmin.Text = "ADMINISTRADOR DE TAREAS";
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNombre.AutoSize = true;
            this.textNombre.BackColor = System.Drawing.Color.Transparent;
            this.textNombre.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.textNombre.Location = new System.Drawing.Point(68, 128);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(120, 32);
            this.textNombre.TabIndex = 1;
            this.textNombre.Text = "Nombre";
            // 
            // boxNombre
            // 
            this.boxNombre.AllowDrop = true;
            this.boxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxNombre.BackColor = System.Drawing.Color.White;
            this.boxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxNombre.Font = new System.Drawing.Font("Book Antiqua", 11F);
            this.boxNombre.Location = new System.Drawing.Point(213, 133);
            this.boxNombre.Multiline = true;
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(136, 27);
            this.boxNombre.TabIndex = 2;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaVencimiento.AutoSize = true;
            this.fechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.fechaVencimiento.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.fechaVencimiento.Location = new System.Drawing.Point(62, 181);
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.Size = new System.Drawing.Size(125, 32);
            this.fechaVencimiento.TabIndex = 3;
            this.fechaVencimiento.Text = "Fecha de";
            // 
            // textPrioridad
            // 
            this.textPrioridad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrioridad.AutoSize = true;
            this.textPrioridad.BackColor = System.Drawing.Color.Transparent;
            this.textPrioridad.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.textPrioridad.Location = new System.Drawing.Point(62, 261);
            this.textPrioridad.Name = "textPrioridad";
            this.textPrioridad.Size = new System.Drawing.Size(135, 32);
            this.textPrioridad.TabIndex = 5;
            this.textPrioridad.Text = "Prioridad";
            // 
            // boxPrioridad
            // 
            this.boxPrioridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxPrioridad.BackColor = System.Drawing.SystemColors.Window;
            this.boxPrioridad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxPrioridad.Font = new System.Drawing.Font("Book Antiqua", 11F);
            this.boxPrioridad.FormattingEnabled = true;
            this.boxPrioridad.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.boxPrioridad.Location = new System.Drawing.Point(213, 261);
            this.boxPrioridad.Name = "boxPrioridad";
            this.boxPrioridad.Size = new System.Drawing.Size(136, 35);
            this.boxPrioridad.TabIndex = 6;
            // 
            // boxFecha
            // 
            this.boxFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxFecha.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.boxFecha.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.boxFecha.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.boxFecha.CustomFormat = "dd/mm/yyyy";
            this.boxFecha.Font = new System.Drawing.Font("Book Antiqua", 11F);
            this.boxFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.error.SetIconAlignment(this.boxFecha, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.boxFecha.Location = new System.Drawing.Point(213, 192);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(136, 35);
            this.boxFecha.TabIndex = 7;
            this.boxFecha.Value = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // textComentario
            // 
            this.textComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textComentario.AutoSize = true;
            this.textComentario.BackColor = System.Drawing.Color.Transparent;
            this.textComentario.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComentario.Location = new System.Drawing.Point(56, 334);
            this.textComentario.Name = "textComentario";
            this.textComentario.Size = new System.Drawing.Size(165, 32);
            this.textComentario.TabIndex = 10;
            this.textComentario.Text = "Comentario";
            // 
            // boxComentario
            // 
            this.boxComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxComentario.BackColor = System.Drawing.SystemColors.Window;
            this.boxComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxComentario.Font = new System.Drawing.Font("Book Antiqua", 11F);
            this.boxComentario.Location = new System.Drawing.Point(213, 331);
            this.boxComentario.Name = "boxComentario";
            this.boxComentario.Size = new System.Drawing.Size(136, 35);
            this.boxComentario.TabIndex = 11;
            // 
            // dgvTareas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTareas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTareas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTareas.Location = new System.Drawing.Point(501, 110);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 62;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.Size = new System.Drawing.Size(528, 301);
            this.dgvTareas.TabIndex = 12;
            // 
            // tsmMenu
            // 
            this.tsmMenu.BackColor = System.Drawing.Color.Transparent;
            this.tsmMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAgregar,
            this.tslBuscar,
            this.tslEliminar,
            this.tslModificar,
            this.tslCompletada,
            this.tslSalir});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(1119, 33);
            this.tsmMenu.TabIndex = 13;
            this.tsmMenu.Text = "toolStrip1";
            // 
            // tslAgregar
            // 
            this.tslAgregar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.tslAgregar.Name = "tslAgregar";
            this.tslAgregar.Size = new System.Drawing.Size(99, 28);
            this.tslAgregar.Text = "Agregar";
            this.tslAgregar.Click += new System.EventHandler(this.tslAgregar_Click);
            // 
            // tslBuscar
            // 
            this.tslBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.tslBuscar.Name = "tslBuscar";
            this.tslBuscar.Size = new System.Drawing.Size(86, 28);
            this.tslBuscar.Text = "Buscar";
            this.tslBuscar.Click += new System.EventHandler(this.tslBuscar_Click);
            // 
            // tslEliminar
            // 
            this.tslEliminar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(108, 28);
            this.tslEliminar.Text = "Eliminar";
            this.tslEliminar.Click += new System.EventHandler(this.tslEliminar_Click);
            // 
            // tslModificar
            // 
            this.tslModificar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.tslModificar.Name = "tslModificar";
            this.tslModificar.Size = new System.Drawing.Size(121, 28);
            this.tslModificar.Text = "Modificar";
            this.tslModificar.Click += new System.EventHandler(this.tslModificar_Click);
            // 
            // tslCompletada
            // 
            this.tslCompletada.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.tslCompletada.Name = "tslCompletada";
            this.tslCompletada.Size = new System.Drawing.Size(145, 28);
            this.tslCompletada.Text = "Completada";
            this.tslCompletada.Click += new System.EventHandler(this.tslCompletada_Click);
            // 
            // tslSalir
            // 
            this.tslSalir.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(64, 28);
            this.tslSalir.Text = "Salir";
            this.tslSalir.Click += new System.EventHandler(this.tslSalir_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // textOrdenar
            // 
            this.textOrdenar.AutoSize = true;
            this.textOrdenar.BackColor = System.Drawing.Color.Transparent;
            this.textOrdenar.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.textOrdenar.Location = new System.Drawing.Point(506, 426);
            this.textOrdenar.Name = "textOrdenar";
            this.textOrdenar.Size = new System.Drawing.Size(121, 32);
            this.textOrdenar.TabIndex = 14;
            this.textOrdenar.Text = "Ordenar";
            // 
            // boxOrdenar
            // 
            this.boxOrdenar.BackColor = System.Drawing.SystemColors.Window;
            this.boxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxOrdenar.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Bold);
            this.boxOrdenar.FormattingEnabled = true;
            this.boxOrdenar.Items.AddRange(new object[] {
            "",
            "Todas",
            "Por prioridad",
            "Incompletas",
            "Completadas",
            "Por fecha"});
            this.boxOrdenar.Location = new System.Drawing.Point(606, 423);
            this.boxOrdenar.Name = "boxOrdenar";
            this.boxOrdenar.Size = new System.Drawing.Size(131, 35);
            this.boxOrdenar.TabIndex = 15;
            this.boxOrdenar.SelectedIndexChanged += new System.EventHandler(this.boxOrdenar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vencimiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::AdminTareasAvanzado.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1119, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxOrdenar);
            this.Controls.Add(this.textOrdenar);
            this.Controls.Add(this.tsmMenu);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.boxComentario);
            this.Controls.Add(this.textComentario);
            this.Controls.Add(this.boxFecha);
            this.Controls.Add(this.boxPrioridad);
            this.Controls.Add(this.textPrioridad);
            this.Controls.Add(this.fechaVencimiento);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.TituloAdmin);
            this.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloAdmin;
        private System.Windows.Forms.Label textNombre;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.Label fechaVencimiento;
        private System.Windows.Forms.Label textPrioridad;
        private System.Windows.Forms.ComboBox boxPrioridad;
        private System.Windows.Forms.Label textComentario;
        private System.Windows.Forms.TextBox boxComentario;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.ToolStrip tsmMenu;
        private System.Windows.Forms.ToolStripLabel tslAgregar;
        private System.Windows.Forms.ToolStripLabel tslEliminar;
        private System.Windows.Forms.ToolStripLabel tslModificar;
        private System.Windows.Forms.ToolStripLabel tslCompletada;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolStripLabel tslSalir;
        private System.Windows.Forms.ToolStripLabel tslBuscar;
        private System.Windows.Forms.ComboBox boxOrdenar;
        private System.Windows.Forms.Label textOrdenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker boxFecha;
    }
}

