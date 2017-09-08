using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class RPNCalculatorEngine : CalculatorEngine
    {
        public string Process(string str)
        {
            // split str to parts
            // loop each part
            //     if part is number
            //          push to stack
            //     if part is operator
            //          pop two times =-> second, first operand
            //          calculate(operator, first, second) => result
            //          push result to stack
            // return result;

            string result = string.Empty;
            Stack<string> RPNstack = new Stack<string>();
            string[] parts = str.Split(' ');

            for(int i = 0;i < parts.Length;i++)
            {
                if(isNumber(parts[i]))
                {
                    RPNstack.Push(parts[i]);
                }
                if(isOperator(parts[i]))
                {
                    string second = RPNstack.Pop();
                    string first = RPNstack.Pop();

                    result = calculate(parts[i], first, second);

                    RPNstack.Push(result);
                }

            }


            return result;
        }
    }
}
