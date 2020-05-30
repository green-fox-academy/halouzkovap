package com.example.restapi.controller;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class StudenController {
    @RequestMapping(value = {"/hi"}, method = RequestMethod.GET)
    public String hi() {
        return "Hello";
    }
}
