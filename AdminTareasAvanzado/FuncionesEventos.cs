using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdminTareasAvanzado
{
    public class FuncionesEventos
    {

        //Funcion el evento de tarea añadida
        public static void tarea_añadida(object a, string b)
        {
            //Ruta del archivo de sonido MP3
            string sonido = "pop.mp3";

            //Se atrapan las excepciones
            try
            {
                //Se cargaa el archivo de sonido MP3
                using (var mp3Reader = new Mp3FileReader(sonido))

                //Se inicializa el reproductor de audio
                using (var waveOut = new WaveOutEvent())
                {
                    //Se configurar el reproductor para reproducir el archivo MP3
                    waveOut.Init(mp3Reader);
                    //Se reproduce
                    waveOut.Play();
                    //Detiene la ejecución del hilo actual durante la duración del sonido
                    Thread.Sleep((int)(mp3Reader.TotalTime.TotalMilliseconds));
                }
            }
            catch (Exception ex)
            {
               
            }
        }


        //Funcion el evento de tarea modificada
        public static void tarea_modificada(object a, string b)
        {
            
            //Ruta del archivo de sonido MP3
            string sonido = "teclado.mp3";

            //Se atrapan las excepciones
            try
            {
                //Se cargaa el archivo de sonido MP3
                using (var mp3Reader = new Mp3FileReader(sonido))

                //Se inicializa el reproductor de audio
                using (var waveOut = new WaveOutEvent())
                {
                    //Se configurar el reproductor para reproducir el archivo MP3
                    waveOut.Init(mp3Reader);
                    //Se reproduce
                    waveOut.Play();
                    //Detiene la ejecución del hilo actual durante la duración del sonido
                    Thread.Sleep((int)(mp3Reader.TotalTime.TotalMilliseconds));
                }
            }
            catch (Exception ex)
            {
                //Se maneja cualquier excepción que ocurra durante la reproducción del sonido
                
            }
        }


        //Funcion el evento de tarea eliminada
        public static void tarea_eliminada(object a, string b)
        {
            

            //Ruta del archivo de sonido MP3
            string sonido = "pop2.mp3";

            //Se atrapan las excepciones
            try
            {
                //Se cargaa el archivo de sonido MP3
                using (var mp3Reader = new Mp3FileReader(sonido))

                //Se inicializa el reproductor de audio
                using (var waveOut = new WaveOutEvent())
                {
                    //Se configurar el reproductor para reproducir el archivo MP3
                    waveOut.Init(mp3Reader);
                    //Se reproduce
                    waveOut.Play();
                    //Detiene la ejecución del hilo actual durante la duración del sonido
                    Thread.Sleep((int)(mp3Reader.TotalTime.TotalMilliseconds));
                }
            }
            catch (Exception ex)
            {
                //Se maneja cualquier excepción que ocurra durante la reproducción del sonido
                
            }
        }


        //Funcion el evento de tarea completada
        public static void tarea_completada(object a, string b)
        {
            

            //Ruta del archivo de sonido MP3
            string sonido = "campanita.mp3";

            //Se atrapan las excepciones
            try
            {
                //Se cargaa el archivo de sonido MP3
                using (var mp3Reader = new Mp3FileReader(sonido))

                //Se inicializa el reproductor de audio
                using (var waveOut = new WaveOutEvent())
                {
                    //Se configurar el reproductor para reproducir el archivo MP3
                    waveOut.Init(mp3Reader);
                    //Se reproduce
                    waveOut.Play();
                    //Detiene la ejecución del hilo actual durante la duración del sonido
                    Thread.Sleep((int)(mp3Reader.TotalTime.TotalMilliseconds));
                }
            }
            catch (Exception ex)
            {
                //Se maneja cualquier excepción que ocurra durante la reproducción del sonido
                
            }
        }

    }

}
