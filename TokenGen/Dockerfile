# escape=`

#Base Image from Microsoft
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

#Enviornment Variables
ENV ASPNETCORE_HTTP_PORTS=5000
ENV ASPNETCORE_ENVIRONMENT="Development"

#set up a directory in container
WORKDIR /scr

#copy sourceCode to /src folder on container
COPY TokenGen.WebApi/ .

#restore nuget packages -- #RUN: Used to execute a command during the build process of the docker image
RUN dotnet restore

#Build the app
RUN dotnet build

#Expose Port
EXPOSE 5000

#Run the app
ENTRYPOINT [ "dotnet", "run" ]

#docker image build -t dotnettokengen .
#docker run --rm --name dotnettokengen -p 5000:5000 dotnettokengen

##Retag and push to dockerhub
#docker tag dotnettokengen jawadhasanshani/dotnettokengen
#docker push jawadhasanshani/dotnettokengen

#docker image build -t jawadhasanshani/dotnettokengen