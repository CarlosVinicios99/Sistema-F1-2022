namespace SistemaF12022.Entities
{
    class CorridaSprint : Corrida
    {

        public CorridaSprint()
        {

        }

        public CorridaSprint(string local)
        : base(local)
        {

        }
        
        public override void DistribuirPontos()
        {
            throw new System.NotImplementedException();
            //distribuir pontos para os 3 primeiros
        }
    }
}