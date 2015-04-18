using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String fechanac =dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");
            String fechaing =dtpfechaingreso.Value.ToString("dd/MM/yyyy");
            string kk=cmbSexo.SelectedItem.ToString();

            Empleado empleado1= new Empleado(txtNombre.Text,txtApellido.Text, kk ,fechanac,fechaing,float.Parse(txtSalario.Text));
            MessageBox.Show("El nombre del empleado es"+empleado1.Nombre+"El apellido es : "+empleado1.Apellido+"sexo "+empleado1.Sexo+"fecha 1"+empleado1.Fechaing+"fecha 2"+empleado1.Fechanac);


        }
    }
}
