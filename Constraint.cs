public abstract class Constraint // TypeDefIndex: 4174
{	// Fields
	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	// Properties
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	protected virtual DataSet _DataSet { get; }

	// Methods

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 4
	public virtual string get_ConstraintName() { }

	// RVA: 0x1224010 Offset: 0x1223410 VA: 0x181224010 Slot: 5
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0x1223FD0 Offset: 0x12233D0 VA: 0x181223FD0
	internal string get_SchemaName() { }

	// RVA: 0x1224290 Offset: 0x1223690 VA: 0x181224290
	internal void set_SchemaName(string value) { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0 Slot: 6
	internal virtual bool get_InCollection() { }

	// RVA: 0x1224230 Offset: 0x1223630 VA: 0x181224230 Slot: 7
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DataTable get_Table();

	// RVA: 0x1223F60 Offset: 0x1223360 VA: 0x181223F60
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool ContainsColumn(DataColumn column);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool CanEnableConstraint();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Constraint Clone(DataSet destination);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	// RVA: 0x1223D50 Offset: 0x1223150 VA: 0x181223D50
	internal void CheckConstraint() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void CheckState();

	// RVA: 0x1223DC0 Offset: 0x12231C0 VA: 0x181223DC0
	protected void CheckStateForProperty() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 17
	protected virtual DataSet get__DataSet() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract bool IsConstraintViolated();

	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950 Slot: 3
	public override string ToString() { }

	// RVA: 0x1223EF0 Offset: 0x12232F0 VA: 0x181223EF0
	protected void .ctor() { }

}

