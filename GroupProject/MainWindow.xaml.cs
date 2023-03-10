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

namespace GroupProject
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

        private void Async_Sequential_Click(object sender, RoutedEventArgs e)
        {
            txtBubbleSort.Text = "1";
            txtSelectionSort.Text = "1";
            txtMergeSort.Text = "1";
            txtQuickSort.Text = "1";
            txtShellSort.Text = "1";
        }

        private void Async_Parallel_Click(object sender, RoutedEventArgs e)
        {
            txtBubbleSort.Text = "2";
            txtSelectionSort.Text = "2";
            txtMergeSort.Text = "2";
            txtQuickSort.Text = "2";
            txtShellSort.Text = "2";
        }

        private void Sync_Sequential_Click(object sender, RoutedEventArgs e)
        {
            txtBubbleSort.Text = "3";
            txtSelectionSort.Text = "3";
            txtMergeSort.Text = "3";
            txtQuickSort.Text = "3";
            txtShellSort.Text = "3";
        }

        private void Sync_Parallel_Click(object sender, RoutedEventArgs e)
        {
            txtBubbleSort.Text = "4";
            txtSelectionSort.Text = "4";
            txtMergeSort.Text = "4";
            txtQuickSort.Text = "4";
            txtShellSort.Text = "4";
        }
    }
}
