internal struct GlyphValueRecord // TypeDefIndex: 4113
{	// Fields
	[NativeNameAttribute] // RVA: 0x883D0 Offset: 0x877D0 VA: 0x1800883D0
	[SerializeField] // RVA: 0x883D0 Offset: 0x877D0 VA: 0x1800883D0
	private float m_XPlacement; // 0x0
	[NativeNameAttribute] // RVA: 0x886B0 Offset: 0x87AB0 VA: 0x1800886B0
	[SerializeField] // RVA: 0x886B0 Offset: 0x87AB0 VA: 0x1800886B0
	private float m_YPlacement; // 0x4
	[NativeNameAttribute] // RVA: 0x887B0 Offset: 0x87BB0 VA: 0x1800887B0
	[SerializeField] // RVA: 0x887B0 Offset: 0x87BB0 VA: 0x1800887B0
	private float m_XAdvance; // 0x8
	[NativeNameAttribute] // RVA: 0x88A60 Offset: 0x87E60 VA: 0x180088A60
	[SerializeField] // RVA: 0x88A60 Offset: 0x87E60 VA: 0x180088A60
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; }
	public float yPlacement { get; }
	public float xAdvance { get; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x13A270 Offset: 0x139670 VA: 0x18013A270
	public float get_xPlacement() { }

	// RVA: 0x2121C0 Offset: 0x2115C0 VA: 0x1802121C0
	public float get_yPlacement() { }

	// RVA: 0x2121D0 Offset: 0x2115D0 VA: 0x1802121D0
	public float get_xAdvance() { }

	// RVA: 0x2121E0 Offset: 0x2115E0 VA: 0x1802121E0
	public float get_yAdvance() { }

	// RVA: 0x23DD90 Offset: 0x23D190 VA: 0x18023DD90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DD20 Offset: 0x23D120 VA: 0x18023DD20 Slot: 0
	public override bool Equals(object obj) { }

}

public struct GlyphValueRecord_Legacy // TypeDefIndex: 6767
{	// Fields
	public float xPlacement; // 0x0
	public float yPlacement; // 0x4
	public float xAdvance; // 0x8
	public float yAdvance; // 0xC

	// Methods

	// RVA: 0x117310 Offset: 0x116710 VA: 0x180117310
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0xC44EC0 Offset: 0xC442C0 VA: 0x180C44EC0
	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }

}

