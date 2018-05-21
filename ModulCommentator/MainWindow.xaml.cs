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
using ModulCommentator.view;
using ModulCommentatorViewModel;

namespace ModulCommentator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DozentViewModel dozentViewModel = new DozentViewModel();
            UCDozierende.Content = new DozierendeView(dozentViewModel);

            StudentViewModel studentViewModel = new StudentViewModel();
            UCStudierende.Content = new StudentView(studentViewModel);
        }
    }
}
