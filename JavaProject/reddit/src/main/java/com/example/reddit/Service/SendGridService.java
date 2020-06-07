package com.example.reddit.Service;

import com.example.reddit.ControllerRestTemplateTest.EmailPojo;

public interface SendGridService {
    String sendMailWithPojo (EmailPojo emailPojo);

}
