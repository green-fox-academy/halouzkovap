package com.example.reddit.Repository;

import com.example.reddit.Entity.Category;
import com.example.reddit.Entity.Post;
import com.example.reddit.Entity.User;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public interface PostRepository extends CrudRepository<Post, Long> {

    List<Post> findByCategoryAllIgnoreCase(Category category);

    Optional<Post> findByUserAllIgnoreCase(User user);

    Post findById(int id);

    List<Post> findByCategoryNameIn(List<String> cat);

    @Query("select p from Post p where p.Name=:equal and p.category.name=:equall")
    Post queryByUserAndAndCategory(@Param("equal") String userName,
                                   @Param("equall") String categoryName);


}
