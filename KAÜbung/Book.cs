using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAÜbung
{
    public class Book
    {
        private string isbn;
        private string title;
        private string author;
        private string yor;

        public Book(string isbn, string title, string author, string yor)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.yor = yor;
        }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Yor { get => yor; set => yor = value; }
    }
}
