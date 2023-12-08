﻿using HotelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5066/api/DashboardWidgets/StaffCount");

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.v = jsonData;
            
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("http://localhost:5066/api/DashboardWidgets/BookingCount");
           
                var jsonData2 = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.v2 = jsonData2;

            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client.GetAsync("http://localhost:5066/api/DashboardWidgets/AppUserCount");

            var jsonData3 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.v3 = jsonData3;

            return View();
        }
    }
}
