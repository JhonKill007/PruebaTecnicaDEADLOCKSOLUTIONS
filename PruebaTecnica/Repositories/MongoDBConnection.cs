
using MongoDB.Driver;
using System;

public class MongoDBConnection
{
    public MongoClient client;
    public IMongoDatabase db;
    public readonly string _connectionString;
    private readonly string _databaseName;

    public MongoDBConnection(string connectionString)
    {
        _connectionString = connectionString;
        _databaseName = "PruevaTecnica";
        GetConnection();
    }

    public void GetConnection()
    {
        client = new MongoClient(_connectionString);
        db = client.GetDatabase(_databaseName);
    }
}