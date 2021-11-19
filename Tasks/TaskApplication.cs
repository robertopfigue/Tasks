using System.Collections.Generic;
using System.Linq;
using Tasks.Entidades;
using Tasks.Infra.Dtos;
using Tasks.Infra.Repository;

namespace Tasks.Services
{
    public class TaskApplication
    {

        public void RemoveTaskById(int id)
        {
            var tasks = GetTasks();

            var task = tasks.Where(w => w.Id == id).FirstOrDefault();

            tasks.Remove(task);
        }

        public List<Task> GetTasks()
        {
            TaskRepository tasksRepos = null;
            return tasksRepos.GetAllTasks();
        }

        public void CreateTask(TaskDto dto)
        {
            if (Validator(dto))
            {
                Task task = new Task(dto.Id, dto.Descricao, dto.Completa);

                AddTask(task);
            }
        }

        public void AddTask(Task task)
        {
            List<Task> tasks = new List<Task>();

            tasks.Add(task);
        }

        public bool Validator(TaskDto dto)
        {
            if (dto.Descricao.Length > 5)
                return true;
            else return false;
        }
    }
}
