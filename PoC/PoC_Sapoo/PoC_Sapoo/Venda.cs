using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PoC_Sapoo
{
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MATEUSM\SQLEXPRESS;Initial Catalog=Sapoo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //comando pra puxar os clientes e adicionar da comboBox
            SqlCommand comandoCliente = new SqlCommand("select * from cliente", connection);
            SqlDataReader reader = comandoCliente.ExecuteReader();
            while (reader.Read())
            {
                cbox_Cliente.Items.Add(reader["nome"].ToString());
            }
            reader.Close();
            //comando pra puxar os vendedores e adicionar da comboBox
            SqlCommand comandoVendedor = new SqlCommand("select * from vendedor", connection);
            reader = comandoVendedor.ExecuteReader();
            while (reader.Read())
            {
                cbox_Vendedor.Items.Add(reader["nome"].ToString());
            }
            connection.Close();
        }


    }
}
