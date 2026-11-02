using CCXII.Domain.Entities;
namespace CCXII.Domain.ValueObjects;

public class DatosVehiculoUtilitario
{
    public List<OperadorCarroza> OperadoresCarroza { get; private set; }
    public Carrozas Carroza { get; private set; }

    private DatosVehiculoUtilitario(List<OperadorCarroza> operadoresCarroza, Carrozas carroza)
    {
        OperadoresCarroza = operadoresCarroza;
        Carroza = carroza;
    }

    public static DatosVehiculoUtilitario Create(List<OperadorCarroza> operadoresCarroza, Carrozas carroza)
    {
        return new DatosVehiculoUtilitario(operadoresCarroza, carroza);
    }
}
