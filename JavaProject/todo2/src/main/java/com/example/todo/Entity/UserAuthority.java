package com.example.todo.Entity;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import java.util.UUID;

@Getter
@Setter
@Entity(name = "authorities")
public class UserAuthority {
    @Id
    private UUID id;

    @ManyToOne

    private User user;
    private String authority;

    public UserAuthority() {

    }

    public UserAuthority(User user, String authority) {
        this.id = UUID.randomUUID();
        this.user = user;
        this.authority = authority;
    }
}

