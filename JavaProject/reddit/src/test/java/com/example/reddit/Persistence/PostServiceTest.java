package com.example.reddit.Persistence;

import com.example.reddit.Entity.Category;
import com.example.reddit.Entity.CategoryType;
import com.example.reddit.Entity.Post;
import com.example.reddit.Entity.User;
import com.example.reddit.Repository.CategoryRepository;
import com.example.reddit.Repository.PostRepository;
import com.example.reddit.Repository.UserRepository;
import com.example.reddit.Service.IPostService;
import com.example.reddit.Service.PostService;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.List;
import java.util.Optional;

import static org.mockito.Mockito.*;
import static org.junit.jupiter.api.Assertions.*;

@SpringBootTest
public class PostServiceTest {
    //constance for testing
    private static final Post post = new Post("seznam", "www.seznam.cz");
    private static final Category cat = new Category("scifi", CategoryType.sciFi);
    private static final User use = new User("Petra", "eamil@seznam.cz");
    //testing IPost Service
    private IPostService uderTests;
    // post service user post repository so we mock this post repository
    private PostRepository postRepository = mock(PostRepository.class);
    private UserRepository userRepository = mock(UserRepository.class);
    private CategoryRepository categoryRepository = mock(CategoryRepository.class);

    @BeforeEach
    void setUp() {
        uderTests = new PostService(postRepository, userRepository, categoryRepository);
    }


    @Test //ok
    public void givenCountMethodMocked_WhenCountInvoked_ThenMockValueReturned() {
        when(postRepository.count()).thenReturn(123L);
        long postCount = postRepository.count();
        assertEquals(123L, postCount);
    }

    @Test
    public void createPost() {

        when(postRepository.findById(16)).thenReturn(post);
        Post actual = uderTests.findByIdInt(16);
        assertEquals("seznam", actual.getName());
        assertEquals("www.seznam.cz", actual.getUrl());
        verify(postRepository).findById(16);
    }


}
