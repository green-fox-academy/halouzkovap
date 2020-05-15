using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TodoLvl3.Entity;
using TodoLvl3.TodoDB;

namespace TodoLvl3.Services
{
    public class TodoService : ITodoService
    {
        private TodoLvl3DbContext dbContext;

        public TodoService(TodoLvl3DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateTask(Entity.Task task)
        {
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();
        }

        public void CreateSubTask(SubTask sub)
        {
            dbContext.SubTasks.Add(sub);
            dbContext.SaveChanges();
        }

        public void CreateAssignee(Assignee assignee)
        {
            dbContext.Assignees.Add(assignee);
            dbContext.SaveChanges();
        }

        public void CreateMentor(Mentor mentor)
        {
            dbContext.Mentors.Add(mentor);
            dbContext.SaveChanges();
        }

        public void CreateProject(Project project)
        {
            dbContext.Projects.Add(project);
            dbContext.SaveChanges();
        }

        public Task FindTask(int id)
        {
            return dbContext.Tasks.Find(id);
        }

        public SubTask FindSubTask(int id)
        {
            return dbContext.SubTasks.Find(id);

        }

        public Assignee GetAssignees(int id)
        {
            return dbContext.Assignees.Include(x => x.Tasks).Include(x => x.SubTasks).FirstOrDefault(x => x.Id == id);

        }

        public Mentor FindMentor(int id)
        {
            return dbContext.Mentors.Find(id);

        }

        public Project FindProject(int id)
        {
            return dbContext.Projects.Find(id);
        }

        public Task GetTask(int id)
        {
            return dbContext.Tasks.Include(x => x.Project).Include(x => x.Assignee).Include(x => x.SubTasks).FirstOrDefault(x => x.Id == id);
        }

        public SubTask GetSub(int id)
        {
            return dbContext.SubTasks.Include(x => x.Assignee).Include(x => x.Task).FirstOrDefault(x => x.Id == id);

        }

        public Assignee GetAssigne(int id)
        {
            return dbContext.Assignees.Include(x => x.SubTasks).Include(x => x.Tasks).FirstOrDefault(x => x.Id == id);

        }

        public Mentor GetMentor(int id)
        {
            return dbContext.Mentors.Include(x => x.Project).FirstOrDefault(x => x.Id == id);
        }

        public Project GetProject(int id)
        {
            return dbContext.Projects.Include(x => x.Mentor).Include(x => x.Tasks).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Task> GetTasks()
        {
            return dbContext.Tasks.Include(x => x.Project).Include(x => x.Assignee).Include(x => x.SubTasks);
        }

        public IEnumerable<Assignee> GetAssignees()
        {
            return dbContext.Assignees.Include(x => x.SubTasks).Include(x => x.Tasks);
        }

        public IEnumerable<Mentor> GetMentors()
        {
            return dbContext.Mentors.Include(x => x.Project);
        }

        public IEnumerable<Project> Projects()
        {
            return dbContext.Projects.Include(x => x.Mentor).Include(x => x.Tasks);
        }

        public IEnumerable<SubTask> GetSubTasks()
        {
            return dbContext.SubTasks.Include(x => x.Assignee).Include(x => x.Task);
        }

        public void UpdateTask(Task task)
        {
            dbContext.Entry(task).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void UpdateSubTask(SubTask sub)
        {
            dbContext.Entry(sub).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void UpdateAssignee(Assignee assignee)
        {
            dbContext.Entry(assignee).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void UpdateMentor(Mentor mentor)
        {
            dbContext.Entry(mentor).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void UpdateProject(Project project)
        {
            dbContext.Entry(project).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public Assignee FindAssignees(int id)
        {
            return dbContext.Assignees.Find(id);

        }
    }
}
