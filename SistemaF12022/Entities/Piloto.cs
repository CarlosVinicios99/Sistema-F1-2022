namespace SistemaF12022.Entities
{
    class Piloto
    {
        public string Nome {get; set;}
        public int Numero {get; set;}
        public int Pontos {get; private set;}
        public int Vitorias {get; private set;}
        public int Podios {get; private set;}
        public Equipe Equipe {get; set;}
    }
}