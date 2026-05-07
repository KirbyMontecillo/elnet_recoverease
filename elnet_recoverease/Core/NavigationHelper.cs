using System;
using System.Windows.Forms;

namespace elnet_recoverease.Core
{
    public static class NavigationHelper
    {
        public static void WireNavButton(Panel pnl, Action action)
        {
            pnl.Click += (s, e) => action();
            foreach (Control ctrl in pnl.Controls)
            {
                ctrl.Click += (s, e) => action();
                if (ctrl is Panel childPnl) WireNavButton(childPnl, action);
            }
        }

        public static void SwitchForm(Form current, Form target)
        {
            target.Show();
            if (current is Login) 
            {
                current.Hide();
            }
            else 
            {
                current.Close();
            }
            
            // Handle target form closure to exit application if it's the only one left
            target.FormClosed += (s, e) => {
                if (Application.OpenForms.Count == 0 || (Application.OpenForms.Count == 1 && Application.OpenForms[0] is Login))
                {
                    // Logic to exit or show login
                }
            };
        }

        public static void Logout(Form current)
        {
            UserSession.Logout();
            Login login = new Login();
            login.Show();
            current.Hide();
        }
    }
}
