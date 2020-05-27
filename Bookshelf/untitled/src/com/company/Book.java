package com.company;

import lombok.AccessLevel;
import lombok.Getter;
import lombok.Setter;

public class Book {
    @Getter
    @Setter
    String title;
    @Getter
    @Setter
    String author;
    @Getter
    @Setter
    int releaseYear;
    @Getter
    @Setter
    boolean isHardCover;
    @Getter
    int numberOfPages;
    @Getter
    private int weight;


}
