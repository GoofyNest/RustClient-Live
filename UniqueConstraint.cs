public class UniqueConstraint : Constraint // TypeDefIndex: 4311
{	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48

	// Properties
	internal Index ConstraintIndex { get; }
	[ReadOnlyAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnlyAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public override DataTable Table { get; }

	// Methods

	// RVA: 0xCC98D0 Offset: 0xCC8CD0 VA: 0x180CC98D0
	public void .ctor(DataColumn column) { }

	// RVA: 0xCC9890 Offset: 0xCC8C90 VA: 0x180CC9890
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xCC99A0 Offset: 0xCC8DA0 VA: 0x180CC99A0
	public void .ctor(DataColumn[] columns) { }

	// RVA: 0xCC99E0 Offset: 0xCC8DE0 VA: 0x180CC99E0
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal Index get_ConstraintIndex() { }

	// RVA: 0xCC92E0 Offset: 0xCC86E0 VA: 0x180CC92E0
	internal void ConstraintIndexClear() { }

	// RVA: 0xCC9320 Offset: 0xCC8720 VA: 0x180CC9320
	internal void ConstraintIndexInitialize() { }

	// RVA: 0xCC8A90 Offset: 0xCC7E90 VA: 0x180CC8A90 Slot: 16
	internal override void CheckState() { }

	// RVA: 0xCC8A90 Offset: 0xCC7E90 VA: 0x180CC8A90
	private void NonVirtualCheckState() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xCC8790 Offset: 0xCC7B90 VA: 0x180CC8790 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xCC8920 Offset: 0xCC7D20 VA: 0x180CC8920 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0xCC95D0 Offset: 0xCC89D0 VA: 0x180CC95D0 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0xCC8970 Offset: 0xCC7D70 VA: 0x180CC8970 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xCC9370 Offset: 0xCC8770 VA: 0x180CC9370 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xCC8AA0 Offset: 0xCC7EA0 VA: 0x180CC8AA0 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xCC8AC0 Offset: 0xCC7EC0 VA: 0x180CC8AC0 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xCC8F30 Offset: 0xCC8330 VA: 0x180CC8F30
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xCC9A30 Offset: 0xCC8E30 VA: 0x180CC9A30 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xCC9A40 Offset: 0xCC8E40 VA: 0x180CC9A40
	public bool get_IsPrimaryKey() { }

	// RVA: 0xCC9380 Offset: 0xCC8780 VA: 0x180CC9380
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xCC94A0 Offset: 0xCC88A0 VA: 0x180CC94A0 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xCC9AD0 Offset: 0xCC8ED0 VA: 0x180CC9AD0 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal DataKey get_Key() { }

	// RVA: 0xCC9AA0 Offset: 0xCC8EA0 VA: 0x180CC9AA0 Slot: 8
	public override DataTable get_Table() { }

}

