package com.example.reddit.ControllerRestTemplateTest;

import javax.validation.ConstraintViolation;
import javax.validation.ConstraintViolationException;
import javax.validation.ValidationException;

import com.example.reddit.Exception.ErrorMessage;
import com.example.reddit.Exception.FieldErrorMessage;
import com.example.reddit.Exception.FieldErrorMessageResponse;
import org.springframework.http.HttpStatus;
import org.springframework.validation.FieldError;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ControllerAdvice;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.ResponseStatus;

@ControllerAdvice
public class ControllerExceptionHandler {

    @ResponseStatus(HttpStatus.BAD_REQUEST)
    @ExceptionHandler(ValidationException.class)
    @ResponseBody()
    ErrorMessage exceptionHandler(ValidationException e) {
        return new ErrorMessage("400", e.getMessage());
    }


    @ExceptionHandler(ConstraintViolationException.class)
    @ResponseStatus(HttpStatus.BAD_REQUEST)
    @ResponseBody
    FieldErrorMessageResponse onConstraintValidationException(ConstraintViolationException e) {
        FieldErrorMessageResponse error = new FieldErrorMessageResponse();

        for (ConstraintViolation violation : e.getConstraintViolations()) {
            error.getFieldErrorMessageList().add(new FieldErrorMessage(violation.getPropertyPath().toString(), violation.getMessage()));
        }
        return error;
    }

    @ExceptionHandler(MethodArgumentNotValidException.class)
    @ResponseStatus(HttpStatus.BAD_REQUEST)
    @ResponseBody
    FieldErrorMessageResponse onMethodArgumentNotValidException(MethodArgumentNotValidException e) {
        FieldErrorMessageResponse error = new FieldErrorMessageResponse();
        for (FieldError fieldError : e.getBindingResult().getFieldErrors()) {
            error.getFieldErrorMessageList().add(new FieldErrorMessage(fieldError.getField(), fieldError.getDefaultMessage()));
        }
        return error;
    }
}
