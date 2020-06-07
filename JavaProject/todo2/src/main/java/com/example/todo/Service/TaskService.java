package com.example.todo.Service;

import com.example.todo.Entity.Category;
import com.example.todo.Entity.Task;
import com.example.todo.Repository.TaskRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TaskService implements ITaskService {
    @Autowired
    TaskRepository taskRepository;


    @Override
    public Task findByid(int id) {
        return taskRepository.findById(id);
    }

    @Override
    public void createTask(Task task) {
        taskRepository.save(task);
    }

    @Override
    public Iterable<Task> findByCategory(List<String> cat) {
        return taskRepository.findByCategoryNameIn(cat);
    }

    @Override
    public Iterable<Task> findall() {
        return taskRepository.findAll();
    }

    @Override
    public void delete(int id) {
        taskRepository.deleteById(id);
    }
}
