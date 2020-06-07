package com.example.reddit.Entity;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.rmi.server.ExportException;
import java.util.Optional;

@Entity
@Getter
@Setter
public class Post {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;
    private String Name;
    private String Url;

    @ManyToOne
    @JoinColumn(name = "user_id")
    private User user;

    @ManyToOne
    @JoinColumn(name = "category_id")
    private Category category;

    public Post() {

    }

    public Post(String name, String url) {

        this.Name = name;
        this.Url = url;
    }

    public void addCategrory(Category cat) {
        try {
            if (cat.getName() != null)
                this.category = cat;
        } catch (Exception e) {

            throw new RuntimeException("category cannot be null " + e.getMessage());
        }
    }

    public void addUser(User user) {
        this.user = user;
    }
}
