FROM microsoft/dotnet:2.1-sdk
WORKDIR /app   
EXPOSE 8080
COPY . /app
CMD ["dotnet", "jenkinsnetcore.dll"]