using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmQueries1 : Form
    {
        public frmQueries1()
        {
            InitializeComponent();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            grvResultados.DataSource = Datos.Empleados;
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            var colecion = from Empleado in Datos.Empleados
                           orderby Empleado.Nombre
                           select Empleado;
            grvResultados.DataSource = colecion.ToList();
        }
        private void btnQuery3_Click(object sender, EventArgs e)
        {
            var colecion = from Empleado in Datos.Empleados
                           orderby Empleado.Nombre descending
                           select new
                           {
                               Codigo = Empleado.Id,
                               NombreProducto = Empleado.Nombre
                           };
            grvResultados.DataSource = colecion.ToList();
        }
        private void btnQuery4_Click(object sender, EventArgs e)
        {
            var colecion = from Empleado in Datos.Empleados
                           orderby Empleado.Salario descending
                           select new dtoProducto
                           {
                               Nombre= Empleado.Nombre,
                               Precio= Empleado.Salario 
                           };
            grvResultados.DataSource = colecion.ToList();
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            var coleccion = from Control ctl in this.Controls
                           select new 
                           {
                               Control = ctl.Name,
                               Texto = ctl.Text
                           };
            grvResultados.DataSource = coleccion.ToList();
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            var colecion = from Empleado in Datos.Empleados
                           where Empleado.Salario > 50000 && Empleado.Salario < 80000
                select Empleado;

            grvResultados.DataSource = colecion.ToList();
        }

        private void frmQueries1_Load(object sender, EventArgs e)
        {

        }
    }
}
