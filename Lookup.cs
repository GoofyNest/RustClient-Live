internal class Lookup.Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement> // TypeDefIndex: 3227
{
	internal TKey key; 
	internal int hashCode; 
	internal TElement[] elements; 
	internal int count; 
	internal Lookup.Grouping<TKey, TElement> hashNext; 
	internal Lookup.Grouping<TKey, TElement> next; 

public TKey Key { get; }
private int System.Collections.Generic.ICollection<TElement>.Count { get; }
private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly { get; }
private TElement System.Collections.Generic.IList<TElement>.Item { get; set; }


internal void Add(TElement element) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.Add
|
|-Lookup.Grouping<InventoryDefId, object>.Add
|
|-Lookup.Grouping<Int32Enum, object>.Add
|
|-Lookup.Grouping<object, object>.Add
|
|-Lookup.Grouping<uint, object>.Add
|
|-Lookup.Grouping<Vector2Int, Resolution>.Add
*/

	[IteratorStateMachineAttribute] 
public IEnumerator<TElement> GetEnumerator() { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.GetEnumerator
|
|-Lookup.Grouping<InventoryDefId, object>.GetEnumerator
|-Lookup.Grouping<Int32Enum, object>.GetEnumerator
|-Lookup.Grouping<object, object>.GetEnumerator
|-Lookup.Grouping<uint, object>.GetEnumerator
|-Lookup.Grouping<Vector2Int, Resolution>.GetEnumerator
*/

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.IEnumerable.GetEnumerator
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.IEnumerable.GetEnumerator
|-Lookup.Grouping<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
|-Lookup.Grouping<object, object>.System.Collections.IEnumerable.GetEnumerator
|-Lookup.Grouping<uint, object>.System.Collections.IEnumerable.GetEnumerator
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.IEnumerable.GetEnumerator
*/

public TKey get_Key() { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.get_Key
|-Lookup.Grouping<InventoryDefId, object>.get_Key
|-Lookup.Grouping<Int32Enum, object>.get_Key
|-Lookup.Grouping<uint, object>.get_Key
|
|-Lookup.Grouping<object, object>.get_Key
|-Lookup.Grouping<Vector2Int, Resolution>.get_Key
*/

private int System.Collections.Generic.ICollection<TElement>.get_Count() { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.get_Count
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.get_Count
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.get_Count
|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.get_Count
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_Count
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.get_Count
*/

private bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
*/

private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Add
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Add
|
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Add
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
|
|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Add
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Add
*/

private void System.Collections.Generic.ICollection<TElement>.Clear() { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Clear
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Clear
|
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Clear
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
|
|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Clear
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Clear
*/

private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Contains
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Contains
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Contains
|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Contains
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Contains
*/

private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.CopyTo
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.CopyTo
*/

private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Remove
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Remove
|
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Remove
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
|
|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Remove
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Remove
*/

private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.IndexOf
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.IndexOf
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.IndexOf
|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.IndexOf
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.IndexOf
*/

private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.Insert
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.Insert
|
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.Insert
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
|
|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.Insert
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.Insert
*/

private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.RemoveAt
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.RemoveAt
|
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.RemoveAt
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
|
|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.RemoveAt
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.RemoveAt
*/

private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.get_Item
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.get_Item
|
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.get_Item
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
|
|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.get_Item
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.get_Item
*/

private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.set_Item
|
|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.set_Item
|
|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.set_Item
|
|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
|
|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.set_Item
|
|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.set_Item
*/

public void .ctor() { }
/* GenericInstMethod :
|
|-Lookup.Grouping<InventoryDefId, InventoryItem>..ctor
|-Lookup.Grouping<InventoryDefId, object>..ctor
|-Lookup.Grouping<Int32Enum, object>..ctor
|-Lookup.Grouping<object, object>..ctor
|-Lookup.Grouping<uint, object>..ctor
|-Lookup.Grouping<Vector2Int, Resolution>..ctor
*/

}

private sealed class Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 3228
{
	private int <>1__state; 
	private TElement <>2__current; 
	public Lookup.Grouping<TKey, TElement> <>4__this; 
	private int <i>5__1; 

private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }
/* GenericInstMethod :
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>..ctor
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>..ctor
|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>..ctor
|-Lookup.Grouping.<GetEnumerator>d__7<object, object>..ctor
|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>..ctor
|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>..ctor
*/

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }
/* GenericInstMethod :
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.IDisposable.Dispose
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.IDisposable.Dispose
|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.IDisposable.Dispose
|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.IDisposable.Dispose
|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.IDisposable.Dispose
|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.IDisposable.Dispose
*/

private bool MoveNext() { }
/* GenericInstMethod :
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.MoveNext
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.MoveNext
|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.MoveNext
|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.MoveNext
|
|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.MoveNext
|
|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.MoveNext
*/

	[DebuggerHiddenAttribute] 
private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
/* GenericInstMethod :
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.Generic.IEnumerator<TElement>.get_Current
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
|
|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
*/

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }
/* GenericInstMethod :
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.Reset
|
|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.Reset
|
|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.Reset
|
|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.Reset
|
|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.IEnumerator.Reset
*/

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.get_Current
|
|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.get_Current
|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.get_Current
|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.get_Current
|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.get_Current
|
|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.IEnumerator.get_Current
*/

}

private sealed class Lookup.<GetEnumerator>d__12<TKey, TElement> : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator // TypeDefIndex: 3229
{
	private int <>1__state; 
	private IGrouping<TKey, TElement> <>2__current; 
	public Lookup<TKey, TElement> <>4__this; 
	private Lookup.Grouping<TKey, TElement> <g>5__1; 

private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }
/* GenericInstMethod :
|
|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>..ctor
|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>..ctor
|-Lookup.<GetEnumerator>d__12<Int32Enum, object>..ctor
|-Lookup.<GetEnumerator>d__12<object, object>..ctor
|-Lookup.<GetEnumerator>d__12<uint, object>..ctor
|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>..ctor
*/

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }
/* GenericInstMethod :
|
|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.IDisposable.Dispose
|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.IDisposable.Dispose
|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.IDisposable.Dispose
|-Lookup.<GetEnumerator>d__12<object, object>.System.IDisposable.Dispose
|-Lookup.<GetEnumerator>d__12<uint, object>.System.IDisposable.Dispose
|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.IDisposable.Dispose
*/

private bool MoveNext() { }
/* GenericInstMethod :
|
|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.MoveNext
|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.MoveNext
|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.MoveNext
|-Lookup.<GetEnumerator>d__12<uint, object>.MoveNext
|
|-Lookup.<GetEnumerator>d__12<object, object>.MoveNext
|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.MoveNext
*/

	[DebuggerHiddenAttribute] 
private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current() { }
/* GenericInstMethod :
|
|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
*/

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }
/* GenericInstMethod :
|
|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
|
|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.IEnumerator.Reset
|
|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.IEnumerator.Reset
|
|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.Reset
|
|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.IEnumerator.Reset
|
|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.Collections.IEnumerator.Reset
*/

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.get_Current
|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.IEnumerator.get_Current
|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.IEnumerator.get_Current
|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.get_Current
|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.IEnumerator.get_Current
|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.Collections.IEnumerator.get_Current
*/

}

