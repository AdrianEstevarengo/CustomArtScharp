namespace CustomArtScharp.Server.Entities;

public class Pedido
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime DataCriacao { get; set; }
    public string Status { get; set; }
    public decimal Total { get; set; }
    public List<Quadro> Quadros { get; set; }
}