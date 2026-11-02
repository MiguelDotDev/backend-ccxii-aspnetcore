namespace CCXII.Domain.ValueObjects;

public class Misa
{
    public DateTime HoraYFecha { get; private set; }
    public string Lugar { get; private set; }
    public string? Observaciones { get; private set; }

    private Misa(DateTime horaYFecha, string lugar, string? observaciones)
    {
        HoraYFecha = horaYFecha;
        Lugar = lugar;
        Observaciones = observaciones;
    }

    public static Misa Create(DateTime horaYFecha, string lugar, string? observaciones)
    {
        return new Misa(horaYFecha, lugar, observaciones);
    }
}
