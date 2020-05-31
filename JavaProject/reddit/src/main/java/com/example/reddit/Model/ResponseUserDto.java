package com.example.reddit.Model;

import com.sun.istack.NotNull;
import org.springframework.http.HttpStatus;

import javax.persistence.Column;

public class ResponseUserDto {
    public String userName;

    public String email;

    public ResponseUserDto(String userName, String email) {
        this.userName = userName;
        this.email = email;
    }


}
