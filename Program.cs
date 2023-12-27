using DesafioPOO.Models;

public class Program {
    public static void Main(string[] args){

        Nokia nokia = new Nokia();
        Iphone iphone = new Iphone();

        nokia.InstalarAplicativo(nokia.nomeApp);

        iphone.InstalarAplicativo(iphone.nomeApp);

    }
}

// TODO: Realizar os testes com as classes Nokia e Iphone