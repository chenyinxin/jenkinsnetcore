FROM microsoft/dotnet:2.1-sdk
WORKDIR /app   
EXPOSE 80
COPY . /app
CMD ["dotnet", "jenkinsnetcore.dll"]