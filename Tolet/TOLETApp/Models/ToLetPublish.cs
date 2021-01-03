using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TOLETApp.Models
{
    public class ToLetPublish
    {
        public int Id { get; set; }
        public string AreaName { get; set; }
        public string ToLetFromMonth { get; set; }
        public string RoomType { get; set; }
        public double HouseRent { get; set; }
        public string Location { get; set; }
        public double PhoneNumber { get; set; }
        public string Note { get; set; }
    }
}