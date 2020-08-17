using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.DotNetCoreAPI.Swagger.Models;

namespace Demo.DotNetCoreAPI.Swagger.Repository
{
    public class BookRepository
    {
        public List<BookInfo> GetAllBooks()
        {
            return DataSource();
        }

        public BookInfo GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<BookInfo> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.AuthorName.Contains(authorName)).ToList();
        }

        private List<BookInfo> DataSource()
        {
            return new List<BookInfo>() {
            new BookInfo(){ Id = 1 , Title ="MVC" ,AuthorName="kaustubh"   ,Category="Tech"        },
            new BookInfo(){ Id = 2 , Title ="Yoga" ,AuthorName="Sayali"    ,Category="Tech"        },
            new BookInfo(){ Id = 3 , Title ="Docker" ,AuthorName="kaustubh", Category="Tech"       },
            new BookInfo(){ Id = 4 , Title ="AI" ,AuthorName="Saurabh"      ,Category="Mathematics"},
            new BookInfo(){ Id = 5 , Title ="MVC" ,AuthorName="Saurabh"      ,Category="Tech"      },
            new BookInfo(){ Id = 6 , Title ="Ayurveda" ,AuthorName="Sayali" ,Category="Ayurveda"   },
            };
        }

    }
}
