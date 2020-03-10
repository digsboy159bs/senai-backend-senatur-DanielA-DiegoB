using Senai.Senatur.WebApi.DataBaseFirst.Domains;
using Senai.Senatur.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.DataBaseFirst.Repositories
{

    public class PacotesRepository : IPacotesRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int Id, Pacotes pacoteAtualizado)
        {
            Pacotes pacoteBuscado = ctx.Pacotes.Find(Id);

            // Verifica se o nome do estúdio foi informado
            if (pacoteAtualizado.NomePacote != null)
            {
                // Atribui os novos valores ao campos existentes
                pacoteBuscado.NomePacote = pacoteAtualizado.NomePacote;
            }

            // Atualiza o estúdio que foi buscado
            ctx.Pacotes.Update(pacoteBuscado);

            // Salva as informações para serem gravadas no banco
            ctx.SaveChanges();
        }

        public Pacotes BuscarPorId(int id)
        {
            return ctx.Pacotes.FirstOrDefault(p => p.IdPacote == id);
        }

        public void Cadastrar(Pacotes novoPacote)
        {
            ctx.Pacotes.Add(novoPacote);

            ctx.SaveChanges();
        }

        public void Deletar(int Id)
        {
            Pacotes pacoteBuscado = ctx.Pacotes.Find(Id);

            ctx.Pacotes.Remove(pacoteBuscado);

            ctx.SaveChanges();
        }

        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }
    }
}
