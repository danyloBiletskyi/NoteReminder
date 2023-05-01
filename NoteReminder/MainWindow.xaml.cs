using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace NoteReminder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //Функція для кнопки (додає елемент нагадування при натисканні)

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Notifications notification = new Notifications();
            notificationsList.Items.Add(notification);
            notificationsList.SelectedItem= notification;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            notificationsList.Items.Remove(notificationsList.Items[notificationsList.SelectedIndex]); //Не працює якщо багато треба видаляти
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            notifPropGrid.Children.Clear();
            this.notificationsList.Items.Clear();
        }

        private void notificationsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Notifications selectedNotif = notificationsList.SelectedItem as Notifications;
            if (selectedNotif != null)
            {

            }
        }
    }

}