internal sealed class RecordManager // TypeDefIndex: 4292
{	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }


	internal void .ctor(DataTable table) { }

	private void GrowRecordCapacity() { }

	internal int get_LastFreeRecord() { }

	internal int get_MinimumCapacity() { }

	internal void set_MinimumCapacity(int value) { }

	internal int get_RecordCapacity() { }

	internal void set_RecordCapacity(int value) { }

	internal static int NewCapacity(int capacity) { }

	private int NormalizedMinimumCapacity(int capacity) { }

	internal int NewRecordBase() { }

	internal void FreeRecord(ref int record) { }

	internal void Clear(bool clearAll) { }

	internal DataRow get_Item(int record) { }

	internal void set_Item(int record, DataRow value) { }

	internal int ImportRecord(DataTable src, int record) { }

	internal int CopyRecord(DataTable src, int record, int copy) { }

	internal void SetRowCache(DataRow[] newRows) { }

}

