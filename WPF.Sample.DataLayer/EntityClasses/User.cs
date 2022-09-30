using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Library;

namespace WPF.Sample.DataLayer
{
    [Table("User", Schema = "dbo")]
    public class User : CommonBase
    {
        private int _UserId;
        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private string _Address = string.Empty;
        private int _Age;

        [Required]
        [Key]
        public int UserId
        {
            get { return _UserId; }
            set
            {
                _UserId = value;
                RaisePropertyChanged("UserId");
            }
        }

        [Required]
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        [Required]
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        [Required]
        public string Address
        {
            get { return _Address; }
            set
            {
                _Address = value;
                RaisePropertyChanged("Address");
            }
        }

        [Required]
        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                RaisePropertyChanged("Age");
            }
        }
    }
}