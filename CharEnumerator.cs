public sealed class CharEnumerator : IEnumerator, ICloneable, IEnumerator<char>, IDisposable // TypeDefIndex: 184
{	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private char currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x1176E90 Offset: 0x1176290 VA: 0x181176E90
	internal void .ctor(string str) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 7
	public object Clone() { }

	// RVA: 0x158F020 Offset: 0x158E420 VA: 0x18158F020 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x158EFF0 Offset: 0x158E3F0 VA: 0x18158EFF0 Slot: 9
	public void Dispose() { }

	// RVA: 0x158F080 Offset: 0x158E480 VA: 0x18158F080 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x158F1A0 Offset: 0x158E5A0 VA: 0x18158F1A0 Slot: 8
	public char get_Current() { }

	// RVA: 0x158F070 Offset: 0x158E470 VA: 0x18158F070 Slot: 6
	public void Reset() { }

	// RVA: 0x158F170 Offset: 0x158E570 VA: 0x18158F170
	internal void .ctor() { }

}

