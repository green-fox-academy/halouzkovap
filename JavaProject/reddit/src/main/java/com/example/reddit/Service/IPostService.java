package com.example.reddit.Service;

import com.example.reddit.Entity.Post;


import java.util.List;
import java.util.Optional;

public interface IPostService {
    Post findByIdInt(int id);

    Iterable<Post> findAll();

    Post save(Post post, int CategoryId);

    Post save(Post post);

    boolean saveBool(Post post);

    void deleteById(long id);

    Post findById(Long id);

    Optional<Post> findId(Long id);


    Iterable<Post> findByCategory(List<String> ct);


}
