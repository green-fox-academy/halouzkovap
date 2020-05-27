package com.greenfox.springstart.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.concurrent.atomic.AtomicLong;

@Controller
public class HelloWebController {


    // @RequestMapping("/web/greeting")
    // public String greeting(Model model) {
    //   model.addAttribute("name", " World");
    // return "greeting";
    //}
    private static AtomicLong id = new AtomicLong();

    @RequestMapping(value = "/web/greeting", method = RequestMethod.GET)
    public String greeting(@RequestParam(value = "name", required = false) String name, Model model) {
        if (name == null) {
            name = "World";
        }
        model.addAttribute("name", name);
        model.addAttribute("id", id.incrementAndGet());
        return "Hello, " + name + "!" + "This site was loaded " + id + "times since last server start.";
    }
}
