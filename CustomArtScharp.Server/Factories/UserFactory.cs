using CustomArtScharp.Server.DTOs;
using CustomArtScharp.Server.Entities;

namespace CustomArtScharp.Server.Factories;

public static class UsuarioFactory
{
    public static UsuarioDto ToDto(Usuario usuario) => new UsuarioDto
    {
        Id = usuario.Id,
        Nome = usuario.Nome,
        Email = usuario.Email
    };
}