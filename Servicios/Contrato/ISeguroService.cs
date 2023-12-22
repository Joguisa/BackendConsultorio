using BackendConsultorio.Models;

namespace BackendConsultorio.Servicios.Contrato
{
    public interface ISeguroService
    {
        Task<List<Seguro>> GetListSeguros();
        Task<Seguro> GetSeguroById(int idSeguro);
        Task<Seguro> CreateSeguro(Seguro seguro);
        Task<Seguro> UpdateSeguro(Seguro seguro, int idSeguro);
        Task<Seguro> DeleteSeguro(int id);
    }
}
