private enum RBTree.NodeColor<K> // TypeDefIndex: 4292
{
	public int value__; 
	public const RBTree.NodeColor<K> red = 0;
	public const RBTree.NodeColor<K> black = 1;

}

private struct RBTree.Node<K> // TypeDefIndex: 4293
{
	internal int _selfId; 
	internal int _leftId; 
	internal int _rightId; 
	internal int _parentId; 
	internal int _nextId; 
	internal int _subTreeSize; 
	internal K _keyOfNode; 
	internal RBTree.NodeColor<K> _nodeColor; 

}

private struct RBTree.NodePath<K> // TypeDefIndex: 4294
{
	internal readonly int _nodeID; 
	internal readonly int _mainTreeNodeID; 


	internal void .ctor(int nodeID, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RBTree.NodePath<int>..ctor
	|-RBTree.NodePath<object>..ctor
	*/

}

private sealed class RBTree.TreePage<K> // TypeDefIndex: 4295
{
	internal readonly RBTree.Node<K>[] _slots; 
	internal readonly int[] _slotMap; 
	private int _inUseCount; 
	private int _pageId; 
	private int _nextFreeSlotLine; 

	internal int InUseCount { get; set; }
	internal int PageId { get; set; }


	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RBTree.TreePage<int>..ctor
	|
	|-RBTree.TreePage<object>..ctor
	*/

	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RBTree.TreePage<int>.AllocSlot
	|-RBTree.TreePage<object>.AllocSlot
	*/

	internal int get_InUseCount() { }
	/* GenericInstMethod :
	|
	|-RBTree.TreePage<int>.get_InUseCount
	|-RBTree.TreePage<object>.get_InUseCount
	*/

	internal void set_InUseCount(int value) { }
	/* GenericInstMethod :
	|
	|-RBTree.TreePage<int>.set_InUseCount
	|-RBTree.TreePage<object>.set_InUseCount
	*/

	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RBTree.TreePage<int>.get_PageId
	|-RBTree.TreePage<object>.get_PageId
	*/

	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RBTree.TreePage<int>.set_PageId
	|-RBTree.TreePage<object>.set_PageId
	*/

}

internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 4296
{
	private readonly RBTree<K> _tree; 
	private readonly int _version; 
	private int _index; 
	private int _mainTreeNodeId; 
	private K _current; 

	public K Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|-RBTree.RBTreeEnumerator<object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	*/

	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RBTree.RBTreeEnumerator<object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	*/

}

