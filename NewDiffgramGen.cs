internal sealed class NewDiffgramGen // TypeDefIndex: 4331
{	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0xEA6AB0 Offset: 0xEA5EB0 VA: 0x180EA6AB0
	internal void .ctor(DataSet ds) { }

	// RVA: 0xEA6C00 Offset: 0xEA6000 VA: 0x180EA6C00
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xEA48E0 Offset: 0xEA3CE0 VA: 0x180EA48E0
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xEA4BA0 Offset: 0xEA3FA0 VA: 0x180EA4BA0
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0xEA4EA0 Offset: 0xEA42A0 VA: 0x180EA4EA0
	private bool EmptyData() { }

	// RVA: 0xEA6AA0 Offset: 0xEA5EA0 VA: 0x180EA6AA0
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0xEA6570 Offset: 0xEA5970 VA: 0x180EA6570
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xEA6480 Offset: 0xEA5880 VA: 0x180EA6480
	private void GenerateTable(DataTable table) { }

	// RVA: 0xEA5EB0 Offset: 0xEA52B0 VA: 0x180EA5EB0
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0xEA58D0 Offset: 0xEA4CD0 VA: 0x180EA58D0
	private void GenerateRow(DataRow row) { }

	// RVA: 0xEA5010 Offset: 0xEA4410 VA: 0x180EA5010
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xEA6510 Offset: 0xEA5910 VA: 0x180EA6510
	internal static string QualifiedName(string prefix, string name) { }

}

