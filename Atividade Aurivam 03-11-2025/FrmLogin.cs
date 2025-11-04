using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Aurivam_03_11_2025
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario = txt_usuario.Text;
            senha = Convert.ToInt32(txt_senha.Text);

            if (usuario == "admin" & senha == 123)
            {
                FrmMenuPrincipal abrir = new FrmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorretos!");
            }
        }
    }
}
