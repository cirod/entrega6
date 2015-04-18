using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleado
{
    class Empleado
    {
        float salario;
        string nombre;
        string apellido;
        string sexo;
        string fechanac;
        string fechaing;

        public Empleado()
        {
 
        }
        public Empleado(string a, string b, string s,string f1,string f2,float salario1)
        {
            this.nombre = a;
            this.apellido = b;
            this.sexo = s;
            this.fechanac = f1;
            this.fechaing = f2;
            this.salario = salario1;
        }

        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }



        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        public string Fechanac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }


        public string Fechaing
        {
            get { return fechaing; }
            set { fechaing = value; }
        }


    }
}
