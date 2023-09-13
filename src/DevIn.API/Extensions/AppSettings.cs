﻿namespace DevIn.API.Extensions
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int ExpireHours { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
