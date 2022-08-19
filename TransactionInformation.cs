public class TransactionInformation // TypeDefIndex: 3986
{	// Fields
	private string local_id; // 0x10
	private Guid dtcId; // 0x18
	private DateTime creation_time; // 0x28
	private TransactionStatus status; // 0x30

	// Properties
	public TransactionStatus Status { get; set; }

	// Methods

	// RVA: 0x2307830 Offset: 0x2306C30 VA: 0x182307830
	internal void .ctor() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public TransactionStatus get_Status() { }

	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	internal void set_Status(TransactionStatus value) { }

}

