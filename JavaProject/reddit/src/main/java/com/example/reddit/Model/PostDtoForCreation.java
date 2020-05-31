package com.example.reddit.Model;

import com.example.reddit.Entity.Category;
import com.sun.istack.NotNull;

import javax.validation.constraints.NotBlank;


public class PostDtoForCreation {

    @NotNull
    @NotBlank
    public String name;
    @NotNull
    public String url;
    @NotNull
    public int categoryId;
    public  int userId;
}
