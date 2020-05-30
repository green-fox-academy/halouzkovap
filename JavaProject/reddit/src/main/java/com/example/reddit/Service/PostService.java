package com.example.reddit.Service;

import com.example.reddit.Entity.Post;
import com.example.reddit.Repository.CategoryRepository;
import com.example.reddit.Repository.PostRepository;
import com.example.reddit.Repository.UserRepository;
import jdk.jfr.Category;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.Optional;

@Service
public class PostService implements  IPostService{


    private final PostRepository postRepository;
    private final UserRepository userRepository;
    private final CategoryRepository categoryRepository;


    public PostService(PostRepository postRepository, UserRepository userRepository, CategoryRepository categoryRepository){
        this.postRepository = postRepository;
        this.userRepository = userRepository;
        this.categoryRepository = categoryRepository;
    }


    @Override
    public Iterable<Post> findAll() {
        return postRepository.findAll();
    }

    @Override
    public Post save(Post post, int CategoryId) {
        if (categoryRepository.findById(CategoryId).isPresent()) {
            post.setCategory(categoryRepository.findById(CategoryId).get());
        }
        return postRepository.save(post);
    }

    @Override
    public Post save(Post post) {
        return postRepository.save(post);
    }


    @Override
    public void deleteById(long id) {
        postRepository.deleteById(id);
    }

    @Override
    public Optional<Post> findById(Long id) {
        return postRepository.findById(id);
    }

    @Override
    public Iterable<Post> findByCategory(Category category) {
        return postRepository.findByCategoryAllIgnoreCase((com.example.reddit.Entity.Category) category);
    }
}
