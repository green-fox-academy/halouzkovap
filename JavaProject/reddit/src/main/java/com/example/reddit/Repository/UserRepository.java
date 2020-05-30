package com.example.reddit.Repository;

import com.example.reddit.Entity.User;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public interface UserRepository extends CrudRepository<User, Integer> {

    List<User> findByUserName(String Name);
    Optional<User> findByEmail(String Email);
    Optional<User> findByUserNameAndEmail(String name,String email);
}
