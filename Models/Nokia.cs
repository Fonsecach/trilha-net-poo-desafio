namespace DesafioPOO.Models
{

    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(){
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            string confirmacao = "";
            do {
                Console.WriteLine("Insira o nome do aplicativo: ");
                nomeApp = Console.ReadLine();
                Console.WriteLine("Confirma a instalação? (Y/N): ");
                confirmacao = Console.ReadLine().ToUpper();

                if(confirmacao == "Y"){
                    Console.WriteLine("-= Instalando o aplicativo =-");
                    Console.WriteLine("-=-=-=-");
                    Console.WriteLine($"Aplicativo instalado com sucesso!");
                } else {
                    Console.WriteLine("Operação cancelada!");
                }

                confirmacao = "N";
                Console.WriteLine("Deseja inserir outro aplicativo? (Y/N)");
                confirmacao = Console.ReadLine().ToUpper();
            } while (confirmacao == "Y");
        }
    }
}