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
    public partial class Venta : Form { 
        public int varid;
        public string vararticulo;
        public float varprecio_venta;
        public int Id_ultimaVenta;
        public int cantidaddata;
        public float preciodata;
        public float subtotal;
        public Venta()
        {
            InitializeComponent();
        }

        ConexionSQL cx = new ConexionSQL();
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand comand;
        SqlDataReader rd;

        private DataGridView _dtfactura;
        public DataGridView Dtfactura { get => _dtfactura; set => _dtfactura = value; }
        public void dt_factura_publico()
        {
            _dtfactura = dgvdetalleventa;
        }
        /*public void llenarCombo()
        {
            adapter = new SqlDataAdapter("SELECT * FROM tbl_asociado", cx.Cx);
            dt = new DataTable();
            adapter.Fill(dt);

            cmbasociado.DataSource = dt;
            cmbasociado.DisplayMember = "asociado";
            cmbasociado.ValueMember = "id_asociado";
        }
       */
        private void btnagregar_Click(object sender, EventArgs e)
        {
            Buscador b = new Buscador();
            AddOwnedForm(b);
            b.ShowDialog();
        }
        public void obtenerID()
        {
            cx.abrirConexion();
            comand = new SqlCommand("select top 1 id_venta FROM tbl_venta ORDER BY id_venta DESC",cx.Cx);
            comand.ExecuteNonQuery();

            rd = comand.ExecuteReader();
            if (rd.Read())
            {
                txtidventa.Text = (int.Parse(rd["id_venta"].ToString()) + 1).ToString();
            }
            
            cx.cerraConexion();
        }
        private void Venta_Load(object sender, EventArgs e)
        {
            //llenarCombo();
            txtfecha.Text = DateTime.Today.ToString();
            txtfecha.Enabled = false;
            //obtenerID();
            dt_factura_publico();
            txtsubtotal.Text = "0";
            txttotal.Text = "0";
            cmbestado.SelectedIndex = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool vacia = false;

                foreach (DataGridViewRow row in dgvdetalleventa.Rows)
                {
                    if (row.Cells["cantidad"].Value.ToString() == "0")
                    {
                        vacia = true;
                    }
                }
                if (vacia == true)
                {
                    MessageBox.Show("No puede dejar vacia la cantidad");
                }
                else if (MessageBox.Show("Desea aplicar los cambios?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cx.abrirConexion();
                    comand = new SqlCommand("SP_venta", cx.Cx);
                    comand.CommandType = CommandType.StoredProcedure;

                    if (txtidventa.Text != "")
                    {
                        comand.Parameters.AddWithValue("@id_venta", SqlDbType.Int).Value = txtidventa.Text;
                    }
                    else
                    {
                        comand.Parameters.AddWithValue("@id_venta", SqlDbType.Int).Value = -1;
                    }

                    comand.Parameters.AddWithValue("@estado", SqlDbType.VarChar).Value = cmbestado.Text;
                    comand.Parameters.Add("@parametro1", SqlDbType.Int).Direction = ParameterDirection.Output;
                   
                    comand.ExecuteNonQuery();
                    Id_ultimaVenta = Convert.ToInt32(comand.Parameters["@parametro1"].Value);
                    //MessageBox.Show(Id_ultimaVenta.ToString());

                    foreach (DataGridViewRow dr in dgvdetalleventa.Rows)
                    {
                        comand = new SqlCommand("SP_detalleventa", cx.Cx);
                        comand.CommandType = CommandType.StoredProcedure;
                        comand.Parameters.AddWithValue("@id_venta", SqlDbType.Int).Value = Id_ultimaVenta; 
                        comand.Parameters.AddWithValue("@id_articulo", SqlDbType.Int).Value = dr.Cells["id_articulo"].Value;
                        comand.Parameters.AddWithValue("@cantidad", SqlDbType.Int).Value = dr.Cells["cantidad"].Value;
                        comand.Parameters.AddWithValue("@precio_venta", SqlDbType.Float).Value = dr.Cells["precio_venta"].Value;
                        comand.Parameters.AddWithValue("@subtotal", SqlDbType.Float).Value = int.Parse(dr.Cells["cantidad"].Value.ToString()) * float.Parse(dr.Cells["precio_venta"].Value.ToString());
                        comand.ExecuteNonQuery();

                        comand = new SqlCommand("UPDATE tbl_articulo SET existencia = existencia - "+ dr.Cells["cantidad"].Value + " WHERE id_articulo = "+ dr.Cells["id_articulo"].Value + "",cx.Cx);
                        comand.ExecuteNonQuery();
                    }

                    cx.cerraConexion();
                    MessageBox.Show("La Venta se realizó correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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

        private void dgvdetalleventa_SelectionChanged(object sender, EventArgs e)
        {
            dgvdetalleventa.BeginEdit(true);
               
        }   

        private void dgvdetalleventa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            for (int drc = 0; drc < dgvdetalleventa.Rows.Count; drc++) //RECORRE LAS FILAS DEL DATAGRID
            {
                //MessageBox.Show(drc.ToString());
                //MessageBox.Show(dgvdetalleventa.Rows[drc].Cells["cantidad"].Value.ToString());

                if (dgvdetalleventa.Rows[drc].Cells["cantidad"].Value.ToString().Length <= 1) //SIEMPRE QUE LA VUELTA SEA MENOR O IGUAL A 1 VA RESETEAR LOS TEXTBOX
                {
                    txtsubtotal.Text = "0"; //CUANDO HAY MAS DE 1 ARTICULO, EN LA PRIMERA VUELTA REINICIA LOS TEXTBOX CUANDO LA VUELTA ES 
                    txttotal.Text = "0";//MAYOR O IGUAL A LAS FILAS DEL DATA COMIENZA A INSERTAR Y SE SUMA UNA SOBRE OTRA
                }
            } //CUANDO LA VUELTA ES IGUAL A LA CANTIDAD DE FILAS DEL DATAGRID SE DETIENE
         
            //SE RECORREN LAS FILAS Y SE VALIDA QUE NO ESTEN VACIAS    
            foreach (DataGridViewRow dr in dgvdetalleventa.Rows)
            {
                if (dr.Cells["cantidad"].Value != null)
                {
                    
                    //MessageBox.Show(dr.Cells["cantidad"].Value.ToString(),"celda");
            
                    cantidaddata = int.Parse(dr.Cells["cantidad"].Value.ToString()); //SE LLENA LA VARIABLE CON LA CANTIDAD DE LA PRIMERA FILA
                    preciodata = int.Parse(dr.Cells["precio_venta"].Value.ToString());//SE CAPTURA EL PRECIO VENTA
                    //MessageBox.Show(cantidaddata.ToString(),"variable");
                    subtotal = cantidaddata * preciodata;
                    txtsubtotal.Text = Convert.ToString(int.Parse(txtsubtotal.Text) + subtotal); //SE SUMA AL TEXTBOX LA VARIABLE
                    txttotal.Text = txtsubtotal.Text;
                    cantidaddata = 0; //Y AL FINAL SE REINICIA PARA QUE SUME LO NUEVO CON LO ANTERIOR QUE CONTIENE EL TEXTBOX
                    
                }

                
            }   
       
        }
    }
}
