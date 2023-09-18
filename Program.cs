using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dicionario = new Dictionary<string,string>();
            bool salir = false;
             while (!salir) {
                Console.WriteLine("1. Ingrese datos al Diccionario");
                Console.WriteLine("2. Actuaalizar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Ver diccionario");
                Console.WriteLine("5. salir");

                Console.WriteLine("");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese una clave: ");
                        string clave = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre");
                        string valor = Console.ReadLine();
                        dicionario.Add(clave, valor);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la clave a modificar");
                        string claveModificar = Console.ReadLine();
                        if(dicionario.TryGetValue(claveModificar, out string ResultadoClave))
                        {
                            Console.WriteLine(ResultadoClave);

                            // Ahora solo lo actualizo
                            string ciudadC;
                            Console.WriteLine("\nIngresa el nuevo valor : ");
                            ciudadC = Console.ReadLine();
                            dicionario[claveModificar] = ciudadC; // cammbia el valor, NO la clave.
                        }
                        else
                        {
                            Console.WriteLine("La clave no existe");
                        }
                        break;
                    case 3:

                        foreach(var key in dicionario) {
                        Console.WriteLine("La clave es : " + key.Key + "Su valor es: " + key.Value);
                        }
                        Console.WriteLine("Ingrese la clave que desea eliminar: ");
                        string claveEliminar = Console.ReadLine();
                        dicionario.Remove(claveEliminar);
                        break;
                    case 4:
                        foreach(var key in dicionario)
                        {

                            Console.WriteLine("La clave es : " + key.Key + "Su valor es: " + key.Value);
                        }
                        break;
                        case 5:
                        salir = true;
                        break;
                }
            
            }
        
        }
    }
}
