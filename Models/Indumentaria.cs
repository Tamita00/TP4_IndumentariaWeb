public class Indumentaria{
    public string medias {get; private set;}
    public string pantalon {get; private set;}
    public string camiseta {get; private set;}
    
    public Indumentaria (string mediasReci, string pantalonResi, string camisetaResi)
    {
        medias = mediasReci;
        pantalon = pantalonResi;
        camiseta = camisetaResi;
    }
}