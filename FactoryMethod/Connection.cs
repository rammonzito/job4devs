﻿using System;

namespace FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public void ExecuteCommand(string command)
        {
            Console.WriteLine($"Executando o comando {command}");
        }
        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão Aberta");
        }

        public void Close()
        {
            Opened = false;
            Console.WriteLine("Conexão Fechada");
        }
    }
}