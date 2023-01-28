using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class Book
    {
        public Book(string author, int pages, int bookmark, int price)
        {
            this.author = author;
            this.pages = pages;
            this.bookmark = bookmark;
            this.price = price;
        }
        public string author;
        public int pages;
        public int bookmark;
        public int price;
        List<string> chapters = new List<string>();
        public string getChapter(int chpNum)
        {
            return chapters[chpNum - 1];
        }
        public void SetBookmark(int pgNum)
        {
            bookmark = pgNum;
        }
        public int getBookmark()
        {
            return bookmark;
        }
        public int getPrice()
        {
            return price;
        }
        public void setPrice(int p)
        {
            price = p;
        }
        public void AddChapter(string ch)
        {
            chapters.Add(ch);
        }
    }
}
