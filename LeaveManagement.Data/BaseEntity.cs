﻿namespace LeaveManagement.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModified { get; set; }
    }
}
