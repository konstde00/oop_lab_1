using System.Collections.Generic;
using System.Diagnostics;

namespace Excel
{
    public class LabCalculatorVisitor : LabCalculatorBaseVisitor<double>
    {
        private readonly Dictionary<string, double> _tableIdentifier = new();

        public override double VisitCompileUnit(LabCalculatorParser.CompileUnitContext context)
        {
            return Visit(context.expression());
        }

        public override double VisitNumberExpr(LabCalculatorParser.NumberExprContext context)
        {
            var result = double.Parse(context.GetText());
            Debug.WriteLine(result);

            return result;
        }

        //IdentifierExpr
        public override double VisitIdentifierExpr(LabCalculatorParser.IdentifierExprContext context)
        {
            var result = context.GetText();
            return _tableIdentifier.TryGetValue(result, out var value) ? value : 0.0;
        }
        public override double VisitUnaryMinusExpr(LabCalculatorParser.UnaryMinusExprContext context)
        {
            var left = WalkLeft(context);

            Debug.WriteLine("-{0}", left);
            left = -left;
            return left;
        }

        public override double VisitParenthesizedExpr(LabCalculatorParser.ParenthesizedExprContext context)
        {
            return Visit(context.expression());
        }

        public override double VisitExponentialExpr(LabCalculatorParser.ExponentialExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);

            Debug.WriteLine("{0} ^ {1}", left, right);
            return System.Math.Pow(left, right);
        }
        public override double VisitIncDecExpr(LabCalculatorParser.IncDecExprContext context)
        {
            var left = WalkLeft(context);

            if (context.operatorToken.Type == LabCalculatorLexer.INCREMENT)
            {
                Debug.WriteLine("++{0}", left);
                return ++left;
            }
            else 
            {
                Debug.WriteLine("{0}--", left);
                return --left;
            }
        }
        public override double VisitAdditiveExpr(LabCalculatorParser.AdditiveExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);

            if (context.operatorToken.Type == LabCalculatorLexer.ADD)
            {
                Debug.WriteLine("{0} + {1}", left, right);
                return left + right;
            }
            else 
            {
                Debug.WriteLine("{0} - {1}", left, right);
                return left - right;
            }
        }

        public override double VisitMultiplicativeExpr(LabCalculatorParser.MultiplicativeExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);

            if (context.operatorToken.Type == LabCalculatorLexer.MULTIPLY)
            {
                Debug.WriteLine("{0} * {1}", left, right);
                return left * right;
            }
            else 
            {
                Debug.WriteLine("{0} / {1}", left, right);
                return left / right;
            }
        }

        private double WalkLeft(LabCalculatorParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<LabCalculatorParser.ExpressionContext>(0));
        }

        private double WalkRight(LabCalculatorParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<LabCalculatorParser.ExpressionContext>(1));
        }
    }
}
