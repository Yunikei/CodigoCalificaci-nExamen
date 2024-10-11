namespace CodigoCalificaciónExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la calificación:");
            
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calificación aprobatoria.");
            }
            else if (numero >= 50 && numero <= 70)
            {
                Console.ForegroundColor= ConsoleColor.Red;    
                Console.WriteLine("Calificación reprobatoria con derecho a regularizar.");
            }
            else if(numero < 50)
            { 
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Reprobado, debe volver a cursar.");
            }

        }
    }
}
