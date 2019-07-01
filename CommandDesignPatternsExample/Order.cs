namespace CommandDesignPatternsExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The order.
    /// </summary>
    internal class Order
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
        /// Gets or sets the task.
        /// </summary>
        public List<Task> Tasks { get; set; } = new List<Task>();

        /// <summary>
        /// The add task.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        public void AddTask(Task task)
        {
            if (task is null)
            {
                throw new Exception($"Param {nameof(task)} cannot be null.");
            }

            this.Tasks.Add(task);
        }

        /// <summary>
        /// The remove task.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        /// <exception cref="Exception">
        /// The null parameter exception.
        /// </exception>
        public void RemoveTask(Task task)
        {
            if (task is null)
            {
                throw new Exception($"Param {nameof(task)} cannot be null.");
            }

            if (this.Tasks.Exists(t => t.Id == task.Id))
            {
                this.Tasks.Remove(task);
            }
        }

        /// <summary>
        /// The update task.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        /// <exception cref="Exception">
        /// The null parameter exception.
        /// </exception>
        public void UpdateTask(Task task)
        {
            if (task is null)
            {
                throw new Exception($"Param {nameof(task)} cannot be null.");
            }

            if (this.Tasks.Exists(t => t.Id == task.Id))
            {
                this.Tasks.Remove(task);
                this.Tasks.Add(task);
            }
        }

        /// <summary>
        /// The get total cost.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double GetTotalCost()
        {
            var total = 0.0;

            foreach (var task in this.Tasks)
            {
                total += task.UnitCost * task.Quantity;
            }

            return total;
        }

        /// <summary>
        /// The get current cost.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double GetCurrentCost()
        {
            var total = 0.0;

            foreach (var task in this.Tasks.Where(t => t.Status == Status.Complete))
            {
                total += task.UnitCost * task.Quantity;
            }

            return total;
        }
    }
}
