using Senai.Senatur.WebApi.DataBaseFirst.Domains;
using Senai.Senatur.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.DataBaseFirst.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        InLockContext ctx = new InLockContext();

        public TiposUsuario BuscarPorId(int Id)
        {
            return ctx.TiposUsuario.FirstOrDefault(s => s.IdTipoUsuario == Id);
        }

        public List<TiposUsuario> Listar()
        {
            return ctx.TiposUsuario.ToList();
        }
    }
}
