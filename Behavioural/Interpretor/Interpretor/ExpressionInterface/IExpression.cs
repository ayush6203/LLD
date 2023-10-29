using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpretor.ExpressionInterface
{
    public interface IExpression
    {
        public bool Interpret(string context);
    }
}
