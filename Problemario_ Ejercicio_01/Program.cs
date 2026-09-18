Console.WriteLine("==============================================");
Console.WriteLine("     POTENCIA DE UN MOTOR DC");
Console.WriteLine("==============================================");
Console.WriteLine("Calcula la Potencia Electrica de un motor de corriente directa");
Console.WriteLine("(P = V * I) y verifique si esta dentro del rango seguro.");
Console.WriteLine();

// Solicitar el voltaje
Console.Write("Ingrese el voltaje del motor (V): ");
double voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente consumida (A): "); // Solicitar la corriente
double corriente = Convert.ToDouble(Console.ReadLine());

// Calcular la potencia
double potencia = voltaje * corriente;

// Mostrar la potencia calculada
Console.WriteLine();
Console.WriteLine("Potencia eléctrica: " + potencia + " W");

// Clasificar el consumo
if (potencia <= 120)
{
    Console.WriteLine("CONSUMO NORMAL.");  // Mostrar mensaje si la potencia es menor o igual a 120 W
}
else
{
    Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO."); // Mostrar advertencia si la potencia es mayor a 120 W
}