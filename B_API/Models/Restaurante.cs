namespace B_API.Controllers.Models
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Preco { get; set; }
        public int Categoria { get; set; }
        public string Especialidade { get; set; }
        public string Status { get; set; }
    }
}