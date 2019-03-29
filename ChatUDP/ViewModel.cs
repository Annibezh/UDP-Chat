using ChatUDP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChatUDP
{
    class ViewModel : INotifyPropertyChanged
    {
        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<MSG> Messages { get; set; }
        Chat chat;
        public string Message { get; set; }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                Notify("Name");
            }
        }

        bool isEnabled;
        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                isEnabled = value;
                Notify("IsEnabled");
            }
        }
        bool isEnabledBtn;
        public bool IsEnabledBtn
        {
            get
            {
                return isEnabledBtn;
            }
            set
            {
                isEnabledBtn = value;
                Notify("IsEnabledBtn");
            }
        }

        public ICommand Send { get; }
        public ICommand Join { get; }
        public ICommand Exit { get; }
        bool isActive = false;
        public ViewModel()
        {
            chat = new Chat();
            IsEnabled = true;
            IsEnabledBtn = true;
            Name = "Anonimous";
            Messages = new ObservableCollection<MSG>();
            if (String.IsNullOrWhiteSpace(Name))
                MessageBox.Show("Enter your Name!");
            else
            {
                Join = new RelayCommand(x =>
                {
                    isActive = true;
                    IsEnabled = false;
                    IsEnabledBtn = false;
                    chat.Send($"{Name} joined the CHAT", isActive);
                });
                if (Message != "")
                {
                    string time = DateTime.Now.ToLongTimeString();
                    Send = new RelayCommand(x => chat.Send($"{time}\t{Name}: {Message}", isActive));
                }
                else
                    MessageBox.Show("Enter Message!");
                Exit = new RelayCommand(x =>
                {
                    chat.Send($"{Name} left the CHAT", isActive);
                    isActive = false;
                });
            }
            Listen();

        }
        public async void Listen()
        {
            while (true)
            {
                MSG obj = await chat.Receive();
                Messages.Add(obj);
            }
        }
    }
}
