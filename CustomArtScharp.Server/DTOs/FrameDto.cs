namespace CustomArtScharp.Server.DTOs
{
    public class QuadroDto
    {
        public int Id { get; set; }
        public int ArteId { get; set; }
        public string CorMoldura { get; set; }
        public int EspessuraMoldura { get; set; }
        public int ProfundidadeMoldura { get; set; }
        public bool PassePartoutAtivo { get; set; }
        public int LarguraPassePartout { get; set; }
        public string CorPassePartout { get; set; }
        public int Largura { get; set; }
        public int Altura { get; set; }
        public string Material { get; set; }
        public string Vidro { get; set; }
        public decimal Preco { get; set; }
    }
}