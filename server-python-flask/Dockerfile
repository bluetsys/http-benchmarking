FROM wymoon2690/python-mecab-ko

WORKDIR /app
COPY . /app

RUN pip install --no-cache-dir --upgrade -r requirements.txt
#RUN pip install -U Flask

EXPOSE 80
ENTRYPOINT ["python3", "-m", "flask", "run", "--host=0.0.0.0", "--port=80"]