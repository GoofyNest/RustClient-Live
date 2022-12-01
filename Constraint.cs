public abstract class Constraint // TypeDefIndex: 4179
{
	private string _schemaName;
	private bool _inCollection;
	private DataSet _dataSet;
	internal string _name;
	internal PropertyCollection _extendedProperties;

	[DefaultValueAttribute]
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[BrowsableAttribute]
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliantAttribute]
	protected virtual DataSet _DataSet { get; }


	public virtual string get_ConstraintName() { }

	public virtual void set_ConstraintName(string value) { }

	internal string get_SchemaName() { }

	internal void set_SchemaName(string value) { }

	internal virtual bool get_InCollection() { }

	internal virtual void set_InCollection(bool value) { }

	public abstract DataTable get_Table();

	public PropertyCollection get_ExtendedProperties() { }

	internal abstract bool ContainsColumn(DataColumn column);

	internal abstract bool CanEnableConstraint();

	internal abstract Constraint Clone(DataSet destination);

	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	internal void CheckConstraint() { }

	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	internal abstract void CheckState();

	protected void CheckStateForProperty() { }

	protected virtual DataSet get__DataSet() { }

	internal abstract bool IsConstraintViolated();

	public override string ToString() { }

	protected void .ctor() { }

}

