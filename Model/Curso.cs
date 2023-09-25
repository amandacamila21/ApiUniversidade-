using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiUniversidade.Model
{
    public class Curso
    {
       public int Id {get; set;}
       public string? Nome {get; set;}
       public string? Area {get; set;}
       public int Duracao {get; set;}

       public List<Disciplina> disciplinas {get; set;} 
       public List<Aluno> alunos {get; set;} 

       public Curso()
       {
            disciplinas = new List<Disciplina>();
            alunos = new List<Aluno>();
       }
       
    }
}