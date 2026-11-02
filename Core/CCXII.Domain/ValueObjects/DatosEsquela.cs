namespace CCXII.Domain.ValueObjects;

public class DatosEsquela
{
    public bool EsquelaDigital { get; private set; }
    public bool SubirFacebook { get; private set; }
    public bool FotoImpresa { get; private set; }

    private DatosEsquela(bool esquelaDigital, bool subirFacebook, bool fotoImpresa)
    {
        EsquelaDigital = esquelaDigital;
        SubirFacebook = subirFacebook;
        FotoImpresa = fotoImpresa;
    }

    public static DatosEsquela Create(bool esquelaDigital, bool subirFacebook, bool fotoImpresa)
    {
        // Validaciones y lógica de negocio aquí
        return new DatosEsquela(esquelaDigital, subirFacebook, fotoImpresa);
    }
}
