namespace BaristaLabs.ChromeDevTools.CSS
{
    /// <summary>
    /// Fired whenever a stylesheet is changed as a result of the client operation.
    /// </summary>
    public sealed class StyleSheetChangedEvent
    {
    
        
        /// <summary>
        /// Gets or sets the styleSheetId
        /// </summary>
        
        public string StyleSheetId
        {
            get;
            set;
        }
    
    }
}