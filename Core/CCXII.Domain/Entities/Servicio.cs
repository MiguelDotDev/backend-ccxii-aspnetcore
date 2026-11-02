using CCXII.Domain.ValueObjects;
namespace CCXII.Domain.Entities;

public class Servicio
{
    public Guid Id { get; private set; }
    public Guid TrascendidoId { get; private set; }
    public PlanesPrevision? Plan { get; private set; }
    public string? Localidad { get; private set; }
    public DateOnly FechaContratacion { get; private set; }
    public DateOnly FechaTermino { get; private set; }
    public bool MemoriasCorazon { get; private set; }
    public bool EsquelasSeparador { get; private set; }
    public TipoVelacion TipoVelacion { get; private set; }
    public List<FamiliarTrascendido> Familiares { get; private set; } = new();
    public TipoServicio TipoServicio { get; private set; }
    public List<Misa> Misas { get; private set; } = new();
    public DatosFosa? DatosFosa { get; private set; }
    public DatosEsquela? DatosEsquela { get; private set; }
    public DatosCafeteria? DatosCafeteria { get; private set; }
    public DatosVehiculoUtilitario? DatosVehiculoUtilitario { get; private set; }
}
