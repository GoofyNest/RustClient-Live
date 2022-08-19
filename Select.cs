internal sealed class Select // TypeDefIndex: 4297
{	// Fields
	private readonly DataTable _table; // 0x10
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

	// Methods

	// RVA: 0xEAD600 Offset: 0xEACA00 VA: 0x180EAD600
	public void .ctor(DataTable table, string filterExpression, string sort, DataViewRowState recordStates) { }

	// RVA: 0xEACDF0 Offset: 0xEAC1F0 VA: 0x180EACDF0
	private bool IsSupportedOperator(int op) { }

	// RVA: 0xEA9D30 Offset: 0xEA9130 VA: 0x180EA9D30
	private void AnalyzeExpression(BinaryNode expr) { }

	// RVA: 0xEAA900 Offset: 0xEA9D00 VA: 0x180EAA900
	private bool CompareSortIndexDesc(IndexField[] fields) { }

	// RVA: 0xEAC130 Offset: 0xEAB530 VA: 0x180EAC130
	private bool FindSortIndex() { }

	// RVA: 0xEAA5F0 Offset: 0xEA99F0 VA: 0x180EAA5F0
	private int CompareClosestCandidateIndexDesc(IndexField[] fields) { }

	// RVA: 0xEABD10 Offset: 0xEAB110 VA: 0x180EABD10
	private bool FindClosestCandidateIndex() { }

	// RVA: 0xEACBC0 Offset: 0xEABFC0 VA: 0x180EACBC0
	private void InitCandidateColumns() { }

	// RVA: 0xEAAA50 Offset: 0xEA9E50 VA: 0x180EAAA50
	private void CreateIndex() { }

	// RVA: 0xEACD30 Offset: 0xEAC130 VA: 0x180EACD30
	private bool IsOperatorIn(ExpressionNode enode) { }

	// RVA: 0xEAA420 Offset: 0xEA9820 VA: 0x180EAA420
	private void BuildLinearExpression() { }

	// RVA: 0xEACE10 Offset: 0xEAC210 VA: 0x180EACE10
	public DataRow[] SelectRows() { }

	// RVA: 0xEACA80 Offset: 0xEABE80 VA: 0x180EACA80
	public DataRow[] GetRows() { }

	// RVA: 0xEA9B60 Offset: 0xEA8F60 VA: 0x180EA9B60
	private bool AcceptRecord(int record) { }

	// RVA: 0xEAB310 Offset: 0xEAA710 VA: 0x180EAB310
	private int Eval(BinaryNode expr, DataRow row, DataRowVersion version) { }

	// RVA: 0xEABB80 Offset: 0xEAAF80 VA: 0x180EABB80
	private int Evaluate(int record) { }

	// RVA: 0xEABF90 Offset: 0xEAB390 VA: 0x180EABF90
	private int FindFirstMatchingRecord() { }

	// RVA: 0xEAC060 Offset: 0xEAB460 VA: 0x180EAC060
	private int FindLastMatchingRecord(int lo) { }

	// RVA: 0xEAC340 Offset: 0xEAB740 VA: 0x180EAC340
	private Range GetBinaryFilteredRecords() { }

	// RVA: 0xEAC5A0 Offset: 0xEAB9A0 VA: 0x180EAC5A0
	private int[] GetLinearFilteredRecords(Range range) { }

	// RVA: 0xEAC860 Offset: 0xEABC60 VA: 0x180EAC860
	private DataRow[] GetLinearFilteredRows(Range range) { }

	// RVA: 0xEAA6A0 Offset: 0xEA9AA0 VA: 0x180EAA6A0
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xEAD440 Offset: 0xEAC840 VA: 0x180EAD440
	private void Sort(int left, int right) { }

}

private sealed class Select.ColumnInfo // TypeDefIndex: 4298
{	// Fields
	public bool flag; // 0x10
	public bool equalsOperator; // 0x11
	public BinaryNode expr; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

