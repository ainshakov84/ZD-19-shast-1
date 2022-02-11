using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ZD_19_shast_1
{
    class MainWindowVievModel : INotifyPropertyChanged
    {


       public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private int namber1;
        public int Namber1
        {
        get=> namber1;
            set
            {
                namber1 = value;
                OnPropertyChanged();
            }
        }
        private int namber2;
        public int Namber2
        {
        get=> namber2;
            set
            {
                namber2 = value;
                OnPropertyChanged();
            }
        } 
        private int namber3;
        public int Namber3
        {
        get=> namber3;
            set
            {
                namber3 = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Namber3=Ariph.Add(Namber1,Namber2);
        }
        private bool CanAddCommandExecute(object p)
        {
            if (Namber1 !=0 || Namber2 !=0)
                return true;
            else
                return false;
        }
        public MainWindowVievModel()
        {
            AddCommand=new RelayCommand(OnAddCommandExecute, CanAddCommandExecute);
        }
            
    }

}

