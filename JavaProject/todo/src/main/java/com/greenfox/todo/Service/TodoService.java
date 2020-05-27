package com.greenfox.todo.Service;

import com.greenfox.todo.Repository.TodoRepository;
import com.greenfox.todo.model.Todo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class TodoService {

    private final TodoRepository todoRepository;

    @Autowired
    public TodoService(TodoRepository todoRepository) {
        this.todoRepository = todoRepository;
    }

    public Iterable<Todo> findAll() {
        return todoRepository.findAll();
    }

    public void add(String title) {
        todoRepository.save(new Todo(title));
    }

    public void add(Todo todo) {
        todoRepository.save(todo);
    }

}
