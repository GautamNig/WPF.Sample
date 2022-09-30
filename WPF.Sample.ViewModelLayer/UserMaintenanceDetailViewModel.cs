using WPF.Sample.DataLayer;
using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using Common.Library;

namespace WPF.Sample.ViewModelLayer
{
    public class UserMaintenanceDetailViewModel : UserMaintenanceListViewModel
    {
        private User _Entity = new User();

        public User Entity
        {
            get { return _Entity; }
            set
            {
                _Entity = value;
                RaisePropertyChanged("Entity");
            }
        }

        public override void LoadUsers()
        {
            // Load all users
            base.LoadUsers();

            // Set default user
            if (Users.Count > 0)
            {
                Entity = Users[0];
            }
        }

        public override void BeginEdit()
        {
            base.BeginEdit();
        }

        public override bool Save()
        {
            bool ret = false;
            SampleDbContext db = null;

            try
            {
                db = new SampleDbContext();

                db.Entry(Entity).State = EntityState.Modified;

                db.SaveChanges();

                ret = true;

                IsDetailEnabled = false;
            }
            catch (DbEntityValidationException ex)
            {
            }
            catch (Exception ex)
            {

            }

            return ret;
        }
    }
}
