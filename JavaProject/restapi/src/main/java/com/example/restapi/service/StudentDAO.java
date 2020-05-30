package com.example.restapi.service;

import com.example.restapi.entity.Student;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class StudentDAO implements IStudentDAO {

    @Autowired
    private final StudentRepository studentRepository;

    @Autowired
    IStudentDAO iStudentDAO;

    public StudentDAO(StudentRepository studentRepository){
        this.studentRepository = studentRepository;
    }
    @Override
    public boolean save(Student student) {
        studentRepository.save(student);

        return false;
    }
}
