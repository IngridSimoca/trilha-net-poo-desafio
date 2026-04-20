using System.Reflection;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine("Dados Nokia");
           Console.WriteLine("Número: " + numero);
           Console.WriteLine("Modelo: " + modelo);
           Console.WriteLine("IMEI: " + imei);
           Console.WriteLine("Memória: " + memoria);
           Console.WriteLine("\n");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando "+ nomeApp +"no Nokia");
        }

        public override void Ligar()
        {
           Console.WriteLine("Smatphone Nokia");
           Console.WriteLine("Ligando...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Smatphone Nokia");
            Console.WriteLine("Recebendo ligação...");
        }
    }
}