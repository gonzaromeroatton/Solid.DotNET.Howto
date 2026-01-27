using Solid.DotNET.Howto._2.OCP.Good.Interface;

namespace Solid.DotNET.Howto._2.OCP.Good
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Discounts : IDiscount
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.05m;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsMatch(string type)
        {
            return type == "Regular";
        }
    }
}
