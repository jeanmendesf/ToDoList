using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.BackEnd.Data.DAO;
using ToDoList.BackEnd.Domain.Models;

namespace ToDoList.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : Controller
    {

        readonly TarefaDAO _tarefaDAO;

        public TarefaController()
        {
            _tarefaDAO = new TarefaDAO();
        }

        [HttpGet]
        [Route("")]
        public ActionResult ObterTodasTarefas()
        {
            List<Tarefa> listaTarefas;
            listaTarefas = _tarefaDAO.ObterTodasTarefas();

            return Ok(listaTarefas);

        }

        [HttpPost]
        [Route("adicionar")]
        public ActionResult AdicionarTarefa(Tarefa tarefa)
        { 
            _tarefaDAO.AdicionarTarefa(tarefa);
            
            return Ok();  
        }






    }
}
