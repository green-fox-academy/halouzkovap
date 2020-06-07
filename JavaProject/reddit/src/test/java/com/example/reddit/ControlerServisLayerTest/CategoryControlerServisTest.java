package com.example.reddit.ControlerServisLayerTest;

import com.example.reddit.ControllerRestTemplateTest.CategoryController;
import com.example.reddit.ControllerRestTemplateTest.PostController;
import com.example.reddit.Entity.Category;
import com.example.reddit.Entity.CategoryType;
import com.example.reddit.Entity.Post;
import com.example.reddit.RedditApplication;
import com.example.reddit.Repository.PostRepository;
import com.example.reddit.Service.ICategoryService;
import com.example.reddit.Service.IPostService;
import com.example.reddit.Service.IUserService;
import com.example.reddit.Service.PostService;
import org.aspectj.lang.annotation.Before;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.mockito.InjectMocks;
import org.mockito.MockitoAnnotations;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.AutoConfigureMockMvc;
import org.springframework.boot.test.autoconfigure.web.servlet.WebMvcTest;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.http.MediaType;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.RequestBuilder;
import org.springframework.test.web.servlet.ResultActions;
import org.springframework.test.web.servlet.setup.MockMvcBuilders;
import org.springframework.util.MimeTypeUtils;
import org.springframework.web.context.WebApplicationContext;

import java.util.Arrays;
import java.util.List;

import static org.hamcrest.collection.IsCollectionWithSize.hasSize;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.get;

import static org.mockito.Mockito.*;

import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.*;
import static org.hamcrest.core.Is.is;

@WebMvcTest(CategoryController.class)
public class CategoryControlerServisTest {

    @Autowired
    private MockMvc mockMvc;
    @MockBean
    private ICategoryService service;
    @MockBean
    private IPostService postService;
    @MockBean
    private IUserService userService;

    @Test
    public void givenPost_whenGetPost_thenReturnJsonArray() throws Exception {
        //given
        Category cat = new Category("scifi", CategoryType.sciFi);
        List<Category> allCategory = Arrays.asList(cat);
        //when
        when(service.list()).thenReturn(allCategory);
        //expectation
        this.mockMvc.perform(get("/category"))
                .andExpect(status().isOk())
                .andExpect(content().contentType(MediaType.APPLICATION_JSON))
                .andExpect(jsonPath("$", hasSize(1)))
                .andExpect(jsonPath("$[0].name", is("scifi")));

        // verify(service, times(1)).list();
        //verifyNoMoreInteractions(service);

    }


}
