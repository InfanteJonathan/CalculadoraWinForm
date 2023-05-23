using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public static string CalcularExpresion(string expr) 
        {
            DataTable dt = new DataTable();
            var result = dt.Compute(expr, "");
            return result.ToString();
        }
    }
}
