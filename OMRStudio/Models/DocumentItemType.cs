using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Text;

namespace OMRStudio.Models
{
    /// <summary>
    /// The type of Document Item
    /// </summary>
    public enum DocumentItemType
    {
        /// <summary>
        /// A reference or ancher mark item. These marks are used for mapping between DataDocument with ReferenceDocument marks.     
        /// </summary>
        Reference,
        Data

    }
}
