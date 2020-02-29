package com.microsoft.demo.demoproject.controllers;

import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;


@RestController
public class HelloController{
    @RequestMapping(value="/")
    public String Index() {
        return "Greetings from Spring Boot";
    }
    
}