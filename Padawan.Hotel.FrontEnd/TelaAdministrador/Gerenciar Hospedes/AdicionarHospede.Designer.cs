namespace Padawan.Hotel.FrontEnd
{
    partial class Form_AdicionarHospede
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CpfHospede = new System.Windows.Forms.TextBox();
            this.txt_NomeHospede = new System.Windows.Forms.TextBox();
            this.txt_SobrenomeHospede = new System.Windows.Forms.TextBox();
            this.txt_NascimentoHospede = new System.Windows.Forms.MonthCalendar();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_SalvarHospede = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de Nascimento";
            // 
            // txt_CpfHospede
            // 
            this.txt_CpfHospede.Location = new System.Drawing.Point(125, 340);
            this.txt_CpfHospede.Name = "txt_CpfHospede";
            this.txt_CpfHospede.Size = new System.Drawing.Size(167, 20);
            this.txt_CpfHospede.TabIndex = 5;
            // 
            // txt_NomeHospede
            // 
            this.txt_NomeHospede.Location = new System.Drawing.Point(125, 190);
            this.txt_NomeHospede.Name = "txt_NomeHospede";
            this.txt_NomeHospede.Size = new System.Drawing.Size(167, 20);
            this.txt_NomeHospede.TabIndex = 6;
            // 
            // txt_SobrenomeHospede
            // 
            this.txt_SobrenomeHospede.Location = new System.Drawing.Point(125, 265);
            this.txt_SobrenomeHospede.Name = "txt_SobrenomeHospede";
            this.txt_SobrenomeHospede.Size = new System.Drawing.Size(167, 20);
            this.txt_SobrenomeHospede.TabIndex = 7;
            // 
            // txt_NascimentoHospede
            // 
            this.txt_NascimentoHospede.Location = new System.Drawing.Point(357, 198);
            this.txt_NascimentoHospede.Name = "txt_NascimentoHospede";
            this.txt_NascimentoHospede.TabIndex = 8;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Voltar.Location = new System.Drawing.Point(200, 465);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(124, 35);
            this.btn_Voltar.TabIndex = 9;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Fechar.Location = new System.Drawing.Point(413, 465);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(124, 35);
            this.btn_Fechar.TabIndex = 10;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_SalvarHospede
            // 
            this.btn_SalvarHospede.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_SalvarHospede.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarHospede.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_SalvarHospede.Location = new System.Drawing.Point(124, 380);
            this.btn_SalvarHospede.Name = "btn_SalvarHospede";
            this.btn_SalvarHospede.Size = new System.Drawing.Size(124, 35);
            this.btn_SalvarHospede.TabIndex = 11;
            this.btn_SalvarHospede.Text = "Salvar";
            this.btn_SalvarHospede.UseVisualStyleBackColor = false;
            // 
            // Form_AdicionarHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Padawan.Hotel.FrontEnd.Properties.Resources.frame_padawan_hotel;
            this.ClientSize = new System.Drawing.Size(733, 574);
            this.Controls.Add(this.btn_SalvarHospede);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.txt_NascimentoHospede);
            this.Controls.Add(this.txt_SobrenomeHospede);
            this.Controls.Add(this.txt_NomeHospede);
            this.Controls.Add(this.txt_CpfHospede);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AdicionarHospede";
            this.Text = "Adicionar Hospede";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CpfHospede;
        private System.Windows.Forms.TextBox txt_NomeHospede;
        private System.Windows.Forms.TextBox txt_SobrenomeHospede;
        private System.Windows.Forms.MonthCalendar txt_NascimentoHospede;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_SalvarHospede;
    }
}

