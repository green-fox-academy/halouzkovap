package com.example.reddit.Service;


import com.example.reddit.Controller.EmailPojo;
import com.sendgrid.Method;
import com.sendgrid.Request;
import com.sendgrid.Response;
import com.sendgrid.SendGrid;
import com.sendgrid.helpers.mail.Mail;
import com.sendgrid.helpers.mail.objects.Email;
import com.sendgrid.helpers.mail.objects.Personalization;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Service;

import java.io.IOException;

@Service
public class SendGridServiceImpl implements SendGridService {


    @Value("${SENDGRID.APIKEY}")
    private String Apikey;
    @Value("${SENDGRID.TEMPLATEID}")
    private String TempleteId;

    private Mail PersonalizeEmail(EmailPojo emailPojo) {
        Mail mail = new Mail();
        /*
         * Personalization setting,  add recipient
         */
        Email fromEmail = new Email();
        fromEmail.setName("Vetulus Rascal");

        fromEmail.setEmail("pierrett75@gmail.com");

        mail.setFrom(fromEmail);
        Personalization personalization = new Personalization();
        Email to = new Email();
        to.setName(emailPojo.getToName());
        to.setEmail(emailPojo.getToEmail());
        personalization.addTo(to);

        personalization.addHeader("X-Test", "test");
        personalization.addHeader("X-Mock", "true");

        /* Substitution value settings */
        //personalization.addSubstitution("%name%", emailPojo.getToName());
        personalization.addDynamicTemplateData("UserName", emailPojo.getUserName());
        personalization.addDynamicTemplateData("UserKingdom", emailPojo.getUserKingdom());


        mail.addPersonalization(personalization);

        /* Set template id */
        mail.setTemplateId(TempleteId);


        return mail;
    }

    @Override
    public String sendMailWithPojo(EmailPojo emailPojo) {
        SendGrid sg = new SendGrid(Apikey);
        //sg.addRequestHeader("X-Mock", "true");

        Request request = new Request();
        Mail mail = PersonalizeEmail(emailPojo);
        try {
            request.setMethod(Method.POST);
            request.setEndpoint("mail/send");
            request.setBody(mail.build());
            Response response = sg.api(request);
            System.out.println(response.getStatusCode());
            System.out.println(response.getBody());
            System.out.println(response.getHeaders());
        } catch (IOException ex) {
            ex.printStackTrace();
            return "Failed to send mail! " + ex.getMessage();
        }
        return "Email is sent Successfully!!";
    }



    @Override
    public void sendMail(String subject, String body, String address) {

    }
}
