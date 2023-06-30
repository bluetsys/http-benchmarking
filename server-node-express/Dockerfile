FROM node

WORKDIR /app
COPY . /app

RUN npm install

EXPOSE 80
ENTRYPOINT ["node", "app.js", "0.0.0.0", "80"]