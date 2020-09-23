namespace Padawan.Hotel.FrontEnd.TelaAdministrador
{
    partial class Form_AdicionarQuarto
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.txt_AndarQuarto = new System.Windows.Forms.TextBox();
            this.txt_NumeroQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SalvarHospede
            // 
            this.btn_SalvarHospede.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_SalvarHospede.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarHospede.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_SalvarHospede.Location = new System.Drawing.Point(124, 305);
            this.btn_SalvarHospede.Name = "btn_SalvarHospede";
            this.btn_SalvarHospede.Size = new System.Drawing.Size(124, 35);
            this.btn_SalvarHospede.TabIndex = 19;
            this.btn_SalvarHospede.Text = "Salvar";
            this.btn_SalvarHospede.UseVisualStyleBackColor = false;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Voltar.Location = new System.Drawing.Point(200, 465);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(124, 35);
            this.btn_Voltar.TabIndex = 18;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            // 
            // txt_AndarQuarto
            // 
            this.txt_AndarQuarto.Location = new System.Drawing.Point(125, 265);
            this.txt_AndarQuarto.Name = "txt_AndarQuarto";
            this.txt_AndarQuarto.Size = new System.Drawing.Size(167, 20);
            this.txt_AndarQuarto.TabIndex = 17;
            // 
            // txt_NumeroQuarto
            // 
            this.txt_NumeroQuarto.Location = new System.Drawing.Point(125, 190);
            this.txt_NumeroQuarto.Name = "txt_NumeroQuarto";
            this.txt_NumeroQuarto.Size = new System.Drawing.Size(167, 20);
            this.txt_NumeroQuarto.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Andar do Quarto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número do Quarto:";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Fechar.Location = new System.Drawing.Point(413, 465);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(124, 35);
            this.btn_Fechar.TabIndex = 20;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            // 
            // Form_AdicionarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Padawan.Hotel.FrontEnd.Properties.Resources.frame_padawan_hotel;
            this.ClientSize = new System.Drawing.Size(730, 572);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_SalvarHospede);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.txt_AndarQuarto);
            this.Controls.Add(this.txt_NumeroQuarto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AdicionarQuarto";
            this.Text = "Adicionar Quarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SalvarHospede;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.TextBox txt_AndarQuarto;
        private System.Windows.Forms.TextBox txt_NumeroQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Fechar;
    }
}