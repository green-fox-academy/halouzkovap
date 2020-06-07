package com.example.reddit.ControllerRestTemplateTest;

import com.example.reddit.Entity.Category;
import com.example.reddit.Entity.User;
import com.example.reddit.Model.CategoryDtoForCreation;
import com.example.reddit.Model.ResponseUserDto;
import com.example.reddit.Model.UserDtoCreation;
import com.example.reddit.Service.ICategoryService;
import com.example.reddit.Service.IPostService;
import com.example.reddit.Service.IUserService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import javax.xml.bind.ValidationException;
import java.util.Optional;

@RestController
public class CategoryController {

    private final ICategoryService categoryService;
    private final IPostService postService;
    private final IUserService userService;

    public CategoryController(IPostService postService, ICategoryService categoryService, IUserService userService) {
        this.categoryService = categoryService;
        this.postService = postService;
        this.userService = userService;
    }

    @GetMapping("/category")
    public ResponseEntity<Iterable<Category>> all() {
        return ResponseEntity.ok(categoryService.list());
    }

    @PostMapping("/category")
    public Category create(@Validated @RequestBody CategoryDtoForCreation categoryDtoForCreation) {
        Category category = new Category(categoryDtoForCreation.getName(), categoryDtoForCreation.getCt());
        return categoryService.createCategory(category);
    }

    @GetMapping("/user")
    public Iterable<User> list() {
        return userService.list();
    }

    @GetMapping("/user/{id}")
    public ResponseEntity<Optional<User>> oneUser(@PathVariable int id) {

        return new ResponseEntity<Optional<User>>(userService.findUser(id), HttpStatus.OK);
    }


    @PostMapping("/user")
    ResponseEntity<ResponseUserDto> create(@RequestBody UserDtoCreation udc) throws ValidationException {
        if (udc.getUserName() != null && udc.getEmail() != null && udc.getPassword() != null) {
            User u = new User(udc.getUserName(), udc.getEmail(), udc.getPassword());
            userService.Create(u);
            return new ResponseEntity<ResponseUserDto>(new ResponseUserDto(u.getUserName(), u.getEmail()), HttpStatus.OK);
        } else throw new ValidationException("User cannot be created");

    }


    @DeleteMapping("/user/{id}")
    public ResponseEntity delet(@PathVariable int id) {
        if (userService.findUser(id).isPresent()) {
            userService.deleteUser(id);
            return new ResponseEntity(HttpStatus.OK);
        } else {
            return new ResponseEntity(HttpStatus.BAD_REQUEST);
        }


    }
}
