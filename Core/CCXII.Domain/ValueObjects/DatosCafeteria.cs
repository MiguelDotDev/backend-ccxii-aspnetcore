namespace CCXII.Domain.ValueObjects;

public class DatosCafeteria
{
    public bool HayCafeteria { get; private set; }
    public string EncargadoLlevarla { get; private set; } = string.Empty;
    public DateTime MomentoEntrega { get; private set; }
    public string Observaciones { get; private set; } = string.Empty;

    private DatosCafeteria(
        bool hayCafeteria,
        string encargadoLlevarla,
        DateTime momentoEntrega,
        string observaciones)
    {
        HayCafeteria = hayCafeteria;
        EncargadoLlevarla = encargadoLlevarla;
        MomentoEntrega = momentoEntrega;
        Observaciones = observaciones;
    }

    public static DatosCafeteria Create(
        bool hayCafeteria,
        string encargadoLlevarla,
        DateTime momentoEntrega,
        string observaciones)
    {
        // Validaciones y lógica de negocio aquí
        return new DatosCafeteria(hayCafeteria, encargadoLlevarla, momentoEntrega, observaciones);
    }
}
