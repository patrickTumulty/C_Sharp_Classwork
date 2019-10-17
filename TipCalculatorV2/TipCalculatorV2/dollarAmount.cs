using System;
namespace TipCalculatorLibrary 
{
    public class dollarAmount
    {
        double Bill_Total;
        double Tip;
        int[] Tip_Percentages = { 18, 20, 22, 25 };
        double Bill_Split;
        double Tip_Split;

        public dollarAmount()
        {
        }

        public void Split_Total(double BillAmount, double Percentage)
        {
            Percentage = Percentage / 100;
            Tip = BillAmount * Percentage;
        }


    }
}
