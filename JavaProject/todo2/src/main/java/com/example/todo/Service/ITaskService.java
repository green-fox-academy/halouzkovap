package com.example.todo.Service;

import com.example.todo.Entity.Category;
import com.example.todo.Entity.Task;

import java.util.List;

public interface ITaskService {
    Task findByid(int id);
    void createTask(Task task);
    Iterable<Task> findByCategory(List<String> cat);
    Iterable<Task> findall();

    void delete(int id);
}
