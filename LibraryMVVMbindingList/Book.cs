using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVVMbindingList
{
    class Book
    {
        private string _isbn;
        private string _author;
        private string _title;
        private string _loaner;

        public Book(string isbn, string author, string title)
        {
            this._isbn = isbn;
            this._author = author;
            this._title = title;
        }

        public string Isbn
        {
            get => _isbn;
            set => _isbn = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Loaner
        {
            get => _loaner;
            set => _loaner = value;
        }
    }
}
