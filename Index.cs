internal sealed class Index // TypeDefIndex: 4305
{
	private readonly DataTable _table;
	internal readonly IndexField[] _indexFields;
	private readonly Comparison<DataRow> _comparison;
	private readonly DataViewRowState _recordStates;
	private WeakReference _rowFilter;
	private Index.IndexTree _records;
	private int _recordCount;
	private int _refCount;
	private Listeners<DataViewListener> _listeners;
	private bool _suspendEvents;
	private readonly bool _isSharable;
	private readonly bool _hasRemoteAggregate;
	private static int s_objectTypeCount;
	private readonly int _objectID;

	internal bool HasRemoteAggregate { get; }
	internal int ObjectID { get; }
	public DataViewRowState RecordStates { get; }
	public IFilter RowFilter { get; }
	public bool HasDuplicates { get; }
	public int RecordCount { get; }
	public bool IsSharable { get; }
	public int RefCount { get; }
	private bool DoListChanged { get; }
	internal DataTable Table { get; }


	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	internal bool get_HasRemoteAggregate() { }

	internal int get_ObjectID() { }

	public DataViewRowState get_RecordStates() { }

	public IFilter get_RowFilter() { }

	public int GetRecord(int recordIndex) { }

	public bool get_HasDuplicates() { }

	public int get_RecordCount() { }

	public bool get_IsSharable() { }

	private bool AcceptRecord(int record) { }

	private bool AcceptRecord(int record, IFilter filter) { }

	internal void ListChangedAdd(DataViewListener listener) { }

	internal void ListChangedRemove(DataViewListener listener) { }

	public int get_RefCount() { }

	public void AddRef() { }

	public int RemoveRef() { }

	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	public bool CheckUnique() { }

	private int CompareRecords(int record1, int record2) { }

	private int CompareDataRows(int record1, int record2) { }

	private int CompareDuplicateRecords(int record1, int record2) { }

	private int CompareRecordToKey(int record1, object[] vals) { }

	public void DeleteRecordFromIndex(int recordIndex) { }

	private void DeleteRecord(int recordIndex) { }

	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	public int GetIndex(int record) { }

	private int GetIndex(int record, int changeRecord) { }

	public object[] GetUniqueKeyValues() { }

	private int FindNodeByKey(object originalKey) { }

	private int FindNodeByKeys(object[] originalKey) { }

	private int FindNodeByKeyRecord(int record) { }

	private Range GetRangeFromNode(int nodeId) { }

	public Range FindRecords(object key) { }

	public Range FindRecords(object[] key) { }

	internal void FireResetEvent() { }

	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	private static int GetReplaceAction(DataViewRowState oldState) { }

	public DataRow GetRow(int i) { }

	public DataRow[] GetRows(object[] values) { }

	public DataRow[] GetRows(Range range) { }

	private void InitRecords(IFilter filter) { }

	public int InsertRecordToIndex(int record) { }

	private int InsertRecord(int record, bool fireEvent) { }

	public bool IsKeyInIndex(object key) { }

	public bool IsKeyInIndex(object[] key) { }

	public bool IsKeyRecordInIndex(int record) { }

	private bool get_DoListChanged() { }

	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	private void OnListChanged(ListChangedType changedType, int index) { }

	private void OnListChanged(ListChangedEventArgs e) { }

	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	public void Reset() { }

	public void RecordChanged(int record) { }

	public void RecordChanged(int oldIndex, int newIndex) { }

	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	internal DataTable get_Table() { }

	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-Index.IndexOfReference<object>
	*/

}

private sealed class Index.IndexTree : RBTree<int> // TypeDefIndex: 4306
{
	private readonly Index _index;


	internal void .ctor(Index index) { }

	protected override int CompareNode(int record1, int record2) { }

	protected override int CompareSateliteTreeNode(int record1, int record2) { }

}

private sealed class Index.<>c // TypeDefIndex: 4307
{
	public static readonly Index.<>c <>9;
	public static Listeners.Func<DataViewListener, DataViewListener, bool> <>9__22_0;
	public static Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool> <>9__85_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <.ctor>

	internal void <OnListChanged>

}

private sealed class Index.<>c__DisplayClass86_0 // TypeDefIndex: 4308
{
	public ListChangedType changedType;


	public void .ctor() { }

	internal void <MaintainDataView>

}

