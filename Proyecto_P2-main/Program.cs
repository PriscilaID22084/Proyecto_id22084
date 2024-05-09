using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //clase padre
    {
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria
        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)

        public string nombre = "";
        public string fecha_nacimiento = "";
        public string edad = "";
        public string matricula = "";
        public string puesto = "";

        public Persona(string _nombre, string _fecha_nacimiento, string _edad, string _matricula, string _puesto) {
            this.nombre = _nombre;
            this.fecha_nacimiento = _fecha_nacimiento;
            this.edad = _edad;
            this.matricula = _matricula;
            this.puesto = _puesto;
        }
    }

    class Alumno :Persona //clase hija alumno
    {
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código

        public Alumno(string _nombre, string _fecha_nacimiento, string _edad, string _matricula, string _puesto) : base (_nombre, _fecha_nacimiento, _edad, _matricula, _puesto)
        {

        }
        

    }
    class Empleado : Persona //clase hija
    {
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        string sueldo = "";

        public Empleado(string _nombre, string _fecha_nacimiento, string _edad, string _matricula, string _puesto, string _sueldo) : base(_nombre, _fecha_nacimiento, _edad, _matricula, _puesto)
        {
            this.sueldo = _sueldo;
        }
    }

    class Docente : Persona //clase Hija
    {
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código

        string sueldo = "";

        // declaramos la propiedad para inicializar el construtor
        public Docente(string _nombre, string _fecha_nacimiento, string _edad, string _matricula, string _puesto, string _sueldo) : base(_nombre, _fecha_nacimiento, _edad, _matricula, _puesto)
        {
            //this hace referencia al atributo de esa clase 
            this.sueldo = _sueldo;
        }
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
