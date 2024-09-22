﻿namespace WindowsFormsNetCore.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DesktopBridge.Helpers helpers = new DesktopBridge.Helpers();
            bool isUwp = helpers.IsRunningAsUwp();
            string text = isUwp ? "The app is running as a Universal Windows Package" : "The app is running as a native Win32 app";
            txtStatus.Text = text;
        }
    }
}
