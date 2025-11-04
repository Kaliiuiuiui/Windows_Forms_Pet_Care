namespace Atividade_Aurivam_03_11_2025
{
    partial class FrmMenuPrincipal
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
            this.btn_cadastro_cliente = new System.Windows.Forms.Button();
            this.lbl_petcare = new System.Windows.Forms.Label();
            this.btn_cadastro_animal = new System.Windows.Forms.Button();
            this.btn_cadastro_veterinario = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastro_cliente
            // 
            this.btn_cadastro_cliente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cadastro_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro_cliente.Location = new System.Drawing.Point(302, 115);
            this.btn_cadastro_cliente.Name = "btn_cadastro_cliente";
            this.btn_cadastro_cliente.Size = new System.Drawing.Size(195, 42);
            this.btn_cadastro_cliente.TabIndex = 1;
            this.btn_cadastro_cliente.Text = "Cadastro Cliente";
            this.btn_cadastro_cliente.UseVisualStyleBackColor = false;
            this.btn_cadastro_cliente.Click += new System.EventHandler(this.btn_cadastro_cliente_Click);
            // 
            // lbl_petcare
            // 
            this.lbl_petcare.AutoSize = true;
            this.lbl_petcare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_petcare.Location = new System.Drawing.Point(347, 57);
            this.lbl_petcare.Name = "lbl_petcare";
            this.lbl_petcare.Size = new System.Drawing.Size(104, 25);
            this.lbl_petcare.TabIndex = 1;
            this.lbl_petcare.Text = "Pet Care";
            // 
            // btn_cadastro_animal
            // 
            this.btn_cadastro_animal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cadastro_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro_animal.Location = new System.Drawing.Point(302, 189);
            this.btn_cadastro_animal.Name = "btn_cadastro_animal";
            this.btn_cadastro_animal.Size = new System.Drawing.Size(195, 42);
            this.btn_cadastro_animal.TabIndex = 2;
            this.btn_cadastro_animal.Text = "Cadastro Animal";
            this.btn_cadastro_animal.UseVisualStyleBackColor = false;
            this.btn_cadastro_animal.Click += new System.EventHandler(this.btn_cadastro_animal_Click);
            // 
            // btn_cadastro_veterinario
            // 
            this.btn_cadastro_veterinario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cadastro_veterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro_veterinario.Location = new System.Drawing.Point(302, 259);
            this.btn_cadastro_veterinario.Name = "btn_cadastro_veterinario";
            this.btn_cadastro_veterinario.Size = new System.Drawing.Size(195, 42);
            this.btn_cadastro_veterinario.TabIndex = 3;
            this.btn_cadastro_veterinario.Text = "Cadastro Veterinário";
            this.btn_cadastro_veterinario.UseVisualStyleBackColor = false;
            this.btn_cadastro_veterinario.Click += new System.EventHandler(this.btn_cadastro_veterinario_Click);
            // 
            // btn_produtos
            // 
            this.btn_produtos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.Location = new System.Drawing.Point(302, 329);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(195, 42);
            this.btn_produtos.TabIndex = 4;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(302, 399);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(195, 42);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.btn_cadastro_veterinario);
            this.Controls.Add(this.btn_cadastro_animal);
            this.Controls.Add(this.lbl_petcare);
            this.Controls.Add(this.btn_cadastro_cliente);
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastro_cliente;
        private System.Windows.Forms.Label lbl_petcare;
        private System.Windows.Forms.Button btn_cadastro_animal;
        private System.Windows.Forms.Button btn_cadastro_veterinario;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_sair;
    }
}