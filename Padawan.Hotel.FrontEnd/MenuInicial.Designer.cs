namespace Padawan.Hotel.FrontEnd
{
    partial class Form_MenuInicial
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
            this.btn_AcessoHospede = new System.Windows.Forms.Button();
            this.btn_AcessoAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha uma opção: ";
            // 
            // btn_AcessoHospede
            // 
            this.btn_AcessoHospede.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AcessoHospede.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcessoHospede.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AcessoHospede.Location = new System.Drawing.Point(245, 310);
            this.btn_AcessoHospede.Name = "btn_AcessoHospede";
            this.btn_AcessoHospede.Size = new System.Drawing.Size(247, 50);
            this.btn_AcessoHospede.TabIndex = 1;
            this.btn_AcessoHospede.Text = "Hospede";
            this.btn_AcessoHospede.UseVisualStyleBackColor = false;
            // 
            // btn_AcessoAdministrador
            // 
            this.btn_AcessoAdministrador.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AcessoAdministrador.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcessoAdministrador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AcessoAdministrador.Location = new System.Drawing.Point(245, 210);
            this.btn_AcessoAdministrador.Name = "btn_AcessoAdministrador";
            this.btn_AcessoAdministrador.Size = new System.Drawing.Size(247, 50);
            this.btn_AcessoAdministrador.TabIndex = 2;
            this.btn_AcessoAdministrador.Text = "Administrador";
            this.btn_AcessoAdministrador.UseVisualStyleBackColor = false;
            // 
            // Form_MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Padawan.Hotel.FrontEnd.Properties.Resources.frame_padawan_hotel;
            this.ClientSize = new System.Drawing.Size(737, 574);
            this.Controls.Add(this.btn_AcessoAdministrador);
            this.Controls.Add(this.btn_AcessoHospede);
            this.Controls.Add(this.label1);
            this.Name = "Form_MenuInicial";
            this.Text = "Hotel Padawan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AcessoHospede;
        private System.Windows.Forms.Button btn_AcessoAdministrador;
    }
}