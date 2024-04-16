using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoC_Sapoo
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            Venda formvenda = new Venda();
            formvenda.Show();
        }
    }
}
