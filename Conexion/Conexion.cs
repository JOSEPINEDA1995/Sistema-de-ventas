using System.Data.SqlClient;

namespace Sistema_de_ventas.Conexion
{
    public class Conexion
    {
        private string CadenaSQL = string.Empty;

        public Conexion() {
            var builder =new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            CadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }


        public string getCadenaSQL() { 
        
        return CadenaSQL;
        
        }


        private string CadenaSQL2 = string.Empty;

        public void  Conexion1()
        {
            var builder2 = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            CadenaSQL2 = builder2.GetSection("ConnectionStrings:CadenaSQL2").Value;
 
        }


        public string getCadenaSQL2()
        {

            return CadenaSQL;

        }






    }
}
