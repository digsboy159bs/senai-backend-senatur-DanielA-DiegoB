using Senai.Senatur.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.DataBaseFirst.Interfaces
{
    interface IPacotesRepository
    {
        List<Pacotes> Listar();

        void Cadastrar(Pacotes novoPacote);

        void Atualizar(int Id, Pacotes pacoteAtualizado);

        void Deletar(int Id);

        Pacotes BuscarPorId(int id);
    }
}
