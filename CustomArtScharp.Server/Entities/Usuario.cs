
namespace CustomArtScharp.Server.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string SenhaHash { get; set; }
    public DateTime DataCriacao { get; set; }
    public List<Pedido> Pedidos { get; set; }
    public List<Arte> Artes { get; set; }
}