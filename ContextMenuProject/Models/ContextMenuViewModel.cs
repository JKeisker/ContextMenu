
namespace ContextMenu.Models
{
    /// <summary>
    ///     Container for ContextMenu
    /// </summary>
    public class ContextMenuViewModel
    {
        /// <summary>
        ///     ContextMenuViewModel
        /// </summary>
        public ContextMenuViewModel() { }

        /// <summary>
        ///     Email address
        /// </summary>
        public string EmailName { get; set; }

        /// <summary>
        ///     populate w/ any unique name
        /// </summary>
        public string HtmlPrefix { get; set; } 
    }
}