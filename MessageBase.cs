public abstract class MessageBase // TypeDefIndex: 1727
{	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	public NtlmFlags Flags { get; set; }
	public int Type { get; }


	protected void .ctor(int messageType) { }

	public NtlmFlags get_Flags() { }

	public void set_Flags(NtlmFlags value) { }

	public int get_Type() { }

	protected byte[] PrepareMessage(int messageSize) { }

	protected virtual void Decode(byte[] message) { }

	protected bool CheckHeader(byte[] message) { }

	public abstract byte[] GetBytes();

	private static void .cctor() { }

}

