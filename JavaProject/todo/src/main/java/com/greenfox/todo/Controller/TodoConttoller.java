package com.greenfox.todo.Controller;

import com.greenfox.todo.Repository.TodoRepository;
import com.greenfox.todo.Service.TodoService;
import com.greenfox.todo.model.Todo;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/todo")
public class TodoConttoller {

    private final TodoRepository todoService;

    public TodoConttoller(TodoRepository todoService) {
        this.todoService = todoService;
    }

    @RequestMapping(value = {"/list"}, method = RequestMethod.GET)
    public ResponseEntity<Iterable<Todo>> list() {

        var todos = todoService.findAll();

        return ResponseEntity.status(200).body(todos);
    }
}
