//using System;
//class Punto3
//{
//    static void Main()
//    {
//        int valor = 2500;
//        double pagar = 0;
//        double tot = 0;
//        double descu = 0;
        
//        for(int i = 1; i <= 15; i++)
//        {
//            Console.WriteLine("Ingrese cuantos kilos de naranja desea comprar: ");
//            int comprar = int.Parse(Console.ReadLine());

//            if(comprar > 10)
//            {
//                descu = (valor * comprar) * 0.15;
//                pagar = (valor * comprar) - descu;
//            }
//            else
//            {
//                pagar = valor * comprar;
//            }
//            tot += pagar;
//            Console.WriteLine("Cliente N°"+i+ "\nDebe pagar: "+pagar);
//        }
//        Console.WriteLine("El total de ventas es de: " + tot);
//    }
//}
///*
// * Punto N°3
// * Al cerrar un expendio de naranjas, 15 clientes que aún no han pagado recibirán
//un 15% de descuento si compran más de 10 kilos. Determinar cuánto pagará cada
//cliente y cuanto percibirá la tienda por esas compras. 
// */