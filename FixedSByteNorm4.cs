public struct FixedSByteNorm4 // TypeDefIndex: 13207
{
	private const int FracBits = 7;
	private const float MaxFrac = 128;
	private const float RcpMaxFrac = 0,0078125;
	public sbyte x; 
	public sbyte y; 
	public sbyte z; 
	public sbyte w; 


	public void .ctor(Vector4 vec) { }

	public static Vector4 op_Explicit(FixedSByteNorm4 vec) { }

}

