package com.example.reddit.Controller;

import com.example.reddit.Entity.Category;
import com.example.reddit.Entity.CategoryType;
import com.example.reddit.Entity.Post;
import com.example.reddit.Model.CategoryDtoForCreation;
import com.example.reddit.Model.PostDtoForCreation;
import com.example.reddit.Model.PostDtoForUpdate;
import com.example.reddit.Model.ResponsPostDto;
import com.example.reddit.Service.CategoryService;
import com.example.reddit.Service.ICategoryService;
import com.example.reddit.Service.IPostService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.Optional;

@RestController
public class PostController {


    private final ICategoryService categoryService;
    private final IPostService postService;

    public PostController(IPostService postService, ICategoryService categoryService) {
        this.categoryService = categoryService;
        this.postService = postService;
    }


    @GetMapping("/posts")
    public ResponseEntity<Iterable<Post>> all() {
        return ResponseEntity.ok(postService.findAll());
    }

    @GetMapping("/posts/{id}")
    public Optional<Post> onePost(@PathVariable long id) {
        return (postService.findById(id));
    }

    @PostMapping("/posts")
    public ResponsPostDto create(@Validated @RequestBody PostDtoForCreation postDtoForCreation) {

        Post p1 = new Post(postDtoForCreation.name, postDtoForCreation.url);
        postService.save(p1, postDtoForCreation.categoryId);
        ResponsPostDto rpd = new ResponsPostDto(p1.getName(), p1.getUrl(),p1.getCategory().getName());
        return rpd;
    }


    @PutMapping("/posts/{id}")
    Optional<Post> replacePost(@Validated @RequestBody PostDtoForUpdate postDtoForUpdate, @PathVariable Long id) {

        return postService.findById(id)
                .map(post -> {
                    post.setName(postDtoForUpdate.name);
                    post.setUrl(postDtoForUpdate.url);
                    return postService.save(post, postDtoForUpdate.categoryId);
                });

    }

    @DeleteMapping("/posts/{id}")
    void deletePost(@PathVariable Long id) {
        postService.deleteById(id);
    }

}
