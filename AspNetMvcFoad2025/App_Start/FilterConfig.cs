﻿using System.Web;
using System.Web.Mvc;

namespace AspNetMvcFoad2025
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
