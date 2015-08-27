﻿/*
 * Markdown Scanner
 * Copyright (c) Microsoft Corporation
 * All rights reserved. 
 * 
 * MIT License
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the ""Software""), to deal in 
 * the Software without restriction, including without limitation the rights to use, 
 * copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the
 * Software, and to permit persons to whom the Software is furnished to do so, 
 * subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all 
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
 * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

namespace ApiDocs.Validation
{
    public static class ValidationConfig
    {
        static ValidationConfig()
        {
            ExpectedResponseAsRequiredProperties = true;
            AdditionalHttpHeaders = new string[0];
            RetryAttemptsOnServiceUnavailableResponse = 4; // Try 1 + 4 retries = 5 total attempts
            MaximumBackoffMilliseconds = 5000;
            BaseBackoffMilliseconds = 100;
        }

        /// <summary>
        /// Validatation requires that properties shown in the documentation's expected response are
        /// found when testing the service or simulatedResponse.
        /// </summary>
        public static bool ExpectedResponseAsRequiredProperties { get; set; }

        /// <summary>
        /// Instead of using the default OData metadata settings, force the odata metadata parameters to none.
        /// </summary>
        public static string ODataMetadataLevel { get; set; }

        /// <summary>
        /// An array of additional HTTP headers that are added to outgoing requests to the service.
        /// </summary>
        public static string[] AdditionalHttpHeaders { get; set; }

        public static int RetryAttemptsOnServiceUnavailableResponse { get; set; }

        public static int MaximumBackoffMilliseconds { get; set; }

        public static int BaseBackoffMilliseconds { get; set; }

    }
}
