﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaQuiminvest.Model;
using SistemaQuiminvest.Model.Repositories;

namespace SistemaQuiminvest.Control
{
    public class oFuncionario : IDisposable
    {
        RepositoryFuncionarios _Repository;
        public oFuncionario()
        {
            _Repository = new RepositoryFuncionarios();
        }

        public void Incluir(funcionario oFuncionario)
        {
            _Repository.Incluir(oFuncionario);
        }

        public funcionario Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(funcionario oFuncionario, bool attach = false)
        {
            _Repository.Alterar(oFuncionario, attach);
        }

        public void Excluir(funcionario oFuncionario)
        {
            _Repository.Excluir(oFuncionario);
        }

        public List<funcionario> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}