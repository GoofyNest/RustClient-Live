public struct FixedSByteNorm3 // TypeDefIndex: 11414
{	private const int FracBits = 7;
	private const float MaxFrac = 128;
	private const float RcpMaxFrac = 0,0078125;
	public sbyte x; // 0x0
	public sbyte y; // 0x1
	public sbyte z; // 0x2


	public void .ctor(Vector3 vec) { }

	public static Vector3 op_Explicit(FixedSByteNorm3 vec) { }

}

