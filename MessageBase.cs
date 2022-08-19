public abstract class MessageBase // TypeDefIndex: 1727
{	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	protected void .ctor(int messageType) { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public NtlmFlags get_Flags() { }

	// RVA: 0x596250 Offset: 0x595650 VA: 0x180596250
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Type() { }

	// RVA: 0x1AB3080 Offset: 0x1AB2480 VA: 0x181AB3080
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x1AB2E00 Offset: 0x1AB2200 VA: 0x181AB2E00 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x1AB2CC0 Offset: 0x1AB20C0 VA: 0x181AB2CC0
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x1AB31A0 Offset: 0x1AB25A0 VA: 0x181AB31A0
	private static void .cctor() { }

}

