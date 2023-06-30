import platform
import fastapi

from typing import Union
from fastapi import FastAPI, Response, Request

app = FastAPI()

@app.get("/")
async def read_root():
    return Response(content='Hello World')

@app.get("/health")
def read_health():
    data = {
        "hostname":  platform.node(),
        "language":
        {
            "name": 'python',
            "version": platform.python_version(),
        },
        "web":
        {
            "name": 'fastapi',
            "version": fastapi.__version__,
        },
    }
    return data