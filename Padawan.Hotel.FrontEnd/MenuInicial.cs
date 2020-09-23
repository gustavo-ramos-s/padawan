using Padawan.Hotel.FrontEnd.TelaAdministrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padawan.Hotel.FrontEnd
{
    public partial class Form_MenuInicial : Form
    {
        public Form_MenuInicial()
        {
            InitializeComponent();
        }

        private void btn_AcessoAdministrador_Click(object sender, EventArgs e)
        {
            var menuAdministrador = new Form_MenuAdministrador();
            this.Hide();
            menuAdministrador.ShowDialog();
            this.Show();
        }

        private void btn_AcessoHospede_Click(object sender, EventArgs e)
        {
            var menuHospede = new Form_AdicionarHospede();
            this.Hide();
            menuHospede.ShowDialog();
            this.Show();
        }
    }
}
