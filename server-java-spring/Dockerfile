FROM openjdk

WORKDIR /app
COPY /target/demo-*.jar app.jar

EXPOSE 80

ENTRYPOINT ["java", "-jar", "app.jar", "--server.port=80"]