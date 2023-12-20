namespace DesafioPOO.Models
{
    // Implementado! (TODO: Herdar da classe "Smartphone")
    public class Iphone : Smartphone
    {
        // Implementado um construtor da classe filha que envia valores para o construtor da classe pai
        public Iphone(string numero, string modelo, string imei, int memoria) :base(numero,modelo,imei,memoria)
        {
            
        }
        // Implementando! (TODO: Sobrescrever o método "InstalarAplicativo")
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone");
        }
    }
}