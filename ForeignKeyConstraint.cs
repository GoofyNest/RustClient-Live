public class ForeignKeyConstraint : Constraint // TypeDefIndex: 4268
{	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50

	// Properties
	internal DataKey ChildKey { get; }
	[ReadOnlyAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual DataColumn[] Columns { get; }
	[ReadOnlyAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public override DataTable Table { get; }
	[DefaultValueAttribute] // RVA: 0xA5780 Offset: 0xA4B80 VA: 0x1800A5780
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValueAttribute] // RVA: 0xA5910 Offset: 0xA4D10 VA: 0x1800A5910
	public virtual Rule DeleteRule { get; set; }
	[ReadOnlyAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnlyAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual DataTable RelatedTable { get; }
	[DefaultValueAttribute] // RVA: 0xA5BB0 Offset: 0xA4FB0 VA: 0x1800A5BB0
	public virtual Rule UpdateRule { get; set; }

	// Methods

	// RVA: 0x13E3490 Offset: 0x13E2890 VA: 0x1813E3490
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E34F0 Offset: 0x13E28F0 VA: 0x1813E34F0
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E3580 Offset: 0x13E2980 VA: 0x1813E3580
	internal DataKey get_ChildKey() { }

	// RVA: 0x13E35A0 Offset: 0x13E29A0 VA: 0x1813E35A0 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x13E3640 Offset: 0x13E2A40 VA: 0x1813E3640 Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x13E1440 Offset: 0x13E0840 VA: 0x1813E1440 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x13E30F0 Offset: 0x13E24F0 VA: 0x1813E30F0
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x13E2D90 Offset: 0x13E2190 VA: 0x1813E2D90 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x13E02C0 Offset: 0x13DF6C0 VA: 0x1813E02C0 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x13E04C0 Offset: 0x13DF8C0 VA: 0x1813E04C0
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x13E0650 Offset: 0x13DFA50 VA: 0x1813E0650
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x13E0C40 Offset: 0x13E0040 VA: 0x1813E0C40
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x13E0E80 Offset: 0x13E0280 VA: 0x1813E0E80
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x13E15B0 Offset: 0x13E09B0 VA: 0x1813E15B0
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x13E16D0 Offset: 0x13E0AD0 VA: 0x1813E16D0
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x13E17A0 Offset: 0x13E0BA0 VA: 0x1813E17A0
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x13E1A50 Offset: 0x13E0E50 VA: 0x1813E1A50 Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x13E31B0 Offset: 0x13E25B0 VA: 0x1813E31B0
	private void NonVirtualCheckState() { }

	// RVA: 0x13E1D70 Offset: 0x13E1170 VA: 0x1813E1D70 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x13E3560 Offset: 0x13E2960 VA: 0x1813E3560 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x13E3680 Offset: 0x13E2A80 VA: 0x1813E3680 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x13E2900 Offset: 0x13E1D00 VA: 0x1813E2900 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xCC8AA0 Offset: 0xCC7EA0 VA: 0x180CC8AA0 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x13E1D80 Offset: 0x13E1180 VA: 0x1813E1D80 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x13E23F0 Offset: 0x13E17F0 VA: 0x1813E23F0
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x13E2950 Offset: 0x13E1D50 VA: 0x1813E2950
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E35C0 Offset: 0x13E29C0 VA: 0x1813E35C0 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x13E3700 Offset: 0x13E2B00 VA: 0x1813E3700 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x13E2B70 Offset: 0x13E1F70 VA: 0x1813E2B70 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13E3600 Offset: 0x13E2A00 VA: 0x1813E3600 Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x13E35E0 Offset: 0x13E29E0 VA: 0x1813E35E0
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x13E35E0 Offset: 0x13E29E0 VA: 0x1813E35E0
	internal DataKey get_ParentKey() { }

	// RVA: 0x13E2CB0 Offset: 0x13E20B0 VA: 0x1813E2CB0
	internal DataRelation FindParentRelation() { }

	// RVA: 0x13E3620 Offset: 0x13E2A20 VA: 0x1813E3620 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x13E3660 Offset: 0x13E2A60 VA: 0x1813E3660 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x13E3780 Offset: 0x13E2B80 VA: 0x1813E3780 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }

}

