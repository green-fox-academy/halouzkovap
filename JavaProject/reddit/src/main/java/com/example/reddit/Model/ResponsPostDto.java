package com.example.reddit.Model;

import com.example.reddit.Entity.Category;
import com.example.reddit.Entity.Post;
import com.example.reddit.Entity.User;

import javax.persistence.*;
import java.util.Optional;

public class ResponsPostDto {

    public String Name;
    public String Url;
    public String userName;
    public String categoryName;

    public ResponsPostDto(){

    }

    public ResponsPostDto(String name, String url, String userName, String categoryName) {
        Name = name;
        Url = url;
        this.userName = userName;
        this.categoryName = categoryName;
    }
    public ResponsPostDto(String name, String url,  String categoryName) {
        Name = name;
        Url = url;

        this.categoryName = categoryName;
    }

}
