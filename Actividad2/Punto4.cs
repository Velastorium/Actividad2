//using System;
//class AutoContaminantes
//{
//    static void Main()
//    {
//        double ContContaminantes = 0;
//        int MenosContamina = int.MaxValue;
//        int MasContamina = int.MinValue;

//        for (int i = 1;i<=25;i++)
//        {
//            Console.WriteLine("Ingrese los puntos contaminantes de su automovil: ");
//            int puntos = int.Parse(Console.ReadLine());

//            ContContaminantes += puntos;

//            MenosContamina = Math.Min(MenosContamina, puntos);
//            MasContamina = Math.Max(MasContamina, puntos);
//        }

//        double promContaminantes = ContContaminantes / 25;

//        Console.WriteLine("Promedio de puntos contaminates: "+ promContaminantes);
//        Console.WriteLine("El Carro que menos contamino tiene " + MenosContamina + " puntos");
//        Console.WriteLine("El Carro que más contamino tiene " + MasContamina + " puntos");
//    }
//}
///*
// * Punto N°4
// * En un centro de verificación de automóviles se desea saber el promedio de puntos
//contaminantes de los primeros 25 automóviles que lleguen. Asimismo, se desea
//saber los puntos contaminantes del carro que menos contamino y del que más
//contamino.*/