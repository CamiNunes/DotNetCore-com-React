using Alunos.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alunos.WebApi.Services
{
    public interface IAlunoService
    {
        //Task representa uma operação assíncrona;
        Task<IEnumerable<Aluno>> GetAlunos();

        Task<Aluno> GetAluno(int id);

        Task<IEnumerable<Aluno>> GetAlunoByName(string nome);

        Task CreateAluno(Aluno aluno);

        Task UpdateAluno(Aluno aluno);

        Task DeleteAluno(Aluno aluno);
    }
}
