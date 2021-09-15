using MediatR;
using FarmFresh.Web.ViewModels;
using System.Collections.Generic;

namespace FarmFresh.Web.Features.MyOrders
{
    public class GetMyOrders : IRequest<IEnumerable<OrderViewModel>>
    {
        public string UserName { get; set; }

        public GetMyOrders(string userName)
        {
            UserName = userName;
        }
    }
}
