package com.example.todo.Contorller;

import com.example.todo.Entity.Category;
import com.example.todo.Model.CreateCategoryDTO;
import com.example.todo.Service.ICategoryService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
public class CategoryController {
    @Autowired
    ICategoryService categoryService;

    @GetMapping("/category")
    public ResponseEntity<Iterable<Category>> getAll() {
        Iterable<Category> cats = categoryService.allCategory();
        return new ResponseEntity<Iterable<Category>>(cats, HttpStatus.OK);
    }

    @PostMapping("/category")
    public ResponseEntity<Category> createCat(@RequestBody CreateCategoryDTO createCategoryDTO) {
        Category cat = categoryService.createCategory(new Category(CreateCategoryDTO.class.getName()));
        return new ResponseEntity<Category>(cat, HttpStatus.OK);
    }

    @GetMapping("/category/{id}")
    public ResponseEntity<Category> findCategory(@PathVariable int id) {
        Category cat = categoryService.findByid(id);
        return new ResponseEntity<Category>(cat, HttpStatus.OK);
    }

    @DeleteMapping("/category/{id}")
    public ResponseEntity<?> delete(@PathVariable int id){
        categoryService.deleteCategory(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
