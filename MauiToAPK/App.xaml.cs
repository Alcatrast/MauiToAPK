
using MauiToAPK.Service;

namespace MauiToAPK
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            CommandSenderManager.Init();
            MainPage = new AppShell();
        }
    }
}