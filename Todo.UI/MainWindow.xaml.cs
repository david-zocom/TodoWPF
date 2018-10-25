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

namespace Todo.UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private ViewModel.MainViewModel ViewModel;

		public MainWindow(ViewModel.MainViewModel viewModel)
		{
			InitializeComponent();
			ViewModel = viewModel;
			DataContext = viewModel;
			
		}


		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			ViewModel.Load();
		}
		private void Grid_Loaded(object sender, RoutedEventArgs e)
		{

		}
	}
}
