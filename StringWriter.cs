public class StringWriter : TextWriter // TypeDefIndex: 650
{	// Fields
	private static UnicodeEncoding m_encoding; // 0x0
	private StringBuilder _sb; // 0x28
	private bool _isOpen; // 0x30

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x162F590 Offset: 0x162E990 VA: 0x18162F590
	public void .ctor() { }

	// RVA: 0x162F490 Offset: 0x162E890 VA: 0x18162F490
	public void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x162F6C0 Offset: 0x162EAC0 VA: 0x18162F6C0
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x162F7D0 Offset: 0x162EBD0 VA: 0x18162F7D0
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x162F1E0 Offset: 0x162E5E0 VA: 0x18162F1E0 Slot: 8
	public override void Close() { }

	// RVA: 0xF5AC10 Offset: 0xF5A010 VA: 0x180F5AC10 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x162F8A0 Offset: 0x162ECA0 VA: 0x18162F8A0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x162F440 Offset: 0x162E840 VA: 0x18162F440 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x162F230 Offset: 0x162E630 VA: 0x18162F230 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x162F3F0 Offset: 0x162E7F0 VA: 0x18162F3F0 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x162F200 Offset: 0x162E600 VA: 0x18162F200 Slot: 3
	public override string ToString() { }

}

