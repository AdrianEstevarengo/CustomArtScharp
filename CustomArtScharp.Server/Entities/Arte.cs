namespace CustomArtScharp.Server.Entities;

public class Arte
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Url { get; set; }
    public string Proporcao { get; set; }
    public string Origem { get; set; } // 'upload' ou 'biblioteca'
    public int? UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
}