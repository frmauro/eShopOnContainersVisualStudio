# Containerized eShop - Catalog Service
Sample reference containerized application, cross-platform and microservices architecture.

# command docker run to sql server
 docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Pass@word" -p 1433:1433 --name sqldata  -d mcr.microsoft.com/mssql/server:2019-latest

# command docker run to rabbitmq
docker run -d --name rabbitmq  -p 15672:15672 -p 5672:5672 rabbitmq:3-management-alpine

