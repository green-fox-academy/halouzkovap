package com.example.reddit.Exception;

import java.util.ArrayList;
import java.util.List;

public class FieldErrorMessageResponse {
    private List<FieldErrorMessage> fieldErrorMessageList = new ArrayList<>();

    public List<FieldErrorMessage> getFieldErrorMessageList() {
        return fieldErrorMessageList;
    }

    public void setFieldErrorMessageList(List<FieldErrorMessage> fieldErrorMessageList) {
        this.fieldErrorMessageList = fieldErrorMessageList;
    }
}
