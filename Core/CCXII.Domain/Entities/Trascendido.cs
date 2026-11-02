namespace CCXII.Domain.Entities;

public class Trascendido
{
    public Guid Id { get; private set; }
    public string Nombre { get; private set; }
    public string ApellidoPaterno { get; private set; }
    public string ApellidoMaterno { get; private set; }
    public DateOnly FechaNacimiento { get; private set; }
    public DateOnly FechaDefuncion { get; private set; }
}
