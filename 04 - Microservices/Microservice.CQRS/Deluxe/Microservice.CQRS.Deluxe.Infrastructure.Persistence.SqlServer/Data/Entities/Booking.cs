﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Microservice.CQRS.Deluxe.Infrastructure.Persistence.SqlServer.Data.Entities
{
    public partial class Booking
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string Name { get; set; }
        public int CourtId { get; set; }
        public int StartingAt { get; set; }
        public int Length { get; set; }
        public string Notes { get; set; }

        public virtual Court Court { get; set; }
    }
}