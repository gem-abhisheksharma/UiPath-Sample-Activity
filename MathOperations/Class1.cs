using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace MathOperations
{
    public class SimpleFormula : CodeActivity
    {
        [Category("Input")]
        [DisplayName("First Number")]
        [Description("First Number")]
        [RequiredArgument]
        public InArgument<double> FirstNumber { get; set; }

        [Category("Input")]
        [DisplayName("Second Number")]
        [Description("Second Number")]
        [RequiredArgument]
        public InArgument<double> SecondNumber { get; set; }

        [Category("Output")]
        [DisplayName("Result")]
        [Description("Sum of First and Second Number")]
        public OutArgument<double> ResultNumber { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            var firstNumber = FirstNumber.Get(context);
            var secondNumber = SecondNumber.Get(context);
            var result = firstNumber + secondNumber;
            ResultNumber.Set(context, result);
        }
    }
}
