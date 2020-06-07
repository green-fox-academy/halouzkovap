package com.example.reddit.EmailTest;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class SendMessageTest {
    private EmailSendGridTestDouble emailDouble;

    @BeforeEach
    void init() {
        emailDouble = new EmailSendGridTestDouble();
    }

}
