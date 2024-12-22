int option = 0;
List<double> listaItems = new List<double>();

do
{
    Console.WriteLine("Menu calculadora "+ (listaItems.Count > 0 ? string.Join(", ", listaItems) : "") +"\n");
    Console.WriteLine("1.- Asignar un numero");
    Console.WriteLine("2.- Sumar");
    Console.WriteLine("3.- Restar");
    Console.WriteLine("4.- Multiplicacion");
    Console.WriteLine("5.- Dividir");
    Console.WriteLine("6.- Eliminar numero");
    Console.WriteLine("7.- Salir");

    if (int.TryParse(Console.ReadLine(), out option))
    {
        switch (option)
        {
            case 1:
                asignarVariables();
                Console.Clear();
                break;
            case 2:
                sumarValores();
                break;
            case 3:
                restaValores();
                break;
            case 4:
                multiplicarValores();
                break;
            case 5:
                dividirValores();
                break;
            case 6:
                eliminarNum();
                Console.Clear();
                break;
            case 7:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opcion no valida, intenta de nuevo.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada no valida, intenta de nuevo.");
    }
} while (option!=5);

void asignarVariables() {
    Console.WriteLine("Agrega un nuevo numero: ");
    string stringNum = Console.ReadLine();
    double num = double.Parse(stringNum);
    listaItems.Add(num);
}

void eliminarNum()
{   
    Console.WriteLine(string.Join(", ", listaItems) + "\nIngresa el numero a eliminar: ");
    string numEliminar = Console.ReadLine();
    double num = double.Parse(numEliminar);
    listaItems.Remove(num);
    Console.WriteLine("Nuevos valores de la lista: " + string.Join(", ", listaItems));
}

void sumarValores()
{
    double suma = 0;
    foreach (var item in listaItems)
    {
        suma += item;
    }
    Console.WriteLine("La suma de los valores es: " + suma);
}

void multiplicarValores()
{
    double multiplicacion = 1;
    foreach (var item in listaItems)
    {
        multiplicacion *= item;
    }
    Console.WriteLine("La multiplicacion de los valores es: " + multiplicacion);
}

void dividirValores()
{
    double division = 1;
    foreach (var item in listaItems)
    {
        division /= item;
    }
    Console.WriteLine("La division de los valores es: " + division);
}

void restaValores()
{
    double resta = 0;
    var listaOrdenada = listaItems.OrderByDescending(item => item).ToList();
    Console.WriteLine("Lista ordenada: " + string.Join(", ", listaOrdenada));
    foreach (var item in listaOrdenada)
    {
        resta -= item;
    }
    Console.WriteLine("La resta de los valores es: " + resta);
}