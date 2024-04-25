using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Net;

namespace Negocio
{
    public class NegocioArticulo
    {
        //TODO: VARIABLES NEGOCIO:
        private SqlDataReader lector = null;
        private Database datos;
        public List<Articulo> articulos;
        public List<Categoria> categorias;
        public List<Marca> marcas;

        //TODO: METODOS NEGOCIO:
        //TODO: Leer Datos
        public List<Articulo> Leer()
        {
            try
            {
                Articulo artAux;
                articulos = new List<Articulo>();
                datos = new Database();

                // CADENA DE CONEXION A LA BD EN Database.cs
                datos.AbrirConexion();
                datos.setQuery("SELECT DISTINCT( A.Id), Codigo, Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, M.Id as IdMarca, C.Descripcion as Categoria, C.Id as IdCategoria, Precio, I.ImagenUrl  as URL FROM ARTICULOS A  LEFT JOIN CATEGORIAS C on C.Id = A.IdCategoria LEFT JOIN MARCAS M on M.Id = A.IdMarca LEFT JOIN IMAGENES I on I.IdArticulo = A.Id");    
                datos.readData();
                lector = datos.reader;

                while(lector.Read())
                {
                    artAux = new Articulo();
                    artAux.id = Convert.ToInt32(lector["Id"]);
                    artAux.codigo = lector["Codigo"].ToString();
                    artAux.nombre = lector["Nombre"].ToString();
                    artAux.descripicion = lector["Descripcion"].ToString();

                    artAux.marca = new Marca(lector["Marca"].ToString());
                    artAux.marca.idMarca = Convert.ToInt32(lector["IdMarca"]);
                    artAux.marca.marca = lector["Marca"].ToString();

                    artAux.categoria = new Categoria(lector["Categoria"].ToString());
                    artAux.categoria.idCategoria = Convert.ToInt32(lector["IdMarca"]);
                    artAux.categoria.categoria = lector["Categoria"].ToString();

                    artAux.precio = Convert.ToDecimal(lector["Precio"]);
                    if (!(lector["URL"] is DBNull))
                        artAux.UrlImagen = lector["URL"].ToString(); // cuidado, si tiene mas fotos no se como cargarlas, hay que usar una query y modo distinto
                    // metodo lector de imagenes ?
                    articulos.Add(artAux);
                }
                return articulos;

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                lector?.Close(); // pregunta si " lector == null? " si no lo esta llama al metodo interno Close() 
                datos.CerrarConexion();
            }
        }
        //TODO: CBO BOX CATEGORIAS
        public List<Categoria> LeerCategorias()
        {
            try
            {
                Categoria cat;
                categorias = new List<Categoria>();
                datos = new Database();

                datos.AbrirConexion();
                datos.setQuery("SELECT id, Descripcion FROM CATEGORIAS");
                datos.readData();
                lector = datos.reader;

                while (lector.Read())
                {
                    cat = new Categoria();
                    cat.idCategoria = (int)lector["id"];
                    cat.categoria = lector["Descripcion"].ToString();
                    categorias.Add(cat);
                }
                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lector?.Close(); // pregunta si " lector == null? " si no lo esta llama al metodo interno Close() 
                datos.CerrarConexion();
            }
        }
        //TODO: CBO BOX MARCAS
        public List<Marca> LeerMarcas()
        {
            try
            {
                Marca marca;
                marcas = new List<Marca>();
                datos = new Database();

                datos.AbrirConexion();
                datos.setQuery("SELECT id, Descripcion FROM MARCAS");
                datos.readData();
                lector = datos.reader;

                while (lector.Read())
                {
                    marca = new Marca();
                    marca.idMarca = (int)lector["id"];
                    marca.marca = lector["Descripcion"].ToString();
                    marcas.Add(marca);
                }
                return marcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lector?.Close(); // pregunta si " lector == null? " si no lo esta llama al metodo interno Close() 
                datos.CerrarConexion();
            }
        }
        //TODO: Agregar Datos
        public int Agregar(Articulo nuevoArticulo)
        {
            try
            {
                datos = new Database();
                datos.AbrirConexion();
                string query = $"INSERT INTO ARTICULOS VALUES (@codigo, @nombre, @descripcion, @marca, @categoria, @precio)";
                datos.setQuery(query);
                datos.setearParamento("@codigo", nuevoArticulo.codigo);
                datos.setearParamento("@nombre", nuevoArticulo.nombre);
                datos.setearParamento("@descripcion", nuevoArticulo.descripicion);
                datos.setearParamento("@categoria", nuevoArticulo.categoria.idCategoria);
                datos.setearParamento("@marca", nuevoArticulo.marca.idMarca);
                datos.setearParamento("@precio", nuevoArticulo.precio);
                return datos.executeQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lector?.Close(); // pregunta si " lector == null? " si no lo esta llama al metodo interno Close() 
                datos.CerrarConexion();
            }
        }
        //TODO: Modificar artículo (HAY QUE REVISAR LA QUERY PRINCIPAL QUE NO TRAE LOS NUEVOS ARTÍCULOS)
        public int Modificar(Articulo nuevoArticulo)
        {
            try
            {
                datos = new Database();
                datos.AbrirConexion();
                string query = "UPDATE ARTICULOS SET Codigo=@codigo,Nombre=@nombre, Descripcion=@descripcion, IdMarca=@marca, IdCategoria=@categoria, Precio=@precio WHERE ID=@id" ;
                datos.setQuery(query);
                datos.setearParamento("@id", nuevoArticulo.id);
                datos.setearParamento("@codigo", nuevoArticulo.codigo);
                datos.setearParamento("@nombre", nuevoArticulo.nombre);
                datos.setearParamento("@descripcion", nuevoArticulo.descripicion);
                datos.setearParamento("@categoria", nuevoArticulo.categoria.idCategoria);
                datos.setearParamento("@marca", nuevoArticulo.marca.idMarca);
                datos.setearParamento("@precio", nuevoArticulo.precio);
                return datos.executeQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                lector?.Close();
                datos.CerrarConexion();
            }
        }
        //TODO: Eliminar Artículo
        public  int Eliminar(int id)
        {
            try
            {
                datos = new Database();
                datos.AbrirConexion();
                string query = "Delete from Articulos WHERE ID = @id";
                datos.setQuery(query);
                datos.setearParamento("@id", id);

                return datos.executeQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        //TODO: Agregar Imagen a la bd
        public int AgregarImg(int id, string urlImagen)
        {
            datos = new Database();
            try
            {
                datos.AbrirConexion();
                datos.setQuery("INSERT INTO IMAGENES VALUES (@id, @urlimg)");
                datos.setearParamento("@urlimg", urlImagen);
                datos.setearParamento("@id", id);
                return datos.executeQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lector?.Close();
                datos.CerrarConexion();
            }
        }
        //TODO: Modificar Imagen 
        public int ModificarImg(int Id, string urlImg)
        {
            datos = new Database();
            try
            {
                datos.AbrirConexion();
                datos.setQuery("UPDATE IMAGENES SET ImagenUrl = @urlimg WHERE Id = @id");
                datos.setearParamento("@urlimg", urlImg);
                datos.setearParamento("@id", Id);

                if (ComprobarImg(Id))
                    return datos.executeQuery();
                else
                    return AgregarImgAux(Id, urlImg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            { 
                lector?.Close(); 
                datos.CerrarConexion();
            }
        }
        //TODO: Comprobar Img
        public bool ComprobarImg(int idArt)
        {
            Database datosAux = new Database();
            try
            {
                datosAux.AbrirConexion();
                datosAux.setQuery("SELECT Id FROM IMAGENES WHERE IdArticulo = @id");
                datosAux.setearParamento("@id", idArt);
                datosAux.readData();
                if (datos.reader != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datosAux.CerrarConexion();
            }
        }
        // Metodos Internos
        //TODO: Eliminar Img
        private int EliminarImgBd(int idArt) // ver si usar
        {
            Database datosAux = new Database();
            try
            {
                datosAux.AbrirConexion();
                datosAux.setQuery("DELETE FROM IMAGENES WHERE Id = @idArt");
                datosAux.setearParamento("@idart", idArt);
                return datosAux.executeQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datosAux.CerrarConexion();
            }
        }
        //TODO: Agregar url Img (privado)
        private int AgregarImgAux(int idArt, string urlImg)
        {
            Database datosImg = new Database();
            try
            {
                datosImg = new Database();
                datosImg.AbrirConexion();
                datosImg.setQuery("INSERT INTO IMAGENES VALUES (@idarticulo, @urlimg)");
                datosImg.setearParamento("@idarticulo", idArt);
                datosImg.setearParamento("@urlimg", urlImg);
                return datosImg.executeQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lector?.Close();
                datosImg.CerrarConexion();
            }
        }

    }//Fin
}
