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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent(); 
        }

        ConexionSQL cx = new ConexionSQL();
        SqlCommand comand;
        SqlDataAdapter adapter;
        DataTable dt;
        private void Entrada_Load(object sender, EventArgs e)
        {
            llenarGrid();
            llenarCombo();
            llenarComboSucursal();
            txtNombreArticulo.Select();
        }

        public void llenarGrid()
        {
            try
            {
                cx.abrirConexion();
                adapter = new SqlDataAdapter("SELECT * FROM TOPARTICULOS", cx.Cx);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvProductos.DataSource = dt;
                cx.cerraConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (MessageBox.Show("Desea aplicar los cambios?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cx.abrirConexion();
                    comand = new SqlCommand("SP_articulo", cx.Cx);
                    comand.CommandType = CommandType.StoredProcedure;
                   
                    if(txtID.Text != "")
                    {
                        comand.Parameters.AddWithValue("@id_articulo", SqlDbType.Int).Value = txtID.Text;
                    }
                    else
                    {
                        comand.Parameters.AddWithValue("@id_articulo", SqlDbType.Int).Value = -1;
                    }
                   
                    comand.Parameters.AddWithValue("@articulo", SqlDbType.VarChar).Value = txtNombreArticulo.Text;
                    comand.Parameters.AddWithValue("@precio_compra", SqlDbType.Float).Value = txtPrecioCompra.Text;
                    comand.Parameters.AddWithValue("@precio_venta", SqlDbType.Float).Value = txtPrecioVenta.Text;
                    comand.Parameters.AddWithValue("@precio_docena", SqlDbType.Float).Value = txt_precioDocena.Text;
                    comand.Parameters.AddWithValue("@existencia", SqlDbType.Int).Value = txtExistencia.Text;
                    comand.Parameters.AddWithValue("@id_asociado", SqlDbType.Int).Value = cmbAsociado.SelectedValue;
                    comand.Parameters.AddWithValue("@id_sucursal", SqlDbType.Int).Value = cmbsucursal.SelectedValue;
                    comand.ExecuteNonQuery();
                    cx.cerraConexion();
                    MessageBox.Show("Articulo guardado correctamente","EXITO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNombreArticulo.Clear();
                    txtExistencia.Clear();
                    txtPrecioCompra.Clear();
                    txt_precioDocena.Clear();
                    txtPrecioVenta.Clear();
                    llenarGrid();
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenarCombo()
        {
            adapter = new SqlDataAdapter("SELECT * FROM tbl_asociado",cx.Cx);
            dt = new DataTable();
            adapter.Fill(dt);

            cmbAsociado.DataSource = dt;
            cmbAsociado.DisplayMember = "asociado";
            cmbAsociado.ValueMember = "id_asociado";
        }

        public void llenarComboSucursal()
        {
            adapter = new SqlDataAdapter("SELECT * FROM tbl_sucursal", cx.Cx);
            dt = new DataTable();
            adapter.Fill(dt);

            cmbsucursal.DataSource = dt;
            cmbsucursal.DisplayMember = "sucursal";
            cmbsucursal.ValueMember = "id_sucursal";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreArticulo.Clear();
            txtID.Clear();
            txtExistencia.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txt_precioDocena.Clear();
            txtNombreArticulo.Select();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)  //to disable the row and column headers
            {
                txtID.Text = dgvProductos.Rows[e.RowIndex].Cells["id_articulo"].Value.ToString();
                txtNombreArticulo.Text = dgvProductos.Rows[e.RowIndex].Cells["articulo"].Value.ToString();
                txtPrecioCompra.Text = dgvProductos.Rows[e.RowIndex].Cells["precio_compra"].Value.ToString();
                txtPrecioVenta.Text = dgvProductos.Rows[e.RowIndex].Cells["precio_venta"].Value.ToString();
                txt_precioDocena.Text = dgvProductos.Rows[e.RowIndex].Cells["precio_docena"].Value.ToString();
                txtExistencia.Text = dgvProductos.Rows[e.RowIndex].Cells["existencia"].Value.ToString();
            }
        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            //CADA VEZ QUE EL TEXTO CAMBIE EN EL TEXTBOX VA ABRIR LA CONEXION
            cx.abrirConexion();
            comand = new SqlCommand("SP_BUSCARARTICULOS", cx.Cx); //SE EJECUTARA EL PROCEDIMIENTO DE BUSCAR
            comand.Parameters.AddWithValue("@param", SqlDbType.VarChar).Value = txtbuscador.Text; //PASAMOS EL PARAMETRO DEL LIKE
            comand.CommandType = CommandType.StoredProcedure;
            //Y ACTUALIZAMOS LA GRID ESTO LO HARÀ CADA VEZ QUE CAMBIE EL TEXTO
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = comand;
            dt = new DataTable();
            adapter.Fill(dt);
            dgvProductos.DataSource = dt;
            cx.cerraConexion();
        }
    }
}
