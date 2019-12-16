namespace Terrasoft.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Web;
    using Core.Factories;
    using Web.Common;

    #region Class: ApprovalService 

    /// <summary>
    /// ApprovalService service class for working with Approval Entities
    /// </summary>
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class ApprovalService : BaseService
    {

        #region Methods: Private

        private bool ChangeApproval(ApprovalRequest request, Guid statusId) {
            if (request == null) {
                return false;
            }
            var action = ClassFactory.Get<ApprovalAction>(new ConstructorArgument("userConnection", UserConnection));
            if (request.AdditionalColumnValues == null) {
                request.AdditionalColumnValues = new Dictionary<string, object>();
            }
            request.AdditionalColumnValues.Add("StatusId", statusId);
            return action.ChangeApproval(request.SchemaName, request.Id, request.AdditionalColumnValues);
        }

        #endregion

        #region Methods: Public

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public bool Approve(ApprovalRequest request) {
            return ChangeApproval(request, ApprovalConstants.Accepted);
        }
        
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public bool Reject(ApprovalRequest request) {
            return ChangeApproval(request, ApprovalConstants.Rejected);
        }

        #endregion

    }

    #endregion

    #region Class: ApprovalRequest

    /// <summary>
    /// ApprovalRequest json object.
    /// </summary>
    [DataContract]
    public class ApprovalRequest
    {

        #region Properties: Public

        /// <summary>
        /// Identifier.
        /// </summary>
        [DataMember(Name = "id")] 
        public Guid Id;

        /// <summary>
        /// Approval schema name.
        /// </summary>
        [DataMember(Name = "schemaName")] 
        public string SchemaName;

        /// <summary>
        /// Additional column values.
        /// </summary>
        [DataMember(Name = "additionalColumnValues")] 
        public Dictionary<string, object> AdditionalColumnValues;

        #endregion

    }

    #endregion

}
