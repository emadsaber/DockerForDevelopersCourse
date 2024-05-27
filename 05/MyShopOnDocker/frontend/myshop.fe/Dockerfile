FROM node:current-alpine3.19 AS build
WORKDIR /app

COPY . .
RUN npm install
RUN npm run build:prod

# Serve Application using Nginx Server
FROM nginx:alpine AS publish
COPY --from=build /app/dist/myshop.fe/ /usr/share/nginx/html
EXPOSE 80