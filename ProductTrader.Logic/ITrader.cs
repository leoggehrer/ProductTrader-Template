namespace ProductTrader.Logic
{
    public interface ITrader
    {
        /// <summary>
        /// Returns the current profit.
        /// </summary>
        double CurrentProfit { get; }
        /// <summary>
        /// The Trader's name. 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Gets the profit made so far.
        /// </summary>
        double PastProfit { get; }
        /// <summary>
        /// Gets the purchase value.
        /// </summary>
        double PurchaseValue { get; }
        /// <summary>
        /// Gets the retail value.
        /// </summary>
        double RetailValue { get; }

        /// <summary>
        /// Registration method for the product.
        /// </summary>
        /// <param name="sender">The product.</param>
        /// <param name="eventArgs">The default is EventArgs.Empty.</param>
        void Update(object sender, EventArgs eventArgs);
    }
}