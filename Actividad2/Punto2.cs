//using System;

//namespace Actividad2
//{
//    class PromedioPeso
//    {
//        static void Main()
//        {
//            int totNinos = 0;
//            int totJovenes = 0;
//            int totAdultos = 0;
//            int totViejos = 0;
//            double promNiños = 0;
//            double promJovenes = 0;
//            double promAdultos = 0;
//            double promViejos = 0;
//            int cantNin = 0;
//            int cantJov = 0;
//            int cantAdul = 0;
//            int cantViejos = 0;

//            for (int i = 1;i < 50; i++)
//            {
//                Console.WriteLine("Ingrese su edad: ");
//                int edad = int.Parse(Console.ReadLine());
//                Console.WriteLine("Ingrese su peso: ");
//                int peso = int.Parse(Console.ReadLine());

//                if(edad <= 12)
//                {
//                    totNinos += peso ;
//                    cantNin += 1;
//                }
//                else
//                {
//                    if (edad >= 13 && edad <= 29)
//                    {
//                        totJovenes += peso;
//                        cantJov += 1;
//                    }
//                    else
//                    {
//                        if (edad >= 30 && edad <= 59)
//                        {
//                            totAdultos += peso;
//                            cantAdul += 1;
//                        }
//                        else
//                        {
//                            totViejos += peso;
//                            cantViejos += 1;
//                        }
//                    }
//                }
//            }

//            promNiños = totNinos / cantNin;
//            promJovenes = totJovenes / cantJov;
//            promAdultos = totAdultos / cantAdul;
//            promViejos = totViejos / cantViejos;

//            Console.WriteLine("Promedio de peso de niños: " + promNiños);
//            Console.WriteLine("Promedio de peso de jovenes: " + promJovenes);
//            Console.WriteLine("Promedio de peso de Adultos: " + promAdultos);
//            Console.WriteLine("Promedio de peso de Viejos: " + promViejos);
//        }
//    }
//}
///*
// * Punto N°2
// * Una persona debe realizar un muestreo con 50 personas para determinar el
//promedio de peso de los niños, jóvenes, adultos y viejos que existen en su
//zona habitacional. Se determinan las categorías con base en la siguiente
//tabla: 
// */