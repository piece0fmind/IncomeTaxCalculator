namespace TaxCalculationTest;

public class TaxCalculationTests
{
    private readonly Tax _tax;

    public TaxCalculationTests()
    {
        _tax = new Tax();
    }

    [Fact]
    public void CalculateTax_ShouldReturnCorrectTaxAmount()
    {
        double usualIncome = 900;
        double additionalIncome = 16000;
        double taxAmount = 4870;

        var result = _tax.CalculateTax(usualIncome, additionalIncome);

        Assert.Equal(taxAmount, result);
    }

    //[Fact]
    //public void CalculateTax_BothIncomesAreZero_ShouldReturnZero()
    //{
    //    double usualIncome = 0;
    //    double additionalIncome = 0;
    //    double taxAmount = 0;

    //    var result = _tax.CalculateTax(usualIncome, additionalIncome);

    //    Assert.Equal(taxAmount, result);
    //}

    //[Fact]
    //public void CalculateTax_AdditionalIncomeIsZero_ShouldReturnZero()
    //{
    //    double usualIncome = 1000;
    //    double additionalIncome = 0;
    //    double taxAmount = 0;

    //    var result = _tax.CalculateTax(usualIncome, additionalIncome);

    //    Assert.Equal(taxAmount, result);
    //}

    //[Fact]
    //public void CalculateTax_UsualIncomeIsZero_ShouldReturnZero()
    //{
    //    double usualIncome = 0;
    //    double additionalIncome = 0;
    //    double taxAmount = 0;

    //    var result = _tax.CalculateTax(usualIncome, additionalIncome);

    //    Assert.Equal(taxAmount, result);
    //}

}
