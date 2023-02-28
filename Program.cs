using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnMayor_Menor
{
    /// <summary>
    /// 22/02/2023
    /// Jaider Andres Oquendo Zapata
    /// Programa que permite ingresar tres valores por teclado. Luego muestra el mayor y el menor de estos.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa para mostrar el mayor y el menor de tres valores ingresados");
            //se instancia la clase y se invocan los metodos
            Program calcular = new Program();
            calcular.Ingresar_calcular_Valores();
            Console.ReadKey();

        }
        //Metodos
        #region
        //Metodo que permite ingresar los tres valores por teclado, y luego mostrar el mayor y el menor de estos.
        public void Ingresar_calcular_Valores()
        {
            Console.WriteLine("Por favor ingrese el primer valor: ");
            double Valor1 =Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("Por favor ingrese el segundo valor: ");
            double Valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el tercer valor: ");
            double Valor3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segun los tres valores ingresados:");
            Console.WriteLine("El mayor de los valores ingresados es: " + ValorMayor( Valor1,  Valor2,  Valor3) );
            Console.WriteLine("El menor de los valores ingresados es: " + ValorMenor( Valor1, Valor2, Valor3) );

        }
        //Metodo con estructura de desicion logica para seleccionar y devolver el valor mayor de los tres valores ingresados.
        public double ValorMayor(double Valor1, double Valor2, double Valor3 )
        {
            double Mayor;
            if (Valor1>Valor2&&Valor1>Valor3)
            {
                Mayor = Valor1;
            }
            else
            {
                if (Valor2>Valor1&&Valor2>Valor3)
                {
                    Mayor = Valor2;
                }
                else
                {
                    Mayor = Valor3;
                }
            }
            return Mayor;
        }
        //Metodo con estructura de desicion logica para seleccionar y devolver el valor menor de los tres valores ingresados.
        public double ValorMenor(double Valor1, double Valor2, double Valor3)
        {
            double Menor;
            if (Valor1 < Valor2 && Valor1 < Valor3)
            {
                Menor = Valor1;
            }
            else
            {
                if (Valor2 < Valor1 && Valor2 < Valor3)
                {
                    Menor = Valor2;
                }
                else
                {
                    Menor = Valor3;
                }
            }
            return Menor;
        }
        #endregion
    }
}
