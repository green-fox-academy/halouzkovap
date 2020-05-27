package com.greenfox.todo;

import com.greenfox.todo.Repository.TodoRepository;
import com.greenfox.todo.model.Todo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class TodoApplication implements CommandLineRunner {

    private TodoRepository todoRepository;


    @Autowired
    public TodoApplication(TodoRepository todoRepository) {
        this.todoRepository = todoRepository;
    }


    public static void main(String[] args) {
        SpringApplication.run(TodoApplication.class, args);
    }

    @Override
    public void run(String... args) throws Exception {
        todoRepository.save(new Todo("jjj", true, true));

        System.out.println(todoRepository.findAll());
    }
}
