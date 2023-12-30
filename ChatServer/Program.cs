﻿using System.Net.Sockets;
using System.Net;
namespace ChatServer
{
     class Program
    {


        static List<Client> _users;
        static TcpListener _listener;

        static void Main(string[] args)
        {


            _users = new List<Client>();
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7891);
            _listener.Start();


            // It is blocking statement once the client has connected then only the below console command will run
            while (true)
            {
                var client = new Client(_listener.AcceptTcpClient());
                _users.Add(client);
            }
            //** Broadcast the message to clients

        }
    }
}