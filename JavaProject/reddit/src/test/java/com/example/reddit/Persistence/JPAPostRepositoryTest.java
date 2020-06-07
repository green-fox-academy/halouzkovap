package com.example.reddit.Persistence;

import com.example.reddit.Entity.Post;
import com.example.reddit.Repository.PostRepository;
import com.example.reddit.Service.IPostService;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.jdbc.AutoConfigureTestDatabase;
import org.springframework.boot.test.autoconfigure.orm.jpa.DataJpaTest;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.jupiter.api.Assertions.*;

@DataJpaTest
@AutoConfigureTestDatabase(replace = AutoConfigureTestDatabase.Replace.NONE)
public class JPAPostRepositoryTest {
    @Autowired
    PostRepository repository;
    @Test
    public void testCreateReadDelete(){
        Post post = new Post("petra","petra");
        repository.save(post);

        Iterable<Post> posts = repository.findAll();
        assertThat(posts).extracting(Post::getName).containsOnly("petra");

       repository.deleteAll();
       assertThat(repository.findAll()).isEmpty();
    }
}
