﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7DeLange.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get;  }
        void SaveBook(Book b);
        void CreateBook(Book b);
        void DeleteBook(Book b);
    }
}
