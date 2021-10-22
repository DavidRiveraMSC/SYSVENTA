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
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        SqlCommand comand;
        DataTable dt;
        SqlDataAdapter adapter;
        ConexionSQL cx = new ConexionSQL();

        public int varid;
        public string vararticulo;
        public float varprecio_venta;
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

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void dgvbuscador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)  //to disable the row and column headers
            {
                varid = int.Parse(dgvbuscador.Rows[e.RowIndex].Cells["id_articulo"].Value.ToString());
                vararticulo = dgvbuscador.Rows[e.RowIndex].Cells["articulo"].Value.ToString();
                varprecio_venta = int.Parse(dgvbuscador.Rows[e.RowIndex].Cells["precio_venta"].Value.ToString());
            }*/

        }
        private void Enviar()
        {
            Venta v = Owner as Venta;
            
            v.Dtfactura.Rows.Add(dgvbuscador.CurrentRow.Cells[0].Value, 
                dgvbuscador.CurrentRow.Cells[1].Value, 
                dgvbuscador.CurrentRow.Cells[2].Value,
                "0");


            //v.Dtfactura.Rows[v.Dtfactura.Rows.Count - 1].Cells[0].Value = dgvbuscador.CurrentRow.Cells[0].Value;
            //v.Dtfactura.CurrentRow.Selected = true;



            //v.Dtfactura.CurrentRow.Cells[1].Value = dgvbuscador.CurrentRow.Cells[1].Value;
            //v.Dtfactura.CurrentRow.Cells[2].Value = dgvbuscador.CurrentRow.Cells[2].Value;

            //v.Dtfactura.Rows[v.Dtfactura.Rows.Count - 1].Selected = false;
            
            this.Close();
            //v.Dtfactura.CurrentCell = v.Dtfactura.CurrentRow.Cells["CANTIDAD"];
        }

        private void dgvbuscador_DoubleClick(object sender, EventArgs e)
        {
            Enviar();
        }
    }
}
