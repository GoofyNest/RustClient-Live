internal sealed class Merger // TypeDefIndex: 4277
{	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29


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

