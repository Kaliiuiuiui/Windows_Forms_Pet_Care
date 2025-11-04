namespace Atividade_Aurivam_03_11_2025
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.panel = new System.Windows.Forms.Panel();
            this.txt_codigo_cliente = new System.Windows.Forms.TextBox();
            this.txt_idade_cliente = new System.Windows.Forms.TextBox();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_nome_cliente = new System.Windows.Forms.Label();
            this.lbl_dados_cliente = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.txt_codigo_cliente);
            this.panel.Controls.Add(this.txt_idade_cliente);
            this.panel.Controls.Add(this.txt_nome_cliente);
            this.panel.Controls.Add(this.lbl_codigo);
            this.panel.Controls.Add(this.lbl_idade);
            this.panel.Controls.Add(this.lbl_nome_cliente);
            this.panel.Controls.Add(this.lbl_dados_cliente);
            this.panel.Location = new System.Drawing.Point(24, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(735, 252);
            this.panel.TabIndex = 15;
            // 
            // txt_codigo_cliente
            // 
            this.txt_codigo_cliente.Location = new System.Drawing.Point(148, 185);
            this.txt_codigo_cliente.Name = "txt_codigo_cliente";
            this.txt_codigo_cliente.Size = new System.Drawing.Size(187, 20);
            this.txt_codigo_cliente.TabIndex = 3;
            // 
            // txt_idade_cliente
            // 
            this.txt_idade_cliente.Location = new System.Drawing.Point(148, 122);
            this.txt_idade_cliente.Name = "txt_idade_cliente";
            this.txt_idade_cliente.Size = new System.Drawing.Size(187, 20);
            this.txt_idade_cliente.TabIndex = 2;
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(148, 63);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(187, 20);
            this.txt_nome_cliente.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(26, 184);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(62, 18);
            this.lbl_codigo.TabIndex = 16;
            this.lbl_codigo.Text = "Código";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idade.Location = new System.Drawing.Point(26, 121);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(48, 18);
            this.lbl_idade.TabIndex = 15;
            this.lbl_idade.Text = "Idade";
            // 
            // lbl_nome_cliente
            // 
            this.lbl_nome_cliente.AutoSize = true;
            this.lbl_nome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cliente.Location = new System.Drawing.Point(26, 62);
            this.lbl_nome_cliente.Name = "lbl_nome_cliente";
            this.lbl_nome_cliente.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome_cliente.TabIndex = 14;
            this.lbl_nome_cliente.Text = "Nome";
            // 
            // lbl_dados_cliente
            // 
            this.lbl_dados_cliente.AutoSize = true;
            this.lbl_dados_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados_cliente.Location = new System.Drawing.Point(3, 0);
            this.lbl_dados_cliente.Name = "lbl_dados_cliente";
            this.lbl_dados_cliente.Size = new System.Drawing.Size(114, 18);
            this.lbl_dados_cliente.TabIndex = 13;
            this.lbl_dados_cliente.Text = "Dados Cliente";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(53, 429);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(200, 45);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atividade_Aurivam_03_11_2025.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(437, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_nome_cliente;
        private System.Windows.Forms.Label lbl_dados_cliente;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_codigo_cliente;
        private System.Windows.Forms.TextBox txt_idade_cliente;
    }
}