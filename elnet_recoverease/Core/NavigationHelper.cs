using System;
using System.Windows.Forms;

namespace elnet_recoverease.Core
{
    public static class NavigationHelper
    {
        public static void WireNavButton(Panel pnl, Action action)
        {
            pnl.Tag = action;
            pnl.Click += new EventHandler(NavAction_Click);
            foreach (Control ctrl in pnl.Controls)
            {
                ctrl.Tag = action;
                ctrl.Click += new EventHandler(NavAction_Click);
                if (ctrl is Panel childPnl) WireNavButton(childPnl, action);
            }
        }

        private static void NavAction_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl.Tag is Action action)
            {
                action();
            }
        }

        public static void WireNavButton(Panel pnl, EventHandler handler)
        {
            pnl.Click += handler;
            foreach (Control ctrl in pnl.Controls)
            {
                // We want clicking the control to fire the panel's handler but passing the panel as sender
                // We use a wrapper to handle this without lambdas
                var wrapper = new NavHandlerWrapper(pnl, handler);
                ctrl.Tag = wrapper;
                ctrl.Click += new EventHandler(NavHandler_Click);
                
                if (ctrl is Panel childPnl) WireNavButton(childPnl, handler);
            }
        }

        private static void NavHandler_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl.Tag is NavHandlerWrapper wrapper)
            {
                wrapper.Handler(wrapper.Panel, e);
            }
        }

        private class NavHandlerWrapper
        {
            public Panel Panel { get; }
            public EventHandler Handler { get; }
            public NavHandlerWrapper(Panel p, EventHandler h) { Panel = p; Handler = h; }
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
            target.FormClosed += new FormClosedEventHandler(TargetForm_Closed);
        }

        private static void TargetForm_Closed(object? sender, FormClosedEventArgs e)
        {
            // If the main window is closed, we should exit the application.
            // Since we Hide the Login form instead of closing it, we must explicitly exit.
            Application.Exit();
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
