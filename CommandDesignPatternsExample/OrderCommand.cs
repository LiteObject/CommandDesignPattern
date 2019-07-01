namespace CommandDesignPatternsExample
{
    using System;
    
    /// <summary>
    /// The order command. We can decouple classes that invoke operations from classes that perform these operations. 
    /// and support undoable operations.
    /// </summary>
    internal class OrderCommand : ICommand
    {
        /// <summary>
        /// The order.
        /// </summary>
        private readonly Order order;

        /// <summary>
        /// The order action.
        /// </summary>
        private readonly OrderAction orderAction;

        /// <summary>
        /// The task.
        /// </summary>
        private readonly Task task;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCommand"/> class. 
        /// Initializes a new instance of the <see cref="TaskCommand"/> class.
        /// </summary>
        /// <param name="order">
        /// The order.
        /// </param>
        /// <param name="orderAction">
        /// The order Action.
        /// </param>
        /// <param name="task">
        /// The task.
        /// </param>
        public OrderCommand(Order order, OrderAction orderAction, Task task)
        {
            this.orderAction = orderAction;
            this.order = order;
            this.task = task;
        }

        /// <summary>
        /// The execute action.
        /// </summary>
        public void ExecuteAction()
        {
            Console.WriteLine($"Executing {this.orderAction} action");

            // ...or we could have separate command classes (all inheriting from ICommand) such as AddTaskCommand, RemoveTaskCommand, etc.
            switch (this.orderAction)
            {
                case OrderAction.AddTask:
                    this.order.AddTask(this.task);

                    // Do something else
                    break;
                case OrderAction.RemoveTask:
                    this.order.RemoveTask(this.task);

                    // Do something else
                    break;
                case OrderAction.UpdateTask:
                    this.order.UpdateTask(this.task);

                    // Do something else
                    break;
                default:
                    Console.WriteLine($"Unknown order action {this.orderAction}.");
                    break;
            }
        }
    }
}
