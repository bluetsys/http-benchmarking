const os = require("os");
const http = require('http');

const HOST = process.argv[2];
const PORT = process.argv[3];

const app = require('http');

console.log(`Running on http://${HOST}:${PORT}`);

http.createServer((req, res) => {
  // console.log(req.url)
  if (req.url === '/') {
    res.end('Hello World');
  } else if (req.url === '/health') {
    var data = {
      hostname: os.hostname(),
      language: {
        name: 'node',
        version: process.version
      },
      web: {
        name: 'http',
        version: process.version
      }
    }
    res.end(JSON.stringify(data));
  }
}).listen(PORT);