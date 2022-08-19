public class MatchCollection : ICollection, IEnumerable // TypeDefIndex: 2622
{	// Fields
	internal Regex _regex; // 0x10
	internal ArrayList _matches; // 0x18
	internal bool _done; // 0x20
	internal string _input; // 0x28
	internal int _beginning; // 0x30
	internal int _length; // 0x34
	internal int _startat; // 0x38
	internal int _prevlen; // 0x3C
	private static int infinite; // 0x0

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x14C2FA0 Offset: 0x14C23A0 VA: 0x1814C2FA0
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x14C2DB0 Offset: 0x14C21B0 VA: 0x1814C2DB0
	internal Match GetMatch(int i) { }

	// RVA: 0x14C3100 Offset: 0x14C2500 VA: 0x1814C3100 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14C2BB0 Offset: 0x14C1FB0 VA: 0x1814C2BB0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14C2D50 Offset: 0x14C2150 VA: 0x1814C2D50 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14C2F60 Offset: 0x14C2360 VA: 0x1814C2F60
	private static void .cctor() { }

	// RVA: 0x14C30D0 Offset: 0x14C24D0 VA: 0x1814C30D0
	internal void .ctor() { }

}

