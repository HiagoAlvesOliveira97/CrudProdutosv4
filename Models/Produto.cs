﻿namespace CrudProdutosv4.Models
{
    public class Produto
    {
       public int Id { get; set; }

        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

        public decimal Preco { get; set; }
    }
}
