package com.example.reddit.Service;

import com.example.reddit.Entity.Post;
import jdk.jfr.Category;

import java.util.List;
import java.util.Optional;

public interface IPostService {

    Iterable<Post> findAll();

    Post save(Post post, int CategoryId);
    Post save(Post post);

    void deleteById(long id);

    Post findById(Long id);
    Optional<Post>findId(Long id);


 Iterable<Post> findByCategory(List<String> ct);

}
