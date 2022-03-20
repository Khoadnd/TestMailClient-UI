using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailClient.Core;

namespace MailClient.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand InboxViewCommand { get; set; }
        public RelayCommand SentViewCommand { get; set; }
        public RelayCommand DraftsViewCommand { get; set; }
        public RelayCommand TrashViewCommand { get; set; }
        public InboxViewModel InboxVM { get; set; }

        public SentViewModel SentVM { get; set; }
        public DraftsViewModel DraftsVM { get; set; }
        public TrashViewModel TrashVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            InboxVM = new InboxViewModel();
            SentVM = new SentViewModel();
            DraftsVM = new DraftsViewModel();
            TrashVM = new TrashViewModel();
            CurrentView = InboxVM;

            InboxViewCommand = new RelayCommand(o =>
            {
                CurrentView = InboxVM;
            });

            SentViewCommand = new RelayCommand(o =>
            {
                CurrentView = SentVM;
            });
            DraftsViewCommand = new RelayCommand(o =>
            {
                CurrentView = DraftsVM;
            }); 
            TrashViewCommand = new RelayCommand(o =>
            {
                CurrentView = TrashVM;
            });
        }
    }
}
