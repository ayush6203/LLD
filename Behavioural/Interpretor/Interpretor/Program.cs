// See https://aka.ms/new-console-template for more information
using Interpretor;
using Interpretor.ExpressionInterface;

Console.WriteLine("Hello, World!");



IExpression getMale = InterpretorDemo.GetMaleExpression();
IExpression getMarried = InterpretorDemo.GetMarriedExpression();

Console.WriteLine("Is John is Male? : " + getMale.Interpret("John"));
Console.WriteLine("Is Julie is Married Women? : " + getMarried.Interpret("Married Julie"));

Console.ReadKey();
