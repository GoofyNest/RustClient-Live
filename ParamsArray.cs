internal struct ParamsArray // TypeDefIndex: 286
{	private static readonly object[] oneArgArray; // 0x0
	private static readonly object[] twoArgArray; // 0x8
	private static readonly object[] threeArgArray; // 0x10
	private readonly object arg0; // 0x0
	private readonly object arg1; // 0x8
	private readonly object arg2; // 0x10
	private readonly object[] args; // 0x18

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

