using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiUniversidade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpGet(Name = "alunos")]
        public List<Aluno> GetAluno()
        {
            List<Aluno> alunos = new List<Aluno>();

            Aluno a1 = new Aluno();
            a1.Nome = "Amanda";
            a1.DataNascimento = DateTime.Now;
            a1.cpf = "123.456.789-52";

            Aluno a2 = new Aluno();
            a2.Nome = "Camila";
            a2.DataNascimento = DateTime.Now;
            a2.cpf = "987.654.321-85";

            alunos.Add(a1);
            alunos.Add(a2);

            return alunos;

        }
    }
}