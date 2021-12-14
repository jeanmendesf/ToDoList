using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BackEnd.Domain.Models
{
    internal class Tarefa
    {
        public Tarefa()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

    }
}
