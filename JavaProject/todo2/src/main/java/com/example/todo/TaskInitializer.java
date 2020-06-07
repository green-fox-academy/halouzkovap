package com.example.todo;

import com.example.todo.Entity.Task;
import com.example.todo.Entity.User;
import com.example.todo.Repository.TaskRepository;
import com.example.todo.Repository.UserRepository;
import org.springframework.beans.factory.SmartInitializingSingleton;


import org.springframework.stereotype.Component;

@Component
public class TaskInitializer implements SmartInitializingSingleton {
    private final TaskRepository task;
    private final UserRepository users;

    public TaskInitializer(TaskRepository task, UserRepository users) {
        this.task = task;
        this.users = users;
    }
    @Override
    public void afterSingletonsInstantiated() {
        this.task.save(new Task("Read War and Peace", "user"));
        this.task.save(new Task("Free Solo the Eiffel Tower", "user"));
        this.task.save(new Task("Hang Christmas Lights", "user"));

        User user = new User("user", "{bcrypt}$2a$10$3njzOWhsz20aimcpMamJhOnX9Pb4Nk3toq8OO0swIy5EPZnb1YyGe");
        user.grantAuthority("task:read");
        this.users.save(user);

        User hasRead = new User("hasread", "{bcrypt}$2a$10$3njzOWhsz20aimcpMamJhOnX9Pb4Nk3toq8OO0swIy5EPZnb1YyGe");
        hasRead.grantAuthority("task:read");
        this.users.save(hasRead);

        User hasWrite = new User("haswrite", "{bcrypt}$2a$10$3njzOWhsz20aimcpMamJhOnX9Pb4Nk3toq8OO0swIy5EPZnb1YyGe");
        hasWrite.grantAuthority("taks:write");
        this.users.save(hasWrite);
    }
}
