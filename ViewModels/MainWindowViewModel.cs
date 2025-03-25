using System;
using System.Diagnostics;
using System.Windows.Input;
using ReactiveUI;

namespace Xoul_s_Era.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand StartGameCommand { get; }
        public ICommand OpenGitHubCommand { get; }
        public ICommand OpenWebsiteCommand { get; }
        public ICommand OpenFacebookCommand { get; }
        public ICommand OpenDiscordCommand { get; }

        public MainWindowViewModel()
        {
            StartGameCommand = ReactiveCommand.Create(StartGame);
            OpenGitHubCommand = ReactiveCommand.Create(() => OpenLink("https://github.com/NhomNhem/FiniteStateMachineUnity"));
            OpenWebsiteCommand = ReactiveCommand.Create(() => OpenLink("https://www.nhomtoongtenz.shop/"));
            OpenFacebookCommand = ReactiveCommand.Create(() => OpenLink("https://www.facebook.com/hien.nguyen.1608/"));
            OpenDiscordCommand = ReactiveCommand.Create(() => OpenLink("https://discord.gg/xucFydTg"));
        }

        private void StartGame()
        {
            // Mở game (chỉnh đường dẫn file game.exe nếu cần)
            OpenLink("file:///C:/Path/To/Your/Game.exe");
        }

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi mở link: {ex.Message}");
            }
        }
    }
}
