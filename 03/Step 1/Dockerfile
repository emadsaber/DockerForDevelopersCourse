# Select your image
FROM nginx:latest

# copy files to the image 
COPY . /usr/share/nginx/html

# expose the http port from inside the container
EXPOSE 80

# run Nginx to serve your files
CMD ["nginx", "-g", "daemon off;"]
