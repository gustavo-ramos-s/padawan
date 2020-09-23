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
    public partial class Form_AdicionarHospede : Form
    {
        public Form_AdicionarHospede()
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
    }
}
