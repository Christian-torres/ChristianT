using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            string Nombre, Apellido, Rut, Mes;
            string Ssalud;
            int Año, ValorHora, Cantidadhorassemana, Cantidadhorasfindesemana, Bonos, Anticipos, Descuentos;

            Console.Write(" 1 - Ingrese Nombre del Trabajador    :");
            Nombre = Console.ReadLine();
            Console.Write(" 2 - Ingrese Apellido del Trabajador  :");
            Apellido = Console.ReadLine();
            Console.Write(" 3 - Ingrese rut del Trabajador       :");
            Rut = Console.ReadLine();  
            Console.Write(" 4 - Mes de la Liquidacion            :");
            Mes = Console.ReadLine();
            Console.Write(" 5 - Año                              :");
            Año = Convert.ToInt16(Console.ReadLine());
            Console.Write(" 6 - Ingrese Valor Hora               :");
            ValorHora = Convert.ToInt16(Console.ReadLine());
            Console.Write(" 7 - Horas Trabajadas en la Semana    :");
            Cantidadhorassemana = Convert.ToInt16(Console.ReadLine());
            Console.Write(" 8 - Horas Trabajadas Fin de semana   :");
            Cantidadhorasfindesemana = Convert.ToInt16(Console.ReadLine());
            Console.Write(" 9 - Bonos Obtenidos en el Mes        :");
            Bonos = Convert.ToInt32(Console.ReadLine());
            Console.Write(" 10 - Anticipos Solicitado            :");
            Anticipos = Convert.ToInt32(Console.ReadLine());
            Console.Write(" 11 - Descuento Prestamo Solicitado   :");
            Descuentos = Convert.ToInt32(Console.ReadLine());
            double valortotalhabil = Cantidadhorassemana * ValorHora;
            double ValorTotalfin = (Cantidadhorasfindesemana * 1.5) * ValorHora;
            double SueldoImponible = valortotalhabil + ValorTotalfin;
            Console.WriteLine(" - Total sueldo en horas habiles          : " + "$" + valortotalhabil);
            Console.WriteLine(" - Horas extras fin de semana             : " + "$" + ValorTotalfin);
            Console.WriteLine(" - Bonos Otrorgados                       : " + "$" + Bonos);
            Console.WriteLine(" - Sueldo Imponible                       : " + "$" + (SueldoImponible - Descuentos - Anticipos + Bonos) );
            Console.WriteLine("Seleccione su sistema de salud: \n 1 Fonasa \n 2 Isapre ");
            Ssalud = Console.ReadLine();
            if (Ssalud == "1")
            {
                Ssalud = "Fonasa";
                double descfon = (SueldoImponible - Anticipos - Descuentos + Bonos) - ((SueldoImponible - Anticipos - Descuentos + Bonos) * 7 / 100);
                SueldoImponible = (SueldoImponible - Anticipos - Descuentos + Bonos) - ((SueldoImponible - Anticipos - Descuentos + Bonos) * 7 / 100);

                Console.WriteLine("Sueldo Imponible menos sistema de salud: " + descfon);
            }
            else if (Ssalud == "2")
            {
                Ssalud = "Isapre";
                Console.WriteLine("Seleccione su Isapre: \n 1 Banmedica \n 2 GoldenCross \n 3 MasVida ");
                string isap = Console.ReadLine();
                if (isap == "1")
                {
                    SueldoImponible = (SueldoImponible - Anticipos - Descuentos + Bonos) - ((SueldoImponible - Anticipos - Descuentos + Bonos) * 10 / 100);
                    Console.WriteLine("Sueldo liquido es: $" + (SueldoImponible));
                    Console.ReadLine();
                }
                else if (isap == "2")
                {
                    SueldoImponible = (SueldoImponible - Anticipos - Descuentos + Bonos) - ((SueldoImponible - Anticipos - Descuentos + Bonos) * 11 / 100);
                    Console.WriteLine("Sueldo liquido es: $" + (SueldoImponible));
                    Console.ReadLine();

                }
                else if (isap == "3")
                {
                    SueldoImponible = (SueldoImponible - Anticipos - Descuentos + Bonos) - ((SueldoImponible - Anticipos - Descuentos + Bonos) * 12 / 100);
                    Console.WriteLine("Sueldo liquido del Trabajador es: $" + (SueldoImponible));
                    Console.ReadLine();

                }


            }
            else if (Ssalud != "1" || Ssalud != "2")
            {
                Ssalud = "no ingreso numero o no es correcto";
            }

            Console.WriteLine("Seleccione AFP:\n 1 Capital \n 2 Habitat \n 3 Cuprum \n 4 PlanVital \n 5 Provida \n 6 Modelo");
            string AFP = Console.ReadLine();
            if (AFP == "1")
            {
                Console.WriteLine("Sueldo liquido del Trabajador es: $" + (SueldoImponible - (SueldoImponible * (11.44 / 100))));
            }
            else if (AFP == "2")
            {
                Console.WriteLine("Sueldo liquido del Trabajador es: $" + (SueldoImponible - (SueldoImponible * (11.27 / 100))));
            }
            else if (AFP == "3")
            {
                Console.WriteLine("Sueldo liquido del Trabajador es: $" + (SueldoImponible - (SueldoImponible * (11.48 / 100))));
            }
            else if (AFP == "4")
            {
                Console.WriteLine("Sueldo liquido del Trabajador es: $" + (SueldoImponible - (SueldoImponible * (10.47 / 100))));
            }
            else if (AFP == "5")
            {
                Console.WriteLine("Sueldo liquido del Trabajador es: $" + (SueldoImponible - (SueldoImponible * (11.54 / 100))));
            }
            else if (AFP == "6")
            {
                Console.WriteLine("Sueldo liquido del Trabajador es: $" + (SueldoImponible - (SueldoImponible * (10.77 / 100))));
            }

            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
      
    }

}

