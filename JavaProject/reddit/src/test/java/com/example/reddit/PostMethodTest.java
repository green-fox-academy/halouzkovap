package com.example.reddit;

import com.example.reddit.Entity.Category;
import com.example.reddit.Entity.CategoryType;
import com.example.reddit.Entity.Post;
import com.example.reddit.Entity.User;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

@DisplayName("Post methodd") // in export we can find this name
public class PostMethodTest {
    private User user;
    private Post post;
    private Category category;
    private Category category2;

    @BeforeEach
    void init(){
        user = new User("petra", "text@eamil.cz");
        post= new Post("test", "www.seznam.cz");
        category = new Category("Scifi", CategoryType.sciFi);

    }

    @Test
    @DisplayName("add user to post")
    void addUserToPost(){
        post.addUser(user);
        assertEquals("petra",post.getUser().getUserName());
    }

    @Test
    void addCategoryToPost() {
        post.addCategrory(category);
        assertEquals("Scifi",post.getCategory().getName());
    }
    @Test
    void addNullCategoryToPost(){
       Exception error = assertThrows(RuntimeException.class,()->
               post.addCategrory(category2));
       assertEquals("category cannot be null null",error.getMessage());
    }
}
