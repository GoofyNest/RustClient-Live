public struct FixedShort3 // TypeDefIndex: 11413
{	// Fields
	private const int FracBits = 10;
	private const float MaxFrac = 1024;
	private const float RcpMaxFrac = 0,0009765625;
	public short x; // 0x0
	public short y; // 0x2
	public short z; // 0x4

	// Methods

	// RVA: 0xF53B0 Offset: 0xF47B0 VA: 0x1800F53B0
	public void .ctor(Vector3 vec) { }

	// RVA: 0x78BAE0 Offset: 0x78AEE0 VA: 0x18078BAE0
	public static Vector3 op_Explicit(FixedShort3 vec) { }

}

