namespace Strategie
{
   public interface IStrategieRemise
    {
        double CalculerRemise(double montant);
    }
    public class StrategieRemiseRegulier : IStrategieRemise
    {
        public double CalculerRemise(double montant )
        {
            // Aucune remise pour les clients réguliers
            return 0;
        }
    }

    // Stratégie de remise pour les clients fidèles
    public class StrategieRemiseFidele : IStrategieRemise
    {
        public double CalculerRemise(double montant)
        {
            // Remise de 10% pour les clients fidèles
            return montant * 0.1;
        }
    }
    // Stratégie de remise pour les clients VIP
    public class StrategieRemiseVIP : IStrategieRemise
    {
        public double CalculerRemise(double montant)
        {
            // Remise de 20% pour les clients VIP
            return montant * 0.2;
        }
    }



    }