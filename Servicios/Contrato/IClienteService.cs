using BackendConsultorio.Models;

namespace BackendConsultorio.Servicios.Contrato
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetListClientes();
    }
}
