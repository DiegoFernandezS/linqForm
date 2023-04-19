using System;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmExtensiones : Form
    {
        public frmExtensiones()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e1)
        {
            try
            {
                txtResultado.Text = txtValor.Text.Left(1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Debe ingresar un texto");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultado.Text = txtValor.Text.Right(1);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Debe ingresar un texto");
            }
        }

        private void frmExtensiones_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
