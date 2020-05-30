package com.example.reddit.Controller;

import com.example.reddit.Entity.Category;
import com.example.reddit.Model.CategoryDtoForCreation;
import com.example.reddit.Service.ICategoryService;
import com.example.reddit.Service.IPostService;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class CategoryController {
    private final ICategoryService categoryService;
    private final IPostService postService;

    public CategoryController(IPostService postService, ICategoryService categoryService) {
        this.categoryService = categoryService;
        this.postService = postService;
    }



    @GetMapping("/category")
    public ResponseEntity<Iterable<Category>> allC() {
        return ResponseEntity.ok(categoryService.list());
    }

    @PostMapping("/category")
    public Category create(@Validated @RequestBody CategoryDtoForCreation categoryDtoForCreation) {
        Category category = new Category(categoryDtoForCreation.getName(), categoryDtoForCreation.getCt());
        return categoryService.createCategory(category);
    }
}
