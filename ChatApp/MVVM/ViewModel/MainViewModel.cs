using System;


namespace ChatApp.MVVM.ViewModel
{
    public class MainViewModel
    {
        public RelayCommand ConnectToServerCommand { get; set; }

        private Server _server;
        public string  Username { get; set; }

        public MainViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer(Username), o => !String.IsNullOrEmpty(Username));
        }
    }

}
