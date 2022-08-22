public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 910
{	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	[ObsoleteAttribute] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	public int Count { get; }
	public object SyncRoot { get; }


	public void .ctor() { }

	public int get_Count() { }

	public object get_SyncRoot() { }

	[ObsoleteAttribute] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	public void CopyTo(Array array, int index) { }

	[ObsoleteAttribute] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	public IEnumerator GetEnumerator() { }

}

private class Evidence.EvidenceEnumerator : IEnumerator // TypeDefIndex: 911
{	private IEnumerator currentEnum; // 0x10
	private IEnumerator hostEnum; // 0x18
	private IEnumerator assemblyEnum; // 0x20

	public object Current { get; }


	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	public bool MoveNext() { }

	public void Reset() { }

	public object get_Current() { }

}

