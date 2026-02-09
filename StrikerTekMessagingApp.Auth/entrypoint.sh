
#!/bin/bash
set -e

echo "Waiting for SQL Server to be ready..."
until /opt/mssql-tools18/bin/sqlcmd -S sqlserver -U sa -P YourStrong@Passw0rd -C -Q "SELECT 1" &> /dev/null
do
  echo "SQL Server is unavailable - sleeping"
  sleep 3
done

echo "SQL Server is up - executing migrations"
/opt/mssql-tools18/bin/sqlcmd -S sqlserver -U sa -P YourStrong@Passw0rd -C -d master -i /app/init.sql

echo "Starting application"
exec dotnet StrikerTekMessagingApp.Auth.dll
```

**Or add this to .gitattributes to enforce LF:**

Create `.gitattributes` in the root directory:
```
*.sh text eol=lf