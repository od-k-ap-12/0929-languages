using System;
using System.Collections.Generic;
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

namespace _0929_languages
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
        string lang_mode = "eng";

        private void buttonChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if(lang_mode == "eng")
            {
                buttonFile.Content = "Файл";
                buttonEdit.Content = "Редагувати";
                buttonProject.Content = "Проект";
                buttonView.Content = "Вид";
                buttonBuild.Content = "Збірка";
                lang_mode = "ukr";
                language.Source = new BitmapImage(new Uri("/images/ukraine.png", UriKind.Relative));
            }
            else if (lang_mode == "ukr")
            {
                buttonFile.Content = "File";
                buttonEdit.Content = "Edit";
                buttonProject.Content = "Project";
                buttonView.Content = "View";
                buttonBuild.Content = "Build";
                lang_mode = "eng";
                language.Source = new BitmapImage(new Uri("/images/usa.png", UriKind.Relative));
            }
        }
    }
}
