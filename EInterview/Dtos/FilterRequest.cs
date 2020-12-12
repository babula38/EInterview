﻿using EInterview.Domain.Entities;

namespace EInterview.Dtos
{
    public class FilterRequest
    {
        public FilterType Type { get; internal set; }
        public int Low { get; internal set; }
        public int High { get; internal set; }
        public int CatlogID { get; set; }
    }
}