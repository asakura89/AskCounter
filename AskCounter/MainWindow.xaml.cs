using System;
using System.Windows;

namespace AskCounter
{
    public partial class MainWindow : Window
    {
        Int32 internalCounter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            if (--internalCounter <= 0)
                internalCounter = 0;

            UpdateUI();
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            ++internalCounter;
            UpdateUI();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            internalCounter = 0;
            UpdateUI();
        }

        void UpdateUI()
        {
            TxtCounter.Text = internalCounter.ToString();
        }
    }
}
