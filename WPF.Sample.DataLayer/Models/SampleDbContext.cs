using System.Data.Entity;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using Common.Library;

namespace WPF.Sample.DataLayer
{
  public partial class SampleDbContext : DbContext
  {
    public SampleDbContext() : base("name=Samples")
    {
    }

    public virtual DbSet<User> Users { get; set; }
  }
}
