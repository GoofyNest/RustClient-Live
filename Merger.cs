internal sealed class Merger // TypeDefIndex: 4277
{	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0xEA4070 Offset: 0xEA3470 VA: 0x180EA4070
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xEA4000 Offset: 0xEA3400 VA: 0x180EA4000
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xEA1570 Offset: 0xEA0970 VA: 0x180EA1570
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0xEA3890 Offset: 0xEA2C90 VA: 0x180EA3890
	internal void MergeTable(DataTable src) { }

	// RVA: 0xEA3AF0 Offset: 0xEA2EF0 VA: 0x180EA3AF0
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xEA2E80 Offset: 0xEA2280 VA: 0x180EA2E80
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0xEA37D0 Offset: 0xEA2BD0 VA: 0x180EA37D0
	private void MergeTableData(DataTable src) { }

	// RVA: 0xEA14E0 Offset: 0xEA08E0 VA: 0x180EA14E0
	private void MergeConstraints(DataSet source) { }

	// RVA: 0xEA1240 Offset: 0xEA0640 VA: 0x180EA1240
	private void MergeConstraints(DataTable table) { }

	// RVA: 0xEA2400 Offset: 0xEA1800 VA: 0x180EA2400
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0xEA2260 Offset: 0xEA1660 VA: 0x180EA2260
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xEA10B0 Offset: 0xEA04B0 VA: 0x180EA10B0
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

}

