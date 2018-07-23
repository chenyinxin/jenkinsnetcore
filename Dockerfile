FROM microsoft/aspnetcore
WORKDIR /app   
EXPOSE 80
COPY . /app
CMD ["dotnet", "jenkinsnetcore.dll"]