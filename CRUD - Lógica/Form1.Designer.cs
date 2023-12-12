namespace CRUD___Lógica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalvar = new System.Windows.Forms.Button();
            this.txtAtualizar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.Button();
            this.txtApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCliente
            // 
            this.dtCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCliente.Location = new System.Drawing.Point(2, 261);
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.Size = new System.Drawing.Size(799, 188);
            this.dtCliente.TabIndex = 0;
            this.dtCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCliente_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(53, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(130, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(658, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(130, 82);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(658, 20);
            this.txtLogradouro.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(130, 108);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(658, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(130, 134);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(658, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(130, 160);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(658, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(130, 186);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(658, 20);
            this.txtEstado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "LOGRADOURO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "NÚMERO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "BAIRRO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "CIDADE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "ESTADO:";
            // 
            // txtSalvar
            // 
            this.txtSalvar.Location = new System.Drawing.Point(204, 232);
            this.txtSalvar.Name = "txtSalvar";
            this.txtSalvar.Size = new System.Drawing.Size(75, 23);
            this.txtSalvar.TabIndex = 15;
            this.txtSalvar.Text = "Salvar";
            this.txtSalvar.UseVisualStyleBackColor = true;
            this.txtSalvar.Click += new System.EventHandler(this.txtSalvar_Click);
            // 
            // txtAtualizar
            // 
            this.txtAtualizar.Location = new System.Drawing.Point(300, 232);
            this.txtAtualizar.Name = "txtAtualizar";
            this.txtAtualizar.Size = new System.Drawing.Size(75, 23);
            this.txtAtualizar.TabIndex = 16;
            this.txtAtualizar.Text = "Atualizar";
            this.txtAtualizar.UseVisualStyleBackColor = true;
            this.txtAtualizar.Click += new System.EventHandler(this.txtAtualizar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(397, 232);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(75, 23);
            this.txtPesquisar.TabIndex = 17;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.UseVisualStyleBackColor = true;
            this.txtPesquisar.Click += new System.EventHandler(this.txtPesquisar_Click);
            // 
            // txtApagar
            // 
            this.txtApagar.Location = new System.Drawing.Point(492, 232);
            this.txtApagar.Name = "txtApagar";
            this.txtApagar.Size = new System.Drawing.Size(75, 23);
            this.txtApagar.TabIndex = 18;
            this.txtApagar.Text = "Apagar";
            this.txtApagar.UseVisualStyleBackColor = true;
            this.txtApagar.Click += new System.EventHandler(this.txtApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtApagar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtAtualizar);
            this.Controls.Add(this.txtSalvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txtSalvar;
        private System.Windows.Forms.Button txtAtualizar;
        private System.Windows.Forms.Button txtPesquisar;
        private System.Windows.Forms.Button txtApagar;
    }
}

