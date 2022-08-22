public class TransactionInformation // TypeDefIndex: 3986
{	private string local_id; // 0x10
	private Guid dtcId; // 0x18
	private DateTime creation_time; // 0x28
	private TransactionStatus status; // 0x30

	public TransactionStatus Status { get; set; }


	internal void .ctor() { }

	public TransactionStatus get_Status() { }

	internal void set_Status(TransactionStatus value) { }

}

