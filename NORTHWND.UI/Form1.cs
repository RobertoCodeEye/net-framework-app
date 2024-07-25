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
    public partial class Form1 : Form
    {
        private List<Products> listado;
        ProductsDAL oProductoDAL = new ProductsDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listado = new List<Products>();
            UpdateGrid();                      
        }        

        private void UpdateGrid()
        {
           
            listado = oProductoDAL.SelectAll();

            dataGridView1.DataSource = listado;

            var categorias = listado.Select(c => c.CategoryID).Distinct().ToList();
            var proveedores = listado.Select(p => p.SupplierID).Distinct().ToList();

            comboBox1.DataSource = categorias;
            comboBox2.DataSource = proveedores;

            //List<int> edades = new List<int>() { 1, 5, 6, 7, 8, 9, 4, 6 };

            //var queryMayorSeis = from e in edades
            //                     where e > 6
            //                     select e;

            //var queryMayorSeis2 = (from e in edades
            //                     where e > 6
            //                     select e).ToList();

            //foreach (int item in queryMayorSeis)
            //{
            //    MessageBox.Show(item.ToString());
            //}


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filtrocategorias = listado.Where(p => p.CategoryID == (int)comboBox1.SelectedValue).ToList();

            var querifilterCategories = (from p in listado
                                         where p.CategoryID == (int)comboBox1.SelectedValue
                                         select new { ID = p.CategoryID, Nombre = p.ProductName }).ToList();

            dataGridView1.DataSource = filtrocategorias;
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filtroproveedores = listado.Where(p => p.CategoryID == (int)comboBox1.SelectedValue).ToList();

            dataGridView2.DataSource = filtroproveedores;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var verificar = oProductoDAL.SelectAll().Where(u => u.UnitsInStock <= 20).ToList();
            dataGridView2.DataSource = verificar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var idname = (from n in listado
                          where n.Discontinued == true
                          select new { id = n.ProductID, nombre = n.ProductName, stock = n.UnitsInStock }).OrderBy(x => x.nombre).ToList();

            dataGridView2.DataSource = idname;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Inventario = (from inv in listado
                              select new
                              {
                                  ID = inv.CategoryID,
                                  Nombre = inv.ProductName,
                                  Exist = inv.UnitsInStock,
                                  Inversion = (inv.UnitPrice * inv.UnitsInStock)
                              }).ToList();


            //Func >>ejecutar acciones
            //Action >>asignar
            decimal total = 0;
            //Action
            Inventario.ForEach(p =>
            {
                total += p.Inversion;
            });

            label1.Text = total.ToString();

            //Func
            label1.Text = Inventario.Sum(p => p.Inversion).ToString();
            dataGridView2.DataSource = Inventario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
