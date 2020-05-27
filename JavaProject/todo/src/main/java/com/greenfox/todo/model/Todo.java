package com.greenfox.todo.model;

import javax.persistence.*;

@Entity
@Table(name = "todos")
public class Todo {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;
    @Column(name = "title")
    private String title;
    private boolean isUrgent;
    private boolean isDone;

    public Todo(String title, boolean isUrgent, boolean isDone) {
        this.title = title;
        this.isUrgent = isUrgent;
        this.isDone = isDone;
    }

    public Todo(String title) {
        this.title = title;
    }

    public Todo() {
    }


    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public boolean getIsUrgent() {
        return isUrgent;
    }

    public void setIsUrgent(boolean urgent) {
        isUrgent = urgent;
    }

    public boolean getIsDone() {
        return isDone;
    }

    public void setIsDone(boolean done) {
        isDone = done;
    }


    @Override
    public String toString() {
        return title;
    }
}
