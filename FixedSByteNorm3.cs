public struct FixedSByteNorm3 // TypeDefIndex: 13110
{
	private const int FracBits = 7;
	private const float MaxFrac = 128;
	private const float RcpMaxFrac = 0,0078125;
	public sbyte x; 
	public sbyte y; 
	public sbyte z; 


	public void .ctor(Vector3 vec) { }

	public static Vector3 op_Explicit(FixedSByteNorm3 vec) { }

}

