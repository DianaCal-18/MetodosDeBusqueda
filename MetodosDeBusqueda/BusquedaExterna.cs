namespace MetodosDeBusqueda
{
    /// <summary> PARTE 3
    /// Clase <see cref="BusquedaExterna"/>
    /// Contiene un ejercicio que simula una busqueda externa sobre un arreglo de datos masivo
    /// </summary>
    public class BusquedaExterna
    {
        /// <summary> PARTE 3
        /// Mtodo <see cref="BuscarClientePorCedula"/>
        /// Tarea: Simular búsqueda externa con un arreglo largo (1000+ cédulas).
        /// Buscar la cédula ingresada por el usuario.
        /// </summary>
        public static void BuscarClientePorCedula()
        {
            //Arreglo largo 
            string[] cedulas = new string[1001];
            Random random = new Random();

            // Para llenar el arreglo de cedulas utilizando random (es decir, que sean aleatorias)
            for (int i = 0; i < cedulas.Length; i++)
            {
                // tomando como referencia (100000000, 999999999) buscara cedulas de nueve digitos
                cedulas[i] = random.Next(100000000, 999999999).ToString();
            }

            // para tener de referencia
            string cedula = cedulas[889];
            Console.WriteLine($"cedula para prueba:{cedula}");

            Console.WriteLine("Ejercicio 1: Verificar existencia de un cliente");
            Console.Write("Ingrese el numero de cedula a buscar: ");
            string cedulaBuscada = Console.ReadLine();

            
            bool encontrada = false;

            /// <summary>
            /// Recorremos secuencialmente el arreglo , simula una lectura externa
            /// ya que el arreglo es muy largo y no necesariamente este ordenado
            /// </summary>
            for (int i = 0; i < cedulas.Length; i++)
            {
                if (cedulas[i] == cedulaBuscada)
                {
                    Console.WriteLine($"\nLa cedula {cedulaBuscada} fue encontrada. ");
                    encontrada = true;
                    break;
                }
            }

            if (!encontrada)
            {
                Console.WriteLine($"\nLa cedula {cedulaBuscada} no se encuentra registrada.");
            }
        }
    }
}
