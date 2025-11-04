using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Aurivam_03_11_2025
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadastro_cliente_Click(object sender, EventArgs e)
        {
            FrmCliente abrir = new FrmCliente();
            abrir.Show();
            this.Hide();
        }

        private void btn_cadastro_animal_Click(object sender, EventArgs e)
        {
            FrmAnimal abrir = new FrmAnimal();
            abrir.Show();
            this.Hide();
        }

        private void btn_cadastro_veterinario_Click(object sender, EventArgs e)
        {
            FrmVeterinario abrir = new FrmVeterinario();
            abrir.Show();
            this.Hide();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
