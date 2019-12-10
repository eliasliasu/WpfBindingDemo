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

namespace WpfBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public string AuthorName
        {
            get { return (string)GetValue(AuthorNameProperty); }
            set { SetValue(AuthorNameProperty, value); }
        }



        public string BookName
        {
            get { return (string)GetValue(BookNameProperty); }
            set { SetValue(BookNameProperty, value); }
        }



        public string PublishedDate
        {
            get { return (string)GetValue(PublishedDateProperty); }
            set { SetValue(PublishedDateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PublishedDate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PublishedDateProperty =
            DependencyProperty.Register("PublishedDate", typeof(string),
                typeof(MainWindow), new PropertyMetadata("2019"));

        // Using a DependencyProperty as the backing store for BookName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BookNameProperty =
            DependencyProperty.Register("BookName", typeof(string),
                typeof(MainWindow), new PropertyMetadata("Data Binding"));

        // Using a DependencyProperty as the backing store for AuthorName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AuthorNameProperty =
            DependencyProperty.Register("AuthorName", typeof(string), 
                typeof(MainWindow), new PropertyMetadata("Elias Liasu"));


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
