public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 3116
{	private LinkedList<T> _list; // 0x0
	private LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1498E0 Offset: 0x148CE0 VA: 0x1801498E0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x149A50 Offset: 0x148E50 VA: 0x180149A50
	|-LinkedList.Enumerator<object>..ctor
	*/

	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149AD0 Offset: 0x148ED0 VA: 0x180149AD0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x149AF0 Offset: 0x148EF0 VA: 0x180149AF0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x149AB0 Offset: 0x148EB0 VA: 0x180149AB0
	|-LinkedList.Enumerator<object>..ctor
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	|-LinkedList.Enumerator<ItemCraftTask>.get_Current
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.get_Current
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.get_Current
	|-LinkedList.Enumerator<object>.get_Current
	|
	|-RVA: 0x116D50 Offset: 0x116150 VA: 0x180116D50
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.get_Current
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.get_Current
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149610 Offset: 0x148A10 VA: 0x180149610
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1494D0 Offset: 0x1488D0 VA: 0x1801494D0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x149750 Offset: 0x148B50 VA: 0x180149750
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147D40 Offset: 0x147140 VA: 0x180147D40
	|-LinkedList.Enumerator<ItemCraftTask>.MoveNext
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.MoveNext
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.MoveNext
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x1487D0 Offset: 0x147BD0 VA: 0x1801487D0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x1482A0 Offset: 0x1476A0 VA: 0x1801482A0
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.MoveNext
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.MoveNext
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148F50 Offset: 0x148350 VA: 0x180148F50
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148C50 Offset: 0x148050 VA: 0x180148C50
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148EB0 Offset: 0x1482B0 VA: 0x180148EB0
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
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
	|-RVA: 0x1498A0 Offset: 0x148CA0 VA: 0x1801498A0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x149880 Offset: 0x148C80 VA: 0x180149880
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x1498C0 Offset: 0x148CC0 VA: 0x1801498C0
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149870 Offset: 0x148C70 VA: 0x180149870
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x149850 Offset: 0x148C50 VA: 0x180149850
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x149860 Offset: 0x148C60 VA: 0x180149860
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

}

