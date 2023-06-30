docker build -t wymoon2690/dotnet-webapi ./server-dotnet-webapi/.
docker push wymoon2690/dotnet-webapi

docker build -t wymoon2690/python-django ./server-python-django/.
docker push wymoon2690/python-django

docker build -t wymoon2690/python-fastapi ./server-python-fastapi/.
docker push wymoon2690/python-fastapi

docker build -t wymoon2690/python-flask ./server-python-flask/.
docker push wymoon2690/python-flask

docker build -t wymoon2690/node-express ./server-node-express/.
docker push wymoon2690/node-express

docker build -t wymoon2690/node-http ./server-node-http/.
docker push wymoon2690/node-http

docker build -t wymoon2690/java-spring ./server-java-spring/.
docker push wymoon2690/java-spring