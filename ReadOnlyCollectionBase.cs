public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
{

[ComVisibleAttribute] 
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable 
	private ArrayList list; 

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

