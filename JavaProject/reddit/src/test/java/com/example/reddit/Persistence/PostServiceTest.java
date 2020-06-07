package com.example.reddit.Persistence;

import com.example.reddit.Entity.Post;
import com.example.reddit.Repository.PostRepository;
import com.example.reddit.Service.IPostService;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;
import static org.mockito.Mockito.*;

@SpringBootTest
public class PostServiceTest {
    //constance for testing
    private static final Post post = new Post("seznam","www.seznam.cz");
    //testing IPost Service
    private IPostService uderTests;
    // post service user post repository so we mock this post repository
    private PostRepository postRepository = mock(PostRepository.class);
    @BeforeEach
    static void init(){

    }
    @Test
    public void addNewPost(){

    }
}
