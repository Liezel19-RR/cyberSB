using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cyber_security_bottttt
{
    public partial class MainWindow : Window
    {
        ChatBot bot = new ChatBot();
        TypingEffect typer = new TypingEffect();
        VoicePlayer voice = new VoicePlayer();

        public MainWindow()
        {
            InitializeComponent();

            voice.PlayVoice();
        }
        private async void StartChat_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            ChatBox.Clear();

            await typer.Type(
                ChatBox,
                $"Hello {txtName.Text}! Welcome to Cyber Security Chatbot 🤖"
            );
        }

        private async void AskBot_Click(object sender, RoutedEventArgs e)
        {
            if (MenuBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a topic.");
                return;
            }

            ComboBoxItem item = (ComboBoxItem)MenuBox.SelectedItem;
            string question = item.Content.ToString();

            ChatBox.AppendText("YOU: " + question + "\n");

            string response = bot.GetResponse(question);

            ChatBox.AppendText("BOT: ");

            await typer.Type(ChatBox, response);

            if (question.ToLower() == "exit")
            {
                Application.Current.Shutdown();
            }
        }
    }


    }
    
