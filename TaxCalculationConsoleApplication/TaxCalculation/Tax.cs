namespace TaxCalculationConsoleApplication
{
	public class Tax
	{
        private List<TaxBracket> TaxBrackets { get; set; }

        public Tax()
        {
            TaxBrackets = new List<TaxBracket>
            {
                new TaxBracket { LowerLimit = 0, UpperLimit = 1000, TaxPercent = 0.1 },
                new TaxBracket { LowerLimit = 1000, UpperLimit = 5000, TaxPercent = 0.2 },
                new TaxBracket { LowerLimit = 5000, UpperLimit = double.PositiveInfinity, TaxPercent = 0.35 }
            };
        }


        public double CalculateTax(double usualIncome, double additionalIncome)
        {
            double totalTax = 0;
            var remainingAmountAfterTaxDeduction = additionalIncome;

            foreach (var taxBracket in TaxBrackets)
            {
                if(usualIncome <= taxBracket.UpperLimit)
                {
                    double taxableIncome = Math.Min(remainingAmountAfterTaxDeduction, taxBracket.UpperLimit - usualIncome);
                    double taxAmount = taxableIncome * taxBracket.TaxPercent;
                    totalTax += taxAmount;
                    remainingAmountAfterTaxDeduction -= taxableIncome;

                }
                if (remainingAmountAfterTaxDeduction == 0)
                {
                    break;
                }

                usualIncome = Math.Max(0, usualIncome - taxBracket.UpperLimit);


            }

            return totalTax;
        }
    }

	
}

