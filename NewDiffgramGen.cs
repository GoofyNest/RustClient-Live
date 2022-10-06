internal sealed class NewDiffgramGen // TypeDefIndex: 4334
{
	internal XmlDocument _doc; 
	internal DataSet _ds; 
	internal DataTable _dt; 
	internal XmlWriter _xmlw; 
	private bool _fBefore; 
	private bool _fErrors; 
	internal Hashtable _rowsOrder; 
	private ArrayList _tables; 
	private bool _writeHierarchy; 


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

