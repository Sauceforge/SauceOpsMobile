﻿using Newtonsoft.Json;

namespace SauceOps.Core.OnDemand {
    public class SaucePlatform {
        #region Attributes

        public string Os { get; set; }
        public string Platform { get; set; }
        public string Browser { get; set; }

        [JsonProperty(PropertyName = "browser-version")]
        public string BrowserVersion { get; set; }

        [JsonProperty(PropertyName = "long-name")]
        public string LongName { get; set; }

        [JsonProperty(PropertyName = "long-version")]
        public string LongVersion { get; set; }

        public string Url { get; set; }
        public string Device { get; set; }

        [JsonProperty(PropertyName = "device-type")]
        public string DeviceType { get; set; }

        [JsonProperty(PropertyName = "device-orientation")]
        public string DeviceOrientation { get; set; }

        #endregion

        #region Constructors

        //static SaucePlatform() {
        //    //OnceOnlyMessages.OnDemand();
        //}

        public SaucePlatform(string mobilePlatformName, string platform, string browser, string browserVersion, string longName,
            string longVersion, string url, string device, string deviceOrientation) {
			Os = mobilePlatformName;
            Browser = browser;
            BrowserVersion = browserVersion;
            Platform = platform;
            LongName = longName;
            LongVersion = longVersion;
            Url = url;
            Device = device;
            DeviceOrientation = deviceOrientation;
        }

        #endregion

        #region Methods

        internal double ParseBrowserVersion() {
            return double.Parse(BrowserVersion);
        }

        #endregion
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th July 2014
 * 
 */