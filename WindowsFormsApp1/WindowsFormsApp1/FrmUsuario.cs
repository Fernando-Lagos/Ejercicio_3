using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();
        Usuario user = new Usuario();

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            UsuariosDataGridView.DataSource = usuarioDA.ListarUsuarios();
        }
    }
}
