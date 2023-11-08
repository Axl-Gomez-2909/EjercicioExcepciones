using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Operaciones
    {
        //Metodo Sumar 
        public double Sumar(double a, double b)
        {
            
            return a + b;
        }
        //Metodo Restar
        public double Restar(double a, double b)
        {
            return a - b;
        }
        //Metodo Multiplicar
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        //Metodo Dividir 
        public double Dividir(double a, double b)
        {
            //Validación para no dividir entre cero
            if (b == 0)
            {
                //Asignación a la exepción DivideByZeroException un mensaje por si el usuario ingresa cer0
                throw new DivideByZeroException("No es posible dividir entre cero.");
            }
            return a / b;
        }
    }
}
