using System;

class EnvrCarta
{
    static void Main()
    {
        double VlrGm = 10;
        double Corriente = 0;
        double Recomendado = 0;
        double CantCorriente = 0;
        double CantRecomendado = 0;
        double TotalLocales = 0;
        double TotalNacionales = 0;
        double TotalInternacionales = 0;
        String Tipo = "";
        String Destino = "";

        Console.WriteLine("Ingresa la cantidad de envios: ");
        int CntdEnvios = int.Parse(Console.ReadLine());

        for (int i =1; i<=CntdEnvios;i++)
        {
            Console.WriteLine("Ingresa el peso de la carta en gramos: ");
            int CartaGramos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tipo de envio: \nCorriente - 1\nRecomendado - 2");
            int TpEnvio = int.Parse(Console.ReadLine());

            if (TpEnvio==1)
            {
                Tipo = "Corriente";
                Console.WriteLine("Ingresa el destino: \nLocal - 1\nNacional - 2\nInternacional - 3");
                int CorrienteDestino = int.Parse(Console.ReadLine());
                switch (CorrienteDestino)
                {
                    case 1:
                        Corriente = 100;
                        CantCorriente++;
                        TotalLocales += Corriente;
                        Destino = "Local";
                        break;
                    case 2:
                        Corriente = 150;
                        CantCorriente++;
                        TotalNacionales += Corriente;
                        Destino = "Nacional";
                        break;
                    case 3:
                        Corriente = 200;
                        CantCorriente++;
                        TotalInternacionales += Corriente;
                        Destino = "Internacional";
                        break;
                }
            }
            else
            {
                Tipo = "Recomendado";
                if (TpEnvio == 2)
                {
                    Console.WriteLine("Ingresa el destino: \nLocal - 1\nNacional - 2\nInternacional - 3");
                    int RecomendadoDestino = int.Parse(Console.ReadLine());
                    switch (RecomendadoDestino)
                    {
                        case 1:
                            Recomendado = 200;
                            CantRecomendado++;
                            TotalLocales += Recomendado;
                            Destino = "Local";
                            break;
                        case 2:
                            Recomendado = 300;
                            CantRecomendado++;
                            TotalNacionales += Recomendado;
                            Destino = "Nacional";
                            break;
                        case 3:
                            Recomendado = 400;
                            CantRecomendado++;
                            TotalInternacionales += Recomendado;
                            Destino = "Internacional";
                            break;
                        default:
                            Console.WriteLine("Esta opción no existe");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Esta opción no existe");
                }
            }
            double TotGmIva = ((CartaGramos * VlrGm) + Corriente + Recomendado);
            double Desc = TotGmIva * 0.16;
            double TotPagar = TotGmIva + Desc;
            Console.WriteLine("Envio N°"+i+":");
            Console.WriteLine("Tipo de envio: "+Tipo);
            Console.WriteLine("Destino: "+Destino);
            Console.WriteLine("Total a pagar: "+TotPagar);
        }
        Console.WriteLine("\nResumen:");
        Console.WriteLine("Cantidad de envíos corrientes: " + CantCorriente);
        Console.WriteLine("Cantidad de envíos recomendados: " + CantRecomendado);
        Console.WriteLine("Total recaudado por envíos locales: " + TotalLocales);
        Console.WriteLine("Total recaudado por envíos nacionales: " + TotalNacionales);
        Console.WriteLine("Total recaudado por envíos internacionales: " + TotalInternacionales);
    }
}
/*
 * Punto N°10
 * 
 */