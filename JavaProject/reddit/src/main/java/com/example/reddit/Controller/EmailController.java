package com.example.reddit.Controller;

import com.example.reddit.Service.SendGridService;
import com.example.reddit.Service.SendGridServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;


@RestController
public class EmailController {
    @Autowired
    SendGridService sendGridService;

    @RequestMapping(value = "/email/", method = RequestMethod.POST)
    public String index(@RequestBody EmailPojo emailPojo) {
        String response = sendGridService.sendMail(emailPojo);
        return response;
    }
}
