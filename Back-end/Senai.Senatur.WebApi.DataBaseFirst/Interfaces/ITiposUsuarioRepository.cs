using Senai.Senatur.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.DataBaseFirst.Interfaces
{
    interface ITiposUsuarioRepository
    {
        List<TiposUsuario> Listar();

        TiposUsuario BuscarPorId(int Id);
    }
}
