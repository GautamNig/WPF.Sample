﻿using System;
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
using WPF.Sample.ViewModelLayer;

namespace WPF.Sample.UserControls
{
  /// <summary>
  /// Interaction logic for UserMaintenanceControl.xaml
  /// </summary>
  public partial class UserMaintenanceControl : UserControl
  {
    public UserMaintenanceControl()
    {
      InitializeComponent();

      // Connect to instance of the view model created by the XAML
      _viewModel = (UserMaintenanceViewModel)this.Resources["viewModel"];
    }

    private UserMaintenanceViewModel _viewModel = null;

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
      _viewModel.Close();
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
      _viewModel.LoadUsers();
    }
  }
}
