package com.example.todo.Entity;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity(name = "users")
@Getter
@Setter
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;
    @Column(name = "username", unique = true)
    private String userName;
    private String password;
    @Column(name = "email", unique = true)
    private String email;

    @OneToMany(cascade = CascadeType.ALL, fetch = FetchType.EAGER)//avoid lazy load exception
    private List<UserAuthority> userAuthorities = new ArrayList<>();
    @OneToMany
    private List<Task> posts;

    {
        posts = new ArrayList<Task>();
    }

    public User() {
    }

    public User(String name, String password, String email) {
        this.email = email;
        this.userName = name;
        this.password = password;
    }

    public User(User user) {
        this.id = user.id;
        this.userName = user.userName;
        this.email = user.password;
        this.password = user.password;
        this.userAuthorities = new ArrayList<>(user.userAuthorities);
    }

    public User(String user, String s) {
        this.userName = user;
        this.password = s;
    }

    public void grantAuthority(String authority) {
        this.userAuthorities.add(new UserAuthority(this, authority));
    }
}
