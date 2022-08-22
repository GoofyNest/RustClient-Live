public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
{
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
	private ArrayList list; // 0x10

	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }


	protected ArrayList get_InnerList() { }

	public virtual int get_Count() { }

	private object System.Collections.ICollection.get_SyncRoot() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	public virtual IEnumerator GetEnumerator() { }

	protected void .ctor() { }

}

