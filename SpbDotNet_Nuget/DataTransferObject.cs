﻿using System;

namespace SpbDotNet_Nuget
{
    public class DataTransferObject
    {
        public Guid Id { get; set; }
        
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Description { get; set; }
    }
}