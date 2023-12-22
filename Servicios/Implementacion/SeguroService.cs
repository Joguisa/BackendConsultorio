using Microsoft.EntityFrameworkCore;
using BackendConsultorio.Models;
using BackendConsultorio.Servicios.Contrato;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using BackendConsultorio.Connection;
using System.Data;

namespace BackendConsultorio.Servicios.Implementacion
{
    public class SeguroService : ISeguroService
    {
        private DBSEGUROSCHUBBContext _context;
        private string cadena;
        public SeguroService(DBSEGUROSCHUBBContext context)
        {
            this._context = context;
            IConfigurationBuilder builder = new ConfigurationBuilder();
            cadena = builder.Build().GetConnectionString("db");

        }

        public async Task<List<Seguro>> GetListSeguros()
        {
            List <Seguro> listaSeguro = new() ;
            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    await db.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand("ObtenerSegurosActivos", db))
                    {
                        // en caso de haber aquí declarar los parámetros

                        // indico que es un sp
                        cmd.CommandType = CommandType.StoredProcedure;
                        // ejecuto el sp
                        cmd.ExecuteNonQuery();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(await reader.ReadAsync())
                            {
                                Seguro seguro = new Seguro();

                                seguro.NombreSeguro = reader["NombreSeguro"].ToString().Trim();
                                seguro.CodigoSeguro = reader["CodigoSeguro"].ToString().Trim();
                                seguro.SumaAsegurada = decimal.Parse(reader["SumaAsegurada"].ToString().Trim());
                                seguro.Prima = decimal.Parse(reader["Prima"].ToString().Trim());

                                listaSeguro.Add(seguro);
                                
                            }
                        }

                    }
                }catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            

        }

        public Task<Seguro> GetSeguro(int idSeguro)
        {
            throw new NotImplementedException();
        }

        public Task<Seguro> SaveSeguro(Seguro seguro)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSeguro(Seguro seguro)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSeguro(int idSeguro)
        {
            throw new NotImplementedException();
        }
    }
}
