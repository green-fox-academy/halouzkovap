package com.greenfox.springstart.controller;

import com.greenfox.springstart.Entity.Greeting;
import org.springframework.boot.Banner;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.concurrent.atomic.AtomicLong;

@RestController
public class HelloRESTController {

    private static final String greetingText = "Hello ";
    private static final AtomicLong id = new AtomicLong();


    @RequestMapping(value = "/hi", method = RequestMethod.GET)
    public Greeting hi(@RequestParam(value = "name", required = false) String name, Model model) {
        if (name == null) {
            name = "Petulka";
        }

        model.addAttribute("name", name);
        return new Greeting(id.incrementAndGet(), greetingText + name + "!");
    }

}
