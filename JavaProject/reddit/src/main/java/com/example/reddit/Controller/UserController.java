package com.example.reddit.Controller;

import com.example.reddit.Entity.User;
import com.example.reddit.Service.IUserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class UserController {

    private final IUserService userService;


    @Autowired
    public UserController(IUserService userService) {
        this.userService = userService;


    }

    @GetMapping("/user")
    public Iterable<User> list(){
        return userService.list();
    }
}
