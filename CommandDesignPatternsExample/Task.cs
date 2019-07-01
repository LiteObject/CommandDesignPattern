namespace CommandDesignPatternsExample
{
    using System;

    /// <summary>
    /// The status.
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The new.
        /// </summary>
        New = 0,

        /// <summary>
        /// The in progress.
        /// </summary>
        InProgress = 1,

        /// <summary>
        /// The paused.
        /// </summary>
        Paused = 2,

        /// <summary>
        /// The cancelled.
        /// </summary>
        Cancelled = 3,

        /// <summary>
        /// The shipped.
        /// </summary>
        Shipped = 4,

        /// <summary>
        /// The complete.
        /// </summary>
        Complete = 5
    }

    /// <summary>
    /// The task.
    /// </summary>
    internal class Task
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the GUID.
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit cost.
        /// </summary>
        public double UnitCost { get; set; }
        
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public Status Status { get; set; }
     }
}