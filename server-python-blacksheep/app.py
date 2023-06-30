import platform
from blacksheep import Application

app = Application()

@app.route("/")
async def home():
    return "Hello World"

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
            "name": 'blacksheep',
            "version": '1.2.8',
        },
    }

    return data