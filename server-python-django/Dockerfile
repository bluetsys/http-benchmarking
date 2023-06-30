FROM wymoon2690/python-mecab-ko

WORKDIR /app
COPY . /app

RUN pip install --no-cache-dir --upgrade -r requirements.txt

EXPOSE 80
ENTRYPOINT ["python3", "app.py", "runserver", "0.0.0.0:80"]