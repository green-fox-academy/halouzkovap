package com.example.todo.Contorller;

import com.example.todo.Entity.Category;
import com.example.todo.Entity.Task;
import com.example.todo.Model.CreateCategoryDTO;
import com.example.todo.Model.CreateTaskDTO;
import com.example.todo.Repository.TaskRepository;
import com.example.todo.Service.ITaskService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
public class TaskController {
    @Autowired
    ITaskService taskService;

    @GetMapping("/task")
    public ResponseEntity<Iterable<Task>> getAll() {
        Iterable<Task> tasks = taskService.findall();
        return new ResponseEntity<Iterable<Task>>(tasks, HttpStatus.OK);
    }



    @GetMapping("/task/{id}")
    public ResponseEntity<Task> findCategory(@PathVariable int id) {
        Task cat = taskService.findByid(id);
        return new ResponseEntity<Task>(cat, HttpStatus.OK);
    }

    @DeleteMapping("/taks/{id}")
    public ResponseEntity<?> delete(@PathVariable int id){
        taskService.delete(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
