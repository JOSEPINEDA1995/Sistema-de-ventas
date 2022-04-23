using Sistema_de_ventas.Models;
using System.Data.SqlClient;
using System.Data;
namespace Sistema_de_ventas.Conexion
{
    public class DeparamentoDatos
    {
        public List<DepartamentoModelo> listar()
        {

            var lista = new List<DepartamentoModelo>();

            var con = new Conexion();

            using (var conexion = new SqlConnection(con.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select * from DEPARTAMENTO", conexion);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DepartamentoModelo()
                        {
                            DEP_ID = Convert.ToInt32(reader["DE_ID"]),
                            DEP_NOMBRE = reader["NOMBRE"].ToString()

                        });
                    }
                }

            }

            return lista;
        }


        public DepartamentoModelo listaruno(int id)
        {

            var lista = new DepartamentoModelo();

            var con = new Conexion();

            using (var conexion = new SqlConnection(con.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(" select * from DEPARTAMENTO where DE_ID ="+id+" ", conexion);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        lista.DEP_ID = Convert.ToInt32(reader["DE_ID"]);
                        lista.DEP_NOMBRE = reader["NOMBRE"].ToString();

                    }
                }

            }

            return lista;
        }


        public bool guardar(DepartamentoModelo depa)
        {
            bool a;
            var con = new Conexion();

            using (var conexion = new SqlConnection(con.getCadenaSQL()))
            {

                try
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("insert into DEPARTAMENTO values('" + depa.DEP_NOMBRE + "') ", conexion);
                    cmd.ExecuteNonQuery();
                    a = true;
                    return a;
                }
                catch (Exception)
                {

                    return
                        false;
                }

                {
                }

            }
            

        }


        public bool modificar(DepartamentoModelo depa)
        {
            bool a;
            var con = new Conexion();

            using (var conexion = new SqlConnection(con.getCadenaSQL()))
            {

                try
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(" update DEPARTAMENTO set NOMBRE = '"+depa.DEP_NOMBRE+"' where DE_ID="+depa.DEP_ID+" ", conexion);
                    cmd.ExecuteNonQuery();
                    a = true;
                    return a;
                }
                catch (Exception)
                {

                    return
                        false;
                }

                {
                }

            }


        }


    }
}
