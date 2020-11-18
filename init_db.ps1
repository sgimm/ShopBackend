$server = 'localhost';
$sa_user = 'sa';
$password = 'M@ster99';
$db = 'master';
$dbs = @('db766617469', 'db809881418');
$dbICS = '';
$connection = New-Object Data.SqlClient.SqlConnection;

$connectionString = "Server=$server;User=$sa_user;database=$db;Password=M@ster99";

for($i=0;$i -lt $dbs.Length; $i++)
{
    $result = 0;
    Write-Host $dbs[$i];
    $temp = $dbs[$i];
    $sqlQuery = "SELECT name FROM sys.databases WHERE name = '$temp'";
    $sqlCreateDbCommand = "CREATE DATABASE [$temp]";
    Write-Host $sqlQuery;
    Write-Host $sqlCreateDbCommand;

    $sqlCommand = New-Object Data.SqlClient.SqlCommand $sqlQuery, $connection;
    $sqlCommand2 = New-Object Data.SqlClient.SqlCommand $sqlCreateDbCommand, $connection;

    $connection.ConnectionString = $connectionString;
    $connection.Open();

    $rd = $sqlCommand.ExecuteReader();
    if($rd.HasRows)
    {
        $result = 0;
    }
    else
    {
    
        $result = 1;
    }

    $connection.Close();


    if($result -gt 0)
    {
        $connection.Open();
        $sqlCommand2.ExecuteNonQuery();
        $connection.Close();
    }
}