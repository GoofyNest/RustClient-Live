public struct FixedSByteNorm4 // TypeDefIndex: 11415
{	private const int FracBits = 7;
	private const float MaxFrac = 128;
	private const float RcpMaxFrac = 0,0078125;
	public sbyte x; // 0x0
	public sbyte y; // 0x1
	public sbyte z; // 0x2
	public sbyte w; // 0x3


	public void .ctor(Vector4 vec) { }

	public static Vector4 op_Explicit(FixedSByteNorm4 vec) { }

}

