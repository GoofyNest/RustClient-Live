public class TransactionInformation // TypeDefIndex: 3986
{
	private string local_id; 
	private Guid dtcId; 
	private DateTime creation_time; 
	private TransactionStatus status; 

	public TransactionStatus Status { get; set; }


	internal void .ctor() { }

	public TransactionStatus get_Status() { }

	internal void set_Status(TransactionStatus value) { }

}

