package com.example.reddit.Model;

import com.example.reddit.Entity.CategoryType;

public class CategoryDtoForCreation {

    private String name;

    private CategoryType ct;

    public CategoryType getCt() {
        return ct;
    }

    public void setCt(CategoryType ct) {
        this.ct = ct;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }


}
