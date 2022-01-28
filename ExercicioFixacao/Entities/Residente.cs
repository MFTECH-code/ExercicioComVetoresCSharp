namespace ExercicioFixacao.Entities
{
    public class Residente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Residente()
        {
            
        }
        public Residente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + "Email: "
                + Email;
        }
    }
}