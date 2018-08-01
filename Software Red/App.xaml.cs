using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Software_Red
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Login f1 = new Login();
        public Main f2 = new Main();
        public Warn f3 = new Warn();
        public App()
        {
            InitializeComponent();
            if (f1.DialogResult.HasValue && f1.DialogResult.Value)
                MessageBox.Show("");
        }
    }
}
