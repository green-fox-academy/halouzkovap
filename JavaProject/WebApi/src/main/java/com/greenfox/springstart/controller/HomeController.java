package com.greenfox.springstart.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class HomeController {
    @RequestMapping("/greeting")
    @ResponseBody
    public String greetin(){
        return "Hello Word";
    }



    @RequestMapping("/hello")
    public String killMe(){
        return "kill me";
    }
}
