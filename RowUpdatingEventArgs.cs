public class RowUpdatingEventArgs : EventArgs // TypeDefIndex: 4414
{
	private IDbCommand _command; 
	private StatementType _statementType; 
	private DataTableMapping _tableMapping; 
	private Exception _errors; 
	private DataRow _dataRow; 
	private UpdateStatus _status; 

	protected virtual IDbCommand BaseCommand { get; set; }
	public IDbCommand Command { get; set; }
	public Exception Errors { set; }
	public DataRow Row { get; }
	public StatementType StatementType { get; }
	public UpdateStatus Status { get; set; }
	public DataTableMapping TableMapping { get; }


	protected virtual IDbCommand get_BaseCommand() { }

	protected virtual void set_BaseCommand(IDbCommand value) { }

	public IDbCommand get_Command() { }

	public void set_Command(IDbCommand value) { }

	public void set_Errors(Exception value) { }

	public DataRow get_Row() { }

	public StatementType get_StatementType() { }

	public UpdateStatus get_Status() { }

	public void set_Status(UpdateStatus value) { }

	public DataTableMapping get_TableMapping() { }

}

