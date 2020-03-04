namespace B_API.Controllers.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Sobre { get; set; }
    }
}