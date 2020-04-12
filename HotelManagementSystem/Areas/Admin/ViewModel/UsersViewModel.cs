﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelManagementSystem.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using PagedList;

namespace HotelManagementSystem.Areas.Admin.ViewModel
{
    
    public class UsersViewModel
    {
        public IPagedList<ApplicationUser> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
        public string RoleId { get; set; }
        public string SearchTerm { get; set; }


    }
    public class UsersActionViewModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public string RoleId { get; set; }

        public IEnumerable<IdentityRole> Roles { get; set; }

    }
}