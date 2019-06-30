using System;

namespace CommandDesignPatternsExample
{
    internal class Task
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }
    }

    public enum Status
    {
        New = 0,
        Released = 1,
        Packed = 2,
        Shipped = 3,
        Cancelled = 4,
        Complete = 5
    }
}