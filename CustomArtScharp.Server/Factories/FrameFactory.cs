using CustomArtScharp.Server.DTOs;
using CustomArtScharp.Server.Entities;

namespace CustomArtScharp.Server.Factories;

public static class QuadroFactory
{
    public static QuadroDto ToDto(Quadro quadro) => new QuadroDto
    {
        Id = quadro.Id,
        ArteId = quadro.ArteId,
        CorMoldura = quadro.CorMoldura,
        EspessuraMoldura = quadro.EspessuraMoldura,
        ProfundidadeMoldura = quadro.ProfundidadeMoldura,
        PassePartoutAtivo = quadro.PassePartoutAtivo,
        LarguraPassePartout = quadro.LarguraPassePartout,
        CorPassePartout = quadro.CorPassePartout,
        Largura = quadro.Largura,
        Altura = quadro.Altura,
        Material = quadro.Material,
        Vidro = quadro.Vidro,
        Preco = quadro.Preco
    };

    public static Quadro ToEntity(QuadroDto dto) => new Quadro
    {
        Id = dto.Id,
        ArteId = dto.ArteId,
        CorMoldura = dto.CorMoldura,
        EspessuraMoldura = dto.EspessuraMoldura,
        ProfundidadeMoldura = dto.ProfundidadeMoldura,
        PassePartoutAtivo = dto.PassePartoutAtivo,
        LarguraPassePartout = dto.LarguraPassePartout,
        CorPassePartout = dto.CorPassePartout,
        Largura = dto.Largura,
        Altura = dto.Altura,
        Material = dto.Material,
        Vidro = dto.Vidro,
        Preco = dto.Preco
    };
}