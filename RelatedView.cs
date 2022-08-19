internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 4293
{	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xB0
	private readonly DataKey _childKey; // 0xC0
	private readonly DataRowView _parentRowView; // 0xC8
	private readonly object[] _filterValues; // 0xD0

	// Methods

	// RVA: 0xEA95D0 Offset: 0xEA89D0 VA: 0x180EA95D0
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xEA9480 Offset: 0xEA8880 VA: 0x180EA9480
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xEA9250 Offset: 0xEA8650 VA: 0x180EA9250
	private object[] GetParentValues() { }

	// RVA: 0xEA92F0 Offset: 0xEA86F0 VA: 0x180EA92F0 Slot: 32
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 26
	internal override IFilter GetFilter() { }

	// RVA: 0xEA91E0 Offset: 0xEA85E0 VA: 0x180EA91E0 Slot: 25
	public override DataRowView AddNew() { }

	// RVA: 0xEA9450 Offset: 0xEA8850 VA: 0x180EA9450 Slot: 29
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

