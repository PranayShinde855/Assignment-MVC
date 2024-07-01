using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public DateTime DOJ { get; set; }
        public string Gender { get; set; }
        public bool Reading { get; set; }
        public bool Playing { get; set; }
        public bool Swimming { get; set; }
        public bool Singing{ get; set; }

    }

    public class UsersDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public DateTime DOJ { get; set; }
        public string Gender { get; set; }
        public bool Reading { get; set; }
        public bool Playing { get; set; }
        public bool Swimming { get; set; }
        public bool Singing { get; set; }
        public List<Departments> Departments { get; set; }
    }
    public class ListUsersDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime DOJ { get; set; }

    }
}