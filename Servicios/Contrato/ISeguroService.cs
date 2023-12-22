using BackendConsultorio.Models;

namespace BackendConsultorio.Servicios.Contrato
{
    public interface ISeguroService
    {
        Task<List<Seguro>> GetListSeguros();
        Task<Seguro> GetSeguro(int idSeguro);
        Task<Seguro> SaveSeguro(Seguro seguro);
        Task<bool> UpdateSeguro(Seguro seguro);
        Task<bool> DeleteSeguro(int idSeguro);
    }
}
