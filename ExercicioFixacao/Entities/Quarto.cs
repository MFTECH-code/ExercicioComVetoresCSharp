namespace ExercicioFixacao.Entities
{
    public class Quarto
    {
        public Residente Residente { get; set; }
        public int Numero { get; set; }

        public Quarto()
        {
            
        }
        public Quarto(Residente residente, int numero)
        {
            Residente = residente;
            Numero = numero;
        }

        public override string ToString()
        {
            return Residente
                + "Quarto: " + Numero;
        }
    }
}