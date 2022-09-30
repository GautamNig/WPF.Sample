using System;
using System.Collections.ObjectModel;

namespace Common.Library
{
  public class ViewModelBase : CommonBase
  {
    #region Private Variables
    #endregion

    #region Close Method
    public virtual void Close()
    {
      MessageBroker.Instance.SendMessage(MessageBrokerMessages.CLOSE_USER_CONTROL);
    }
    #endregion

  }
}
