using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about control
    /// names.
    /// </summary>
    internal class ControlNameConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlNameConfigurator"/> class.
        /// </summary>
        /// <param name="controlName">The control name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ControlNameConfigurator(string controlName, PropertyExpressionOperator conditionOperator)
            : base(WinControl.PropertyNames.ControlName, controlName, conditionOperator)
        {
        }
    }
}