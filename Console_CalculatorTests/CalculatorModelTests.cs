using Microsoft.VisualStudio.TestTools.UnitTesting;
using Console_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator.Tests
{
    [TestClass()]
    public class CalculatorModelTests
    {
        [TestMethod()]
        public void Berechne_DivisionDurchNull()
        {
            CalculatorModel calculatorModel = new CalculatorModel();

            calculatorModel.Rechenoperator = "%";
            calculatorModel.Wert1 = 10;
            calculatorModel.Wert2 = 0;

            calculatorModel.Berechne();

            Assert.AreEqual(Decimal.Zero, calculatorModel.Ergebnis);
        }
    }
}