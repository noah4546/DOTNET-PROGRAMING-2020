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
    /// Product class: Used to store infromation about a product
    /// Including the id, description, quatity ordered, and cost per item
    /// Also implements IBillable
    /// </summary>
    class Product : IBillable
    {
        public int ProductID { get; private set; }
        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public decimal Cost { get; private set; }

        /// <summary>
        /// Creates a new Product
        /// </summary>
        /// <param name="id">ProductID</param>
        /// <param name="description">Description about product</param>
        /// <param name="quantity">Quantity of product ordered (>= 0)</param>
        /// <param name="cost">Cost of each product (>= 0)</param>
        public Product(int id, string description, int quantity, decimal cost)
        {
            ProductID = id;
            Description = description;

            if (quantity >= 0)
                Quantity = quantity;
            else
                throw new ArgumentOutOfRangeException("quantity", "quantity must be a positive number");

            if (cost >= 0)
                Cost = cost;
            else
                throw new ArgumentOutOfRangeException("cost", "cost must be a postive number");
        }

        /// <summary>
        /// Returns a string that contains all the infromation about a product
        /// </summary>
        /// <returns>Product string</returns>
        public override string ToString()
        {
            return $"[Product]\nProduct: {ProductID}, Description: {Description}, Quantity: {Quantity}, Cost: {Cost:C}";
        }

        /// <summary>
        /// Returns the price of the quantity ordered * cost per item
        /// </summary>
        /// <returns>Price</returns>
        public decimal Bill()
        {
            return Quantity * Cost;
        }

        /// <summary>
        /// Returns if the ProductID is valid (must be a 6-digit and start with 10, 11, 12, or 13)
        /// </summary>
        /// <returns>true if valid</returns>
        public bool Validate()
        {
            string starts = ProductID.ToString().Substring(0, 2);
            return ProductID.ToString().Length == 6 && 
                (starts == "10" || starts == "11" || starts == "12" || starts == "13");
        }
    }
}
