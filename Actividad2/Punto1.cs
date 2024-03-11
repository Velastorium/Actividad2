//using System;
//class VotosCandidatos
//{
//    static void Main()
//    {
//        int voto1 = 0;
//        int voto2 = 0;
//        int voto3 = 0;

//        int i = 0;

//        while (i < 5)
//        {
//            Console.WriteLine("Por favor ingrese su voto: \n Candidato 1 - 1 \n Candidato 2 - 2 \n Candidato 3 - 3");
//            int votar = int.Parse(Console.ReadLine());
//            switch (votar)
//            {
//                case 1:
//                    voto1 += 1;
//                    break;

//                case 2:
//                    voto2 += 1;
//                    break;

//                case 3:
//                    voto3 += 1;
//                    break;

//                default:
//                    Console.WriteLine("Este voto no existe");
//                    break;
//            }
//            i += 1;
//        }
//        if(voto1 > voto2 && voto1 > voto3)
//        {
//            Console.WriteLine("El candidato ganador es 1 con: "+voto1);
//        }
//        else
//        {
//            if (voto2 > voto1 && voto2 > voto3)
//            {
//                Console.WriteLine("El candidato ganador es 2 con: " + voto2);
//            }
//            else
//            {
//                if (voto3 > voto1 && voto3 > voto2)
//                {
//                    Console.WriteLine("El candidato ganador es 3 con: " + voto3);
//                }
//                else
//                {
//                    if (voto1 == voto2 || voto1 == voto3 || voto2 == voto3)
//                    {
//                        Console.WriteLine("Hay un empate");
//                    }
//                }
//            }
//        }
//    }
//}
///* 
// * Punto N°1
// * Leer los 100 votos otorgados a los 3 candidatos a gobernador e imprimir el
//número del candidato ganador y su cantidad de votos, junto con su
//porcentaje, porcentaje de votos del candidato 1, porcentaje de votos del
//candidato 2, porcentaje de votos del candidato 3.*/