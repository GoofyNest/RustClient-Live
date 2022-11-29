public struct Color32 // TypeDefIndex: 3462
{
	[IgnoreAttribute] 
	private int rgba; 
	public byte r; 
	public byte g; 
	public byte b; 
	public byte a; 


	public void .ctor(byte r, byte g, byte b, byte a) { }

	public static Color32 op_Implicit(Color c) { }

	public static Color op_Implicit(Color32 c) { }

	public override string ToString() { }

}

