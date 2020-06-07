package com.example.reddit.Controller;

import com.example.reddit.Model.ResponsPostDto;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.web.client.TestRestTemplate;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;

import static org.junit.jupiter.api.Assertions.*;


@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
public class PostControllerTest {
    @Autowired
    private TestRestTemplate restTemplate;
    private static final String URL = "http://localhost:8080/posts";

    @Test
    public void testGetCategory() throws Exception {
        //Execute
        ResponseEntity<ResponsPostDto> responseEntity = restTemplate.getForEntity(URL + "/13", ResponsPostDto.class);
        //collect data
        int status = responseEntity.getStatusCodeValue();
        ResponsPostDto responsPostDto = responseEntity.getBody();
        //verify an ok status is return
        //   assertEquals("Correct Response Status", HttpStatus.OK.value(),status);
        assertEquals(200, status);
        assertNotNull(responsPostDto);
    }
}
