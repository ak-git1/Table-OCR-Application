using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOcrExtractor.Logic.Enums
{
    /// <summary>
    /// Language
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// English
        /// </summary>
        [Description("en")]
        En = 0,

        /// <summary>
        /// Russian
        /// </summary>
        [Description("ru")]
        Ru = 1    
    }
}
