namespace TaxCalculationConsoleApplication
{
	public class Tax
	{
        private List<TaxBracket> TaxBrackets { get; set; }

        public Tax()
        {
            TaxBrackets = new List<TaxBracket>
            {
                new TaxBracket { LowerLimit = 0, UpperLimit = 1000, TaxPercent = 10 },
                new TaxBracket { LowerLimit = 1000, UpperLimit = 5000, TaxPercent = 20 },
                new TaxBracket { LowerLimit = 5000, UpperLimit = 10000, TaxPercent = 35 },
                new TaxBracket { LowerLimit = 10000, UpperLimit = double.PositiveInfinity, TaxPercent = 40 }

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
                    double taxAmount = taxableIncome * (taxBracket.TaxPercent)/100;
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

