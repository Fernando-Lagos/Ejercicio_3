using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Entidades;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuarioTextBox.Text, ClaveTextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto","Datos Erroneos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario Inactivo");
                return;
            }

            FrmUsuario frmUsuarios = new FrmUsuario();
            frmUsuarios.Show();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
