public class RowUpdatingEventArgs : EventArgs // TypeDefIndex: 4409
{	// Fields
	private IDbCommand _command; // 0x10
	private StatementType _statementType; // 0x18
	private DataTableMapping _tableMapping; // 0x20
	private Exception _errors; // 0x28
	private DataRow _dataRow; // 0x30
	private UpdateStatus _status; // 0x38

	// Properties
	protected virtual IDbCommand BaseCommand { get; set; }
	public IDbCommand Command { get; set; }
	public Exception Errors { set; }
	public DataRow Row { get; }
	public StatementType StatementType { get; }
	public UpdateStatus Status { get; set; }
	public DataTableMapping TableMapping { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	protected virtual IDbCommand get_BaseCommand() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 5
	protected virtual void set_BaseCommand(IDbCommand value) { }

	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950
	public IDbCommand get_Command() { }

	// RVA: 0x17D1700 Offset: 0x17D0B00 VA: 0x1817D1700
	public void set_Command(IDbCommand value) { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_Errors(Exception value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public DataRow get_Row() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public StatementType get_StatementType() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public UpdateStatus get_Status() { }

	// RVA: 0x17D1720 Offset: 0x17D0B20 VA: 0x1817D1720
	public void set_Status(UpdateStatus value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public DataTableMapping get_TableMapping() { }

}

