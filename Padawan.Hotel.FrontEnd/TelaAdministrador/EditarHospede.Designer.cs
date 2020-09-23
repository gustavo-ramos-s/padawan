namespace Padawan.Hotel.FrontEnd.TelaAdministrador
{
    partial class Form_EditarHospede
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
            this.btn_AddHospede = new System.Windows.Forms.Button();
            this.btn_AlterarExcluirHospede = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddHospede
            // 
            this.btn_AddHospede.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AddHospede.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddHospede.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddHospede.Location = new System.Drawing.Point(245, 210);
            this.btn_AddHospede.Name = "btn_AddHospede";
            this.btn_AddHospede.Size = new System.Drawing.Size(247, 50);
            this.btn_AddHospede.TabIndex = 5;
            this.btn_AddHospede.Text = "Adicionar Hospede";
            this.btn_AddHospede.UseVisualStyleBackColor = false;
            // 
            // btn_AlterarExcluirHospede
            // 
            this.btn_AlterarExcluirHospede.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AlterarExcluirHospede.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarExcluirHospede.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AlterarExcluirHospede.Location = new System.Drawing.Point(245, 310);
            this.btn_AlterarExcluirHospede.Name = "btn_AlterarExcluirHospede";
            this.btn_AlterarExcluirHospede.Size = new System.Drawing.Size(247, 50);
            this.btn_AlterarExcluirHospede.TabIndex = 4;
            this.btn_AlterarExcluirHospede.Text = "Alterar ou Excluir Hospede";
            this.btn_AlterarExcluirHospede.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha uma opção: ";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Voltar.Location = new System.Drawing.Point(200, 465);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(124, 35);
            this.btn_Voltar.TabIndex = 6;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Fechar.Location = new System.Drawing.Point(413, 465);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(124, 35);
            this.btn_Fechar.TabIndex = 7;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            // 
            // Form_EditarHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Padawan.Hotel.FrontEnd.Properties.Resources.frame_padawan_hotel;
            this.ClientSize = new System.Drawing.Size(734, 573);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_AddHospede);
            this.Controls.Add(this.btn_AlterarExcluirHospede);
            this.Controls.Add(this.label1);
            this.Name = "Form_EditarHospede";
            this.Text = "Editar Hospede";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddHospede;
        private System.Windows.Forms.Button btn_AlterarExcluirHospede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Fechar;
    }
}