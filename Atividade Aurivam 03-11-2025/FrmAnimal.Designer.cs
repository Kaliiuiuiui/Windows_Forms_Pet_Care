namespace Atividade_Aurivam_03_11_2025
{
    partial class FrmAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimal));
            this.lbl_dadosAnimal = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_detalhe = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_detalhe = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dadosAnimal
            // 
            this.lbl_dadosAnimal.AutoSize = true;
            this.lbl_dadosAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dadosAnimal.Location = new System.Drawing.Point(33, 30);
            this.lbl_dadosAnimal.Name = "lbl_dadosAnimal";
            this.lbl_dadosAnimal.Size = new System.Drawing.Size(139, 24);
            this.lbl_dadosAnimal.TabIndex = 0;
            this.lbl_dadosAnimal.Text = "Dados Animal";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(75, 102);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 18);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Location = new System.Drawing.Point(75, 143);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(47, 18);
            this.lbl_peso.TabIndex = 2;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cor.Location = new System.Drawing.Point(75, 182);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(36, 18);
            this.lbl_cor.TabIndex = 3;
            this.lbl_cor.Text = "Cor";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(75, 221);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_detalhe
            // 
            this.lbl_detalhe.AutoSize = true;
            this.lbl_detalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detalhe.Location = new System.Drawing.Point(75, 270);
            this.lbl_detalhe.Name = "lbl_detalhe";
            this.lbl_detalhe.Size = new System.Drawing.Size(65, 18);
            this.lbl_detalhe.TabIndex = 5;
            this.lbl_detalhe.Text = "Detalhe";
            this.lbl_detalhe.Click += new System.EventHandler(this.lbl_detalhe_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(172, 103);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(178, 20);
            this.txt_id.TabIndex = 6;
            this.txt_id.TabStop = false;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(172, 144);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(178, 20);
            this.txt_peso.TabIndex = 7;
            this.txt_peso.TabStop = false;
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(172, 183);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(178, 20);
            this.txt_cor.TabIndex = 8;
            this.txt_cor.TabStop = false;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(172, 222);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(178, 20);
            this.txt_nome.TabIndex = 9;
            this.txt_nome.TabStop = false;
            // 
            // txt_detalhe
            // 
            this.txt_detalhe.Location = new System.Drawing.Point(172, 270);
            this.txt_detalhe.Name = "txt_detalhe";
            this.txt_detalhe.Size = new System.Drawing.Size(178, 20);
            this.txt_detalhe.TabIndex = 10;
            this.txt_detalhe.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(51, 481);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(200, 45);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atividade_Aurivam_03_11_2025.Properties.Resources.Dog_Duck_GIF;
            this.pictureBox1.Location = new System.Drawing.Point(450, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_detalhe);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_detalhe);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cor);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_dadosAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAnimal";
            this.Text = "Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dadosAnimal;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_detalhe;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_detalhe;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}