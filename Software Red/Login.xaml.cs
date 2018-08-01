using DbToDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Software_Red
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        HashSet<Client> h = new HashSet<Client>();
        bool open = false;
        Main f2 = new Main();

        public Login()
        {
            InitializeComponent();
            h.Add(new Client { ID = "root", PSW = "toor" });
            h.Add(new Client { ID = "Lucien", PSW = "abc123" });
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in h)
            {
                if (item.ID == ID.Text)
                {
                    if (item.PSW == PSW.Text)
                    {
                        f2.ShowDialog();
                        open = true;
                        this.Hide();
                        if (f2.DialogResult.HasValue && f2.DialogResult.Value)
                            MessageBox.Show("Ok");
                        else
                            this.Close();
                    }
                    
                }
            }
            if (!open)
            {
                checklog.Text = "ID or password is wrong !";
                checklog.Foreground = Brushes.DarkRed;
            }
        }

        private void ID_GotFocus(object sender, RoutedEventArgs e)
        {
            if(PSW.Text == "")
            {
                PSW.Text = "Password";
                ID.Text = "";
            }
            else
                ID.Text = "";
        }

        private void PSW_GotFocus(object sender, RoutedEventArgs e)
        {
            if(ID.Text == "")
            {
                ID.Text = "ID";
                PSW.Text = "";
            }
            else
                PSW.Text = "";
        }

        

    }
}
