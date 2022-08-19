internal sealed class SortedSet.Node<T> // TypeDefIndex: 3144
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private T <Item>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SortedSet.Node<T> <Left>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SortedSet.Node<T> <Right>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private NodeColor <Color>k__BackingField; // 0x0

	// Properties
	public T Item { get; set; }
	public SortedSet.Node<T> Left { get; set; }
	public SortedSet.Node<T> Right { get; set; }
	public NodeColor Color { get; set; }
	public bool IsBlack { get; }
	public bool IsRed { get; }
	public bool Is2Node { get; }
	public bool Is4Node { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T item, NodeColor color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E29120 Offset: 0x1E28520 VA: 0x181E29120
	|-SortedSet.Node<KeyValuePair<long, object>>..ctor
	|-SortedSet.Node<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1E291B0 Offset: 0x1E285B0 VA: 0x181E291B0
	|-SortedSet.Node<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool IsNonNullRed(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E288C0 Offset: 0x1E27CC0 VA: 0x181E288C0
	|-SortedSet.Node<KeyValuePair<long, object>>.IsNonNullRed
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNonNullRed
	|-SortedSet.Node<object>.IsNonNullRed
	*/

	// RVA: -1 Offset: -1
	public static bool IsNullOrBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28950 Offset: 0x1E27D50 VA: 0x181E28950
	|-SortedSet.Node<KeyValuePair<long, object>>.IsNullOrBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNullOrBlack
	|-SortedSet.Node<object>.IsNullOrBlack
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public T get_Item() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE0C30 Offset: 0xFE0030 VA: 0x180FE0C30
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Item
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	|-SortedSet.Node<object>.get_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_Item(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E293D0 Offset: 0x1E287D0 VA: 0x181E293D0
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Item
	|
	|-RVA: 0x1E293F0 Offset: 0x1E287F0 VA: 0x181E293F0
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Item
	|
	|-RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	|-SortedSet.Node<object>.set_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Left
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Left
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-SortedSet.Node<object>.get_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_Left(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Left
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Left
	|
	|-RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	|-SortedSet.Node<object>.set_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Right
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Right
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-SortedSet.Node<object>.get_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_Right(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Right
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Right
	|
	|-RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	|-SortedSet.Node<object>.set_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public NodeColor get_Color() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Color
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Color
	|
	|-RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	|-SortedSet.Node<object>.get_Color
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_Color(NodeColor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x829920 Offset: 0x828D20 VA: 0x180829920
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Color
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Color
	|
	|-RVA: 0x9775D0 Offset: 0x9769D0 VA: 0x1809775D0
	|-SortedSet.Node<object>.set_Color
	*/

	// RVA: -1 Offset: -1
	public bool get_IsBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E29370 Offset: 0x1E28770 VA: 0x181E29370
	|-SortedSet.Node<KeyValuePair<long, object>>.get_IsBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsBlack
	|-SortedSet.Node<object>.get_IsBlack
	*/

	// RVA: -1 Offset: -1
	public bool get_IsRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E293A0 Offset: 0x1E287A0 VA: 0x181E293A0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_IsRed
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsRed
	|-SortedSet.Node<object>.get_IsRed
	*/

	// RVA: -1 Offset: -1
	public bool get_Is2Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E29230 Offset: 0x1E28630 VA: 0x181E29230
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Is2Node
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is2Node
	|-SortedSet.Node<object>.get_Is2Node
	*/

	// RVA: -1 Offset: -1
	public bool get_Is4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E292E0 Offset: 0x1E286E0 VA: 0x181E292E0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Is4Node
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is4Node
	|-SortedSet.Node<object>.get_Is4Node
	*/

	// RVA: -1 Offset: -1
	public void ColorBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28740 Offset: 0x1E27B40 VA: 0x181E28740
	|-SortedSet.Node<KeyValuePair<long, object>>.ColorBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorBlack
	|-SortedSet.Node<object>.ColorBlack
	*/

	// RVA: -1 Offset: -1
	public void ColorRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28770 Offset: 0x1E27B70 VA: 0x181E28770
	|-SortedSet.Node<KeyValuePair<long, object>>.ColorRed
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorRed
	|-SortedSet.Node<object>.ColorRed
	*/

	// RVA: -1 Offset: -1
	public TreeRotation GetRotation(SortedSet.Node<T> current, SortedSet.Node<T> sibling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E287A0 Offset: 0x1E27BA0 VA: 0x181E287A0
	|-SortedSet.Node<KeyValuePair<long, object>>.GetRotation
	|-SortedSet.Node<KeyValuePair<object, object>>.GetRotation
	|-SortedSet.Node<object>.GetRotation
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> GetSibling(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28850 Offset: 0x1E27C50 VA: 0x181E28850
	|-SortedSet.Node<KeyValuePair<long, object>>.GetSibling
	|-SortedSet.Node<KeyValuePair<object, object>>.GetSibling
	|-SortedSet.Node<object>.GetSibling
	*/

	// RVA: -1 Offset: -1
	public void Split4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E29070 Offset: 0x1E28470 VA: 0x181E29070
	|-SortedSet.Node<KeyValuePair<long, object>>.Split4Node
	|-SortedSet.Node<KeyValuePair<object, object>>.Split4Node
	|-SortedSet.Node<object>.Split4Node
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> Rotate(TreeRotation rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28ED0 Offset: 0x1E282D0 VA: 0x181E28ED0
	|-SortedSet.Node<KeyValuePair<long, object>>.Rotate
	|-SortedSet.Node<KeyValuePair<object, object>>.Rotate
	|-SortedSet.Node<object>.Rotate
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28C40 Offset: 0x1E28040 VA: 0x181E28C40
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateLeft
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeft
	|-SortedSet.Node<object>.RotateLeft
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeftRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28B10 Offset: 0x1E27F10 VA: 0x181E28B10
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateLeftRight
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeftRight
	|-SortedSet.Node<object>.RotateLeftRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28E20 Offset: 0x1E28220 VA: 0x181E28E20
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateRight
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRight
	|-SortedSet.Node<object>.RotateRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRightLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28CF0 Offset: 0x1E280F0 VA: 0x181E28CF0
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateRightLeft
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRightLeft
	|-SortedSet.Node<object>.RotateRightLeft
	*/

	// RVA: -1 Offset: -1
	public void Merge2Nodes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E289E0 Offset: 0x1E27DE0 VA: 0x181E289E0
	|-SortedSet.Node<KeyValuePair<long, object>>.Merge2Nodes
	|-SortedSet.Node<KeyValuePair<object, object>>.Merge2Nodes
	|-SortedSet.Node<object>.Merge2Nodes
	*/

	// RVA: -1 Offset: -1
	public void ReplaceChild(SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28A90 Offset: 0x1E27E90 VA: 0x181E28A90
	|-SortedSet.Node<KeyValuePair<long, object>>.ReplaceChild
	|-SortedSet.Node<KeyValuePair<object, object>>.ReplaceChild
	|-SortedSet.Node<object>.ReplaceChild
	*/

}

public struct SortedSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 3145
{	// Fields
	private static readonly SortedSet.Node<T> s_dummyNode; // 0x0
	private SortedSet<T> _tree; // 0x0
	private int _version; // 0x0
	private Stack<SortedSet.Node<T>> _stack; // 0x0
	private SortedSet.Node<T> _current; // 0x0
	private bool _reverse; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	internal bool NotStartedOrEnded { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230F00 Offset: 0x230300 VA: 0x180230F00
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..ctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x230E80 Offset: 0x230280 VA: 0x180230E80
	|-SortedSet.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set, bool reverse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230EE0 Offset: 0x2302E0 VA: 0x180230EE0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..ctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x230EF0 Offset: 0x2302F0 VA: 0x180230EF0
	|-SortedSet.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230E60 Offset: 0x230260 VA: 0x180230E60
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x230E20 Offset: 0x230220 VA: 0x180230E20
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x230E40 Offset: 0x230240 VA: 0x180230E40
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230DF0 Offset: 0x2301F0 VA: 0x180230DF0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x230E10 Offset: 0x230210 VA: 0x180230E10
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x230E00 Offset: 0x230200 VA: 0x180230E00
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FED0 Offset: 0x22F2D0 VA: 0x18022FED0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Initialize
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Initialize
	|
	|-RVA: 0x22FEE0 Offset: 0x22F2E0 VA: 0x18022FEE0
	|-SortedSet.Enumerator<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FF50 Offset: 0x22F350 VA: 0x18022FF50
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.MoveNext
	|
	|-RVA: 0x22FFA0 Offset: 0x22F3A0 VA: 0x18022FFA0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x22FF40 Offset: 0x22F340 VA: 0x18022FF40
	|-SortedSet.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Dispose
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Dispose
	|-SortedSet.Enumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230FB0 Offset: 0x2303B0 VA: 0x180230FB0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.get_Current
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x2310E0 Offset: 0x2304E0 VA: 0x1802310E0
	|-SortedSet.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230920 Offset: 0x22FD20 VA: 0x180230920
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230C00 Offset: 0x230000 VA: 0x180230C00
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230D20 Offset: 0x230120 VA: 0x180230D20
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2311F0 Offset: 0x2305F0 VA: 0x1802311F0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<object>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FFD0 Offset: 0x22F3D0 VA: 0x18022FFD0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Reset
	|
	|-RVA: 0x22FFE0 Offset: 0x22F3E0 VA: 0x18022FFE0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Reset
	|
	|-RVA: 0x22FFC0 Offset: 0x22F3C0 VA: 0x18022FFC0
	|-SortedSet.Enumerator<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230800 Offset: 0x22FC00 VA: 0x180230800
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2306B0 Offset: 0x22FAB0 VA: 0x1802306B0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2308D0 Offset: 0x22FCD0 VA: 0x1802308D0
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E26B30 Offset: 0x1E25F30 VA: 0x181E26B30
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..cctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1E26C50 Offset: 0x1E26050 VA: 0x181E26C50
	|-SortedSet.Enumerator<object>..cctor
	*/

}

private sealed class SortedSet.<>c__DisplayClass52_0<T> // TypeDefIndex: 3146
{	// Fields
	public int index; // 0x0
	public int count; // 0x0
	public T[] array; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass52_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E30EB0 Offset: 0x1E302B0 VA: 0x181E30EB0
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<long, object>>.<CopyTo>b__0
	|
	|-RVA: 0x1E30E20 Offset: 0x1E30220 VA: 0x181E30E20
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, object>>.<CopyTo>b__0
	|
	|-RVA: 0x1E30D90 Offset: 0x1E30190 VA: 0x181E30D90
	|-SortedSet.<>c__DisplayClass52_0<object>.<CopyTo>b__0
	*/

}

private sealed class SortedSet.<>c__DisplayClass53_0<T> // TypeDefIndex: 3147
{	// Fields
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_0<object>..ctor
	*/

}

private sealed class SortedSet.<>c__DisplayClass53_1<T> // TypeDefIndex: 3148
{	// Fields
	public object[] objects; // 0x0
	public SortedSet.<>c__DisplayClass53_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_1<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E30F50 Offset: 0x1E30350 VA: 0x181E30F50
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<long, object>>.<System.Collections.ICollection.CopyTo>b__0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<object, object>>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x1E31050 Offset: 0x1E30450 VA: 0x181E31050
	|-SortedSet.<>c__DisplayClass53_1<object>.<System.Collections.ICollection.CopyTo>b__0
	*/

}

