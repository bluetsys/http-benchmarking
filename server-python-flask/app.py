import platform
import flask

from flask import Flask, request
app = Flask(__name__)

@app.route("/")
async def hello():
    return 'Hello World'

@app.route("/health")
def health():
    data = {
        "hostname":  platform.node(),
        "language":
        {
            "name": 'python',
            "version": platform.python_version(),
        },
        "web":
        {
            "name": 'flask',
            "version": flask.__version__,
        },
    }

    return data