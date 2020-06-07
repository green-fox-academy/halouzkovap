package com.example.reddit.Service;

import com.example.reddit.Controller.EmailPojo;

public interface SendGridService {
    String sendMailWithPojo (EmailPojo emailPojo);
    public void sendMail(String subject, String body, String address);
}
