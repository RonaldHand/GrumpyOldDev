using Serenity.Services;

namespace GrumpyOldDev.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}