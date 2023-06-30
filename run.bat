docker run -d --pull=always -p 8110:80 --name dotnet-webapi wymoon2690/dotnet-webapi

docker run -d --pull=always -p 8210:80 --name python-django wymoon2690/python-django
docker run -d --pull=always -p 8220:80 --name python-fastapi wymoon2690/python-fastapi
docker run -d --pull=always -p 8230:80 --name python-flask wymoon2690/python-flask

docker run -d --pull=always -p 8310:80 --name node-express wymoon2690/node-express
docker run -d --pull=always -p 8320:80 --name node-http wymoon2690/node-http

docker run -d --pull=always -p 8410:8080 --name java-spring wymoon2690/server-java-spring
docker run -d -p 8410:8080 --name java-spring wymoon2690/server-java-spring

