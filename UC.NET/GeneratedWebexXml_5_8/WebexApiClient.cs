/*
 Generation Steps

 First save this template:

        public {2} {0}({1} {3})
        {{
            messageType message = new messageType();
            message.header = new messageTypeHeader();
            message.header.securityContext = security;
            message.body = new bodyContentType[] {{ {3} }};
            var response = Send(message);
            HandleResponse(response.header.response.FirstOrDefault());
            return ({2})response.body.FirstOrDefault();
        }}

        public async Task<{2}> {0}Async({1} {3})
        {{
            messageType message = new messageType();
            message.header = new messageTypeHeader();
            message.header.securityContext = security;
            message.body = new bodyContentType[] {{ {3} }};
            var response = await SendAsync(message);
            HandleResponse(response.header.response.FirstOrDefault());
            return ({2})response.body.FirstOrDefault();
        }}

  Then grab and format a listing of the api commands and response names from client.cs (e.g. createUser, createUserResponse, etc...)

  Format the list as all first characters as lowercase (will have to fix later)

  Run this ($w is the listing of action and response names)

  $w |? {$_ -notlike "*response"} |% {$c2 = "$($_)Response";$c0 = $_; $c1 = $_; $x = [Regex]::Replace($_, "^[a-z]+", ""); $c3 = [char]::ToLower($x[0]) + $x.Substring(1); $a -f $c0, $c1, $c2, $c3} | Out-File .\webexresults.txt

  add the results and fix any naming issues manually (use "\bevent\b" regex to replace with "recordedevent")

*
*/

using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebexNetClient
{
    public class WebexApiClient
    {
        private HttpClient client;
        private securityContextType security;

        public WebexApiClient(string BaseAddress, securityContextType Security)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(BaseAddress);
            security = Security;
        }

        private async Task<messageType> SendAsync(messageType message)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

            var content = new StringContent(message.Serialize());
            var response = await client.PostAsync("", content);
            var data = await response.Content.ReadAsStringAsync();
            var messageResponse = data.Deserialize<messageType>();

            return messageResponse;
        }

        private messageType Send(messageType message)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

            var content = new StringContent(message.Serialize());
            var response = client.PostAsync("", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var messageResponse = data.Deserialize<messageType>();

            return messageResponse;
        }

        private void HandleResponse(responseType response)
        {
            if (response.result == resultTypeType.FAILURE)
            {
                throw new Exception(response.reason);
            }
        }

        //action template

        public createUserResponse createUser(createUser user)
        {
            messageType message = new messageType();
            message.header = new messageTypeHeader();
            message.header.securityContext = security;
            message.body = new bodyContentType[] { user };
            var response = Send(message);
            HandleResponse(response.header.response.FirstOrDefault());
            return (createUserResponse)response.body.FirstOrDefault();
        }

        public async Task<createUserResponse> createUserAsync(createUser user)
        {
            messageType message = new messageType();
            message.header = new messageTypeHeader();
            message.header.securityContext = security;
            message.body = new bodyContentType[] { user };
            var response = await SendAsync(message);
            HandleResponse(response.header.response.FirstOrDefault());
            return (createUserResponse)response.body.FirstOrDefault();
        }

        public AssignWebACDAgentsResponse assignWebACDAgents(AssignWebACDAgents webACDAgents)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { webACDAgents }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (AssignWebACDAgentsResponse)response.body.FirstOrDefault();
        }

        public async Task<AssignWebACDAgentsResponse> assignWebACDAgentsAsync(AssignWebACDAgents webACDAgents)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { webACDAgents }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (AssignWebACDAgentsResponse)response.body.FirstOrDefault();
        }

        public AssignWebACDQueuesResponse assignWebACDQueues(AssignWebACDQueues webACDQueues)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { webACDQueues }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (AssignWebACDQueuesResponse)response.body.FirstOrDefault();
        }

        public async Task<AssignWebACDQueuesResponse> assignWebACDQueuesAsync(AssignWebACDQueues webACDQueues)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { webACDQueues }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (AssignWebACDQueuesResponse)response.body.FirstOrDefault();
        }

        public authenticateUserResponse authenticateUser(authenticateUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (authenticateUserResponse)response.body.FirstOrDefault();
        }

        public async Task<authenticateUserResponse> authenticateUserAsync(authenticateUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (authenticateUserResponse)response.body.FirstOrDefault();
        }

        public delSessionTemplatesResponse delSessionTemplates(delSessionTemplates sessionTemplates)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { sessionTemplates }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (delSessionTemplatesResponse)response.body.FirstOrDefault();
        }

        public async Task<delSessionTemplatesResponse> delSessionTemplatesAsync(delSessionTemplates sessionTemplates)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { sessionTemplates }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (delSessionTemplatesResponse)response.body.FirstOrDefault();
        }

        public uploadPMRImageResponse uploadPMRImage(uploadPMRImage pMRImage)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { pMRImage }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (uploadPMRImageResponse)response.body.FirstOrDefault();
        }

        public async Task<uploadPMRImageResponse> uploadPMRImageAsync(uploadPMRImage pMRImage)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { pMRImage }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (uploadPMRImageResponse)response.body.FirstOrDefault();
        }

        public getLoginTicketResponse getLoginTicket(getLoginTicket loginTicket)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { loginTicket }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getLoginTicketResponse)response.body.FirstOrDefault();
        }

        public async Task<getLoginTicketResponse> getLoginTicketAsync(getLoginTicket loginTicket)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { loginTicket }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getLoginTicketResponse)response.body.FirstOrDefault();
        }

        public inactivateUserResponse inactivateUser(inactivateUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (inactivateUserResponse)response.body.FirstOrDefault();
        }

        public async Task<inactivateUserResponse> inactivateUserAsync(inactivateUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (inactivateUserResponse)response.body.FirstOrDefault();
        }

        public activateUserResponse activateUser(activateUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (activateUserResponse)response.body.FirstOrDefault();
        }

        public async Task<activateUserResponse> activateUserAsync(activateUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (activateUserResponse)response.body.FirstOrDefault();
        }

        public getlogouturlUserResponse getlogouturlUser(getlogouturlUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getlogouturlUserResponse)response.body.FirstOrDefault();
        }

        public async Task<getlogouturlUserResponse> getlogouturlUserAsync(getlogouturlUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getlogouturlUserResponse)response.body.FirstOrDefault();
        }

        public getloginurlUserResponse getloginurlUser(getloginurlUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getloginurlUserResponse)response.body.FirstOrDefault();
        }

        public async Task<getloginurlUserResponse> getloginurlUserAsync(getloginurlUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getloginurlUserResponse)response.body.FirstOrDefault();
        }

        public delUserResponse delUser(delUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (delUserResponse)response.body.FirstOrDefault();
        }

        public async Task<delUserResponse> delUserAsync(delUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (delUserResponse)response.body.FirstOrDefault();
        }

        public getUserResponse getUser(getUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getUserResponse)response.body.FirstOrDefault();
        }

        public async Task<getUserResponse> getUserAsync(getUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getUserResponse)response.body.FirstOrDefault();
        }

        public lstUserResponse lstUser(lstUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstUserResponse)response.body.FirstOrDefault();
        }

        public async Task<lstUserResponse> lstUserAsync(lstUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstUserResponse)response.body.FirstOrDefault();
        }

        public lstsummaryUserResponse lstsummaryUser(lstsummaryUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummaryUserResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsummaryUserResponse> lstsummaryUserAsync(lstsummaryUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummaryUserResponse)response.body.FirstOrDefault();
        }

        public setUserResponse setUser(setUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setUserResponse)response.body.FirstOrDefault();
        }

        public async Task<setUserResponse> setUserAsync(setUser user)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { user }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setUserResponse)response.body.FirstOrDefault();
        }

        public getTeleconferenceSessionResponse getTeleconferenceSession(getTeleconferenceSession teleconferenceSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { teleconferenceSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getTeleconferenceSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<getTeleconferenceSessionResponse> getTeleconferenceSessionAsync(getTeleconferenceSession teleconferenceSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { teleconferenceSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getTeleconferenceSessionResponse)response.body.FirstOrDefault();
        }

        public setTeleconferenceSessionResponse setTeleconferenceSession(setTeleconferenceSession teleconferenceSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { teleconferenceSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setTeleconferenceSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<setTeleconferenceSessionResponse> setTeleconferenceSessionAsync(setTeleconferenceSession teleconferenceSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { teleconferenceSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setTeleconferenceSessionResponse)response.body.FirstOrDefault();
        }

        public createTeleconferenceSessionResponse createTeleconferenceSession(createTeleconferenceSession teleconferenceSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { teleconferenceSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createTeleconferenceSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<createTeleconferenceSessionResponse> createTeleconferenceSessionAsync(createTeleconferenceSession teleconferenceSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { teleconferenceSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createTeleconferenceSessionResponse)response.body.FirstOrDefault();
        }

        public createSupportSessionResponse createSupportSession(createSupportSession supportSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { supportSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createSupportSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<createSupportSessionResponse> createSupportSessionAsync(createSupportSession supportSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { supportSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createSupportSessionResponse)response.body.FirstOrDefault();
        }

        public GetWebACDQueuesResponse getWebACDQueues(GetWebACDQueues webACDQueues)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { webACDQueues }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (GetWebACDQueuesResponse)response.body.FirstOrDefault();
        }

        public async Task<GetWebACDQueuesResponse> getWebACDQueuesAsync(GetWebACDQueues webACDQueues)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { webACDQueues }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (GetWebACDQueuesResponse)response.body.FirstOrDefault();
        }

        public lstTimeZoneResponse lstTimeZone(lstTimeZone timeZone)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { timeZone }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstTimeZoneResponse)response.body.FirstOrDefault();
        }

        public async Task<lstTimeZoneResponse> lstTimeZoneAsync(lstTimeZone timeZone)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { timeZone }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstTimeZoneResponse)response.body.FirstOrDefault();
        }

        public getSiteResponse getSite(getSite site)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { site }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getSiteResponse)response.body.FirstOrDefault();
        }

        public async Task<getSiteResponse> getSiteAsync(getSite site)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { site }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getSiteResponse)response.body.FirstOrDefault();
        }

        public setSiteResponse setSite(setSite site)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { site }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setSiteResponse)response.body.FirstOrDefault();
        }

        public async Task<setSiteResponse> setSiteAsync(setSite site)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { site }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setSiteResponse)response.body.FirstOrDefault();
        }

        public lstOpportunitiesResponse lstOpportunities(lstOpportunities opportunities)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { opportunities }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstOpportunitiesResponse)response.body.FirstOrDefault();
        }

        public async Task<lstOpportunitiesResponse> lstOpportunitiesAsync(lstOpportunities opportunities)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { opportunities }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstOpportunitiesResponse)response.body.FirstOrDefault();
        }

        public setOpportunityResponse setOpportunity(setOpportunity opportunity)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { opportunity }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setOpportunityResponse)response.body.FirstOrDefault();
        }

        public async Task<setOpportunityResponse> setOpportunityAsync(setOpportunity opportunity)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { opportunity }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setOpportunityResponse)response.body.FirstOrDefault();
        }

        public createOpportunityResponse createOpportunity(createOpportunity opportunity)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { opportunity }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createOpportunityResponse)response.body.FirstOrDefault();
        }

        public async Task<createOpportunityResponse> createOpportunityAsync(createOpportunity opportunity)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { opportunity }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createOpportunityResponse)response.body.FirstOrDefault();
        }

        public lstAccountsResponse lstAccounts(lstAccounts accounts)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { accounts }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstAccountsResponse)response.body.FirstOrDefault();
        }

        public async Task<lstAccountsResponse> lstAccountsAsync(lstAccounts accounts)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { accounts }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstAccountsResponse)response.body.FirstOrDefault();
        }

        public setAccountResponse setAccount(setAccount account)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { account }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setAccountResponse)response.body.FirstOrDefault();
        }

        public async Task<setAccountResponse> setAccountAsync(setAccount account)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { account }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setAccountResponse)response.body.FirstOrDefault();
        }

        public createAccountResponse createAccount(createAccount account)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { account }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createAccountResponse)response.body.FirstOrDefault();
        }

        public async Task<createAccountResponse> createAccountAsync(createAccount account)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { account }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createAccountResponse)response.body.FirstOrDefault();
        }

        public delSalesSessionResponse delSalesSession(delSalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (delSalesSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<delSalesSessionResponse> delSalesSessionAsync(delSalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (delSalesSessionResponse)response.body.FirstOrDefault();
        }

        public lstsummarySalesSessionResponse lstsummarySalesSession(lstsummarySalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummarySalesSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsummarySalesSessionResponse> lstsummarySalesSessionAsync(lstsummarySalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummarySalesSessionResponse)response.body.FirstOrDefault();
        }

        public getSalesSessionResponse getSalesSession(getSalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getSalesSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<getSalesSessionResponse> getSalesSessionAsync(getSalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getSalesSessionResponse)response.body.FirstOrDefault();
        }

        public createSalesSessionResponse createSalesSession(createSalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createSalesSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<createSalesSessionResponse> createSalesSessionAsync(createSalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createSalesSessionResponse)response.body.FirstOrDefault();
        }

        public setSalesSessionResponse setSalesSession(setSalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setSalesSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<setSalesSessionResponse> setSalesSessionAsync(setSalesSession salesSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { salesSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setSalesSessionResponse)response.body.FirstOrDefault();
        }

        public setProductsResponse setProducts(setProducts products)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { products }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setProductsResponse)response.body.FirstOrDefault();
        }

        public async Task<setProductsResponse> setProductsAsync(setProducts products)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { products }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setProductsResponse)response.body.FirstOrDefault();
        }

        public addProductsResponse addProducts(addProducts products)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { products }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (addProductsResponse)response.body.FirstOrDefault();
        }

        public async Task<addProductsResponse> addProductsAsync(addProducts products)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { products }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (addProductsResponse)response.body.FirstOrDefault();
        }

        public lstProductsResponse lstProducts(lstProducts products)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { products }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstProductsResponse)response.body.FirstOrDefault();
        }

        public async Task<lstProductsResponse> lstProductsAsync(lstProducts products)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { products }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstProductsResponse)response.body.FirstOrDefault();
        }

        public getjoinurlMeetingResponse getjoinurlMeeting(getjoinurlMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getjoinurlMeetingResponse)response.body.FirstOrDefault();
        }

        public async Task<getjoinurlMeetingResponse> getjoinurlMeetingAsync(getjoinurlMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getjoinurlMeetingResponse)response.body.FirstOrDefault();
        }

        public gethosturlMeetingResponse gethosturlMeeting(gethosturlMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (gethosturlMeetingResponse)response.body.FirstOrDefault();
        }

        public async Task<gethosturlMeetingResponse> gethosturlMeetingAsync(gethosturlMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (gethosturlMeetingResponse)response.body.FirstOrDefault();
        }

        public getMeetingResponse getMeeting(getMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getMeetingResponse)response.body.FirstOrDefault();
        }

        public async Task<getMeetingResponse> getMeetingAsync(getMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getMeetingResponse)response.body.FirstOrDefault();
        }

        public delMeetingResponse delMeeting(delMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (delMeetingResponse)response.body.FirstOrDefault();
        }

        public async Task<delMeetingResponse> delMeetingAsync(delMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (delMeetingResponse)response.body.FirstOrDefault();
        }

        public lstsummaryMeetingResponse lstsummaryMeeting(lstsummaryMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummaryMeetingResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsummaryMeetingResponse> lstsummaryMeetingAsync(lstsummaryMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummaryMeetingResponse)response.body.FirstOrDefault();
        }

        public lstMeetingResponse lstMeeting(lstMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstMeetingResponse)response.body.FirstOrDefault();
        }

        public async Task<lstMeetingResponse> lstMeetingAsync(lstMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstMeetingResponse)response.body.FirstOrDefault();
        }

        public createMeetingResponse createMeeting(createMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createMeetingResponse)response.body.FirstOrDefault();
        }

        public async Task<createMeetingResponse> createMeetingAsync(createMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createMeetingResponse)response.body.FirstOrDefault();
        }

        public setMeetingResponse setMeeting(setMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setMeetingResponse)response.body.FirstOrDefault();
        }

        public async Task<setMeetingResponse> setMeetingAsync(setMeeting meeting)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meeting }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setMeetingResponse)response.body.FirstOrDefault();
        }

        public lstsupportattendeeHistoryResponse lstsupportattendeeHistory(lstsupportattendeeHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsupportattendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsupportattendeeHistoryResponse> lstsupportattendeeHistoryAsync(lstsupportattendeeHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsupportattendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public lstsupportsessionHistoryResponse lstsupportsessionHistory(lstsupportsessionHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsupportsessionHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsupportsessionHistoryResponse> lstsupportsessionHistoryAsync(lstsupportsessionHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsupportsessionHistoryResponse)response.body.FirstOrDefault();
        }

        public lsteventattendeeHistoryResponse lsteventattendeeHistory(lsteventattendeeHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lsteventattendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lsteventattendeeHistoryResponse> lsteventattendeeHistoryAsync(lsteventattendeeHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lsteventattendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public lsteventsessionHistoryResponse lsteventsessionHistory(lsteventsessionHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lsteventsessionHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lsteventsessionHistoryResponse> lsteventsessionHistoryAsync(lsteventsessionHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lsteventsessionHistoryResponse)response.body.FirstOrDefault();
        }

        public lstmeetingattendeeHistoryResponse lstmeetingattendeeHistory(lstmeetingattendeeHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstmeetingattendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lstmeetingattendeeHistoryResponse> lstmeetingattendeeHistoryAsync(lstmeetingattendeeHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstmeetingattendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public lstsalesAttendeeHistoryResponse lstsalesAttendeeHistory(lstsalesAttendeeHistory attendeeHistory)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { attendeeHistory }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsalesAttendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsalesAttendeeHistoryResponse> lstsalesAttendeeHistoryAsync(lstsalesAttendeeHistory attendeeHistory)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { attendeeHistory }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsalesAttendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public lstmeetingusageHistoryResponse lstmeetingusageHistory(lstmeetingusageHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstmeetingusageHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lstmeetingusageHistoryResponse> lstmeetingusageHistoryAsync(lstmeetingusageHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstmeetingusageHistoryResponse)response.body.FirstOrDefault();
        }

        public lstsalesSessionHistoryResponse lstsalesSessionHistory(lstsalesSessionHistory sessionHistory)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { sessionHistory }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsalesSessionHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsalesSessionHistoryResponse> lstsalesSessionHistoryAsync(lstsalesSessionHistory sessionHistory)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { sessionHistory }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsalesSessionHistoryResponse)response.body.FirstOrDefault();
        }

        public lsttrainingattendeeHistoryResponse lsttrainingattendeeHistory(lsttrainingattendeeHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lsttrainingattendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lsttrainingattendeeHistoryResponse> lsttrainingattendeeHistoryAsync(lsttrainingattendeeHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lsttrainingattendeeHistoryResponse)response.body.FirstOrDefault();
        }

        public lsttrainingsessionHistoryResponse lsttrainingsessionHistory(lsttrainingsessionHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lsttrainingsessionHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lsttrainingsessionHistoryResponse> lsttrainingsessionHistoryAsync(lsttrainingsessionHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lsttrainingsessionHistoryResponse)response.body.FirstOrDefault();
        }

        public lstrecordaccessDetailHistoryResponse lstrecordaccessDetailHistory(lstrecordaccessDetailHistory detailHistory)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { detailHistory }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstrecordaccessDetailHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lstrecordaccessDetailHistoryResponse> lstrecordaccessDetailHistoryAsync(lstrecordaccessDetailHistory detailHistory)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { detailHistory }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstrecordaccessDetailHistoryResponse)response.body.FirstOrDefault();
        }

        public lstrecordaccessHistoryResponse lstrecordaccessHistory(lstrecordaccessHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstrecordaccessHistoryResponse)response.body.FirstOrDefault();
        }

        public async Task<lstrecordaccessHistoryResponse> lstrecordaccessHistoryAsync(lstrecordaccessHistory history)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { history }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstrecordaccessHistoryResponse)response.body.FirstOrDefault();
        }

        public lstsummaryProgramResponse lstsummaryProgram(lstsummaryProgram program)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { program }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummaryProgramResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsummaryProgramResponse> lstsummaryProgramAsync(lstsummaryProgram program)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { program }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummaryProgramResponse)response.body.FirstOrDefault();
        }

        public sendInvitationEmailResponse sendInvitationEmail(sendInvitationEmail invitationEmail)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { invitationEmail }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (sendInvitationEmailResponse)response.body.FirstOrDefault();
        }

        public async Task<sendInvitationEmailResponse> sendInvitationEmailAsync(sendInvitationEmail invitationEmail)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { invitationEmail }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (sendInvitationEmailResponse)response.body.FirstOrDefault();
        }

        public uploadEventImageResponse uploadEventImage(uploadEventImage eventImage)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { eventImage }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (uploadEventImageResponse)response.body.FirstOrDefault();
        }

        public async Task<uploadEventImageResponse> uploadEventImageAsync(uploadEventImage eventImage)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { eventImage }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (uploadEventImageResponse)response.body.FirstOrDefault();
        }

        public lstrecordedEventResponse lstrecordedEvent(lstrecordedEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstrecordedEventResponse)response.body.FirstOrDefault();
        }

        public async Task<lstrecordedEventResponse> lstrecordedEventAsync(lstrecordedEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstrecordedEventResponse)response.body.FirstOrDefault();
        }

        public lstsummaryEventResponse lstsummaryEvent(lstsummaryEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummaryEventResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsummaryEventResponse> lstsummaryEventAsync(lstsummaryEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummaryEventResponse)response.body.FirstOrDefault();
        }

        public delEventResponse delEvent(delEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (delEventResponse)response.body.FirstOrDefault();
        }

        public async Task<delEventResponse> delEventAsync(delEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (delEventResponse)response.body.FirstOrDefault();
        }

        public getEventResponse getEvent(getEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getEventResponse)response.body.FirstOrDefault();
        }

        public async Task<getEventResponse> getEventAsync(getEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getEventResponse)response.body.FirstOrDefault();
        }

        public createEventResponse createEvent(createEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createEventResponse)response.body.FirstOrDefault();
        }

        public async Task<createEventResponse> createEventAsync(createEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createEventResponse)response.body.FirstOrDefault();
        }

        public setEventResponse setEvent(setEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setEventResponse)response.body.FirstOrDefault();
        }

        public async Task<setEventResponse> setEventAsync(setEvent recordedevent)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordedevent }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setEventResponse)response.body.FirstOrDefault();
        }

        public delRecordingResponse delRecording(delRecording recording)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recording }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (delRecordingResponse)response.body.FirstOrDefault();
        }

        public async Task<delRecordingResponse> delRecordingAsync(delRecording recording)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recording }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (delRecordingResponse)response.body.FirstOrDefault();
        }

        public setRecordingInfoResponse setRecordingInfo(setRecordingInfo recordingInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordingInfo }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setRecordingInfoResponse)response.body.FirstOrDefault();
        }

        public async Task<setRecordingInfoResponse> setRecordingInfoAsync(setRecordingInfo recordingInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordingInfo }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setRecordingInfoResponse)response.body.FirstOrDefault();
        }

        public getRecordingInfoResponse getRecordingInfo(getRecordingInfo recordingInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordingInfo }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getRecordingInfoResponse)response.body.FirstOrDefault();
        }

        public async Task<getRecordingInfoResponse> getRecordingInfoAsync(getRecordingInfo recordingInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recordingInfo }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getRecordingInfoResponse)response.body.FirstOrDefault();
        }

        public lstRecordingResponse lstRecording(lstRecording recording)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recording }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstRecordingResponse)response.body.FirstOrDefault();
        }

        public async Task<lstRecordingResponse> lstRecordingAsync(lstRecording recording)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { recording }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstRecordingResponse)response.body.FirstOrDefault();
        }

        public setupOneClickSettingsResponse setupOneClickSettings(setupOneClickSettings oneClickSettings)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { oneClickSettings }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setupOneClickSettingsResponse)response.body.FirstOrDefault();
        }

        public async Task<setupOneClickSettingsResponse> setupOneClickSettingsAsync(setupOneClickSettings oneClickSettings)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { oneClickSettings }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setupOneClickSettingsResponse)response.body.FirstOrDefault();
        }

        public getSessionInfoResponse getSessionInfo(getSessionInfo sessionInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { sessionInfo }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getSessionInfoResponse)response.body.FirstOrDefault();
        }

        public async Task<getSessionInfoResponse> getSessionInfoAsync(getSessionInfo sessionInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { sessionInfo }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getSessionInfoResponse)response.body.FirstOrDefault();
        }

        public getJoinSessionInfoResponse getJoinSessionInfo(getJoinSessionInfo joinSessionInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { joinSessionInfo }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getJoinSessionInfoResponse)response.body.FirstOrDefault();
        }

        public async Task<getJoinSessionInfoResponse> getJoinSessionInfoAsync(getJoinSessionInfo joinSessionInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { joinSessionInfo }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getJoinSessionInfoResponse)response.body.FirstOrDefault();
        }

        public lstDistListResponse lstDistList(lstDistList distList)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { distList }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstDistListResponse)response.body.FirstOrDefault();
        }

        public async Task<lstDistListResponse> lstDistListAsync(lstDistList distList)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { distList }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstDistListResponse)response.body.FirstOrDefault();
        }

        public setDistListResponse setDistList(setDistList distList)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { distList }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (setDistListResponse)response.body.FirstOrDefault();
        }

        public async Task<setDistListResponse> setDistListAsync(setDistList distList)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { distList }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (setDistListResponse)response.body.FirstOrDefault();
        }

        public createDistListResponse createDistList(createDistList distList)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { distList }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createDistListResponse)response.body.FirstOrDefault();
        }

        public async Task<createDistListResponse> createDistListAsync(createDistList distList)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { distList }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createDistListResponse)response.body.FirstOrDefault();
        }

        public lstContactResponse lstContact(lstContact contact)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { contact }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstContactResponse)response.body.FirstOrDefault();
        }

        public async Task<lstContactResponse> lstContactAsync(lstContact contact)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { contact }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstContactResponse)response.body.FirstOrDefault();
        }

        public createContactsResponse createContacts(createContacts contacts)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { contacts }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createContactsResponse)response.body.FirstOrDefault();
        }

        public async Task<createContactsResponse> createContactsAsync(createContacts contacts)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { contacts }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createContactsResponse)response.body.FirstOrDefault();
        }

        public getOneClickSettingsResponse getOneClickSettings(getOneClickSettings oneClickSettings)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { oneClickSettings }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getOneClickSettingsResponse)response.body.FirstOrDefault();
        }

        public async Task<getOneClickSettingsResponse> getOneClickSettingsAsync(getOneClickSettings oneClickSettings)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { oneClickSettings }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getOneClickSettingsResponse)response.body.FirstOrDefault();
        }

        public delSessionResponse delSession(delSession session)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { session }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (delSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<delSessionResponse> delSessionAsync(delSession session)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { session }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (delSessionResponse)response.body.FirstOrDefault();
        }

        public lstsummarySessionResponse lstsummarySession(lstsummarySession session)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { session }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummarySessionResponse)response.body.FirstOrDefault();
        }

        public async Task<lstsummarySessionResponse> lstsummarySessionAsync(lstsummarySession session)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { session }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstsummarySessionResponse)response.body.FirstOrDefault();
        }

        public lstOpenSessionResponse lstOpenSession(lstOpenSession openSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { openSession }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstOpenSessionResponse)response.body.FirstOrDefault();
        }

        public async Task<lstOpenSessionResponse> lstOpenSessionAsync(lstOpenSession openSession)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { openSession }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstOpenSessionResponse)response.body.FirstOrDefault();
        }

        public getAPIVersionResponse getAPIVersion(getAPIVersion aPIVersion)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { aPIVersion }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getAPIVersionResponse)response.body.FirstOrDefault();
        }

        public async Task<getAPIVersionResponse> getAPIVersionAsync(getAPIVersion aPIVersion)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { aPIVersion }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getAPIVersionResponse)response.body.FirstOrDefault();
        }

        public getFeedbackInfoResponse getFeedbackInfo(getFeedbackInfo feedbackInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { feedbackInfo }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getFeedbackInfoResponse)response.body.FirstOrDefault();
        }

        public async Task<getFeedbackInfoResponse> getFeedbackInfoAsync(getFeedbackInfo feedbackInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { feedbackInfo }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getFeedbackInfoResponse)response.body.FirstOrDefault();
        }

        public getEnrollmentInfoResponse getEnrollmentInfo(getEnrollmentInfo enrollmentInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { enrollmentInfo }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (getEnrollmentInfoResponse)response.body.FirstOrDefault();
        }

        public async Task<getEnrollmentInfoResponse> getEnrollmentInfoAsync(getEnrollmentInfo enrollmentInfo)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { enrollmentInfo }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (getEnrollmentInfoResponse)response.body.FirstOrDefault();
        }

        public delMeetingAttendeeResponse delMeetingAttendee(delMeetingAttendee meetingAttendee)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meetingAttendee }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (delMeetingAttendeeResponse)response.body.FirstOrDefault();
        }

        public async Task<delMeetingAttendeeResponse> delMeetingAttendeeAsync(delMeetingAttendee meetingAttendee)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meetingAttendee }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (delMeetingAttendeeResponse)response.body.FirstOrDefault();
        }

        public lstMeetingAttendeeResponse lstMeetingAttendee(lstMeetingAttendee meetingAttendee)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meetingAttendee }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstMeetingAttendeeResponse)response.body.FirstOrDefault();
        }

        public async Task<lstMeetingAttendeeResponse> lstMeetingAttendeeAsync(lstMeetingAttendee meetingAttendee)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meetingAttendee }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (lstMeetingAttendeeResponse)response.body.FirstOrDefault();
        }

        public registerMeetingAttendeeResponse registerMeetingAttendee(registerMeetingAttendee meetingAttendee)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meetingAttendee }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (registerMeetingAttendeeResponse)response.body.FirstOrDefault();
        }

        public async Task<registerMeetingAttendeeResponse> registerMeetingAttendeeAsync(registerMeetingAttendee meetingAttendee)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meetingAttendee }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (registerMeetingAttendeeResponse)response.body.FirstOrDefault();
        }

        public createMeetingAttendeeResponse createMeetingAttendee(createMeetingAttendee meetingAttendee)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meetingAttendee }; var response = Send(message); HandleResponse(response.header.response.FirstOrDefault()); return (createMeetingAttendeeResponse)response.body.FirstOrDefault();
        }

        public async Task<createMeetingAttendeeResponse> createMeetingAttendeeAsync(createMeetingAttendee meetingAttendee)
        {
            messageType message = new messageType(); message.header = new messageTypeHeader(); message.header.securityContext = security; message.body = new bodyContentType[] { meetingAttendee }; var response = await SendAsync(message); HandleResponse(response.header.response.FirstOrDefault()); return (createMeetingAttendeeResponse)response.body.FirstOrDefault();
        }
    }
}