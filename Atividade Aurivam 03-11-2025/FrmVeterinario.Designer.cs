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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeterinario));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_dados_cliente = new System.Windows.Forms.Label();
            this.txt_codigo_vet = new System.Windows.Forms.TextBox();
            this.txt_idade_vet = new System.Windows.Forms.TextBox();
            this.txt_nome_vet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nome_vet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(41, 457);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(200, 45);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_dados_cliente
            // 
            this.lbl_dados_cliente.AutoSize = true;
            this.lbl_dados_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados_cliente.Location = new System.Drawing.Point(12, 22);
            this.lbl_dados_cliente.Name = "lbl_dados_cliente";
            this.lbl_dados_cliente.Size = new System.Drawing.Size(154, 20);
            this.lbl_dados_cliente.TabIndex = 13;
            this.lbl_dados_cliente.Text = "Dados Veterinário";
            this.lbl_dados_cliente.Click += new System.EventHandler(this.lbl_dados_cliente_Click);
            // 
            // txt_codigo_vet
            // 
            this.txt_codigo_vet.Location = new System.Drawing.Point(152, 203);
            this.txt_codigo_vet.Name = "txt_codigo_vet";
            this.txt_codigo_vet.Size = new System.Drawing.Size(128, 20);
            this.txt_codigo_vet.TabIndex = 3;
            // 
            // txt_idade_vet
            // 
            this.txt_idade_vet.Location = new System.Drawing.Point(152, 144);
            this.txt_idade_vet.Name = "txt_idade_vet";
            this.txt_idade_vet.Size = new System.Drawing.Size(128, 20);
            this.txt_idade_vet.TabIndex = 2;
            // 
            // txt_nome_vet
            // 
            this.txt_nome_vet.Location = new System.Drawing.Point(152, 84);
            this.txt_nome_vet.Name = "txt_nome_vet";
            this.txt_nome_vet.Size = new System.Drawing.Size(128, 20);
            this.txt_nome_vet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Idade";
            // 
            // lbl_nome_vet
            // 
            this.lbl_nome_vet.AutoSize = true;
            this.lbl_nome_vet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_vet.Location = new System.Drawing.Point(38, 87);
            this.lbl_nome_vet.Name = "lbl_nome_vet";
            this.lbl_nome_vet.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome_vet.TabIndex = 14;
            this.lbl_nome_vet.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atividade_Aurivam_03_11_2025.Properties.Resources.hello;
            this.pictureBox1.Location = new System.Drawing.Point(432, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_codigo_vet);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_idade_vet);
            this.Controls.Add(this.txt_nome_vet);
            this.Controls.Add(this.lbl_dados_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nome_vet);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVeterinario";
            this.Text = "FrmVeterinario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_dados_cliente;
        private System.Windows.Forms.Label lbl_nome_vet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo_vet;
        private System.Windows.Forms.TextBox txt_idade_vet;
        private System.Windows.Forms.TextBox txt_nome_vet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}