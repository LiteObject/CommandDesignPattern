namespace CommandDesignPatternsExample
{
    using System;

    using CommandDesignPatternsExample;

    /// <summary>
    /// The task command.
    /// </summary>
    internal class TaskCommand : ICommand
    {
        /// <summary>
        /// The _task.
        /// </summary>
        private readonly Task task;

        /// <summary>
        /// The _task action.
        /// </summary>
        private readonly TaskAction taskAction;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCommand"/> class.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        /// <param name="taskAction">
        /// The task action.
        /// </param>
        public TaskCommand(Task task, TaskAction taskAction)
        {
            this.taskAction = taskAction;
            this.task = task;
        }

        /// <summary>
        /// The execute action.
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void ExecuteAction()
        {
            throw new NotImplementedException();
        }
    }
}
