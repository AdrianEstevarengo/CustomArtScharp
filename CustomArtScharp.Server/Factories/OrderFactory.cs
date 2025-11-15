using CustomArtScharp.Server.DTOs;
using CustomArtScharp.Server.Entities;

namespace CustomArtScharp.Server.Factories
{
    public static class PedidoFactory
    {
        public static PedidoDto ToDto(Pedido pedido) => new PedidoDto
        {
            Id = pedido.Id,
            UsuarioId = pedido.UsuarioId,
            DataCriacao = pedido.DataCriacao,
            Status = pedido.Status,
            Total = pedido.Total
        };
    }
}