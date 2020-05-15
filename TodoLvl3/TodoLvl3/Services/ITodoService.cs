using System.Collections.Generic;
using TodoLvl3.Entity;

namespace TodoLvl3.Services
{
    public interface ITodoService
    {
        // task
        void CreateTask(Entity.Task task);
        void UpdateTask(Entity.Task task);
        Task FindTask(int id);
        Task GetTask(int id);
        IEnumerable<Task> GetTasks();

        // subtask
        void CreateSubTask(SubTask sub);
        void UpdateSubTask(SubTask sub);
        SubTask FindSubTask(int id);
        SubTask GetSub(int id);
        IEnumerable<SubTask> GetSubTasks();




        //assigne
        void CreateAssignee(Assignee assignee);
        void UpdateAssignee(Assignee assignee);

        Assignee FindAssignees(int id);
        Assignee GetAssigne(int id);
        IEnumerable<Assignee> GetAssignees();


        //mentor
        void CreateMentor(Mentor mentor);
        void UpdateMentor(Mentor mentor);
        Mentor FindMentor(int id);
        Mentor GetMentor(int id);
        IEnumerable<Mentor> GetMentors();



        //project
        void CreateProject(Project project);
        void UpdateProject(Project project);
        Project FindProject(int id);
        Project GetProject(int id);
        IEnumerable<Project> Projects();

    }
}
