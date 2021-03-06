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

namespace TencentCloud.Cfw.V20190904
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfw.V20190904.Models;

   public class CfwClient : AbstractClient{

       private const string endpoint = "cfw.tencentcloudapi.com";
       private const string version = "2019-09-04";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public async Task<CreateAcRulesResponse> CreateAcRules(CreateAcRulesRequest req)
        {
             JsonResponseModel<CreateAcRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public CreateAcRulesResponse CreateAcRulesSync(CreateAcRulesRequest req)
        {
             JsonResponseModel<CreateAcRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public async Task<DeleteAcRuleResponse> DeleteAcRule(DeleteAcRuleRequest req)
        {
             JsonResponseModel<DeleteAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public DeleteAcRuleResponse DeleteAcRuleSync(DeleteAcRuleRequest req)
        {
             JsonResponseModel<DeleteAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全部删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public async Task<DeleteAllAccessControlRuleResponse> DeleteAllAccessControlRule(DeleteAllAccessControlRuleRequest req)
        {
             JsonResponseModel<DeleteAllAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAllAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全部删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public DeleteAllAccessControlRuleResponse DeleteAllAccessControlRuleSync(DeleteAllAccessControlRuleRequest req)
        {
             JsonResponseModel<DeleteAllAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAllAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public async Task<DescribeAcListsResponse> DescribeAcLists(DescribeAcListsRequest req)
        {
             JsonResponseModel<DescribeAcListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAcLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAcListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public DescribeAcListsResponse DescribeAcListsSync(DescribeAcListsRequest req)
        {
             JsonResponseModel<DescribeAcListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAcLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAcListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// nat规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeNatRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeNatRuleOverviewResponse"/></returns>
        public async Task<DescribeNatRuleOverviewResponse> DescribeNatRuleOverview(DescribeNatRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeNatRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// nat规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeNatRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeNatRuleOverviewResponse"/></returns>
        public DescribeNatRuleOverviewResponse DescribeNatRuleOverviewSync(DescribeNatRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeNatRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public async Task<DescribeRuleOverviewResponse> DescribeRuleOverview(DescribeRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public DescribeRuleOverviewResponse DescribeRuleOverviewSync(DescribeRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public async Task<DescribeSwitchListsResponse> DescribeSwitchLists(DescribeSwitchListsRequest req)
        {
             JsonResponseModel<DescribeSwitchListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSwitchLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSwitchListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public DescribeSwitchListsResponse DescribeSwitchListsSync(DescribeSwitchListsRequest req)
        {
             JsonResponseModel<DescribeSwitchListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSwitchLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSwitchListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产状态查询-互联网&VPC
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncAssetStatusRequest"/></param>
        /// <returns><see cref="DescribeSyncAssetStatusResponse"/></returns>
        public async Task<DescribeSyncAssetStatusResponse> DescribeSyncAssetStatus(DescribeSyncAssetStatusRequest req)
        {
             JsonResponseModel<DescribeSyncAssetStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSyncAssetStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncAssetStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产状态查询-互联网&VPC
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncAssetStatusRequest"/></param>
        /// <returns><see cref="DescribeSyncAssetStatusResponse"/></returns>
        public DescribeSyncAssetStatusResponse DescribeSyncAssetStatusSync(DescribeSyncAssetStatusRequest req)
        {
             JsonResponseModel<DescribeSyncAssetStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSyncAssetStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncAssetStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则表状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public async Task<DescribeTableStatusResponse> DescribeTableStatus(DescribeTableStatusRequest req)
        {
             JsonResponseModel<DescribeTableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则表状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public DescribeTableStatusResponse DescribeTableStatusSync(DescribeTableStatusRequest req)
        {
             JsonResponseModel<DescribeTableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// vpc规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeVpcRuleOverviewResponse"/></returns>
        public async Task<DescribeVpcRuleOverviewResponse> DescribeVpcRuleOverview(DescribeVpcRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeVpcRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// vpc规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeVpcRuleOverviewResponse"/></returns>
        public DescribeVpcRuleOverviewResponse DescribeVpcRuleOverviewSync(DescribeVpcRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeVpcRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public async Task<ModifyAcRuleResponse> ModifyAcRule(ModifyAcRuleRequest req)
        {
             JsonResponseModel<ModifyAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public ModifyAcRuleResponse ModifyAcRuleSync(ModifyAcRuleRequest req)
        {
             JsonResponseModel<ModifyAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public async Task<ModifyAllRuleStatusResponse> ModifyAllRuleStatus(ModifyAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public ModifyAllRuleStatusResponse ModifyAllRuleStatusSync(ModifyAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 一键开启和关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyAllSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllSwitchStatusResponse"/></returns>
        public async Task<ModifyAllSwitchStatusResponse> ModifyAllSwitchStatus(ModifyAllSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 一键开启和关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyAllSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllSwitchStatusResponse"/></returns>
        public ModifyAllSwitchStatusResponse ModifyAllSwitchStatusSync(ModifyAllSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改单个防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyItemSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyItemSwitchStatusResponse"/></returns>
        public async Task<ModifyItemSwitchStatusResponse> ModifyItemSwitchStatus(ModifyItemSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyItemSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyItemSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyItemSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改单个防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyItemSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyItemSwitchStatusResponse"/></returns>
        public ModifyItemSwitchStatusResponse ModifyItemSwitchStatusSync(ModifyItemSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyItemSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyItemSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyItemSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则执行顺序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public async Task<ModifySequenceRulesResponse> ModifySequenceRules(ModifySequenceRulesRequest req)
        {
             JsonResponseModel<ModifySequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则执行顺序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public ModifySequenceRulesResponse ModifySequenceRulesSync(ModifySequenceRulesRequest req)
        {
             JsonResponseModel<ModifySequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则表状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public async Task<ModifyTableStatusResponse> ModifyTableStatus(ModifyTableStatusRequest req)
        {
             JsonResponseModel<ModifyTableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则表状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public ModifyTableStatusResponse ModifyTableStatusSync(ModifyTableStatusRequest req)
        {
             JsonResponseModel<ModifyTableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产-互联网&VPC
        /// </summary>
        /// <param name="req"><see cref="RunSyncAssetRequest"/></param>
        /// <returns><see cref="RunSyncAssetResponse"/></returns>
        public async Task<RunSyncAssetResponse> RunSyncAsset(RunSyncAssetRequest req)
        {
             JsonResponseModel<RunSyncAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunSyncAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunSyncAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产-互联网&VPC
        /// </summary>
        /// <param name="req"><see cref="RunSyncAssetRequest"/></param>
        /// <returns><see cref="RunSyncAssetResponse"/></returns>
        public RunSyncAssetResponse RunSyncAssetSync(RunSyncAssetRequest req)
        {
             JsonResponseModel<RunSyncAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunSyncAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunSyncAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
