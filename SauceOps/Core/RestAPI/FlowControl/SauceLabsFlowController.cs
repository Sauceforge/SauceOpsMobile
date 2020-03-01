using System;
using System.Threading;
using RestSharp;
using SauceOps.Core.RestAPI.FlowControl.Base;
using SauceOps.Core.Util;

namespace SauceOps.Core.RestAPI.FlowControl {
    internal class SauceLabsFlowController : FlowController {
        public override void ControlFlow() {
            while(TooManyTests()) {
                Thread.Sleep(SauceOpsConstants.SAUCELABS_FLOW_WAIT);
            }
        }

        protected override bool TooManyTests() {
            //int maxParallelMacSessionsAllowed;  //Possible future use.
            var json = GetJsonResponseForUser(SauceOpsConstants.ACCOUNT_CONCURRENCY_REQUEST);
            //Console.WriteLine("Concurrency JSON: " + json);
            var jsonStartIndex = json.IndexOf("\"remaining", StringComparison.Ordinal);

            while(jsonStartIndex < 0)
            {
                json = GetJsonResponseForUser(SauceOpsConstants.ACCOUNT_CONCURRENCY_REQUEST);
                jsonStartIndex = json.IndexOf("\"remaining", StringComparison.Ordinal);
            }

            var jsonEndIndex = json.Length - 3;
            var remainingSection = ExtractJsonSegment(json, jsonStartIndex, jsonEndIndex);
            var flowControl = SimpleJson.DeserializeObject<FlowControl>(remainingSection);

            return flowControl.remaining.overall <= 0;
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th July 2014
 * 
 */