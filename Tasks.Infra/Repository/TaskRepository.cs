using System.Collections.Generic;
using Tasks.Entidades;

namespace Tasks.Infra.Repository
{
    public class TaskRepository
    {
        public List<Task> GetAllTasks()
        {
            List<Task> tasks = new List<Task>();
            var task1 = new Task(1 ,"Lavar Louça", true);
            var task2 = new Task(2, "Lavar Cozinha", false);
            var task3 = new Task(3, "Lavar Sala", false);
            var task4 = new Task(4, "Arrumar Cama", true);

            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);

            return tasks;
        }


    }
}
