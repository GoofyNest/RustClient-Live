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
	|-RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
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
	|-RVA: 0x17876D0 Offset: 0x1786AD0 VA: 0x1817876D0
	|-RBTree.TreePage<int>..ctor
	|
	|-RVA: 0x17875F0 Offset: 0x17869F0 VA: 0x1817875F0
	|-RBTree.TreePage<object>..ctor
	*/

	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17874A0 Offset: 0x17868A0 VA: 0x1817874A0
	|-RBTree.TreePage<int>.AllocSlot
	|-RBTree.TreePage<object>.AllocSlot
	*/

	internal int get_InUseCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	|-RBTree.TreePage<int>.get_InUseCount
	|-RBTree.TreePage<object>.get_InUseCount
	*/

	internal void set_InUseCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	|-RBTree.TreePage<int>.set_InUseCount
	|-RBTree.TreePage<object>.set_InUseCount
	*/

	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	|-RBTree.TreePage<int>.get_PageId
	|-RBTree.TreePage<object>.get_PageId
	*/

	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
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
	|-RVA: 0x20AC40 Offset: 0x20A040 VA: 0x18020AC40
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x20AAE0 Offset: 0x209EE0 VA: 0x18020AAE0
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20AB30 Offset: 0x209F30 VA: 0x18020AB30
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x20AC90 Offset: 0x20A090 VA: 0x18020AC90
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|-RBTree.RBTreeEnumerator<object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A6A0 Offset: 0x209AA0 VA: 0x18020A6A0
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0x20A7F0 Offset: 0x209BF0 VA: 0x18020A7F0
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	*/

	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AE2F0 Offset: 0x1AD6F0 VA: 0x1801AE2F0
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	|-RBTree.RBTreeEnumerator<object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20AA30 Offset: 0x209E30 VA: 0x18020AA30
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20AAB0 Offset: 0x209EB0 VA: 0x18020AAB0
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A9C0 Offset: 0x209DC0 VA: 0x18020A9C0
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x20A950 Offset: 0x209D50 VA: 0x18020A950
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	*/

}

