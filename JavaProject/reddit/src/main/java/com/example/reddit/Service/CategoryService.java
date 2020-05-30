package com.example.reddit.Service;

import com.example.reddit.Entity.Category;
import com.example.reddit.Repository.CategoryRepository;
import com.example.reddit.Repository.PostRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.Optional;

@Service
public class CategoryService implements ICategoryService {

    private final CategoryRepository categoryRepository;
    private final PostRepository postRepository;


    public CategoryService(CategoryRepository categoryRepository, PostRepository postRepository) {
        this.categoryRepository = categoryRepository;
        this.postRepository = postRepository;
    }

    @Override
    public void deleteById(int id) {
        categoryRepository.deleteById(id);
    }

    @Override
    public Category createCategory(Category category) {
        return categoryRepository.save(category);
    }

    @Override
    public Iterable<Category> list() {
        return categoryRepository.findAll();
    }

    @Override
    public Optional<Category> findCategory(int id) {
        return  categoryRepository.findById(id);
    }


}
