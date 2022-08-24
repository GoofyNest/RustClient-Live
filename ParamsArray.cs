internal struct ParamsArray // TypeDefIndex: 286
{
	private static readonly object[] oneArgArray; 
	private static readonly object[] twoArgArray; 
	private static readonly object[] threeArgArray; 
	private readonly object arg0; 
	private readonly object arg1; 
	private readonly object arg2; 
	private readonly object[] args; 

	public int Length { get; }
	public object Item { get; }


	public void .ctor(object arg0) { }

	public void .ctor(object arg0, object arg1) { }

	public void .ctor(object arg0, object arg1, object arg2) { }

	public void .ctor(object[] args) { }

	public int get_Length() { }

	public object get_Item(int index) { }

	private object GetAtSlow(int index) { }

	private static void .cctor() { }

}

