namespace B_API.Controllers.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}