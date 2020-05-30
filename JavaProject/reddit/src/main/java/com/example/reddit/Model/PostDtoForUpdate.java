package com.example.reddit.Model;

import com.example.reddit.Entity.Category;
import com.sun.istack.NotNull;

public class PostDtoForUpdate {


    @NotNull
    public String name;
    @NotNull
    public String url;
    @NotNull
    public int categoryId;
    public  int userId;



}
