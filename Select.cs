internal sealed class Select // TypeDefIndex: 4297
{	private readonly DataTable _table; // 0x10
	private readonly IndexField[] _indexFields; // 0x18
	private DataViewRowState _recordStates; // 0x20
	private DataExpression _rowFilter; // 0x28
	private ExpressionNode _expression; // 0x30
	private Index _index; // 0x38
	private int[] _records; // 0x40
	private int _recordCount; // 0x48
	private ExpressionNode _linearExpression; // 0x50
	private bool _candidatesForBinarySearch; // 0x58
	private Select.ColumnInfo[] _candidateColumns; // 0x60
	private int _nCandidates; // 0x68
	private int _matchedCandidates; // 0x6C


	public void .ctor(DataTable table, string filterExpression, string sort, DataViewRowState recordStates) { }

	private bool IsSupportedOperator(int op) { }

	private void AnalyzeExpression(BinaryNode expr) { }

	private bool CompareSortIndexDesc(IndexField[] fields) { }

	private bool FindSortIndex() { }

	private int CompareClosestCandidateIndexDesc(IndexField[] fields) { }

	private bool FindClosestCandidateIndex() { }

	private void InitCandidateColumns() { }

	private void CreateIndex() { }

	private bool IsOperatorIn(ExpressionNode enode) { }

	private void BuildLinearExpression() { }

	public DataRow[] SelectRows() { }

	public DataRow[] GetRows() { }

	private bool AcceptRecord(int record) { }

	private int Eval(BinaryNode expr, DataRow row, DataRowVersion version) { }

	private int Evaluate(int record) { }

	private int FindFirstMatchingRecord() { }

	private int FindLastMatchingRecord(int lo) { }

	private Range GetBinaryFilteredRecords() { }

	private int[] GetLinearFilteredRecords(Range range) { }

	private DataRow[] GetLinearFilteredRows(Range range) { }

	private int CompareRecords(int record1, int record2) { }

	private void Sort(int left, int right) { }

}

private sealed class Select.ColumnInfo // TypeDefIndex: 4298
{	public bool flag; // 0x10
	public bool equalsOperator; // 0x11
	public BinaryNode expr; // 0x18


	public void .ctor() { }

}

