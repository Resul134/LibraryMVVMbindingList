using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using WpfApplication.ViewModel;

namespace LibraryMVVMbindingList
{
    class ViewModel : INotifyPropertyChanged
    {

        private string _loaner;
        // her huskes den valgte bog
        private Book _selectedBook;

        //Her gemmes alle bøger - observable collection betyder at den notificere GUI om ændringer.
        private ObservableCollection<Book> _books = new ObservableCollection<Book>();

        public ViewModel()
        {
            _books.Add(new Book("23234242", "Ebbe Bingo Vango","Flæstesteg for begyndere"));
            _books.Add(new Book("2313123123","Lars Troelsen","Frokost på nye måder"));
            _books.Add(new Book("34252353252","Lasse Coinbæk", "Bitcoin i Vipperød"));
            _books.Add(new Book("214124124124","Michael Kærgården","Den der smører godt, kører godt - Glæden ved at Cykle"));
            LoanBookCommand = new RelayCommand(addLoanertoSelectedBook);
        }

        public ObservableCollection<Book> Books
        {
            get => _books;
            set => _books = value;
        }

        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged();
            }
        }

        public string Loaner
        {
            get => _loaner;
            set
            {
                _loaner = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public RelayCommand LoanBookCommand
        {
            get;
            private set;
        }

        private void addLoanertoSelectedBook()
        {
            Debug.WriteLine("add loaner");
            _selectedBook.Loaner = _loaner;
            OnPropertyChanged("SelectedBook");
        }
    }
}
