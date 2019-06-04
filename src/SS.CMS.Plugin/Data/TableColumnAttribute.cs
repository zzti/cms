﻿using System;

namespace SS.CMS.Plugin.Data
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TableColumnAttribute : Attribute
    {
        public int Length { get; set; }

        public bool Text { get; set; }

        public bool Extend { get; set; }
    }
}