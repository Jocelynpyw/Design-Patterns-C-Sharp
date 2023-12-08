// Classe qui utilise une stratégie pour calculer une remise
using Strategie;

public class ContexteRemise
{
    private IStrategieRemise strategie;

    public ContexteRemise (IStrategieRemise strategie)
    {
        this.strategie = strategie;
    }

    public void AppliquerRemise(double montant)
    {
        double remise = strategie.CalculerRemise(montant);
        double montantFinal = montant - remise;

        Console.WriteLine($"Montant initial : {montant}$");
        Console.WriteLine($"Remise appliquée : {remise}$");
        Console.WriteLine($"Montant final : {montantFinal}$");
    }
}
