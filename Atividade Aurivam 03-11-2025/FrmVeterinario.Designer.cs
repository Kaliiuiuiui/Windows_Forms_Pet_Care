namespace Atividade_Aurivam_03_11_2025
{
    partial class FrmVeterinario
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_dados_cliente = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lbl_nome_vet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(44, 486);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(200, 45);
            this.btn_voltar.TabIndex = 12;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // lbl_dados_cliente
            // 
            this.lbl_dados_cliente.AutoSize = true;
            this.lbl_dados_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados_cliente.Location = new System.Drawing.Point(3, 0);
            this.lbl_dados_cliente.Name = "lbl_dados_cliente";
            this.lbl_dados_cliente.Size = new System.Drawing.Size(143, 18);
            this.lbl_dados_cliente.TabIndex = 13;
            this.lbl_dados_cliente.Text = "Dados Veterinário";
            this.lbl_dados_cliente.Click += new System.EventHandler(this.lbl_dados_cliente_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.lbl_nome_vet);
            this.panel.Controls.Add(this.lbl_dados_cliente);
            this.panel.Location = new System.Drawing.Point(12, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(582, 302);
            this.panel.TabIndex = 13;
            // 
            // lbl_nome_vet
            // 
            this.lbl_nome_vet.AutoSize = true;
            this.lbl_nome_vet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_vet.Location = new System.Drawing.Point(29, 66);
            this.lbl_nome_vet.Name = "lbl_nome_vet";
            this.lbl_nome_vet.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome_vet.TabIndex = 14;
            this.lbl_nome_vet.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código";
            // 
            // FrmVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_voltar);
            this.Name = "FrmVeterinario";
            this.Text = "FrmaVeterinario";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_dados_cliente;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_nome_vet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}