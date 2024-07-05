using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMercado
{
    internal class Produtos
    {
        public string? Codigo;
        public string? Descricao;
        public string? Preco;
        public int Estoque;
        public string? QntEstoque;

        public Produtos(string codigo, string descricao, string preco, int estoque, string qntEstoque)
        {
            Codigo = codigo;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            QntEstoque = qntEstoque;
        }
    }
    internal class Cupom
    {
        public int           _numeroCupom;
        public DateTime     _dataEmissaoCupom;
        public string        _cpfCliente;
        public ItemCupom[]   _itemCupom;

      internal class ItemCupom {
         public Produtos _produto;
         public float    _quantidade;
      }

        public Cupom(int numeroCupom, string cpfCliente ) {
            _numeroCupom = numeroCupom;
            _cpfCliente = cpfCliente;
            _dataEmissaoCupom = DateTime.Now;
        }
    }
        
}
