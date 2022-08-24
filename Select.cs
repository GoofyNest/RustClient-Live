internal sealed class Select // TypeDefIndex: 4297
{
	private readonly DataTable _table; 
	private readonly IndexField[] _indexFields; 
	private DataViewRowState _recordStates; 
	private DataExpression _rowFilter; 
	private ExpressionNode _expression; 
	private Index _index; 
	private int[] _records; 
	private int _recordCount; 
	private ExpressionNode _linearExpression; 
	private bool _candidatesForBinarySearch; 
	private Select.ColumnInfo[] _candidateColumns; 
	private int _nCandidates; 
	private int _matchedCandidates; 


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
{
	public bool flag; 
	public bool equalsOperator; 
	public BinaryNode expr; 


	public void .ctor() { }

}

