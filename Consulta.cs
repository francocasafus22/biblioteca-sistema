using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaMySQL2
{
    internal class Consulta
    {
        private ConexionMySQL conexionMySQL;
        private List<Producto> mProductos;

        public Consulta()
        {
            conexionMySQL = new ConexionMySQL();
            mProductos = new List<Producto>();
        }

        public List<Producto> getLibros(string filtro)
        {
            string QUERY = "SELECT * from libro";
            MySqlDataReader mReader = null;
            try
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    QUERY += $" WHERE idLibro LIKE '%{filtro}%' OR libro.Titulo LIKE '%{filtro}%' OR libro.Autor LIKE '%{filtro}%' OR libro.Editorial LIKE '%{filtro}%' OR libro.NroISBN LIKE '%{filtro}%' OR libro.FechaPublicacion LIKE '%{filtro}%' OR libro.Genero LIKE '%{filtro}%' OR libro.Idioma LIKE '%{filtro}%' OR libro.Edicion LIKE '%{filtro}%' OR libro.PrecioCompra LIKE '%{filtro}%' OR libro.PrecioVenta LIKE '%{filtro}%' OR libro.NumeroPaginas LIKE '%{filtro}%' OR libro.CantidadImpresa LIKE '%{filtro}%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySQL.getConnection();
                mReader = mComando.ExecuteReader();

                Producto mProducto = null;
                while (mReader.Read())
                {
                    mProducto = new Producto();
                    mProducto.idLibro = mReader.GetInt16("idLibro");
                    mProducto.Titulo = mReader.GetString("Titulo");
                    mProducto.Nombre = mReader.GetString("Autor");
                    mProducto.Editorial = mReader.GetString("Editorial");
                    mProducto.NroISBN = mReader.GetString("NroISBN");
                    mProducto.FechaPublicacion = mReader.GetDateTime("FechaPublicacion");
                    mProducto.Genero = mReader.GetString("Genero");
                    mProducto.Edicion = mReader.GetInt16("Edicion");
                    mProducto.PrecioCompra = mReader.GetDecimal("PrecioCompra");
                    mProducto.PrecioVenta = mReader.GetDecimal("PrecioVenta");
                    mProducto.Idioma = mReader.GetString("Idioma");
                    mProducto.NumeroPaginas = mReader.GetInt16("NumeroPaginas");
                    mProducto.CantidadImpresa = mReader.GetInt64("CantidadImpresa");
                    mProductos.Add(mProducto);
                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }




            return mProductos;
        }

        internal bool agregarLibro(Producto mProducto)
        {
            string INSERT = "INSERT INTO libro(Titulo, Autor, Editorial, NroISBN, FechaPublicacion, Genero, Edicion, PrecioCompra, PrecioVenta, Idioma, NumeroPaginas, CantidadImpresa) values (@Titulo, @Autor, @Editorial, @NroISBN, @FechaPublicacion, @Genero, @Edicion, @PrecioCompra, @PrecioVenta, @Idioma, @NumeroPaginas, @CantidadImpresa);";

            MySqlCommand mComando = new MySqlCommand(INSERT, conexionMySQL.getConnection());
            mComando.Parameters.Add(new MySqlParameter("@Titulo" , mProducto.Titulo));
            mComando.Parameters.Add(new MySqlParameter("@Autor" , mProducto.Nombre));
            mComando.Parameters.Add(new MySqlParameter("@Editorial" , mProducto.Editorial));
            mComando.Parameters.Add(new MySqlParameter("@NroISBN" , mProducto.NroISBN));
            mComando.Parameters.Add(new MySqlParameter("@FechaPublicacion" , mProducto.FechaPublicacion));
            mComando.Parameters.Add(new MySqlParameter("@Genero" , mProducto.Genero));
            mComando.Parameters.Add(new MySqlParameter("@Edicion" , mProducto.Edicion));
            mComando.Parameters.Add(new MySqlParameter("@PrecioCompra" , mProducto.PrecioCompra));
            mComando.Parameters.Add(new MySqlParameter("@PrecioVenta" , mProducto.PrecioVenta));
            mComando.Parameters.Add(new MySqlParameter("@Idioma" , mProducto.Idioma));
            mComando.Parameters.Add(new MySqlParameter("@NumeroPaginas" , mProducto.NumeroPaginas));
            mComando.Parameters.Add(new MySqlParameter("@CantidadImpresa" , mProducto.CantidadImpresa));

           return mComando.ExecuteNonQuery() > 0;
        }

        internal bool eliminarProducto(Producto mProducto)
        {
                    string DELETE = "DELETE FROM libro WHERE idLibro = @idLibro;";

                    MySqlCommand mComando = new MySqlCommand(DELETE, conexionMySQL.getConnection());
                  
                    mComando.Parameters.Add(new MySqlParameter("@idLibro", mProducto.idLibro));

                    return mComando.ExecuteNonQuery() > 0;
        }

        internal bool modificarProducto(Producto mProducto)
        {
            string UPDATE = "UPDATE libro SET " + 
                "Titulo = @Titulo, " +
                "Autor = @Autor, " +
                "Editorial = @Editorial, " +
                "NroISBN = @NroISBN, " +
                "FechaPublicacion = @FechaPublicacion, " +
                "Genero = @Genero, " +
                "Edicion = @Edicion, " +
                "PrecioCompra = @PrecioCompra, " +
                "PrecioVenta = @PrecioVenta, " +
                "Idioma = @Idioma, " +
                "NumeroPaginas = @NumeroPaginas, " +
                "CantidadImpresa = @CantidadImpresa " +
                "WHERE idLibro = @idLibro;";

            MySqlCommand mComando = new MySqlCommand(UPDATE, conexionMySQL.getConnection());
            mComando.Parameters.Add(new MySqlParameter("@Titulo", mProducto.Titulo));
            mComando.Parameters.Add(new MySqlParameter("@Autor", mProducto.Nombre));
            mComando.Parameters.Add(new MySqlParameter("@Editorial", mProducto.Editorial));
            mComando.Parameters.Add(new MySqlParameter("@NroISBN", mProducto.NroISBN));
            mComando.Parameters.Add(new MySqlParameter("@FechaPublicacion", mProducto.FechaPublicacion));
            mComando.Parameters.Add(new MySqlParameter("@Genero", mProducto.Genero));
            mComando.Parameters.Add(new MySqlParameter("@Edicion", mProducto.Edicion));
            mComando.Parameters.Add(new MySqlParameter("@PrecioCompra", mProducto.PrecioCompra));
            mComando.Parameters.Add(new MySqlParameter("@PrecioVenta", mProducto.PrecioVenta));
            mComando.Parameters.Add(new MySqlParameter("@Idioma", mProducto.Idioma));
            mComando.Parameters.Add(new MySqlParameter("@NumeroPaginas", mProducto.NumeroPaginas));
            mComando.Parameters.Add(new MySqlParameter("@CantidadImpresa", mProducto.CantidadImpresa));

            mComando.Parameters.Add(new MySqlParameter("@idLibro", mProducto.idLibro));

            return mComando.ExecuteNonQuery() > 0;
        }
    }
}