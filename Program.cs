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
string carnet = Console.ReadLine().ToUpper();

Console.WriteLine("Tiene autorizacion escrita? (S/N)");
string autorizacion = Console.ReadLine().ToUpper();

Console.WriteLine("Trae USB? (S/N)");
string USB =  Console.ReadLine().ToUpper();

string acompanado = "N";

if (hora < 0 || hora > 23)
{
    Console.WriteLine("ERROR, FUERA DE RANGO");
    return;
}
else if (dia < 1 || dia > 7)
{
    Console.WriteLine("ERROR FUERA DE RANGO");
    return; 
}


if (USB == "S")
{
    Console.WriteLine("Esta acompañado? (S/N)");
    acompanado = Console.ReadLine();
}

string acceso = "Denegado";
string nivel = "Sin permiso";

switch (opcion)
    {

        case 1:
          if (dia >=1 && dia <= 5)
        {
            if (hora >= 7 && hora<= 18)
            {
                if (carnet == "S")
                {
                    acceso = "PERMITIDO";
                    nivel = "Acceso academico";
                }

                else
                {
                    nivel = "Necesita carnet vigente";

                }
               
            }
            else
            {
                nivel = "Fuera del horario permitido";
            }
        }
        else
        {
            nivel = "El estudiante entra de lunes a viernes";
        }

            break;


        case 2:
         if (carnet == "S")
        {
            acceso = "PERMITIDO";
            nivel = "Acceso Docente";
        }
        else
        {
            nivel = "Necesita carnet!";
        }



            break;

        case 3:
          if (hora < 7 || hora > 18)
        {
            if (autorizacion == "S")
            {
                acceso = "PERMITIDO";
                nivel = "Mantemiento autorizado";
            }
            else 
            {
                acceso = "Denegado";
                nivel = "Necesita autorizacion fuera de horario";
            }

        }
        else
        {
            acceso = "Permitido";
            nivel = "Solo soporte tecnico en horario laboral!";
        }


            break;

        case 4:
        if (autorizacion == "S")
        {
            if (acompanado == "S")
            {
                acceso = "Permitido";
                nivel = "Visitante controlado";
            }
            else
            {
                nivel = "Visitante sin control";
            }

        }

            break;
        default:
        Console.WriteLine("OPCION INVALIDA!!");

        break;

   

    }

if (USB == "S")
{
    if (!(autorizacion == "S" && acompanado == "S"))
    {
        acceso = "Denegado";
        nivel = "USB no autorizado";
    }
}
