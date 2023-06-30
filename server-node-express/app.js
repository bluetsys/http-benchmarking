const os = require("os");
const express = require("express");

const HOST = process.argv[2];
const PORT = process.argv[3];

const app = express();

app.get("/", (req, res) => {
    res.send("Hello World");
});

app.get("/health", (req, res) => {
    var data = {
        hostname: os.hostname(),
        language: {
            name: 'node',
            version: process.version
        },
        web: {
            name: 'express',
            version: require('./node_modules/express/package.json').version 
        }
    }

    res.send(data);
});

app.listen(PORT, HOST, () => {
    console.log(`Running on http://${HOST}:${PORT}`);
});