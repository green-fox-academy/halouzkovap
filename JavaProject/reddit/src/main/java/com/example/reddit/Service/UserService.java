package com.example.reddit.Service;

import com.example.reddit.Entity.User;
import com.example.reddit.Repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class UserService implements IUserService {

    private final UserRepository userRepository;


    public UserService(UserRepository userRepository) {
        this.userRepository = userRepository;
    }


    @Override
    public Iterable<User> list() {
        return userRepository.findAll();
    }

    @Override
    public List<User> findUsers(String name) {
        return userRepository.findByUserName(name);
    }

    @Override
    public Optional<User> findUsersWithEmail(String email) {
        return userRepository.findByEmail(email);
    }

    @Override
    public Optional<User> findUserEmail(String name, String email) {
        return userRepository.findByUserNameAndEmail(name, email);
    }
}
