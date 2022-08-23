private enum RBTree.NodeColor<K> // TypeDefIndex: 4287
{	public int value__; // 0x0
	public const RBTree.NodeColor<K> red = 0;
	public const RBTree.NodeColor<K> black = 1;

}

private struct RBTree.Node<K> // TypeDefIndex: 4288
{	internal int _selfId; // 0x0
	internal int _leftId; // 0x0
	internal int _rightId; // 0x0
	internal int _parentId; // 0x0
	internal int _nextId; // 0x0
	internal int _subTreeSize; // 0x0
	internal K _keyOfNode; // 0x0
	internal RBTree.NodeColor<K> _nodeColor; // 0x0

}

private struct RBTree.NodePath<K> // TypeDefIndex: 4289
{	internal readonly int _nodeID; // 0x0
	internal readonly int _mainTreeNodeID; // 0x0


	internal void .ctor(int nodeID, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RBTree.NodePath<int>..ctor
	|-RBTree.NodePath<object>..ctor
	*/

}

private sealed class RBTree.TreePage<K> // TypeDefIndex: 4290
{	internal readonly RBTree.Node<K>[] _slots; // 0x0
	internal readonly int[] _slotMap; // 0x0
	private int _inUseCount; // 0x0
	private int _pageId; // 0x0
	private int _nextFreeSlotLine; // 0x0

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

internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 4291
{	private readonly RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

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

