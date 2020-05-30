package com.example.reddit.Service;

import com.example.reddit.Entity.Category;

import java.util.Optional;

public interface ICategoryService {

    void deleteById(int id);
    public Category createCategory(Category category);
    public Iterable<Category> list();
    Optional<Category> findCategory(int id);
}
