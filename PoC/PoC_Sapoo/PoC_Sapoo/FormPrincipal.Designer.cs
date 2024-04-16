
namespace PoC_Sapoo
{
    partial class FormPrincipal
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
            this.btn_venda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_venda
            // 
            this.btn_venda.Location = new System.Drawing.Point(226, 182);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(119, 61);
            this.btn_venda.TabIndex = 0;
            this.btn_venda.Text = "Venda";
            this.btn_venda.UseVisualStyleBackColor = true;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 551);
            this.Controls.Add(this.btn_venda);
            this.Name = "FormPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_venda;
    }
}

