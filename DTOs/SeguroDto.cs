namespace BackendConsultorio.DTOs
{
    public class SeguroDto
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Codigo { get; set; }
        decimal SumaAsegurada { get; set; }
        decimal Prima { get; set; }
        DateTime FechaCreacion { get; set; }
        string Estado { get; set; }
    }
}
