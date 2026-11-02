using CCXII.Domain.ValueObjects;
namespace CCXII.Domain.Entities;

public class FamiliarTrascendido
{
    public Guid Id { get; private set; }
    public string Nombre { get; private set; }
    public string? ApellidoPaterno { get; private set; }
    public string? ApellidoMaterno { get; private set; }
    public Parentescos Parentesco { get; private set; }
    public string NumeroTelefono { get; private set; }
}
