package com.example.demo;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.net.InetAddress;

@RestController
public class TestController {

    @GetMapping(value = "/")
    public String testApi() {
        return "Hello World";
    }

    @GetMapping(value = "/health")
    public String healthApi() {

        String hostName = "";

        if(hostName == null || hostName.isEmpty()) {
			try {
				InetAddress addr = InetAddress.getLocalHost();
				hostName = addr.getHostName();
			} catch (Exception e) {
				System.err.println(e);
				hostName = "Unknow";
			}
		}

        String c = String.format("""
            {\"hostname\":\"%s\",\"language\":{\"name\":\"java\",\"version\":\"%s\"},\"web\":{\"name\":\"spring\",\"version\":\"%s\"}}
            """, hostName, System.getProperty("java.version"), org.springframework.core.SpringVersion.getVersion());

        return c;
    }
}