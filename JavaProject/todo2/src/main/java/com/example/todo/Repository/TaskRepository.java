package com.example.todo.Repository;

import com.example.todo.Entity.Task;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface TaskRepository extends CrudRepository<Task,Integer> {
    Task findById(int id);
    List<Task> findByCategoryNameIn(List<String> cat);

}
