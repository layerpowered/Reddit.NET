﻿using System;

namespace Reddit.Models.Inputs.Flair
{
    [Serializable]
    public class FlairEnabledInput
    {
        /// <summary>
        /// boolean value
        /// </summary>
        public bool flair_enabled { get; set; }
    }
}
