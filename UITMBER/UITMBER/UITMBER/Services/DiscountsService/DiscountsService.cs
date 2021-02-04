using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Services.Request;
using Xamarin.Forms;

namespace UITMBER.Services.DiscountsService
{
    class DiscountsService : IDiscountsService
    {
        private IRequestService _requestService => DependencyService.Get<IRequestService>();
        public async Task<bool> AddToOrder(string code, long idorder)
        {
            var url = $"{Settings.SERVER_ENDPOINT}/Discounts/AddToOrder";
            await _requestService.PostAsync<long>(url, idorder);

            return true;
        }

        public async Task<IActionResult> Verify(string code)
        {
            var url = $"{Settings.SERVER_ENDPOINT}/Discounts/Verify";
            var data = await _requestService.GetAsync<IActionResult>(url);

            return data;
        }
    }   
}
