namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        //Implementado
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalação aplicativo do {nomeApp} foi concuída " );
        }
    }
}