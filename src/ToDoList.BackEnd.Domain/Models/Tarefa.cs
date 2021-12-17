using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BackEnd.Domain.Models
{
    public class Tarefa
    {
        public Tarefa()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public DateTime DataPrazo { get; set; }

    }
}
