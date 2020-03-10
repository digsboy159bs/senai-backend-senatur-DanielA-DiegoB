using Senai.Senatur.WebApi.DataBaseFirst.Domains;
using Senai.Senatur.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.DataBaseFirst.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        InLockContext ctx = new InLockContext();

        public Usuarios BuscarPorEmailSenha(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public Usuarios BuscarPorId(int Id)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.IdUsuario == Id);
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int Id)
        {
            Usuarios usuarioBuscado = ctx.Usuarios.Find(Id);

            ctx.Usuarios.Remove(usuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
