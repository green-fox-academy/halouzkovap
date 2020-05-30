package com.example.reddit.Repository;

import com.example.reddit.Entity.Category;
import com.example.reddit.Entity.Post;
import com.example.reddit.Entity.User;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository 
public interface PostRepository extends CrudRepository<Post, Long> {

    List<Post> findByCategoryAllIgnoreCase(Category category);
    Optional<Post> findByUserAllIgnoreCase(User user);

}
