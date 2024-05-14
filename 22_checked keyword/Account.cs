// Example 1
public class Account
{
    private int _todayPaymentSum;
    private const int MaxDailyPaymentSum = 2000000000;

    public void MakePayment(int amount)
    {
        var paymentSumAfterPayment = _todayPaymentSum + amount;

        checked
        {
            try
            {
                if (paymentSumAfterPayment < MaxDailyPaymentSum)
                {
                    _todayPaymentSum = paymentSumAfterPayment;
                    Console.WriteLine($"[UNCHECKED] {amount} transfer \n" +
                        $"(Payment sum for today: {_todayPaymentSum}");
                }
                else
                    Console.WriteLine($"Transaction limit of {MaxDailyPaymentSum} reached");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception");
            }
        }
    }
};

