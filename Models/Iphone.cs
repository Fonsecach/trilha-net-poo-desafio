namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone()
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            string confirmacao = "";
            Console.WriteLine("-=Bem vindos a Apple Store=-\n\n");
            do
            {
                Console.WriteLine("Insira o nome do aplicativo: ");
                nomeApp = Console.ReadLine();
                Console.WriteLine("Confirma a instalação? (Y/N): ");
                confirmacao = Console.ReadLine().ToUpper();

                if (confirmacao == "Y")
                {
                    Console.WriteLine("-= Instalando o aplicativo =-");
                    Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");

                }
                else
                {
                    Console.WriteLine("Operação cancelada!");
                }

                confirmacao = "N";
                Console.WriteLine("Deseja inserir outro aplicativo? (Y/N)");
                confirmacao = Console.ReadLine().ToUpper();

                if (confirmacao == "N")
                {
                    Console.WriteLine("Central de aplicativos encerrada.\n");
                }
            } while (confirmacao == "Y");
        }

    }
}