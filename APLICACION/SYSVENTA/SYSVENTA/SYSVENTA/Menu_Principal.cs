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

namespace SYSVENTA
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        SqlCommand comand;
        SqlDataAdapter adapter;
        DataTable dt;
        ConexionSQL cx = new ConexionSQL();

        private void btn_entrada_Click(object sender, EventArgs e)
        {
            Entrada en = new Entrada();
            en.ShowDialog();
        }

        public void centrar()
        {
            int alto = Screen.PrimaryScreen.Bounds.Height - this.PreferredSize.Height / 2 - 200;
            int ancho = Screen.PrimaryScreen.Bounds.Width/2-350;
            //MessageBox.Show(alto.ToString());
            groupBuscador.Location = new Point(ancho,alto);
            groupBuscador2.Location = new Point(ancho+150,alto-150);
            lblNombre.Location = new Point(ancho+210,alto-330);
            txtbuscador.Select();
            
        }
        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            //CADA VEZ QUE EL TEXTO CAMBIE EN EL TEXTBOX VA ABRIR LA CONEXION
            cx.abrirConexion();
            comand = new SqlCommand("SP_BUSCARARTICULOS2", cx.Cx); //SE EJECUTARA EL PROCEDIMIENTO DE BUSCAR
            comand.Parameters.AddWithValue("@param", SqlDbType.VarChar).Value = txtbuscador.Text; //PASAMOS EL PARAMETRO DEL LIKE
            comand.CommandType = CommandType.StoredProcedure;
            //Y ACTUALIZAMOS LA GRID ESTO LO HARÀ CADA VEZ QUE CAMBIE EL TEXTO
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = comand;
            dt = new DataTable();
            adapter.Fill(dt);
            dgvbuscador.DataSource = dt;
            cx.cerraConexion();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            centrar();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.ShowDialog();
        }
    }
}
