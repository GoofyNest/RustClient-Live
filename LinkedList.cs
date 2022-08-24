public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 3116
{
	private LinkedList<T> _list; 
	private LinkedListNode<T> _node; 
	private int _version; 
	private T _current; 
	private int _index; 

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-LinkedList.Enumerator<object>..ctor
	*/

	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-LinkedList.Enumerator<object>..ctor
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<ItemCraftTask>.get_Current
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.get_Current
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.get_Current
	|-LinkedList.Enumerator<object>.get_Current
	|
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.get_Current
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.get_Current
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<ItemCraftTask>.MoveNext
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.MoveNext
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.MoveNext
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.MoveNext
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.MoveNext
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<ItemCraftTask>.Dispose
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.Dispose
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.Dispose
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.Dispose
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.Dispose
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.Dispose
	|-LinkedList.Enumerator<object>.Dispose
	*/

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

}

