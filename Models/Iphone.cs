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
                    Console.WriteLine($"\n-= Instalando {nomeApp} =-");
                    Console.WriteLine($"\nAplicativo {nomeApp} instalado com sucesso!");

                }
                else
                {
                    Console.WriteLine("Operação cancelada!");
                }

                confirmacao = "N";
                Console.WriteLine("\nDeseja inserir outro aplicativo? (Y/N)");
                confirmacao = Console.ReadLine().ToUpper();

                if (confirmacao == "N")
                {
                    Console.WriteLine("Central de aplicativos encerrada.\n");
                }
            } while (confirmacao == "Y");
        }

        public string GetNumero()
        {
            Console.WriteLine("Insira o número do celular: ");
            return Numero = Console.ReadLine();
        }

        public string GetModelo()
        {
            Console.WriteLine("Insira do modelo: ");
            return Modelo = Console.ReadLine();
        }

        public string GetIMEI()
        {
            Console.WriteLine("Insira o número do IMEI: ");
            return IMEI = Console.ReadLine();
        }

        public int GetMemoria()
        {
            Console.WriteLine("Insira a memoria em GB: ");
            return Memoria = int.Parse(Console.ReadLine());
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria} Gbs");
        }

    }
}