//using System;
//using System.Security.Cryptography;

//class Calcomania
//{
//    static void Main()
//    {
//        int amarilla = 0;
//        int rosa = 0;
//        int roja = 0;
//        int verde = 0;
//        int azul = 0;
//        Console.WriteLine("Cantidad de autos que entrar a la ciudad de México: ");
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= n; i++)
//        {
//            Console.WriteLine("Ingrese la placa de su automovil N°" + i + ": ");
//            String placa = (Console.ReadLine());
//            char UltmDigito = placa[placa.Length - 1];
//            int Ultimo = int.Parse(UltmDigito.ToString());

//            switch (Ultimo)
//            {
//                case 1:
//                case 2:
//                    amarilla++;
//                    break;
//                case 3:
//                case 4:
//                    rosa++;
//                    break;
//                case 5:
//                case 6:
//                    roja++;
//                    break;
//                case 7:
//                case 8:
//                    verde++;
//                    break;
//                case 9:
//                case 0:
//                    azul++;
//                    break;
//                default:
//                    Console.WriteLine("Esta opción no existe");
//                    break;
//            }
//        }
//        Console.WriteLine("Cantidad de autos con calcomanía amarilla: " + amarilla);
//        Console.WriteLine("Cantidad de autos con calcomanía rosa: " + rosa);
//        Console.WriteLine("Cantidad de autos con calcomanía roja: " + roja);
//        Console.WriteLine("Cantidad de autos con calcomanía verde: " + verde);
//        Console.WriteLine("Cantidad de autos con calcomanía azul: " + azul);
//    }
//}
///*
// * Punto N°6
// * El Departamento de Seguridad Publica y Transito del D.F. desea saber, de los n autos que entran
//a la ciudad de México, cuantos entran con calcomanía de cada color. Conociendo el ultimo dígito de
//la placa de cada automóvil se puede determinar el color de la calcomanía utilizando la siguiente
//relación:
//Dígito Color
//1 o 2 amarilla
//3 o 4 rosa
//5 o 6 roja
//7 o 8 verde
//9 o 0 azul
// */