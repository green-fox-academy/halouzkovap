package com.example.todo.Entity;

import com.sun.istack.NotNull;
import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import javax.persistence.criteria.CriteriaBuilder;
import java.util.ArrayList;
import java.util.List;

@Entity
@Getter
@Setter
public class Category {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;
    @NotNull
    private String name;
    @OneToMany(mappedBy = "category", cascade = CascadeType.ALL)
    List<Task> tasks;
    {
        tasks = new ArrayList<Task>();
    }

    public Category() {
    }
    public Category(String name){
        this.name = name;
    }
}
