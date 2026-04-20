namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
           Console.WriteLine("Dados Iphone");
           Console.WriteLine("Número: " + numero);
           Console.WriteLine("Modelo: " + modelo);
           Console.WriteLine("IMEI: " + imei);
           Console.WriteLine("Memória: " + memoria);
           Console.WriteLine("\n");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           
           Console.WriteLine("Instalando "+ nomeApp +" no Iphone");
        }

        public override void Ligar()
        {
            Console.WriteLine("Smatphone Iphone");
            Console.WriteLine("Ligando...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Smatphone Iphone");
            Console.WriteLine("Recebendo ligação...");
        }
    }
}