var listaSinRealizar = new List<Tarea>();
var listaRealizada = new List<Tarea>();
int cantTareas = new Random().Next(2,5);
Tarea tarea;

for (int i = 0; i < cantTareas; i++)
{
    tarea = new Tarea();
    tarea.tareaID=i+1;
    Console.WriteLine("Ingrese la descripcion de la tarea: ");
    tarea.descripcion=Console.ReadLine();
    Console.WriteLine("\nIngrese la duracion en horas: ");
    tarea.duracion=Convert.ToInt32(Console.ReadLine());
    listaSinRealizar.Add(tarea);
}

int scape=0;

do
{
    foreach (var Tarea in listaSinRealizar)
    {
    Console.WriteLine("-----------------------\n");
    Console.WriteLine($"Tarea Numero: {Tarea.tareaID}");
    Console.WriteLine($"Duracion: {Tarea.duracion} hs");
    Console.WriteLine($"{Tarea.descripcion}");
    Console.WriteLine("-----------------------\n");
    }
    Console.WriteLine("Indique la tarea realizada");
    int indice=Convert.ToInt32(Console.ReadLine())-1;
    listaRealizada.Add(listaSinRealizar[indice]);
    listaSinRealizar.RemoveAt(indice);
    Console.WriteLine("Quiere realizar otra tarea? Si[1], No[0]");
    scape=Convert.ToInt32(Console.ReadLine());

    
} while (scape>0);

string? palabraClave;

Console.WriteLine("-------Buscar tarea por descripcion-------\n");
Console.WriteLine("Ingrese la palabra a buscar: ");
palabraClave=Console.ReadLine();

foreach (var Tarea in listaSinRealizar)
{
    if (Tarea.descripcion.Contains(palabraClave))
    {
        Console.WriteLine($"Tarea Numero: {Tarea.tareaID}\n");
        Console.WriteLine($"Duracion:{Tarea.duracion}\n");
        Console.WriteLine($"{Tarea.descripcion}\n");
    }
}

int horasTrabajadas=0;

foreach (var Tarea in listaRealizada)
{
    horasTrabajadas += Tarea.duracion;
}

Console.WriteLine($"Horas trabajadas por el empleado: {horasTrabajadas}");

