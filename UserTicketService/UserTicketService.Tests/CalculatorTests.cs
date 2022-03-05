using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserTicketService.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.Equal(8, calculator.Multiplication(2, 4));
        }
    }
}
