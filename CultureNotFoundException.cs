public class CultureNotFoundException : ArgumentException, ISerializable // TypeDefIndex: 691
{	// Fields
	private string m_invalidCultureName; // 0x90
	private Nullable<int> m_invalidCultureId; // 0x98

	// Properties
	public virtual Nullable<int> InvalidCultureId { get; }
	public virtual string InvalidCultureName { get; }
	private static string DefaultMessage { get; }
	private string FormatedInvalidCultureId { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x16D93C0 Offset: 0x16D87C0 VA: 0x1816D93C0
	public void .ctor() { }

	// RVA: 0x16D9570 Offset: 0x16D8970 VA: 0x1816D9570
	public void .ctor(string paramName, string message) { }

	// RVA: 0x16D9380 Offset: 0x16D8780 VA: 0x1816D9380
	public void .ctor(string paramName, string invalidCultureName, string message) { }

	// RVA: 0x16D9410 Offset: 0x16D8810 VA: 0x1816D9410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16D9230 Offset: 0x16D8630 VA: 0x1816D9230 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0 Slot: 12
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0 Slot: 13
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x16D9590 Offset: 0x16D8990 VA: 0x1816D9590
	private static string get_DefaultMessage() { }

	// RVA: 0x16D95D0 Offset: 0x16D89D0 VA: 0x1816D95D0
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x16D96D0 Offset: 0x16D8AD0 VA: 0x1816D96D0 Slot: 5
	public override string get_Message() { }

}

