package com.example.reddit.Controller;

public class EmailPojo {
    private String toName;
    private String toEmail;

private String userName;
private String userKingdom;

    public EmailPojo(String toName, String toEmail, String userName, String userKingdom) {
        this.toName = toName;
        this.toEmail = toEmail;
        this.userName = userName;
        this.userKingdom = userKingdom;
    }

    public EmailPojo() {

    }

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public String getUserKingdom() {
        return userKingdom;
    }

    public void setUserKingdom(String userKingdom) {
        this.userKingdom = userKingdom;
    }

    public String getToName() {
        return toName;
    }

    public void setToName(String toName) {
        this.toName = toName;
    }

    public String getToEmail() {
        return toEmail;
    }

    public void setToEmail(String toEmail) {
        this.toEmail = toEmail;
    }
}
