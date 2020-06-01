package com.example.reddit.Model;

import com.example.reddit.Entity.Category;
import com.sun.istack.NotNull;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.Positive;


public class PostDtoForCreation {

    @NotNull
    @NotBlank
    public String name;
    @NotNull
    public String url;
    @NotNull
    @Positive
    public int categoryId;
    @Positive
    public int userId;

    public PostDtoForCreation(@NotBlank String name, String url, @Positive int categoryId) {
        this.name = name;
        this.url = url;
        this.categoryId = categoryId;
    }
}
