Nếu đã cài Docker, chạy lệnh dưới để khởi tạo SQL Server Db Docker container với username: sa, password: huytuan@1995(có thể tùy chỉnh)
docker run --name sql_2019 -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=huytuan@1995" -e "MSSQL_PID=Enterprise" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
Nếu đã có Sql Server Db thì sử dụng luôn k cần cài
Sau khi đã thiết lập code first và tạo dbContext. vào tool -> Nuget Pakage Manager -> Pakage Manager Console 
và sử dụng các lệnh trong link hướng dẫn để thao tác add Migration và Update Database: https://learn.microsoft.com/en-us/ef/core/cli/powershell
Hoặc có thể sử dụng cmd theo link nếu k có có Visual Studio: https://learn.microsoft.com/en-us/ef/core/cli/dotnet
