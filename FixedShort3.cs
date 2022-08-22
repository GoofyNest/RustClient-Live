public struct FixedShort3 // TypeDefIndex: 11413
{	private const int FracBits = 10;
	private const float MaxFrac = 1024;
	private const float RcpMaxFrac = 0,0009765625;
	public short x; // 0x0
	public short y; // 0x2
	public short z; // 0x4


	public void .ctor(Vector3 vec) { }

	public static Vector3 op_Explicit(FixedShort3 vec) { }

}

