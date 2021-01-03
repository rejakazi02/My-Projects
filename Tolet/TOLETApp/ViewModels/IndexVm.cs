using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TOLETApp.Models;

namespace TOLETApp.ViewModels
{
    public class IndexVm
    {
        public List<ToLetPublish> ToLetPublishs { get; set; }
        public List<Customer> Customers { get; set; }
    }
}