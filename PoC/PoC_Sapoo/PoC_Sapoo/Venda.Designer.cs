
namespace PoC_Sapoo
{
    partial class Venda
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
            this.gpBox_cabecalho = new System.Windows.Forms.GroupBox();
            this.cbox_Vendedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbox_Cliente = new System.Windows.Forms.ComboBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpBox_cabecalho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBox_cabecalho
            // 
            this.gpBox_cabecalho.Controls.Add(this.cbox_Vendedor);
            this.gpBox_cabecalho.Controls.Add(this.label2);
            this.gpBox_cabecalho.Controls.Add(this.label1);
            this.gpBox_cabecalho.Controls.Add(this.dateTimePicker1);
            this.gpBox_cabecalho.Controls.Add(this.cbox_Cliente);
            this.gpBox_cabecalho.Controls.Add(this.lbl_Cliente);
            this.gpBox_cabecalho.Location = new System.Drawing.Point(12, 12);
            this.gpBox_cabecalho.Name = "gpBox_cabecalho";
            this.gpBox_cabecalho.Size = new System.Drawing.Size(972, 126);
            this.gpBox_cabecalho.TabIndex = 0;
            this.gpBox_cabecalho.TabStop = false;
            this.gpBox_cabecalho.Text = "Cabeçalho";
            // 
            // cbox_Vendedor
            // 
            this.cbox_Vendedor.FormattingEnabled = true;
            this.cbox_Vendedor.Location = new System.Drawing.Point(651, 49);
            this.cbox_Vendedor.Name = "cbox_Vendedor";
            this.cbox_Vendedor.Size = new System.Drawing.Size(121, 21);
            this.cbox_Vendedor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vendedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data da Venda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // cbox_Cliente
            // 
            this.cbox_Cliente.FormattingEnabled = true;
            this.cbox_Cliente.Location = new System.Drawing.Point(206, 49);
            this.cbox_Cliente.Name = "cbox_Cliente";
            this.cbox_Cliente.Size = new System.Drawing.Size(121, 21);
            this.cbox_Cliente.TabIndex = 1;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(203, 33);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_Cliente.TabIndex = 0;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos e total";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduto,
            this.colQtd});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(532, 251);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // colProduto
            // 
            this.colProduto.Text = "Produto";
            // 
            // colQtd
            // 
            this.colQtd.Text = "Quantidade";
            this.colQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBox_cabecalho);
            this.Name = "Venda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.gpBox_cabecalho.ResumeLayout(false);
            this.gpBox_cabecalho.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBox_cabecalho;
        private System.Windows.Forms.ComboBox cbox_Cliente;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox_Vendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colProduto;
        private System.Windows.Forms.ColumnHeader colQtd;
    }
}