using System;
using System.Net.Sockets;

public class Server
{
	TcpClient _client;
	public Server()
	{
		_client = new TcpClient();
	}
	public void ConnectToServer(string UserName)
	{
		if(!_client.Connected)
		{
			_client.Connect("127.0.0.1", 7891);
		}
	}
}
