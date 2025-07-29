using MetodosDeBusqueda;

int opcion;
do
{
    Console.Clear();
    Console.WriteLine("=== MENU Practica Métodos de Búsqueda Aplicados a Problemas Reales ===\n");
    Console.WriteLine("Parte I:  Búsqueda Secuencial.");
    Console.WriteLine("Parte II: Búsqueda Binaria");
    Console.WriteLine("Parte III: Búsqueda Externa (simulada con archivos o listas grandes)");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opcion: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Programa1();
                break;
            case 2:
                Programa2();
                break;
            case 3:
                Programa3();
                break;
            case 0:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opcion no valida. Favor intentarlo nuevamente");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada no valida. Debes ingresar un numero dentro de las opciones.");
    }

    if (opcion != 0)
    {
        Console.WriteLine("\nPresiona una tecla para continuar...");
        Console.ReadKey();
    }

} while (opcion != 0);


static void Programa1()
{
    BusquedaSecuencial.VerificarAsistencia();
    BusquedaSecuencial.ProductosAgotados();
}
static void Programa2()
{
    BusquedaBinaria.BuscarCalificacion();
    BusquedaBinaria.ValidarCodigoDescuento();
}

static void Programa3()
{
    BusquedaExterna.BuscarClientePorCedula();
}