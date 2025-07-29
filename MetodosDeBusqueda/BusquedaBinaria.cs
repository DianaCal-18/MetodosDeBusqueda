namespace MetodosDeBusqueda
{
    /// <summary> PARTE 2
    /// Clase <see cref="BusquedaBinaria"/> 
    /// Contiene dos ejercicios que aplican metodos de busqueda binaria
    /// </summary>
    public class BusquedaBinaria
    {
        /// <summary> PARTE 2
        /// Metodo <see cref="BuscarCalificacion"/> 
        /// Tarea: Dado un arreglo notas[] ordenado y una notaBuscada,
        /// aplica búsqueda binaria para determinar si la nota está en el arreglo.
        /// </summary>
        public static void BuscarCalificacion()
        {
            // Arreglo ordenado de calificaciones
            int[] notas = { 73,77,85,86,91,94,97,100 };

            // nota que se desea buscar
            int notaBuscada = 91;

            // indice de inicio y fin para la busqueda binaria (limite inferior y superior)
            int inf = 0;
            int sup = notas.Length - 1;


            bool encontrada = false;

            /// <summary>
            /// busqueda binaria
            /// se compara el centro y se descarta la mitad innecesaria
            /// </summary>
            while (inf <= sup)
            {
                int medio = 0;
                medio= (inf + sup) / 2;

                // Si la nota se encuentra en el centro
                if (notas[medio] == notaBuscada)
                {
                    Console.WriteLine("Ejercicio 1: Buscar calificación específica");
                    Console.WriteLine($"La nota {notaBuscada} fue encontrada.\n");
                    encontrada = true;
                    break;
                }
                // Si la nota buscada es mayor, buscar en el lim superior
                else if (notas[medio] < notaBuscada)
                {
                    inf = medio + 1;
                }
                // Si la nota buscada es menor, buscar en el lim inferior
                else
                {
                    sup = medio - 1;
                }
            }

            if (!encontrada)
            {
                Console.WriteLine($"La nota {notaBuscada} no se encuentra en el arreglo.\n");
            }
        }

        /// <summary> PARTE 2
        /// Metodo <see cref="ValidarCodigoDescuento"/> 
        /// Tarea: Dado un arreglo de códigos numéricos ordenados,
        /// aplicar búsqueda binaria para validar si un código ingresado es válido.
        /// </summary>
        public static void ValidarCodigoDescuento()
        {
            int[] codigos = { 1803, 1805, 1818, 1821, 1828 };

            // codigo a validar
            int codigo = 1821;

            // indice de inicio y fin
            int izquierda = 0;// inf
            int derecha = codigos.Length - 1;// sup

            bool valido = false;

            while (izquierda <= derecha)
            {
                int centro = 0;
                   centro =  (izquierda + derecha) / 2;

                if (codigos[centro] == codigo)
                {
                    Console.WriteLine("Ejercicio 2: Validación de código de descuento");
                    Console.WriteLine($"El codigo {codigo} es valido.\n");
                    valido = true;
                    break;
                }
                else if (codigos[centro] < codigo)
                {
                    izquierda = centro + 1;
                }
                else
                {
                    derecha = centro - 1;
                }
            }

        }
    }
}
