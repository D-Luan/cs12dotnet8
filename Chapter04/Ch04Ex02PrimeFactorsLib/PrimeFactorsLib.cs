using System.Text;

namespace Ch04Ex02PrimeFactorsLib;

public static class PrimeFactorsLib
{
    public static string PrimeFactors(int number)
    {
        int primeNumber = 2;
        StringBuilder message = new StringBuilder();

        do
        {
            if (number % primeNumber == 0)
            {
                number = number / primeNumber;
                
                if (message.Length > 0)
                {
                    message.Append(" x ");
                }

                message.Append(primeNumber);
            } else
            {
                primeNumber++;
            }

        } while (number != 1);

        return message.ToString();
    }
}
