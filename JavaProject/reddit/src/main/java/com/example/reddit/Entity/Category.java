package com.example.reddit.Entity;

import com.fasterxml.jackson.annotation.JsonIgnore;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

@Entity
public class Category {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @Column(nullable = false)
    private String name;

    private Enum CategoryType;


    @OneToMany(mappedBy = "category", cascade = CascadeType.ALL)

    private List<Post> posts;

    {
        posts = new ArrayList<>();
    }

    public Category() {
    }

    public Category(String name, CategoryType ct) {
        this.name = name;
        this.CategoryType = ct;
    }


    public Enum getCategoryType() {
        return CategoryType;
    }

    public void setCategoryType(Enum categoryType) {
        CategoryType = categoryType;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public List<Post> getPosts() {
        return posts;
    }

    public void setPosts(List<Post> posts) {
        this.posts = posts;
    }
}
