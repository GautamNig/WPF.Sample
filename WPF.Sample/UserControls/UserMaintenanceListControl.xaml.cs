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
using WPF.Sample.DataLayer;
using WPF.Sample.ViewModelLayer;

namespace WPF.Sample.UserControls
{
  /// <summary>
  /// Interaction logic for UserMaintenanceListControl.xaml
  /// </summary>
  public partial class UserMaintenanceListControl : UserControl
  {
    public UserMaintenanceListControl()
    {
      InitializeComponent();
    }

    private UserMaintenanceViewModel _viewModel;

    private void EditButton_Click(object sender, RoutedEventArgs e)
    {
      // Set selected item
      _viewModel.Entity = (User)((Button)sender).Tag;
      // Go into Edit mode
      _viewModel.BeginEdit();
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
      _viewModel = (UserMaintenanceViewModel)this.DataContext;
    }
  }
}
