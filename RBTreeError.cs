internal enum RBTreeError // TypeDefIndex: 4289
{
	public int value__; 
	public const RBTreeError InvalidPageSize = 1;
	public const RBTreeError PagePositionInSlotInUse = 3;
	public const RBTreeError NoFreeSlots = 4;
	public const RBTreeError InvalidStateinInsert = 5;
	public const RBTreeError InvalidNextSizeInDelete = 7;
	public const RBTreeError InvalidStateinDelete = 8;
	public const RBTreeError InvalidNodeSizeinDelete = 9;
	public const RBTreeError InvalidStateinEndDelete = 10;
	public const RBTreeError CannotRotateInvalidsuccessorNodeinDelete = 11;
	public const RBTreeError IndexOutOFRangeinGetNodeByIndex = 13;
	public const RBTreeError RBDeleteFixup = 14;
	public const RBTreeError UnsupportedAccessMethod1 = 15;
	public const RBTreeError UnsupportedAccessMethod2 = 16;
	public const RBTreeError UnsupportedAccessMethodInNonNillRootSubtree = 17;
	public const RBTreeError AttachedNodeWithZerorbTreeNodeId = 18;
	public const RBTreeError CompareNodeInDataRowTree = 19;
	public const RBTreeError CompareSateliteTreeNodeInDataRowTree = 20;
	public const RBTreeError NestedSatelliteTreeEnumerator = 21;

}

