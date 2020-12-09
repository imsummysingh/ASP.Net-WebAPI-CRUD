using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    }
}


//DB TABLE

//Database Name- WebAPI_CRUD

//Create table Users
//(
//UserId int primary key identity,
//Name nvarchar(50),
//Address nvarchar(50),
//Contact nvarchar(50)
//)

//select* from dbo.Users