internal sealed class NewDiffgramGen // TypeDefIndex: 4331
{	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48


	internal void .ctor(DataSet ds) { }

	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	private void CreateTableHierarchy(DataTable dt) { }

	private void DoAssignments(ArrayList tables) { }

	private bool EmptyData() { }

	internal void Save(XmlWriter xmlw) { }

	internal void Save(XmlWriter xmlw, DataTable table) { }

	private void GenerateTable(DataTable table) { }

	private void GenerateTableErrors(DataTable table) { }

	private void GenerateRow(DataRow row) { }

	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	internal static string QualifiedName(string prefix, string name) { }

}

