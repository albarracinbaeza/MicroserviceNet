﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Microservice.CQRS.Deluxe.Infrastructure.EventStore.SqlServer.Data.Entities
{
    public partial class LoggedEvent
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public int AggregateId { get; set; }
        public string Cargo { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}