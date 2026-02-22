// 2) Control de acceso a laboratorio universitario
Console.WriteLine("MENU");
Console.WriteLine("Presione 1 si es Estudiante");
Console.WriteLine("Presione 2 si es Docente");
Console.WriteLine("Presione 3 si es Tecnico");
Console.WriteLine("Presione 4 si es Visitante");

int opcion = int.Parse(Console.ReadLine());


Console.WriteLine("Ingrese su hora (0-23)");
int hora = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese sus dias (1-7)");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine("Tiene carnet vigente? (S/N)");
string carnet = Console.ReadLine();

Console.WriteLine("Tiene autorizacion escrita? (S/N)");
string autorizacion = Console.ReadLine();

Console.WriteLine("Trae USB? (S/N)");
string USB = Console.ReadLine();

