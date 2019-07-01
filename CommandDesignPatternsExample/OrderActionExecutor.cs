namespace CommandDesignPatternsExample
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The order action executor.
    /// </summary>
    internal class OrderActionExecutor
    {
        /// <summary>
        /// The commands.
        /// </summary>
        private readonly List<ICommand> commands;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderActionExecutor"/> class.
        /// </summary>
        public OrderActionExecutor()
        {
            this.commands = new List<ICommand>();
        }

        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        private ICommand Command { get; set; }

        /// <summary>
        /// The invoke.
        /// </summary>
        public void Invoke()
        {
            this.commands.Add(this.Command);
            this.Command.ExecuteAction();
        }
    }
}
