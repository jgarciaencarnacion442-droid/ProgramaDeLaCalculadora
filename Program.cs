using System.Collections;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

//Variables:
int numberSelect = 0;
int answer = 0;
decimal[] numbers= new decimal[2];
int index = 2;
int option = 0;
int quest = 0;
int TheSelect = 0;
decimal note = 0;
bool ERROR = false;

do
{
    do
    {
        Console.WriteLine("Desea realizar alguna operacion?");
        Console.WriteLine("1.Si");
        Console.WriteLine("2.No");

        ERROR = false;
        try
        {
            do
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option < 0 || option > 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("--ERROR---");
                    Console.WriteLine(" POR FAVOR. Digite un numero compatible con las opciones. ");
                    Console.WriteLine();
                }
                else if(option == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ok, Adios.");
                    return;
                }
            } while (option < 0 || option > 2);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("-- Elige un numero que este entre las opciones asignadas --");

            ERROR = true;
        }
    } while (ERROR == true);

    Console.WriteLine("---Saludos usuario---");
Console.WriteLine("Aqui se encuentran las operacion que desea realizar");
Console.WriteLine("1.Calcular promedio");
Console.WriteLine("2.Calculos basicos");
do
{
    ERROR = false;
    try
    {
        do
        {
            Console.WriteLine("Digite el numero de la opcion que desea:");
            TheSelect = Convert.ToInt32(Console.ReadLine());
            if (TheSelect < 0 || TheSelect > 2)
            {
                Console.WriteLine();
                Console.WriteLine("--ERROR---");
                Console.WriteLine(" POR FAVOR. Digite un numero compatible con las opciones. ");
                Console.WriteLine();
            }
        } while (TheSelect < 0 || TheSelect > 2);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.WriteLine("-- Elige un numero que este entre las opciones asignadas --");

            ERROR = true;
    }
} while (ERROR == true);
//Opciones de la calculadora
if (TheSelect == 2)
{
    Console.WriteLine("---Esta es la calculadora basica---");
    Console.WriteLine("Seleccione el numero de la opcion que desea");
    Console.WriteLine("1.Suma");
    Console.WriteLine("2.Resta");
    Console.WriteLine("3.Multiplicacion");
    Console.WriteLine("4.Division");

    //Introduccion de la seleccion por parte del usuario
    do
    {
        ERROR = false;
        try
    {
        do
        {
            Console.WriteLine("Digite el numero de la opcion que desea:");
            numberSelect = Convert.ToInt32(Console.ReadLine());
            if (numberSelect < 0 || numberSelect > 4)
            {
                Console.WriteLine();
                Console.WriteLine("--ERROR---");
                Console.WriteLine(" POR FAVOR. Digite un numero compatible con las opciones. ");
                Console.WriteLine();
            }
        } while (numberSelect < 0 || numberSelect > 4);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.WriteLine("-- Elige un numero que este entre las opciones asignadas --");
            ERROR = true;
        }
    } while (ERROR == true);

    //Seleccion de los numbers del usuario
    do {
        try
    {
        Console.WriteLine("---Ahora elija los numbers que queria para la operacion---");
        Console.WriteLine("--Recuerde que si desea usar decimales necesita usar la coma(,)--");
        Console.WriteLine("-De lo contrario el calculo podria no ser el que desea-");
        Console.WriteLine("Elija el primer numero: ");
        numbers[0] = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Elija el segundo numero: ");
        numbers[1] = Convert.ToDecimal(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.WriteLine("--Por favor, elija un numero valido--"); 
            ERROR = true;
        }
    } while (ERROR == true);

    //Seleccion de numbers adicionales
do 
{
    try
    {
        while (answer != 2)
        {
            Console.WriteLine("---Desea añadir mas numbers?---");
            Console.WriteLine("1.Si");
            Console.WriteLine("2.No");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                var temporalnumber = numbers;
                numbers = new decimal[index + 1];
                for (int i = 0; i < temporalnumber.Length; i++)
                {
                    numbers[i] = temporalnumber[i];
                }
                Console.WriteLine("Elija el nuevo numero: ");
                numbers[index] = Convert.ToDecimal(Console.ReadLine());

                index++;
            }

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.WriteLine("-- Elija un numero valido--");
        ERROR = true;
    }
} while (ERROR == true) ;
//El Switch

decimal Result = 0;
    switch (numberSelect)
    {
        case 1:
            {
                foreach (var number in numbers)
                {
                    Result += number;
                }
                break;
            }
        case 2:
            {
                Result = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    Result -= numbers[i];
                }
                break;
            }
        case 3:
            {
                Result = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    Result *= numbers[i];
                }
                break;
            }
        case 4:
            {
                Result = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        Console.WriteLine("ERROR, NO SE PUEDE DIVIDIR ENTRE 0");
                        Result = 0;
                    }
                    else
                    {
                        Result /= numbers[i];
                    }
                }
                break;
            }

    }
    Console.WriteLine($"El resultado es: {Result}");
}
if (TheSelect == 1)
{
    //Calculo de la nota
    Console.WriteLine("---Este es el Promedio---");
    Console.WriteLine("Cuantas Calificaciones tiene en total la materia?");
    Console.WriteLine("Coloque la cantidad aqui: ");

do 
{
        ERROR = false;
    try
    {
        quest = Convert.ToInt32(Console.ReadLine());
        numbers = new decimal[quest];
        Console.WriteLine("--Recuerde que si desea usar decimales necesita usar la coma(,)--");
        Console.WriteLine("-De lo contrario el calculo podria no ser el que desea-");

        for (int Count = 0; Count < quest; Count++)
        {
            Console.WriteLine($"Digite la calificacion N.{Count + 1}: ");
            numbers[Count] = Convert.ToDecimal(Console.ReadLine());
        }

        Console.WriteLine("Ahora Digame cuanta nota necesita para pasar la materia: ");

        note = Convert.ToDecimal(Console.ReadLine());

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.WriteLine("-- Elija un numero valido--");
            ERROR = true;
    }
} while (ERROR == true);
    //Calcylo del promedio

    decimal SecondCount = 0;
    foreach (decimal number in numbers)
    {
        SecondCount += number;
    }
    decimal Result = SecondCount / quest;


    //Comprovacion del estado del estudiante
    if (Result >= note)
    {
        Console.WriteLine("El estudiante aprobo");
            Console.WriteLine();
    }
    else
    {
        Console.WriteLine("El estudiante Desaprobo");
            Console.WriteLine();
        }
}


}while(option == 1);
