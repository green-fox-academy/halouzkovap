package com.example.reddit.ControllerRestTemplateTest;

import com.example.reddit.Service.SendGridService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;


@RestController
public class EmailController {
    @Autowired
    SendGridService sendGridService;

    @RequestMapping(value = "/email/", method = RequestMethod.POST)
    public String index(@RequestBody EmailPojo emailPojo) {
        String response = sendGridService.sendMailWithPojo(emailPojo);
        return response;
    }
}
