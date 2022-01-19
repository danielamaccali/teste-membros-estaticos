
namespace ExercMembEst1
{
    public static class CalculadoraDolar
    {
        public static double Iof = 6;

        public static double Conversor(double cotacao, double valor)
        {
            double subtotal = (valor * cotacao);
            return subtotal + (subtotal * (Iof/100) ) ;
        }

    }
}
