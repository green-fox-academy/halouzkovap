package com.example.reddit.Persistence;

import com.example.reddit.Entity.Post;
import com.example.reddit.Service.PostService;
import org.springframework.beans.factory.annotation.Autowired;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;
import static org.junit.jupiter.api.Assertions.assertTrue;

import org.junit.jupiter.api.Tag;
import org.junit.jupiter.api.Test;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.Collections;
import java.util.List;


@SpringBootTest
public class PostPersistenceTest {

    @Autowired
    PostService postService;

    @Test
    public void getPost() throws Exception {
        List<Post> posts = (List<Post>) postService.findAll();
        assertEquals(24, posts.size());
    }

    @Test
    public void getPostByCategory() throws Exception {
        List<Post> ps = (List<Post>) postService.findByCategory(Collections.singletonList("sci-fi"));
        ps.forEach((post) -> {
            assertTrue(post.getCategory().getName().equals("sci-fi")) ;
        });
    }


}
