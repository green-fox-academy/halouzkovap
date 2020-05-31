package com.example.reddit.Service;

import com.example.reddit.Entity.User;

import java.util.Optional;

public interface IUserService {
    Iterable<User> list();
    Iterable<User> findUsers (String name);
    Optional<User> findUsersWithEmail (String email);
    Optional<User> findUserEmail(String name, String email);

    User Create(User u);

    Optional<User> findUser(int id);

    void deleteUser(int id);
}
