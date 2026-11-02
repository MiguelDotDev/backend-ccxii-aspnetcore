namespace CCXII.Domain.Entities;

public class Empleado
{
    public Guid Id { get; private set; }
    public string Nombre { get; private set; }
    public string ApellidoPaterno { get; private set; }
    public string ApellidoMaterno { get; private set; }

    private Empleado(string nombre, string apellidoPaterno, string apellidoMaterno)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
    }

    public static Empleado Create(string nombre, string apellidoPaterno, string apellidoMaterno)
    {
        return new Empleado(nombre, apellidoPaterno, apellidoMaterno);
    }
}
