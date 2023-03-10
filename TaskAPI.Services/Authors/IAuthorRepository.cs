﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public interface IAuthorRepository
    {
        public Author GetAuthor(int id);
        public List<Author> GetAllAuthors(string job,string search);
        public Author AddAuthor(Author author);

    }
}
