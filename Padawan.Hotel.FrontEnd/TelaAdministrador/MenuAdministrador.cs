using Padawan.Hotel.FrontEnd.TelaAdministrador.Gerenciar_Quarto;
using Padawan.Hotel.FrontEnd.TelaAdministrador.GerenciarReserva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padawan.Hotel.FrontEnd.TelaAdministrador
{
    public partial class Form_MenuAdministrador : Form
    {
        public Form_MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_AddHospede_Click(object sender, EventArgs e)
        {
            var menuAdicionaHospede = new Form_AdicionarHospede();
            this.Hide();
            menuAdicionaHospede.ShowDialog();
            this.Show();
        }

        private void btn_AddQuarto_Click(object sender, EventArgs e)
        {
            var menuAdicionaQuarto = new Form_AdicionarQuarto();
            this.Hide();
            menuAdicionaQuarto.ShowDialog();
            this.Show();
        }

        private void btn_AddReserva_Click(object sender, EventArgs e)
        {
            var menuAdicionaReserva = new Form_AdicionarReserva();
            this.Hide();
            menuAdicionaReserva.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirHospede_Click(object sender, EventArgs e)
        {
            var menuAlterarExcluirHospede = new Form_AlterarExcluirHospede();
            this.Hide();
            menuAlterarExcluirHospede.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirQuarto_Click(object sender, EventArgs e)
        {
            var menuAlterarExcluirQuarto = new Form_AlterarExcluirQuarto();
            this.Hide();
            menuAlterarExcluirQuarto.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirReserva_Click(object sender, EventArgs e)
        {
            var menuAlterarExcluirReserva = new Form_AlterarExcluirReserva();
            this.Hide();
            menuAlterarExcluirReserva.ShowDialog();
            this.Show();
        }
    }
}
