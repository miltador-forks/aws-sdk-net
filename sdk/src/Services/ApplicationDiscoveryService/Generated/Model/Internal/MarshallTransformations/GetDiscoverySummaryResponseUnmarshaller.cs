/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationDiscoveryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApplicationDiscoveryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDiscoverySummary operation
    /// </summary>  
    public class GetDiscoverySummaryResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetDiscoverySummaryResponse response = new GetDiscoverySummaryResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentSummary", targetDepth))
                {
                    var unmarshaller = CustomerAgentInfoUnmarshaller.Instance;
                    response.AgentSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("applications", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.Applications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorSummary", targetDepth))
                {
                    var unmarshaller = CustomerConnectorInfoUnmarshaller.Instance;
                    response.ConnectorSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("servers", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.Servers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serversMappedToApplications", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.ServersMappedToApplications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serversMappedtoTags", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.ServersMappedtoTags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("AuthorizationErrorException"))
            {
                return new AuthorizationErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterException"))
            {
                return new InvalidParameterException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
            {
                return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ServerInternalErrorException"))
            {
                return new ServerInternalErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonApplicationDiscoveryServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetDiscoverySummaryResponseUnmarshaller _instance = new GetDiscoverySummaryResponseUnmarshaller();        

        internal static GetDiscoverySummaryResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDiscoverySummaryResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}