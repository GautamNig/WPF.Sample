using System;

namespace Common.Library
{
  public class ViewModelEditBase : ViewModelBase
  {
    private bool _IsDetailEnabled = false;

    public bool IsDetailEnabled
    {
      get { return _IsDetailEnabled; }
      set {
        _IsDetailEnabled = value;
        RaisePropertyChanged("IsDetailEnabled");
      }
    }

    public virtual void BeginEdit()
    {
      IsDetailEnabled = true;
    }

    public virtual bool Save()
    {
      return true;
    }
  }
}
