internal sealed class RecordManager // TypeDefIndex: 4292
{	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Properties
	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }

	// Methods

	// RVA: 0xEA8F50 Offset: 0xEA8350 VA: 0x180EA8F50
	internal void .ctor(DataTable table) { }

	// RVA: 0xEA8BE0 Offset: 0xEA7FE0 VA: 0x180EA8BE0
	private void GrowRecordCapacity() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	internal int get_LastFreeRecord() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	internal int get_MinimumCapacity() { }

	// RVA: 0xEA90D0 Offset: 0xEA84D0 VA: 0x180EA90D0
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal int get_RecordCapacity() { }

	// RVA: 0xEA9130 Offset: 0xEA8530 VA: 0x180EA9130
	internal void set_RecordCapacity(int value) { }

	// RVA: 0xEA8DF0 Offset: 0xEA81F0 VA: 0x180EA8DF0
	internal static int NewCapacity(int capacity) { }

	// RVA: 0xEA8ED0 Offset: 0xEA82D0 VA: 0x180EA8ED0
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xEA8E10 Offset: 0xEA8210 VA: 0x180EA8E10
	internal int NewRecordBase() { }

	// RVA: 0xEA8AA0 Offset: 0xEA7EA0 VA: 0x180EA8AA0
	internal void FreeRecord(ref int record) { }

	// RVA: 0xEA85F0 Offset: 0xEA79F0 VA: 0x180EA85F0
	internal void Clear(bool clearAll) { }

	// RVA: 0xEA9000 Offset: 0xEA8400 VA: 0x180EA9000
	internal DataRow get_Item(int record) { }

	// RVA: 0xEA9040 Offset: 0xEA8440 VA: 0x180EA9040
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0xEA8DD0 Offset: 0xEA81D0 VA: 0x180EA8DD0
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0xEA87F0 Offset: 0xEA7BF0 VA: 0x180EA87F0
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xEA8F10 Offset: 0xEA8310 VA: 0x180EA8F10
	internal void SetRowCache(DataRow[] newRows) { }

}

