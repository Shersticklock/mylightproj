FROM python:3

# copy our application code
ADD docker.tar /c/docker
WORKDIR /c/docker

# fetch app specific deps
RUN pip install -r requirements.txt

# expose port
EXPOSE 5000

# start app
RUN chmod 644 rest_service.py
CMD [ "python", "./rest_service.py" ]