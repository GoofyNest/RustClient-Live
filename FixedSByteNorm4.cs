public struct FixedSByteNorm4 // TypeDefIndex: 11415
{	// Fields
	private const int FracBits = 7;
	private const float MaxFrac = 128;
	private const float RcpMaxFrac = 0,0078125;
	public sbyte x; // 0x0
	public sbyte y; // 0x1
	public sbyte z; // 0x2
	public sbyte w; // 0x3

	// Methods

	// RVA: 0xF5360 Offset: 0xF4760 VA: 0x1800F5360
	public void .ctor(Vector4 vec) { }

	// RVA: 0x78BA60 Offset: 0x78AE60 VA: 0x18078BA60
	public static Vector4 op_Explicit(FixedSByteNorm4 vec) { }

}

