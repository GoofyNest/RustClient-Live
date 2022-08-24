public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 910
{
	private bool _locked; 
	private ArrayList hostEvidenceList; 
	private ArrayList assemblyEvidenceList; 

	[ObsoleteAttribute] 
	public int Count { get; }
	public object SyncRoot { get; }


	public void .ctor() { }

	public int get_Count() { }

	public object get_SyncRoot() { }

	[ObsoleteAttribute] 
	public void CopyTo(Array array, int index) { }

	[ObsoleteAttribute] 
	public IEnumerator GetEnumerator() { }

}

private class Evidence.EvidenceEnumerator : IEnumerator // TypeDefIndex: 911
{
	private IEnumerator currentEnum; 
	private IEnumerator hostEnum; 
	private IEnumerator assemblyEnum; 

	public object Current { get; }


	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	public bool MoveNext() { }

	public void Reset() { }

	public object get_Current() { }

}

