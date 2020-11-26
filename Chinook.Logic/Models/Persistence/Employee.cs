﻿using CsvMapper.Logic.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models.Persistence

{
    [DataClass(HasHeader = true, FileName = "CsvData/Employee.csv")]

    internal class Employee : IdentityObject, Contracts.Persistence.IEmployee
    {
        [DataPropertyInfo(OrderPosition = 1)]

        public string Firstname { get; set; }
        [DataPropertyInfo(OrderPosition = 2)]

        public string LastName { get; set; }
        [DataPropertyInfo(OrderPosition = 3)]

        public string Title { get; set; }
        [DataPropertyInfo(OrderPosition = 4)]

        public string Adress { get; set; }
        [DataPropertyInfo(OrderPosition = 5)]

        public string ReportTo { get; set; }
        [DataPropertyInfo(OrderPosition = 6)]

        public string HireDate { get; set; }
        [DataPropertyInfo(OrderPosition = 7)]

        public string City { get; set; }
        [DataPropertyInfo(OrderPosition = 8)]

        public string State { get; set; }
        [DataPropertyInfo(OrderPosition = 9)]

        public string Country { get; set; }
        [DataPropertyInfo(OrderPosition = 10)]

        public string PostalCode { get; set; }
        [DataPropertyInfo(OrderPosition = 11)]

        public string Phone { get; set; }
        [DataPropertyInfo(OrderPosition = 12)]

        public string Fax { get; set; }
        [DataPropertyInfo(OrderPosition = 13)]

        public string Email { get; set; }
    }
}
