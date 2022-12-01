public abstract class MessageBase // TypeDefIndex: 1727
{
	private static byte[] header;
	private int _type;
	private NtlmFlags _flags;

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

