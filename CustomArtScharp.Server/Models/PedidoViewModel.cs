namespace CustomArtScharp.Server.Models;

public class PedidoViewModel
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public string NomeUsuario { get; set; }
    public DateTime DataCriacao { get; set; }
    public string Status { get; set; }
    public decimal Total { get; set; }
    public List<QuadroViewModel> Quadros { get; set; }
}
