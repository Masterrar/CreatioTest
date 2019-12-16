namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Http.Abstractions;
	using SystemSettings = Core.Configuration.SysSettings;

	#region Class: EstimateLinksGenerator

	/// <summary>
	/// Satisfaction level image links generator.
	/// </summary>
	public class EstimateLinksGenerator : IMacrosInvokable
	{

		#region Constants: Private

		private const int RowLengthLimit = 10;
		private const int CellSize = 40;
		private const int CellPadding = 10;
		private const string DivFormat = "<div data-item-marker=\"satisfaction-level-{0}\" style=\"{1}\">";
		private const string DivStyleFormat = "width: {0}px; height: {0}px; vertical-align: middle; float: left;";
		private const string LinkFormat = "{0}/ServiceModel/CaseRatingManagementService.svc/RateCase/{1}/{2}";
		private const string TokenLinkFormat =
			"{0}/ServiceModel/CaseRatingManagementService.svc/SecureRateCase/[?CaseId={1}?]/{2}";
		private const string ImgFormat = "<img src=\"data:{0};base64,{1}\" width={2} height={2} alt=\"{3}\" />";
		private const string AttachedImgFormat = "<img src=\"{0}\" width={1} height={1} alt=\"{2}\" />";

		#endregion

		#region Constructors: Public

		public EstimateLinksGenerator() {
		}

		public EstimateLinksGenerator(IHttpContextAccessor httpContextAccessor) {
			_httpContextAccessor = httpContextAccessor;
		}

		#endregion

		#region Properties : Private

		private IHttpContextAccessor _httpContextAccessor;
		private IHttpContextAccessor HttpContextAccessor {
			get {
				if (_httpContextAccessor == null) {
					_httpContextAccessor = HttpContext.HttpContextAccessor;
				}
				return _httpContextAccessor;
			}
		}

		#endregion

		#region Properties : Protected

		/// <summary>
		/// Defaul div style.
		/// </summary>
		protected string DefaultDivStyle {
			get	{
				return string.Format(DivStyleFormat, CellSize);
			}
		}

		#endregion

		#region Properties : Public

		/// <summary>
		/// User connection.
		/// </summary>
		public UserConnection UserConnection { get; set; }

		#endregion

		#region Methods : Protected

		/// <summary>
		/// Returns application url.
		/// </summary>
		/// <returns>Url string.</returns>
		protected virtual string GetApplicationUrl() {
			var portalSiteUrl = SystemSettings.GetValue(UserConnection, "PortalSiteUrl", string.Empty);
			if (string.IsNullOrEmpty(portalSiteUrl)) {
				HttpContext httpContext = HttpContextAccessor.GetInstance();
				return httpContext != null
					? WebUtilities.GetBaseApplicationUrl(httpContext.Request)
					: SystemSettings.GetValue(UserConnection, "SiteUrl", string.Empty);
			}		
			return portalSiteUrl;
		}

		/// <summary>
		/// Gets record id from argument object.
		/// </summary>
		/// <param name="argument">Argument object.</param>
		/// <returns>Record id.</returns>
		protected virtual Guid GetRecordId(object argument) {
			var recordArgument = argument as KeyValuePair<string, Guid>?;
			return recordArgument.HasValue ? recordArgument.Value.Value : Guid.Empty;
		}

		/// <summary>
		/// Builds an HTML table cell (<td>) containing image link.
		/// </summary>
		/// <param name="id">Record id.</param>
		/// <param name="point">Point.</param>
		/// <param name="imageData">Binary image data.</param>
		/// <param name="mimeType">Image mime-type.</param>
		/// <param name="divStyle">Custom div style.</param>
		/// <returns>Table cell HTML-code.</returns>
		[Obsolete("7.14.3 | Use GetLinkCell(Guid id, int point, string emoticonImageUrl, string divStyle) instead")]
		protected virtual string GetLinkCell(Guid id, int point, byte[] imageData, string mimeType,
			string divStyle = null) {
			string appRootUrl = GetApplicationUrl();
			string linkFormat = UserConnection.GetIsFeatureEnabled("SecureEstimation") ? TokenLinkFormat : LinkFormat;
			string link = string.Format(linkFormat, appRootUrl, id, point);
			string encodedData = Convert.ToBase64String(imageData);
			var sb = new StringBuilder(1024);
			sb.Append("<td>")
				.AppendFormat(DivFormat, point, divStyle ?? DefaultDivStyle)
					.AppendFormat("<a href=\"{0}\">", link)
						.AppendFormat(ImgFormat, mimeType, encodedData, CellSize, point)
					.Append("</a>")
				.Append("</div>")
			.Append("</td>");
			return sb.ToString();
		}

		/// <summary>
		/// Builds an HTML table cell (<td>) containing image link.
		/// </summary>
		/// <param name="id">Record id.</param>
		/// <param name="point">Point.</param>
		/// <param name="emoticonImageUrl">Emoticon image URL.</param>
		/// <param name="divStyle">Custom div style.</param>
		/// <returns>Table cell HTML-code.</returns>
		protected virtual string GetLinkCell(Guid id, int point, string emoticonImageUrl, string divStyle = null) {
			string appRootUrl = GetApplicationUrl();
			string linkFormat = UserConnection.GetIsFeatureEnabled("SecureEstimation") ? TokenLinkFormat : LinkFormat;
			string link = string.Format(linkFormat, appRootUrl, id, point);
			var sb = new StringBuilder(1024);
			sb.Append("<td>")
				.AppendFormat(DivFormat, point, divStyle ?? DefaultDivStyle)
					.AppendFormat("<a href=\"{0}\">", link)
						.AppendFormat(AttachedImgFormat, emoticonImageUrl, CellSize, point)
					.Append("</a>")
				.Append("</div>")
			.Append("</td>");
			return sb.ToString();
		}

		#endregion

		#region Methods : Public

		/// <summary>
		/// Returns string value for macros.
		/// </summary>
		/// <param name="arguments">Arguments object.</param>
		/// <returns>Result string.</returns>
		public virtual string GetMacrosValue(object arguments) {
			bool featureAttachedImagesForCaseEstimationEmoticonsEnabled =
				UserConnection.GetIsFeatureEnabled("AttachedImagesForCaseEstimationEmoticons");
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SatisfactionLevel");
			EntitySchemaQueryColumn pointColumn = esq.AddColumn("Point");
			pointColumn.OrderDirection = OrderDirection.Descending;
			string pointColumnName = pointColumn.Name;
			string imageIdColumnName = esq.AddColumn("Image.Id").Name;
			string dataColumnName = featureAttachedImagesForCaseEstimationEmoticonsEnabled
				? ""
				: esq.AddColumn("Image.Data").Name;
			string mimeTypeColumnName = featureAttachedImagesForCaseEstimationEmoticonsEnabled
				? ""
				: esq.AddColumn("Image.MimeType").Name;
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "IsActive", true));
			EntityCollection satisfactionLevels = esq.GetEntityCollection(UserConnection);
			if (!satisfactionLevels.Any())
				return string.Empty;
			Guid id = GetRecordId(arguments);
			var count = satisfactionLevels.Count;
			var rows = (count + RowLengthLimit - 1) / RowLengthLimit;
			var rowLenght = count / rows;
			var remainder = count % rows;
			var result = new StringBuilder(1024);
			result.AppendFormat("<table border=\"0\" cellpadding=\"{0}\" cellspacing=\"{0}\">", CellPadding);
			int index = 0;
			var sysImageSchemaUId = UserConnection.EntitySchemaManager.GetInstanceByName("SysImage").UId;
			for (var i = 0; i < rows && index < count; i++, remainder--) {
				result.Append("<tr>");
				for (var j = 0; j < rowLenght + (remainder > 0 ? 1 : 0) && index < count; j++, index++) {
					var satisfactionLevel = satisfactionLevels[index];
					var point = satisfactionLevel.GetTypedColumnValue<int>(pointColumnName);
					if (featureAttachedImagesForCaseEstimationEmoticonsEnabled) {
						var imageId = satisfactionLevel.GetTypedColumnValue<Guid>(imageIdColumnName);
						if (imageId != default(Guid)) {
							var emoticonImageUrl = string.Format("../rest/FileService/GetFile/{0}/{1}",
								sysImageSchemaUId, imageId);
							result.Append(GetLinkCell(id, point, emoticonImageUrl));
						}
					} else {
						var image = satisfactionLevel.GetStreamValue(dataColumnName);
						if (image != null) {
							var imageBinaryData = image.ReadAllBytes();
							var mimeType = satisfactionLevel.GetTypedColumnValue<string>(mimeTypeColumnName);
							var linkCell = GetLinkCell(id, point, imageBinaryData, mimeType);
							result.Append(linkCell);
						}
					}
				}
				result.Append("</tr>");
			}
			result.Append("</table>");
			return result.ToString();
		}

		#endregion

	}

	#endregion

}

