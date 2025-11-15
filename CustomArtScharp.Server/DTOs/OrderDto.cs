namespace CustomArtScharp.Server.DTOs
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
    }
}