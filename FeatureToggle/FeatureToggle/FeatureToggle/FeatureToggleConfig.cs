using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace SampleMVC.FeatureToggle
{
    public class FeatureToggleConfig : Dictionary<string, ControllerToggle>
    {
    }

    public class ControllerToggle
    {
        public bool Enabled { get; set; }
        public List<string> EnabledMethods { get; set; }
        public List<string> DisabledMethods { get; set; }
    }
}
