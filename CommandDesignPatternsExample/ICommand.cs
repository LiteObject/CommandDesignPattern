namespace CommandDesignPatternsExample
{
    /// <summary>
    /// The Command interface. We can decouple classes that invoke operations from classes that perform these operations. 
    /// </summary>
    internal interface ICommand
    {
        /// <summary>
        /// The execute action.
        /// </summary>
        void ExecuteAction();
    }
}
