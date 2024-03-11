//using System;

//class Zoo
//{
//    static void Main()
//    {
//        int i = 0;
//        String nomAnimal = "";
//        int catA = 0;
//        int catB = 0;
//        int catC = 0;
//        Console.WriteLine("¿Qué animal desea estudiar?\n Elefantes - 1\n Jirafas - 2\n Chimpancés - 3");
//        int animal = int.Parse(Console.ReadLine());
//        switch (animal)
//        {
//            case 1:
//                i = 20;
//                nomAnimal = "Elefante";
//                break;
//            case 2:
//                i = 15;
//                nomAnimal = "Jirafas";
//                break;
//            case 3:
//                i = 40;
//                nomAnimal = "Chimpancé";
//                break;
//            default:
//                Console.WriteLine("Esta opción no existe");
//                break;
//        }
//        for(int j = 1;j <= i; j++)
//        {
//            Console.WriteLine("Ingrese la edad del "+ nomAnimal+ " N°"+j);
//            int edad = int.Parse(Console.ReadLine());
//            if (edad <= 1)
//            {
//                catA += 1;
//            }
//            else
//            {
//                if (edad > 1 && edad < 3)
//                {
//                    catB += 1;
//                }
//                else
//                {
//                    catC += 1;
//                }
//            }
//        }
//        double PorA = ((double)catA / i) * 100;
//        double PorB = ((double)catB / i) * 100;
//        double PorC = ((double)catC / i) * 100;
//        Console.WriteLine("Porcentaje de edades: \n Categoria A: De 0 a 1 año: "+PorA+"\n Categoria B:Más de 1 año y menos de 3: "+PorB+ "\n Categoria C: De 3 o más años: " + PorC);
//    }
//}
///*
// * Punto N°5
// * Un Zoólogo pretende determinar el porcentaje de animales que hay en las
//siguientes tres categorías de edades: de 0 a 1 año, de más de 1 año y menos de 3
//y de 3 o más años. El zoológico todavía no está seguro del animal que va a estudiar.
//Si se decide por elefantes solo tomara una muestra de 20 de ellos; si se decide por
//las jirafas, tomara 15 muestras, y si son chimpancés tomara 40. 
// */