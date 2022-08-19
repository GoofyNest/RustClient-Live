public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 3853
{	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x0

	// Properties
	internal int id { get; set; }
	public string name { get; }

	// Methods

	// RVA: 0x222C30 Offset: 0x222030 VA: 0x180222C30
	public void .ctor(string name) { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	internal int get_id() { }

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	internal void set_id(int value) { }

	// RVA: 0x222C80 Offset: 0x222080 VA: 0x180222C80
	public string get_name() { }

	// RVA: 0x222B80 Offset: 0x221F80 VA: 0x180222B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2175A0 Offset: 0x2169A0 VA: 0x1802175A0 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x222C10 Offset: 0x222010 VA: 0x180222C10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19AFEB0 Offset: 0x19AF2B0 VA: 0x1819AFEB0
	private static void .cctor() { }

}

