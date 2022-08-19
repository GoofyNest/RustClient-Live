public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 910
{	// Fields
	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	// Properties
	[ObsoleteAttribute] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x17AEC70 Offset: 0x17AE070 VA: 0x1817AEC70 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 6
	public object get_SyncRoot() { }

	[ObsoleteAttribute] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	// RVA: 0x17AEAE0 Offset: 0x17ADEE0 VA: 0x1817AEAE0 Slot: 4
	public void CopyTo(Array array, int index) { }

	[ObsoleteAttribute] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	// RVA: 0x17AEBA0 Offset: 0x17ADFA0 VA: 0x1817AEBA0 Slot: 7
	public IEnumerator GetEnumerator() { }

}

private class Evidence.EvidenceEnumerator : IEnumerator // TypeDefIndex: 911
{	// Fields
	private IEnumerator currentEnum; // 0x10
	private IEnumerator hostEnum; // 0x18
	private IEnumerator assemblyEnum; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x17AEA20 Offset: 0x17ADE20 VA: 0x1817AEA20
	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	// RVA: 0x17AE900 Offset: 0x17ADD00 VA: 0x1817AE900 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x17AE9A0 Offset: 0x17ADDA0 VA: 0x1817AE9A0 Slot: 6
	public void Reset() { }

	// RVA: 0x17AEA90 Offset: 0x17ADE90 VA: 0x1817AEA90 Slot: 5
	public object get_Current() { }

}

