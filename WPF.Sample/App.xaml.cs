﻿using System;
using System.Windows;

namespace WPF.Sample
{
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      // Set the DataDirectory for Entity Framework
      string path = Environment.CurrentDirectory;
      path = path.Replace(@"\bin\Debug", "");
      path += @"\App_Data\";

      AppDomain.CurrentDomain.SetData("DataDirectory", path);
    }
  }
}
