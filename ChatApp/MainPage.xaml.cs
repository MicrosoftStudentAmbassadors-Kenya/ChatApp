using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using ChatApp.Model;

namespace ChatApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {

            if (EmailEntry.Text == null || PasswordEntry.Text == null)
           { 
            
            
            }
            else
            {
                User usr = new User()
                {
                    username = EmailEntry.Text
                };

                SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
                conn.CreateTable<User>();
                conn.Insert(usr);
                conn.Close();

                Navigation.PushAsync(new HomePage());
            }
            
        }
    }
}
