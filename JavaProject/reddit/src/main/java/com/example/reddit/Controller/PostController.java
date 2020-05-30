package com.example.reddit.Controller;

import com.example.reddit.Entity.Post;
import com.example.reddit.Exception.ApplicationNotFoundException;
import com.example.reddit.Model.PostDtoForCreation;
import com.example.reddit.Model.PostDtoForUpdate;
import com.example.reddit.Model.ResponsPostDto;
import com.example.reddit.Service.ICategoryService;
import com.example.reddit.Service.IPostService;
import lombok.var;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

@RestController
public class PostController {


    private final ICategoryService categoryService;
    private final IPostService postService;

    public PostController(IPostService postService, ICategoryService categoryService) {
        this.categoryService = categoryService;
        this.postService = postService;
    }


    @GetMapping("/posts")
    public ResponseEntity<Iterable<ResponsPostDto>> all() {
        Iterable<Post> list = postService.findAll();
        Iterable<ResponsPostDto> rList = null;
      
        return new ResponseEntity<Iterable<ResponsPostDto>>(rList, HttpStatus.OK);
    }

    @GetMapping("/posts/{id}")
    public ResponseEntity<ResponsPostDto> onePost(@PathVariable long id) {
        try {
            Post p1 = postService.findById(id);
            ResponsPostDto rp1 = new ResponsPostDto(p1.getName(),p1.getUrl(),p1.getCategory().getName());
            return new ResponseEntity<ResponsPostDto>(rp1, HttpStatus.OK);
        } catch (ApplicationNotFoundException exception) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "ID Not Found");
        }
    }

    @PostMapping("/posts")
    public ResponsPostDto create(@Validated @RequestBody PostDtoForCreation postDtoForCreation) {

        Post p1 = new Post(postDtoForCreation.name, postDtoForCreation.url);
        postService.save(p1, postDtoForCreation.categoryId);
        ResponsPostDto rpd = new ResponsPostDto(p1.getName(), p1.getUrl(), p1.getCategory().getName());
        return rpd;
    }


    @PutMapping("/posts/{id}")
    public ResponseEntity<ResponsPostDto> updatePost(@RequestBody PostDtoForUpdate postDtoForUpdate, @PathVariable Long id) {
        try {
            postService.findId(id)
                    .map(post -> {
                        post.setName(postDtoForUpdate.name);
                        post.setUrl(postDtoForUpdate.url);
                        postService.save(post, postDtoForUpdate.categoryId);
                        return null;
                    });
            Post post = postService.findById( id);
            return new ResponseEntity<ResponsPostDto>(new ResponsPostDto(post.getName(), post.getUrl(), post.getCategory().getName()), HttpStatus.OK);

        } catch (ApplicationNotFoundException exception) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "ID Not Found");
        }
    }

    @DeleteMapping("/posts/{id}")
    void deletePost(@PathVariable Long id) {
        postService.deleteById(id);
    }

}
