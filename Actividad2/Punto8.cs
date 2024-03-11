//using System;

//class Punto8
//{
//    static void Main() 
//    {
//        double aprobados = 0;
//        double reprobados = 0;
//        int j = 50;
//        for (int i = 1;i<=j;i++)
//        {
//            Console.WriteLine("Ingrese la calificación N°"+i+": ");
//            double notas = double.Parse(Console.ReadLine());

//            if (notas >= 70)
//            {
//                aprobados++;
//            }
//            else
//            {
//                reprobados++;
//            }
//        }
//        double porAprobados = (aprobados / j) * 100;
//        double porReprobados = (reprobados / j) * 100;

//        Console.WriteLine("Procentaje de alumnos aprobados: "+porAprobados);
//        Console.WriteLine("Procentaje de alumnos reaprobados: " + porReprobados);
//    }
//}
///*
// * Punto N°8
// * Leer 50 calificaciones de un grupo de alumnos. Calcule y escriba el porcentaje
//de reprobados. Tomando en cuenta que la calificación mínima aprobatoria es de 70.
// */