namespace CustomArtScharp.Server.Entities;

public class Quadro
{
    public int Id { get; set; }
    public int ArteId { get; set; }
    public Arte Arte { get; set; }
    public string CorMoldura { get; set; }
    public int EspessuraMoldura { get; set; }
    public int ProfundidadeMoldura { get; set; }
    public bool PassePartoutAtivo { get; set; }
    public int LarguraPassePartout { get; set; }
    public string CorPassePartout { get; set; }
    public int Largura { get; set; } // cm
    public int Altura { get; set; } // cm
    public string Material { get; set; }
    public string Vidro { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataCriacao { get; set; }
    public int? PedidoId { get; set; }
    public Pedido? Pedido { get; set; }
}