/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Rkp.V20191209
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rkp.V20191209.Models;

   public class RkpClient : AbstractClient{

       private const string endpoint = "rkp.tencentcloudapi.com";
       private const string version = "2019-12-09";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RkpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RkpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 根据DevicceToken查询OpenID。
        /// </summary>
        /// <param name="req"><see cref="GetOpenIdRequest"/></param>
        /// <returns><see cref="GetOpenIdResponse"/></returns>
        public async Task<GetOpenIdResponse> GetOpenId(GetOpenIdRequest req)
        {
             JsonResponseModel<GetOpenIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetOpenId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOpenIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据DevicceToken查询OpenID。
        /// </summary>
        /// <param name="req"><see cref="GetOpenIdRequest"/></param>
        /// <returns><see cref="GetOpenIdResponse"/></returns>
        public GetOpenIdResponse GetOpenIdSync(GetOpenIdRequest req)
        {
             JsonResponseModel<GetOpenIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetOpenId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOpenIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取token接口。
        /// </summary>
        /// <param name="req"><see cref="GetTokenRequest"/></param>
        /// <returns><see cref="GetTokenResponse"/></returns>
        public async Task<GetTokenResponse> GetToken(GetTokenRequest req)
        {
             JsonResponseModel<GetTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取token接口。
        /// </summary>
        /// <param name="req"><see cref="GetTokenRequest"/></param>
        /// <returns><see cref="GetTokenResponse"/></returns>
        public GetTokenResponse GetTokenSync(GetTokenRequest req)
        {
             JsonResponseModel<GetTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯天御设备风险查询接口，输入由客户应用自主采集的设备信息， 通过腾讯大数据风控能力，可以准确根据输入设备信息，还原设备库中的设备ID，并且识别设备的风险，解决客户业务过程中的设备风险，降低企业损失。
        /// </summary>
        /// <param name="req"><see cref="QueryDevAndRiskRequest"/></param>
        /// <returns><see cref="QueryDevAndRiskResponse"/></returns>
        public async Task<QueryDevAndRiskResponse> QueryDevAndRisk(QueryDevAndRiskRequest req)
        {
             JsonResponseModel<QueryDevAndRiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryDevAndRisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDevAndRiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯天御设备风险查询接口，输入由客户应用自主采集的设备信息， 通过腾讯大数据风控能力，可以准确根据输入设备信息，还原设备库中的设备ID，并且识别设备的风险，解决客户业务过程中的设备风险，降低企业损失。
        /// </summary>
        /// <param name="req"><see cref="QueryDevAndRiskRequest"/></param>
        /// <returns><see cref="QueryDevAndRiskResponse"/></returns>
        public QueryDevAndRiskResponse QueryDevAndRiskSync(QueryDevAndRiskRequest req)
        {
             JsonResponseModel<QueryDevAndRiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryDevAndRisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDevAndRiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
