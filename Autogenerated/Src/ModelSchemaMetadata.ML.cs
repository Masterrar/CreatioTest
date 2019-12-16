namespace Terrasoft.Configuration.ML
{
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Runtime.Serialization;

	#region Class: ModelSchemaColumn

	/// <summary>
	/// Describes a column within a dataset.
	/// </summary>
	[DataContract]
	[DebuggerDisplay("{Name}")]
	public class ModelSchemaColumn
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets column name.
		/// </summary>
		[DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets column display name.
		/// This column is expected to be the same as <see cref="Name"/> column, but with human-readable names.
		/// This may only make sense for columns of type "Lookup" and "Boolean".
		/// </summary>
		[DataMember(Name = "displayName", IsRequired = false)]
		public string DisplayName { get; set; }

		/// <summary>
		/// Gets or sets column's caption.
		/// </summary>
		[DataMember(Name = "caption", IsRequired = false)]
		public string Caption { get; set; }

		/// <summary>
		/// Gets or sets column's reference schema name.
		/// </summary>
		[DataMember(Name = "referenceSchemaName", IsRequired = false)]
		public string ReferenceSchemaName { get; set; }

		/// <summary>
		/// Gets or sets the transform operations.
		/// </summary>
		/// <value>
		/// The transformations.
		/// </value>
		[DataMember(Name = "transformations", IsRequired = false)]
		public List<ModelSchemaColumnTransformation> Transformations { get; set; }

		#endregion

	}

	#endregion

	#region Class: ModelSchemaColumnTransformation

	/// <summary>
	/// Describes a column value transform operation.
	/// </summary>
	[DataContract]
	public class ModelSchemaColumnTransformation
	{

		#region Properties: Public


		/// <summary>
		/// Gets or sets the operation.
		/// </summary>
		/// <value>
		/// The operation.
		/// </value>
		[DataMember(Name = "operation", IsRequired = true)]
		public string Operation { get; set; }


		/// <summary>
		/// Gets or sets the transform arguments.
		/// </summary>
		/// <value>
		/// The arguments.
		/// </value>
		[DataMember(Name = "arguments", IsRequired = false)]
		public List<string> Arguments { get; set; }

		#endregion

	}

	#endregion

	#region Class: ModelSchemaInput

	/// <summary>
	/// Describes a column within a dataset to be used as model input.
	/// </summary>
	[DataContract]
	[DebuggerDisplay("Name = {Name}; Type = {Type}")]
	public class ModelSchemaInput : ModelSchemaColumn
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets column data type.
		/// Allowed values are: "Boolean", "Numeric", "Text", "Lookup", "DateTime".
		/// </summary>
		[DataMember(Name = "type", IsRequired = false)]
		public string Type { get; set; }

		/// <summary>
		/// Indicates whether model should expect this column may be <c>null</c> or <see cref="double.NaN"/>.
		/// Currently, this parameter is ignored.
		/// </summary>
		[DataMember(Name = "isRequired", IsRequired = false)]
		public bool IsRequired { get; set; }

		/// <summary>
		/// Indicates that the current input is not in use.
		/// </summary>
		[DataMember(Name = "isIgnored", IsRequired = false)]
		public bool IsIgnored { get; set; }

		#endregion

	}

	#endregion

	#region Class: ModelSchemaOutput

	/// <summary>
	/// Describes a column within a dataset, which should be used as predicted.
	/// </summary>
	[DataContract]
	public class ModelSchemaOutput : ModelSchemaColumn
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets column data type.
		/// Allowed values are: "Boolean", "Numeric", "Lookup".
		/// </summary>
		[DataMember(Name = "type", IsRequired = false)]
		public string Type { get; set; }

		#endregion

	}

	#endregion

	#region Class: ModelSchemaMetadata

	/// <summary>
	/// Describes the data set for model to be fitted.
	/// </summary>
	[DataContract]
	public class ModelSchemaMetadata
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets columns within a dataset to be used as model inputs.
		/// </summary>
		[DataMember(Name = "inputs", IsRequired = false)]
		public List<ModelSchemaInput> Inputs { get; set; }

		/// <summary>
		/// Gets or sets a column within a dataset, which should be used as predicted.
		/// </summary>
		[DataMember(Name = "output", IsRequired = false)]
		public ModelSchemaOutput Output { get; set; }

		#endregion

	}

	#endregion

}

