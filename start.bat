start dotnet run -c Release --environment "Production" --project --Logging:LogLevel:Microsoft=Warning .\server-dotnet-webapi\. --urls=http://*:8111/


dotnet run -c Release --Logging:LogLevel:Microsoft=Warning --project .\server-dotnet-webapi\. --urls=http://*:8111/

start python3 .\server-python-django\app.py runserver 0.0.0.0:8211
rem python3 -m uvicorn app:app --host=0.0.0.0 --port=8221
rem python3 -m flask run --host=0.0.0.0 --port=8231

start  .\server-java-spring\mvnw spring-boot:run

start node .\server-node-express\app.js 0.0.0.0 8311
start node .\server-node-http\app.js 0.0.0.0 8321