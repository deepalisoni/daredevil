﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
    public class CheckEmail
    {
        [JsonProperty("IsExist")]
        public bool IsExist { get; set; }
    }
}
