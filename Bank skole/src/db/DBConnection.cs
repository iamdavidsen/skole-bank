﻿using MongoDB.Driver;

namespace Bank_skole.db
{
    public class DBConnection
    {
        public IMongoDatabase Database;
        private static DBConnection _instance;
        
        public static DBConnection Singleton
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBConnection();
                    return _instance;
                }
                else
                    return _instance;
            }
        }        
        
        public DBConnection()
        {
            Database = new MongoClient().GetDatabase("Bank");
        }
    }
}