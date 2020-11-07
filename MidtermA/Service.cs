/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;

namespace MidtermA
{
    /// <summary>
    /// Service class: Used to store infromation about a service
    /// Including the id, detail, and price of the service
    /// Also implements IBillable
    /// </summary>
    class Service : IBillable
    {
        public string ServiceID { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Creates a new Service
        /// </summary>
        /// <param name="id">ServiceID</param>
        /// <param name="detail">Detial about service</param>
        /// <param name="price">Price of the service (>= 0)</param>
        public Service(string id, string detail, decimal price)
        {
            ServiceID = id;
            Detail = detail;

            if (price >= 0)
                Price = price;
            else
                throw new ArgumentOutOfRangeException("price", "price must be a postive number");
        }

        /// <summary>
        /// Returns a string that contains all the infromation about a service
        /// </summary>
        /// <returns>Service string</returns>
        public override string ToString()
        {
            return $"[Service]\nServiceID: {ServiceID}, Detail: {Detail}, Price: {Price:C}";
        }

        /// <summary>
        /// Returns the price of the service
        /// </summary>
        /// <returns>Price</returns>
        public decimal Bill()
        {
            return Price;
        }

        /// <summary>
        /// Returns if the ServiceID is valid ("configure","debug",or "restore")
        /// </summary>
        /// <returns>true if valid</returns>
        public bool Validate()
        {
            return ServiceID.ToLower() == "configure" || 
                ServiceID.ToLower() == "debug" || 
                ServiceID.ToLower() == "restore";
        }
    }
}
