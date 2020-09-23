namespace Padawan.Hotel.FrontEnd.TelaAdministrador
{
    partial class Form_AdicionarReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SalvarHospede = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.txt_DataReserva = new System.Windows.Forms.MonthCalendar();
            this.txt_IdQuarto = new System.Windows.Forms.TextBox();
            this.txt_IdHospede = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Pagamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_SalvarHospede
            // 
            this.btn_SalvarHospede.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_SalvarHospede.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarHospede.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_SalvarHospede.Location = new System.Drawing.Point(124, 380);
            this.btn_SalvarHospede.Name = "btn_SalvarHospede";
            this.btn_SalvarHospede.Size = new System.Drawing.Size(124, 35);
            this.btn_SalvarHospede.TabIndex = 22;
            this.btn_SalvarHospede.Text = "Salvar";
            this.btn_SalvarHospede.UseVisualStyleBackColor = false;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Fechar.Location = new System.Drawing.Point(413, 465);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(124, 35);
            this.btn_Fechar.TabIndex = 21;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Voltar.Location = new System.Drawing.Point(200, 465);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(124, 35);
            this.btn_Voltar.TabIndex = 20;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            // 
            // txt_DataReserva
            // 
            this.txt_DataReserva.Location = new System.Drawing.Point(357, 198);
            this.txt_DataReserva.Name = "txt_DataReserva";
            this.txt_DataReserva.TabIndex = 19;
            // 
            // txt_IdQuarto
            // 
            this.txt_IdQuarto.Location = new System.Drawing.Point(125, 265);
            this.txt_IdQuarto.Name = "txt_IdQuarto";
            this.txt_IdQuarto.Size = new System.Drawing.Size(167, 20);
            this.txt_IdQuarto.TabIndex = 18;
            // 
            // txt_IdHospede
            // 
            this.txt_IdHospede.Location = new System.Drawing.Point(125, 190);
            this.txt_IdHospede.Name = "txt_IdHospede";
            this.txt_IdHospede.Size = new System.Drawing.Size(167, 20);
            this.txt_IdHospede.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data da Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Quarto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Hóspede:";
            // 
            // cmb_Pagamento
            // 
            this.cmb_Pagamento.FormattingEnabled = true;
            this.cmb_Pagamento.Items.AddRange(new object[] {
            "Pago",
            "Pendente"});
            this.cmb_Pagamento.Location = new System.Drawing.Point(125, 340);
            this.cmb_Pagamento.Name = "cmb_Pagamento";
            this.cmb_Pagamento.Size = new System.Drawing.Size(121, 21);
            this.cmb_Pagamento.TabIndex = 23;
            this.cmb_Pagamento.UseWaitCursor = true;
            // 
            // Form_AdicionarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Padawan.Hotel.FrontEnd.Properties.Resources.frame_padawan_hotel;
            this.ClientSize = new System.Drawing.Size(731, 573);
            this.Controls.Add(this.cmb_Pagamento);
            this.Controls.Add(this.btn_SalvarHospede);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.txt_DataReserva);
            this.Controls.Add(this.txt_IdQuarto);
            this.Controls.Add(this.txt_IdHospede);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AdicionarReserva";
            this.Text = "Adicionar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SalvarHospede;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.MonthCalendar txt_DataReserva;
        private System.Windows.Forms.TextBox txt_IdQuarto;
        private System.Windows.Forms.TextBox txt_IdHospede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Pagamento;
    }
}