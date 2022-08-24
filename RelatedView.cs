internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 4293
{
	private readonly Nullable<DataKey> _parentKey; 
	private readonly DataKey _childKey; 
	private readonly DataRowView _parentRowView; 
	private readonly object[] _filterValues; 


	public void .ctor(DataColumn[] columns, object[] values) { }

	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	private object[] GetParentValues() { }

	public bool Invoke(DataRow row, DataRowVersion version) { }

	internal override IFilter GetFilter() { }

	public override DataRowView AddNew() { }

	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

