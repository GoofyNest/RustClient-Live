internal sealed class Index // TypeDefIndex: 4300
{	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly Comparison<DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private Index.IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private Listeners<DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Properties
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

	// Methods

	// RVA: 0xE9F570 Offset: 0xE9E970 VA: 0x180E9F570
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE9F5A0 Offset: 0xE9E9A0 VA: 0x180E9F5A0
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE9D400 Offset: 0xE9C800 VA: 0x180E9D400
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xE9F6F0 Offset: 0xE9EAF0 VA: 0x180E9F6F0
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE9CBC0 Offset: 0xE9BFC0 VA: 0x180E9CBC0
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE9FA70 Offset: 0xE9EE70 VA: 0x180E9FA70
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x5F8160 Offset: 0x5F7560 VA: 0x1805F8160
	internal int get_ObjectID() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public DataViewRowState get_RecordStates() { }

	// RVA: 0xE9FA90 Offset: 0xE9EE90 VA: 0x180E9FA90
	public IFilter get_RowFilter() { }

	// RVA: 0xE9D900 Offset: 0xE9CD00 VA: 0x180E9D900
	public int GetRecord(int recordIndex) { }

	// RVA: 0xE9FA20 Offset: 0xE9EE20 VA: 0x180E9FA20
	public bool get_HasDuplicates() { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public int get_RecordCount() { }

	// RVA: 0xE9FA80 Offset: 0xE9EE80 VA: 0x180E9FA80
	public bool get_IsSharable() { }

	// RVA: 0xE9C050 Offset: 0xE9B450 VA: 0x180E9C050
	private bool AcceptRecord(int record) { }

	// RVA: 0xE9C080 Offset: 0xE9B480 VA: 0x180E9C080
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xE9E5C0 Offset: 0xE9D9C0 VA: 0x180E9E5C0
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xE9E620 Offset: 0xE9DA20 VA: 0x180E9E620
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public int get_RefCount() { }

	// RVA: 0xE9C1C0 Offset: 0xE9B5C0 VA: 0x180E9C1C0
	public void AddRef() { }

	// RVA: 0xE9F180 Offset: 0xE9E580 VA: 0x180E9F180
	public int RemoveRef() { }

	// RVA: 0xE9C340 Offset: 0xE9B740 VA: 0x180E9C340
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xE9C410 Offset: 0xE9B810 VA: 0x180E9C410
	public bool CheckUnique() { }

	// RVA: 0xE9C840 Offset: 0xE9BC40 VA: 0x180E9C840
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xE9C460 Offset: 0xE9B860 VA: 0x180E9C460
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0xE9C520 Offset: 0xE9B920 VA: 0x180E9C520
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xE9C720 Offset: 0xE9BB20 VA: 0x180E9C720
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xE9CAA0 Offset: 0xE9BEA0 VA: 0x180E9CAA0
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xE9CBB0 Offset: 0xE9BFB0 VA: 0x180E9CBB0
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0xE9CAB0 Offset: 0xE9BEB0 VA: 0x180E9CAB0
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xE9D520 Offset: 0xE9C920 VA: 0x180E9D520
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0xE9D710 Offset: 0xE9CB10 VA: 0x180E9D710
	public int GetIndex(int record) { }

	// RVA: 0xE9D590 Offset: 0xE9C990 VA: 0x180E9D590
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0xE9DE10 Offset: 0xE9D210 VA: 0x180E9DE10
	public object[] GetUniqueKeyValues() { }

	// RVA: 0xE9CD30 Offset: 0xE9C130 VA: 0x180E9CD30
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0xE9CF20 Offset: 0xE9C320 VA: 0x180E9CF20
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xE9CC70 Offset: 0xE9C070 VA: 0x180E9CC70
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0xE9D770 Offset: 0xE9CB70 VA: 0x180E9D770
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xE9D290 Offset: 0xE9C690 VA: 0x180E9D290
	public Range FindRecords(object key) { }

	// RVA: 0xE9D240 Offset: 0xE9C640 VA: 0x180E9D240
	public Range FindRecords(object[] key) { }

	// RVA: 0xE9D2E0 Offset: 0xE9C6E0 VA: 0x180E9D2E0
	internal void FireResetEvent() { }

	// RVA: 0xE9D500 Offset: 0xE9C900 VA: 0x180E9D500
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xE9D960 Offset: 0xE9CD60 VA: 0x180E9D960
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xE9D980 Offset: 0xE9CD80 VA: 0x180E9D980
	public DataRow GetRow(int i) { }

	// RVA: 0xE9DA20 Offset: 0xE9CE20 VA: 0x180E9DA20
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0xE9DA70 Offset: 0xE9CE70 VA: 0x180E9DA70
	public DataRow[] GetRows(Range range) { }

	// RVA: 0xE9DF50 Offset: 0xE9D350 VA: 0x180E9DF50
	private void InitRecords(IFilter filter) { }

	// RVA: 0xE9E260 Offset: 0xE9D660 VA: 0x180E9E260
	public int InsertRecordToIndex(int record) { }

	// RVA: 0xE9E2C0 Offset: 0xE9D6C0 VA: 0x180E9E2C0
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xE9E4E0 Offset: 0xE9D8E0 VA: 0x180E9E4E0
	public bool IsKeyInIndex(object key) { }

	// RVA: 0xE9E4C0 Offset: 0xE9D8C0 VA: 0x180E9E4C0
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0xE9E500 Offset: 0xE9D900 VA: 0x180E9E500
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xE9F9B0 Offset: 0xE9EDB0 VA: 0x180E9F9B0
	private bool get_DoListChanged() { }

	// RVA: 0xE9E7A0 Offset: 0xE9DBA0 VA: 0x180E9E7A0
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xE9E890 Offset: 0xE9DC90 VA: 0x180E9E890
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xE9E960 Offset: 0xE9DD60 VA: 0x180E9E960
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE9E680 Offset: 0xE9DA80 VA: 0x180E9E680
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xE9F320 Offset: 0xE9E720 VA: 0x180E9F320
	public void Reset() { }

	// RVA: 0xE9EC00 Offset: 0xE9E000 VA: 0x180E9EC00
	public void RecordChanged(int record) { }

	// RVA: 0xE9EAD0 Offset: 0xE9DED0 VA: 0x180E9EAD0
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xE9ED30 Offset: 0xE9E130 VA: 0x180E9ED30
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xE9EE30 Offset: 0xE9E230 VA: 0x180E9EE30
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal DataTable get_Table() { }

	// RVA: 0xE9DC50 Offset: 0xE9D050 VA: 0x180E9DC50
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE80340 Offset: 0xE7F740 VA: 0x180E80340
	|-Index.IndexOfReference<object>
	*/

}

private sealed class Index.IndexTree : RBTree<int> // TypeDefIndex: 4301
{	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xE9BFF0 Offset: 0xE9B3F0 VA: 0x180E9BFF0
	internal void .ctor(Index index) { }

	// RVA: 0xE9BFB0 Offset: 0xE9B3B0 VA: 0x180E9BFB0 Slot: 5
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0xE9BFD0 Offset: 0xE9B3D0 VA: 0x180E9BFD0 Slot: 6
	protected override int CompareSateliteTreeNode(int record1, int record2) { }

}

private sealed class Index.<>c // TypeDefIndex: 4302
{	// Fields
	public static readonly Index.<>c <>9; // 0x0
	public static Listeners.Func<DataViewListener, DataViewListener, bool> <>9__22_0; // 0x8
	public static Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool> <>9__85_0; // 0x10

	// Methods

	// RVA: 0xEBC720 Offset: 0xEBBB20 VA: 0x180EBC720
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEA4D0 Offset: 0xDE98D0 VA: 0x180DEA4D0
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xEBC6B0 Offset: 0xEBBAB0 VA: 0x180EBC6B0
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

private sealed class Index.<>c__DisplayClass86_0 // TypeDefIndex: 4303
{	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xEBC6E0 Offset: 0xEBBAE0 VA: 0x180EBC6E0
	internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

}

