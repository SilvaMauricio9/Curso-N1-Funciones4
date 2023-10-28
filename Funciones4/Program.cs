using System;

namespace Funciones4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
            // Que analice el número y escriba variable recibida por referencia con:
            // a. 1 si el número es positivo.
            // b.-1 si el número es negativo.
            // c. 0 si el número es cero.
            int numero, estado = 0;
            Console.WriteLine("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());

            positivoNegativoCero(numero, ref estado);

            Console.WriteLine("El valor del numero es: " + numero + " y su estado: " + estado);
        }
        static void positivoNegativoCero(int n, ref int valor){
            if(n > 0)
                valor = 1;
            else if(n < 0)
                valor = -1;
            else
                valor = 0;
        }
    }
}
