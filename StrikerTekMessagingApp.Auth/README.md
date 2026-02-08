# Striker Tek Messaging App Auth

## Using docker-compose (recommended)

docker-compose up -d

## Or using docker directly

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd123" -e "MSSQL_PID=Express" -p 1433:1433 --name strikertek-sqlserver -v sqlserver-data:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2025-latest

docker-compose down  # Stop and remove
docker-compose up -d # Start again

## Or

docker stop strikertek-sqlserver

docker start strikertek-sqlserver
