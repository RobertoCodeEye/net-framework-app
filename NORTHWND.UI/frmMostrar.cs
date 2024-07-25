using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NORTHWND.Entities;
using NORTHWND.DataAccess;

namespace NORTHWND.UI
{
    public partial class frmMostrar : Form
    {
        private List<Products> listado;
        ProductsDAL productos;
        int pos = 0;
        int paginas = 0;
        int paginacion = 10;
        int inicio = 0;
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            productos = new ProductsDAL();
            listado = productos.SelectAll().ToList();
            Paginar();
            
        }

        public void Paginar()
        {
            paginas = listado.Count / paginacion;
            var pagina = listado.Skip(inicio).Take(paginacion).ToList();
            dataGridView1.DataSource = pagina;
        }

        private void btnsig_Click(object sender, EventArgs e)
        {
           
        }
    }
}
