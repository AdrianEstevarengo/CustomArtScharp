namespace CustomArtScharp.Server.Models;

public class ArteViewModel
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Url { get; set; }
    public string Proporcao { get; set; }
    public string Origem { get; set; }
    public int? UsuarioId { get; set; }
    public string? NomeUsuario { get; set; }
}