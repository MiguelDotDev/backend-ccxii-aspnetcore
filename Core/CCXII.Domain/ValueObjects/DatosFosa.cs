namespace CCXII.Domain.ValueObjects;

public class DatosFosa
{
    public ResponsablesFosa Responsable { get; private set; }
    public bool HayLozas { get; private set; }

    private DatosFosa(ResponsablesFosa responsable, bool hayLozas)
    {
        Responsable = responsable;
        HayLozas = hayLozas;
    }

    public static DatosFosa Create(ResponsablesFosa responsable, bool hayLozas)
    {
        // Validaciones y lógica de negocio aquí
        return new DatosFosa(responsable, hayLozas);
    }
}
