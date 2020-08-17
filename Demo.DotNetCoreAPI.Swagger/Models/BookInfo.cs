using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.DotNetCoreAPI.Swagger.Models
{
    public class BookInfo
    {
        /// <summary>
        /// book id 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Book title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Book author name
        /// </summary>
        public string AuthorName { get; set; }
        /// <summary>
        /// Book category
        /// </summary>
        public string Category { get; set; }
    }
}
