using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using persona_herencia;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda

            string nombre = txt_nombre.Text;
            string fecha_nacimiento = txt_fecha_nacimiento.Text;
            string edad = txt_edad.Text;
            string matricula = txt_matricula.Text;
            string puesto = txt_carrera_puesto.Text;
            string sueldo = txt_sueldo.Text;


            // Verificamos la propiedad Checked del radio button para verficar que perfil esta activo
            if (btn_radio_empleado.Checked)
            {
                // Creamos una instancia de la clase empleado, pasandole los paramostros necesarios de la clase
                Empleado empleado = new Empleado(nombre, fecha_nacimiento, edad, matricula, puesto, sueldo);
                Console.WriteLine(empleado.nombre);
            }
            // Verificamos la propiedad Checked del radio button para verficar que perfil esta activo
            if (btn_radio_alumno.Checked)
            {
                // Creamos una instancia de la calse Alumno, pasandole solo los paramostros necesarios
                Alumno alumno = new Alumno(nombre, fecha_nacimiento, edad, matricula, puesto);
                Console.WriteLine(alumno.nombre);
            }
            // Verificamos la propiedad Checked del radio button para verficar que perfil esta activo
            if (btn_radio_docente.Checked)
            {
                // Creamos una instancia de la clase docente pasandole solo los paramostros necesarios
                Docente docente = new Docente(nombre, fecha_nacimiento, edad, matricula, puesto, sueldo);
                Console.WriteLine(docente.nombre);
            }

            // Enviamos un messagebox, para mostrar informacion al usuario que sus datos han sido guardados
            MessageBox.Show("Datos del usuario guardado con exito", "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de borrar las cajas de texto

            // Llamamos al nombre de nuestro textbox y llamando a su metodo Clear(), para poder limpiar el textbox
            txt_nombre.Clear();
            txt_fecha_nacimiento.Clear();
            txt_edad.Clear();
            txt_matricula.Clear();
            txt_carrera_puesto.Clear();
            txt_sueldo.Clear();

            // Llamamos al nombre del radio button y colocamos su propiedad Checked en false
            btn_radio_alumno.Checked = false;
            btn_radio_docente.Checked = false;
            btn_radio_empleado.Checked = false;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de terminar la ejecucion de la interfaz

            // this hace referencia a la ventana  actuala, llamamos su metodo close para cerrar la ventana
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void validar_Click(object sender, EventArgs e)
        {
            // Obtiene la ruta del directorio base del proyecto
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            // Imprimimos la ruta, para conocer donde se encuentra nuestro directorio
            Console.WriteLine("Ruta base: " + directorioBase);

            
            string rutaImagenRelativa = "";

            if (btn_radio_empleado.Checked)
            {
                // Cuando seleccionamos el perfil de empleado habilitamos el campo de sueldo
                txt_sueldo.Enabled = true;

                // Convinamos la dos rutas en donde tenemos nuestro proyecto y donde tenemos guardado nuestras imagenes
                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\empleado.png");
            }
            if (btn_radio_alumno.Checked)
            {
                // Cuando seleccionamos el perfil de alumno desabilitamos el campo de sueldo
                txt_sueldo.Enabled = false;
                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\estudiante.jpg");
            }
            if (btn_radio_docente.Checked)
            {
                // Cuando seleccionamos el perfil de empleado habilitamos el campo de sueldo
                txt_sueldo.Enabled = true;

                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\docente.jpg");
            }


            // Optenemos la ruta completa, desde la ubicacion del disco hasta donde se encuentra nuestra imagen para mostrar la imagen en el picturebox
            string rutaImagenAbsoluta = Path.GetFullPath(rutaImagenRelativa);
            Console.WriteLine(rutaImagenAbsoluta);


            if (System.IO.File.Exists(rutaImagenAbsoluta))
            {
                // Carga la imagen en el PictureBox
                pictureBox1.Image = Image.FromFile(rutaImagenAbsoluta);
            }
        }
    }
}
