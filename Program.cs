﻿using DesafioPOO.Models;

public class Program
{
    public static void Main(string[] args)
    {

        Nokia nokia = new Nokia();

        Console.WriteLine("Smartphone Nokia");
        nokia.GetModelo();
        nokia.GetNumero();
        nokia.GetIMEI();
        nokia.GetMemoria();

        nokia.InstalarAplicativo(nokia.nomeApp);

        nokia.ExibirDados();

        nokia.Ligar();
        nokia.ReceberLigacao();

        Iphone iphone = new Iphone();

        Console.WriteLine("Smartphone Iphone");

        iphone.GetModelo();
        iphone.GetNumero();
        iphone.GetIMEI();
        iphone.GetMemoria();

        iphone.InstalarAplicativo(iphone.nomeApp);

        iphone.Ligar();
        iphone.ReceberLigacao();

    }
}

