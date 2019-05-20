﻿using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a list item control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlListItem : HtmlControl<CUITControls.HtmlListItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlListItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlListItem(By searchConfiguration = null)
            : this(new CUITControls.HtmlListItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlListItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlListItem(CUITControls.HtmlListItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}