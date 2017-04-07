namespace BaristaLabs.ChromeDevTools.IndexedDB
{
    /// <summary>
    /// Data entry.
    /// </summary>
    public sealed class DataEntry
    {
    
        /// <summary>
        /// Key object.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.RemoteObject Key
        {
            get;
            set;
        }
    
        /// <summary>
        /// Primary key object.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.RemoteObject PrimaryKey
        {
            get;
            set;
        }
    
        /// <summary>
        /// Value object.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.RemoteObject Value
        {
            get;
            set;
        }
    
    }
}