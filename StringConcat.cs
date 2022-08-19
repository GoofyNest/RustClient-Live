public struct StringConcat // TypeDefIndex: 2430
{	// Fields
	private string s1; // 0x0
	private string s2; // 0x8
	private string s3; // 0x10
	private string s4; // 0x18
	private string delimiter; // 0x20
	private List<string> strList; // 0x28
	private int idxStr; // 0x30

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x237E50 Offset: 0x237250 VA: 0x180237E50
	public void Clear() { }

	// RVA: 0x1D0ED0 Offset: 0x1D02D0 VA: 0x1801D0ED0
	internal int get_Count() { }

	// RVA: 0x237FF0 Offset: 0x2373F0 VA: 0x180237FF0
	public string GetResult() { }

	// RVA: 0x237E70 Offset: 0x237270 VA: 0x180237E70
	internal void ConcatNoDelimiter(string s) { }

}

