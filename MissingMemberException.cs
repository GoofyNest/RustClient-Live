public class MissingMemberException : MemberAccessException, ISerializable // TypeDefIndex: 271
{	// Fields
	protected string ClassName; // 0x88
	protected string MemberName; // 0x90
	protected byte[] Signature; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1670E20 Offset: 0x1670220 VA: 0x181670E20
	public void .ctor() { }

	// RVA: 0x1670E90 Offset: 0x1670290 VA: 0x181670E90
	public void .ctor(string message) { }

	// RVA: 0x1670ED0 Offset: 0x16702D0 VA: 0x181670ED0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1671010 Offset: 0x1670410 VA: 0x181671010 Slot: 5
	public override string get_Message() { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	internal static string FormatSignature(byte[] signature) { }

	// RVA: 0x1670CC0 Offset: 0x16700C0 VA: 0x181670CC0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

