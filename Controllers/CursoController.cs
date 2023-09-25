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
    public class CursoController : ControllerBase
    {
        [HttpGet(Name = "cursos")]
        public List<Curso> GetCursos()
        {
            List<Curso> cursos = new List<Curso>();

            List<Disciplina> disciplinas = new List<Disciplina>();
            Disciplina d1 = new Disciplina();
            d1.Nome = "Programação para Internet";
            d1.CargaHoraria = 60;
            d1.Semestre = 4;

            Disciplina d2 = new Disciplina();
            d2.Nome = "Internet";
            d2.CargaHoraria = 60;
            d2.Semestre = 5;

            Disciplina d3 = new Disciplina();
            d3.Nome = "Programação";
            d3.CargaHoraria = 60;
            d3.Semestre = 6;

            disciplinas.Add(d1);
            disciplinas.Add(d2);
            disciplinas.Add(d3);


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


            Curso c1 = new Curso();
            c1.Nome = "Internet";
            c1.Area = "programção";
            c1.Duracao = 5;
            c1.disciplinas = disciplinas;
            c1.alunos = alunos;

            Curso c2 = new Curso();
            c2.Nome = "Programação";
            c2.Area = "programção";
            c2.Duracao = 5;
            c2.disciplinas = disciplinas;
            c2.alunos = alunos;

            Curso c3 = new Curso();
            c3.Nome = "web";
            c3.Area = "programção";
            c3.Duracao = 10;
            c3.disciplinas = disciplinas;
            c3.alunos = alunos;

            cursos.Add(c1);
            cursos.Add(c2);
            cursos.Add(c3);

            return cursos;
        }
    }
}