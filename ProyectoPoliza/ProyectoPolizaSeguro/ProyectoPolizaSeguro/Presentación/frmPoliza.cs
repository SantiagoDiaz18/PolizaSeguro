using ProyectoPolizaSeguro.Entidades;
using ProyectoPolizaSeguro.Servicios;
using ProyectoPolizaSeguro.Servicios.Implementaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPolizaSeguro
{
    public partial class frmPoliza : Form
    {
        public frmPoliza()
        {
            InitializeComponent();
        }

        PolizaService oPoliza = new PolizaService();
        AseguradoService oAsegurado = new AseguradoService();
        ProductoService oProducto = new ProductoService();
        TipoProductoService oTipoProducto = new TipoProductoService();
        private void frmPoliza_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Id");
                txtId.Focus();
            }
        
            else
                CargarGrilla(dgvPoliza, oAsegurado.TraerPorId(Convert.ToInt32(txtId.Text)));
                CompletarLabel(oPoliza.TraerPorId(Convert.ToInt32(txtId.Text)));
        }



        private void CargarGrilla(DataGridView grilla, List<Asegurado> lista)
        {
            grilla.Rows.Clear();
            foreach (Asegurado fila in lista)
            {
                grilla.Rows.Add(fila.IdAsegurado, fila.Dni,fila.Nombre, fila.CalcularEdad());
            }
            grilla.Focus(); ;
        }

        private void CompletarLabel(List<Poliza> lista)
          {
            if (lista.Count > 0)
            {
                foreach(Poliza poliza in lista)
                {
                    lblEstado.Text += " Activo ";
                    List<Producto> listaProducto = oProducto.TraerPorId(poliza.IdProducto.IdProducto);
                    List<TipoProducto> listaTipoProducto= oTipoProducto.TraerPorId(poliza.IdTipoProducto.IdTipoProducto);
                    lblProducto.Text += listaProducto[0].Nombre.ToString();
                    lblTipoProducto.Text += listaTipoProducto[0].Nombre.ToString();
                }
                
                
            }
            
        }

        private void lblTipoProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Está seguro de eliminar este Asegurado?"
                               , "ELIMINANDO"
                               , MessageBoxButtons.YesNo
                               , MessageBoxIcon.Warning
                               , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //Delete 
                if (oAsegurado.EliminarAsegurado((int)dgvPoliza.CurrentRow.Cells[0].Value) > 0)
                {
                    MessageBox.Show("El Asegurado se eliminó con éxito!!!");
                    

                    LimpiarGrilla();
                    //LimpiarCampos();
                }
            }
        }

        private void LimpiarGrilla()
        {
            dgvPoliza.DataSource = null;
            dgvPoliza.Rows.Clear(); ;
        }
    }
}
