package com.example.reddit.Exception;

public class FieldErrorMessage {
    private String fild;
    private String messagge;

    public FieldErrorMessage(String fild, String messagge) {
        this.fild = fild;
        this.messagge = messagge;
    }

    public String getFild() {
        return fild;
    }

    public void setFild(String fild) {
        this.fild = fild;
    }

    public String getMessagge() {
        return messagge;
    }

    public void setMessagge(String messagge) {
        this.messagge = messagge;
    }
}
