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
    public class DisciplinaController  : ControllerBase
    {

        [HttpGet(Name = "disciplinas")]
        public List<Disciplina> GetDisciplina()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            //Disciplina d = new Disciplina
            
            /*disciplinas.add(new Disciplina){
                Nome = "Programação para Internet", 
                CargaHoraria = 60, 
                Semestre = 4, 
            };
            return disciplinas; */

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

            return disciplinas;

        }
    }
}
