using Interpretor.ExpressionInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpretor.ConcreteImplementation
{
    public class AndExpression : IExpression
    {
        private IExpression _expression1;
        private IExpression _expression2;

        public AndExpression(IExpression expression1, IExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public bool Interpret(string context)
        {
            return _expression1.Interpret(context) && _expression2.Interpret(context);
        }
    }
}
