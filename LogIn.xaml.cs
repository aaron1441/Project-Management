using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ClassMate1;
 
 

namespace ClassMate1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        
        public LogIn()
        {
            InitializeComponent();
            
        }

        private async void BtnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());

        }

        private async void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }

        private async void BtnSignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        private async void BtnLogIn_Clicked(object sender, EventArgs e)
        {
            MyCode user = new MyCode();
            string email;
            string password;
            int check = 0;

            email = EntUName.Text;
            password = EntPassword.Text;
            user = user.CurrUser();
            
            check = user.CheckDetails(email, password);
            if (check == 1)
            {
                await Navigation.PushAsync(new Student());
            }
        }
    }
}