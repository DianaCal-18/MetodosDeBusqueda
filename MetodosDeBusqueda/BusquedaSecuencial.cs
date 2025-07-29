

namespace MetodosDeBusqueda
{
    /// <summary> PARTE 1
    /// Clase <see cref="BusquedaSecuencial"/> 
    /// Contiene dos ejercicios que aplican metodos de busqueda secuencial
    /// </summary>
    public class BusquedaSecuencial
    {
        /// <summary> PARTE 1
        /// Metodo <see cref="VerificarAsistencia"/> 
        /// Tarea: Dado un arreglo nombres[] y 
        /// un nombreBuscado, usa búsqueda secuencial para determinar si está en la lista
        /// </summary>
        public static void VerificarAsistencia()
        {
            //Arreglo con los nombres de los estudiantes
            string[] nombres = { "Diana", "Delio", "Dayner", "Francis" };

            // Nombre que se desea buscar
            string nombreBuscado = "Francis";

            // booleano como indicador de que es verdadero o falso
            bool encontrado = false;



            for (int i = 0; i < nombres.Length; i++)
            {
                /// <summary> Recorremos el arreglo elemento por elemento (ignorando minusculas y mayusculas)
                /// Porque <see Method=".ToLower"/> 
                /// lo que hace es convertir toda la cadena de texto en minusculas
                /// </summary> 

                if (nombres[i].ToLower() == nombreBuscado.ToLower())
                {
                    // mostramos el nombre y su posicion
                    Console.WriteLine("Ejercicio 1: Verificar asistencia en lista");
                    Console.WriteLine($"{nombreBuscado} esta en la lista.\n");
                    encontrado = true;
                    break;
                }
            }
        }

        /// <summary> PARTE 1
        /// Metodo <see cref="ProductosAgotados"/> 
        /// Tarea: Dado un arreglo de cadenas agotados[], 
        /// busca un producto ingresado por el usuario y devuelve su posición (o mensaje).
        /// </summary>
        public static void ProductosAgotados()
        {
            string[] agotados = { "Producto 1", "Producto 2", "Producto 3", "Proudcto 4" };
            string producto = "Producto 3";
            bool agotado = false;

            for (int i = 0; i < agotados.Length; i++)
            {
                /// <summary> Otra manera que hace la misma funcion del ToLower o ToUpper
                /// Metodo <see cref="Equals(object?)"/>  Compara el contenido de las dos cadenas
                /// StringComparison = compara los caracteres basandose en sus valores numericos 
                /// OrdinalIgnoreCase: ignora si hay letras mayusculas o minusculas
                /// </summary> esta tiene mas precision que el toLower o Upper si dentro de los nombres hay carateres especiales
                if (agotados[i].Equals(producto, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Ejercicio 2: Revisar si un producto esta agotado");
                    Console.WriteLine($"{producto} esta agotado. Posicion: {i}");
                    agotado = true;
                    break;
                }
            }

            if (!agotado)
                Console.WriteLine($"{producto} no esta agotado.");
        }
        }
    }
