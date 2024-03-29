﻿using EcommerceOsorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceOsorio.DAL
{
    public class ProdutoDAO
    {
        private readonly Context _context;
        public ProdutoDAO(Context context)
        {
            _context = context;
        }

        public Produto BuscarProdutoPorNome(Produto p)
        {
            return _context.Produtos.FirstOrDefault(x=> x.Nome.Equals(p.Nome));
        }
        public bool Cadastrar(Produto p)
        {
            if (BuscarProdutoPorNome(p) == null)
            {
                _context.Produtos.Add(p);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Produto> ListarProdutos()
        {
            return _context.Produtos.ToList();
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return _context.Produtos.Find(id);
        }

        public void Remover(int id)
        {
            _context.Produtos.Remove(BuscarProdutoPorId(id));
            _context.SaveChanges();
        }

        public void Alterar(Produto p)
        {
            _context.Produtos.Update(p);
            _context.SaveChanges();
        }


    }
}
