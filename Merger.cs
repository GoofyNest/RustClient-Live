internal sealed class Merger // TypeDefIndex: 4282
{
	private DataSet _dataSet; 
	private DataTable _dataTable; 
	private bool _preserveChanges; 
	private MissingSchemaAction _missingSchemaAction; 
	private bool _isStandAlonetable; 
	private bool _IgnoreNSforTableLookup; 


	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	internal void MergeDataSet(DataSet source) { }

	internal void MergeTable(DataTable src) { }

	private void MergeTable(DataTable src, DataTable dst) { }

	private DataTable MergeSchema(DataTable table) { }

	private void MergeTableData(DataTable src) { }

	private void MergeConstraints(DataSet source) { }

	private void MergeConstraints(DataTable table) { }

	private void MergeRelation(DataRelation relation) { }

	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

}

