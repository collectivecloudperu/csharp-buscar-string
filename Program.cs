using System;

namespace buscarTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string texto = "Crack de la Programación !";
            string textoabuscar = "Zapato"; 

            if(texto.Contains(textoabuscar)){
                Console.WriteLine("Si existe");
            }
            else {
                Console.WriteLine("No existe");
            }

        }
    }
}