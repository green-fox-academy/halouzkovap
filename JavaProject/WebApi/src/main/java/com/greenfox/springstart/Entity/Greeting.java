package com.greenfox.springstart.Entity;

public class Greeting {
    public long id;
    private String filds;

    public Greeting(long id, String fields) {
        this.id = id;
        this.filds = fields;
    }

    public long getId() {
        return id;
    }

    public String getFilds() {
        return filds;
    }
}
