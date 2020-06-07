package com.example.todo.Service;

import com.example.todo.Entity.Category;

public interface ICategoryService {
    Category findByid(int id);

    Category createCategory(Category category);

    Iterable<Category> allCategory();

    void deleteCategory(int id);
}
