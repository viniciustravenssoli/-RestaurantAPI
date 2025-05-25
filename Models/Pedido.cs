using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteApi.Models
{
    public class Pedido
{
    public int Id { get; set; }
    public int RestauranteId { get; set; }
    public Restaurante? Restaurante { get; set; }

    public List<ItemPedido> Itens { get; set; } = [];

    public double ValorTotal { get; set; } = 0;

    public Avaliacao? Avaliacao { get; set; }

    public void CalcularValorTotal()
    {
        ValorTotal = Itens.Sum(i => i.PrecoUnitario * i.Quantidade);
    }
}
}