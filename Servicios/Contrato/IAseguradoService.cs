using BackendConsultorio.Models;

namespace BackendConsultorio.Servicios.Contrato
{
    public interface IAseguradoService
    {
        Task<List<Asegurado>> GetListAsegurados();
    }
}
