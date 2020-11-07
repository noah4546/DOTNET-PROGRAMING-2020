/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

namespace MidtermA
{
    /// <summary>
    /// Interface for billing and validting different Products and Services
    /// </summary>
    interface IBillable
    {
        decimal Bill();
        bool Validate();
    }
}
