using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.BackEnd.Domain.Models;

namespace ToDoList.BackEnd.Data.DAO
{
    public class TarefaDAO


    {
        string connectionString = @"Data Source = LAPTOP-LLO1QL2C\SQLEXPRESS;
                                    Initial Catalog = db_ToDoList; Integrated Security=True";

        public List<Tarefa> ObterTodasTarefas()
        {
            List<Tarefa> listaTarefas = new List<Tarefa>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Tarefa", connection);
                cmd.CommandType = CommandType.Text;
                
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Tarefa tarefa = new Tarefa();

                    tarefa.Id = Convert.ToInt32(reader["Id"]);
                    tarefa.Nome = reader["Nome"].ToString();
                    tarefa.Descricao = reader["Descricao"].ToString();
                    tarefa.Categoria = reader["Categoria"].ToString();
                    tarefa.DataPrazo = Convert.ToDateTime(reader["DataPrazo"]);

                    listaTarefas.Add(tarefa);
                }
                connection.Close();
            }

            return listaTarefas;
        }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Tarefa(Nome, Descricao, Categoria, DataPrazo) " +
                                                    "+ VALIES(@Nome, @Descricao, @Categoria, @DataPrazo)", connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@Descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("@Categoria", tarefa.Categoria);
                cmd.Parameters.AddWithValue("@DataPrazo", tarefa.DataPrazo);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
