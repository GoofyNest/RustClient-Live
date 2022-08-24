public struct LayerMask // TypeDefIndex: 3516
{
	[NativeNameAttribute] 
	private int m_Mask; 

	public int value { get; }


	public static int op_Implicit(LayerMask mask) { }

	public static LayerMask op_Implicit(int intVal) { }

	public int get_value() { }

	[NativeMethodAttribute] 
	[StaticAccessorAttribute] 
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] 
	[StaticAccessorAttribute] 
	public static int NameToLayer(string layerName) { }

	public static int GetMask(string[] layerNames) { }

}

