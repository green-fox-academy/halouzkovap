package com.example.todo.Entity;

import com.sun.istack.NotNull;
import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;

@Entity
@Getter
@Setter
public class Task {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;
    @NotNull
    private String name;
    @ManyToOne
    @JoinColumn(name = "category_id")
    private Category category;

    @ManyToOne
    @JoinColumn(name = "user_id")
    private User user;
    @Column
    private String owner;
    public Task() {
    }

    public Task(String name) {
        this.name = name;
    }

    public Task(String name, User user){
        this.name =name;
        this.user = user;
    }
    public Task(String name, String username){
        this.name =name;
        this.owner = username;
    }
}
