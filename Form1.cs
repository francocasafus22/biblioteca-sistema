using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BibliotecaMySQL2
{
    public partial class Form1 : Form
    {
        private List<Producto> mProductos; // Listado de los libros
        private Consulta mConsulta; // Instancia de la clase Consulta para operar con la DB
        private Producto mProducto; // Representa cada uno de los libros
        public Form1()
        {
            // Inicializa el Form y los componentes
            InitializeComponent();
            mProductos = new List<Producto>();
            mConsulta = new Consulta();
            mProducto = new Producto();
            cargarProductos();
        }

        // Carga los libros de la DB
        private void cargarProductos(string filtro = "")
        {
            // Luego, recarga el DataGridView y los libros para mostrar los datos correspondientes
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mConsulta.getLibros(filtro);

            // Iteración de todos los libros para agregarlos en el DGV
            for (int i = 0; i < mProductos.Count; i++)
            {
                dgvProductos.RowTemplate.Height = 50;
                string fechaPublicacion = mProductos[i].FechaPublicacion.ToString("dd/MM/yyyy");
                dgvProductos.Rows.Add(
                  mProductos[i].idLibro,
                  mProductos[i].Titulo,
                  mProductos[i].Nombre,
                  mProductos[i].Editorial,
                  mProductos[i].NroISBN,
                  fechaPublicacion,
                  mProductos[i].Genero,
                  mProductos[i].Edicion,
                  mProductos[i].PrecioCompra,
                  mProductos[i].PrecioVenta,
                  mProductos[i].Idioma,
                  mProductos[i].NumeroPaginas,
                  mProductos[i].CantidadImpresa
                  );
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /* Al tocar el botón "Agregar Libro" se añade a la DB con los 
           datos colocados por el usuario */
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosProducto();

            if(mConsulta.agregarLibro(mProducto))
            {
                MessageBox.Show("Libro agregado.");
                cargarProductos();
                LimpiarCampos();
            }
        }

        // Limpia todos los cuadros de texto en el formulario, restableciendo sus valores a cadenas vacías.
        private void LimpiarCampos()
        {
            textBoxidLibro.Text = "";
            textBoxTitulo.Text = "";
            textBoxAutor.Text = "";
            textBoxEditorial.Text = "";
            textBoxISBN.Text = "";
            textBoxFechaPublicacion.Text = "";
            textBoxGenero.Text = "";
            textBoxNumeroEdicion.Text = "";
            textBoxCompra.Text = "";
            textBoxVenta.Text = "";
            textBoxIdioma.Text = "";
            textBoxPaginas.Text = "";
            textBoxImpresos.Text = "";
        }

        // Se cargan los datos de los libros
        private void cargarDatosProducto()
        {
            mProducto.idLibro = getidLibroIfExist();
            mProducto.Titulo = textBoxTitulo.Text.Trim();
            mProducto.Nombre = textBoxAutor.Text.Trim();
            mProducto.Editorial = textBoxEditorial.Text.Trim();
            mProducto.NroISBN = textBoxISBN.Text.Trim();

            // Conversión segura de FechaPublicacion
            if (DateTime.TryParse(textBoxFechaPublicacion.Text.Trim(), out DateTime fechaPublicacion))
                mProducto.FechaPublicacion = fechaPublicacion;
            mProducto.Genero = textBoxGenero.Text.Trim();

            // Conversión segura de Edición
            if (int.TryParse(textBoxNumeroEdicion.Text.Trim(), out int edicion))
                mProducto.Edicion = edicion;
            else
                mProducto.Edicion = 0; // Valor predeterminado o manejo de error

            // Conversión segura de PrecioCompra
            if (decimal.TryParse(textBoxCompra.Text.Trim(), out decimal precioCompra))
                mProducto.PrecioCompra = precioCompra;
            else
                mProducto.PrecioCompra = 0m;

            // Conversión segura de PrecioVenta
            if (decimal.TryParse(textBoxVenta.Text.Trim(), out decimal precioVenta))
                mProducto.PrecioVenta = precioVenta;
            else
                mProducto.PrecioVenta = 0m;

            mProducto.Idioma = textBoxIdioma.Text.Trim();

            // Conversión segura de NumeroPaginas
            if (int.TryParse(textBoxPaginas.Text.Trim(), out int numeroPaginas))
                mProducto.NumeroPaginas = numeroPaginas;
            else
                mProducto.NumeroPaginas = 0;

            // Conversión segura de CantidadImpresa
            if (int.TryParse(textBoxImpresos.Text.Trim(), out int cantidadImpresa))
                mProducto.CantidadImpresa = cantidadImpresa;
            else
                mProducto.CantidadImpresa = 0;
        }

        private int getidLibroIfExist() // Obtiene el ID de los libros
        {
            if (!textBoxidLibro.Text.Trim().Equals(""))
            {
                if (int.TryParse(textBoxidLibro.Text.Trim(), out int idLibro))
                {
                    return idLibro;
                }
                else return -1;
            }
            else return -1;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e) // Búsqueda de libros (query)
        {
            cargarProductos(txtBusqueda.Text.Trim());
        }

        private bool datosCorrectos() // Verifica si se ingresaron correctamente los datos o faltaron algunos
        {
            if (textBoxTitulo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un título");
                return false;
            }
            if (textBoxAutor.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un autor");
                return false;
            }
            if (textBoxEditorial.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una editorial");
                return false;
            }
            if (textBoxISBN.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un ISBN");
                return false;
            }
            if (textBoxFechaPublicacion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un año de edición");
                return false;
            }
            if (textBoxGenero.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un genero");
                return false;
            }
            if (!int.TryParse(textBoxNumeroEdicion.Text.Trim(), out int numeroEdicion))
            {
                MessageBox.Show("Debe ingresar una edición");
                return false;
            }
            if (!float.TryParse(textBoxCompra.Text.Trim(), out float precioCompra))
            {
                MessageBox.Show("Debe ingresar un precio de compra");
                return false;
            }
            if (!float.TryParse(textBoxVenta.Text.Trim(), out float precioVenta))
            {
                MessageBox.Show("Debe ingresar un precio de venta");
                return false;
            }
            if (textBoxIdioma.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un idioma");
                return false;
            }
            if (!int.TryParse(textBoxPaginas.Text.Trim(), out int numeroPaginas))
            {
                MessageBox.Show("Debe ingresar el número de páginas");
                return false;
            }
            if (!int.TryParse(textBoxImpresos.Text.Trim(), out int numeroImpresos))
            {
                MessageBox.Show("Debe ingresar el número de libros impresos");
                return false;
            }
            return true;
        }

        /*Al tocar el dato de un libro, se carga en los TextBoxes correspondientes, 
         en donde pueden ser modificados*/

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            textBoxidLibro.Text = fila.Cells[0].Value.ToString();
            textBoxTitulo.Text = fila.Cells[1].Value.ToString();
            textBoxAutor.Text = fila.Cells[2].Value.ToString();
            textBoxEditorial.Text = fila.Cells[3].Value.ToString();
            textBoxISBN.Text = fila.Cells[4].Value.ToString();
            textBoxFechaPublicacion.Text = fila.Cells[5].Value.ToString();
            textBoxGenero.Text = fila.Cells[6].Value.ToString();
            textBoxNumeroEdicion.Text = fila.Cells[7].Value.ToString();
            textBoxCompra.Text = fila.Cells[8].Value.ToString();
            textBoxVenta.Text = fila.Cells[9].Value.ToString();
            textBoxIdioma.Text = fila.Cells[10].Value.ToString();
            textBoxPaginas.Text = fila.Cells[11].Value.ToString();
            textBoxImpresos.Text = fila.Cells[12].Value.ToString();

            
        }


        /*Al tocar el botón "Modificar libro", este cambia los datos 
         en la DB de un libro ya existente*/
        private void button1_Click_3(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosProducto();

            if (mConsulta.modificarProducto(mProducto))
            {
                MessageBox.Show("Libro modificado.");
                cargarProductos();
                LimpiarCampos();
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (getidLibroIfExist() == -1)
            {
                return;
            }
            

            if (MessageBox.Show("¿Desea eliminar el libro?", "Eliminar libro",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosProducto();
                if (mConsulta.eliminarProducto(mProducto))
                {
                    MessageBox.Show("Libro eliminado.");
                    cargarProductos();
                    LimpiarCampos();
                }
            }
        }

        private void textBoxCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdioma_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImpresos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFechaPublicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
