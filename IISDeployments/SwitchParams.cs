﻿
namespace IISDeployments
{
    public class SwitchParams
    {
        public bool? BreakOnError { get; set; }
        public bool? CleanUp { get; set; }
        public bool? Force { get; set; }
        public string ConfigSection { get; set; }
        public string ConfigPath { get; set; }
   
    }
}