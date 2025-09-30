using CustomArtScharp.Server.Models;
using CustomArtScharp.Server.DTOs;

namespace CustomArtScharp.Server.Factories
{
    public static class ArteFactory
    {
        public static ArteDto ToDto(Arte arte) => new ArteDto
        {
            Id = arte.Id,
            Titulo = arte.Titulo,
            Url = arte.Url,
            Proporcao = arte.Proporcao,
            Origem = arte.Origem
        };

        public static Arte ToEntity(ArteDto dto) => new Arte
        {
            Id = dto.Id,
            Titulo = dto.Titulo,
            Url = dto.Url,
            Proporcao = dto.Proporcao,
            Origem = dto.Origem
        };
    }
}