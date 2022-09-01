public sealed class XHashtable.ExtractKeyDelegate<TValue> : MulticastDelegate // TypeDefIndex: 5820
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-XHashtable.ExtractKeyDelegate<object>..ctor
	|-XHashtable.ExtractKeyDelegate<WeakReference>..ctor
	|-XHashtable.ExtractKeyDelegate<XName>..ctor
	*/

	public virtual string Invoke(TValue value) { }
	/* GenericInstMethod :
	|
	|-XHashtable.ExtractKeyDelegate<object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(TValue value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-XHashtable.ExtractKeyDelegate<object>.BeginInvoke
	*/

	public virtual string EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-XHashtable.ExtractKeyDelegate<object>.EndInvoke
	*/

}

private sealed class XHashtable.XHashtableState<TValue> // TypeDefIndex: 5821
{
	private int[] buckets; 
	private XHashtable.XHashtableState.Entry<TValue>[] entries; 
	private int numEntries; 
	private XHashtable.ExtractKeyDelegate<TValue> extractKey; 


	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-XHashtable.XHashtableState<object>..ctor
	*/

	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-XHashtable.XHashtableState<object>.Resize
	*/

	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-XHashtable.XHashtableState<object>.TryGetValue
	*/

	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-XHashtable.XHashtableState<object>.TryAdd
	*/

	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-XHashtable.XHashtableState<object>.FindEntry
	*/

	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	*/

}

private struct XHashtable.XHashtableState.Entry<TValue> // TypeDefIndex: 5822
{
	public TValue Value; 
	public int HashCode; 
	public int Next; 

}

