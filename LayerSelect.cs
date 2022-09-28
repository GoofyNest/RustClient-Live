public struct LayerSelect // TypeDefIndex: 13121
{
	[SerializeField] 
	private int layer; 

	public int Mask { get; }
	public string Name { get; }


	public void .ctor(int layer) { }

	public static int op_Implicit(LayerSelect layer) { }

	public static LayerSelect op_Implicit(int layer) { }

	public int get_Mask() { }

	public string get_Name() { }

}

