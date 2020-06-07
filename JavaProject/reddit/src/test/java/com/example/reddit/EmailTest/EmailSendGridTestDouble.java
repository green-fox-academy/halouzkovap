package com.example.reddit.EmailTest;

import com.example.reddit.Controller.EmailPojo;
import com.example.reddit.Service.SendGridService;

import java.util.ArrayList;

public class EmailSendGridTestDouble implements SendGridService {
    ArrayList<Message> pojo = new ArrayList<>();

    @Override
    public void sendMail(String subject, String body, String address) {
        pojo.add(new Message(subject, body, address));
    }

    @Override
    public String sendMailWithPojo(EmailPojo emailPojo) {
        return null;
    }

    class Message {
        public String toAddress;
        public String subject;
        public String body;

        public Message(String subject, String body, String address) {
            this.subject = subject;
            this.body = body;
            this.toAddress = address;
        }

    }
}
