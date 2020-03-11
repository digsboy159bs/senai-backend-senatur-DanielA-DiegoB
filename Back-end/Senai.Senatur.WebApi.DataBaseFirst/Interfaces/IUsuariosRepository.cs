using Senai.Senatur.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.DataBaseFirst.Interfaces
{
    interface IUsuariosRepository
    {
        List<Usuarios> Listar();

        void Cadastrar(Usuarios novoUsuario);

        void Deletar(int Id);

        Usuarios BuscarPorId(int Id);

        Usuarios BuscarPorEmailSenha(string Email, string Senha);


    }
}
