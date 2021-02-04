using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UITMBER.Services.DiscountsService
{
    public interface IDiscountsService
    {
       
        Task<IActionResult> Verify(string code);
        Task<bool> AddToOrder(string code, long idorder);


    }
}
