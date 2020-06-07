package com.example.todo.Repository;

import com.example.todo.Entity.Category;
import com.example.todo.Entity.Task;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface CategoryRepository extends CrudRepository<Category, Integer> {
    Category findById(int id);
}
