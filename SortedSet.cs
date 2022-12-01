internal sealed class SortedSet.Node<T> // TypeDefIndex: 3144
{
	[CompilerGeneratedAttribute]
	private T <Item>k__BackingField;
	[CompilerGeneratedAttribute]
	private SortedSet.Node<T> <Left>k__BackingField;
	[CompilerGeneratedAttribute]
	private SortedSet.Node<T> <Right>k__BackingField;
	[CompilerGeneratedAttribute]
	private NodeColor <Color>k__BackingField;

	public T Item { get; set; }
	public SortedSet.Node<T> Left { get; set; }
	public SortedSet.Node<T> Right { get; set; }
	public NodeColor Color { get; set; }
	public bool IsBlack { get; }
	public bool IsRed { get; }
	public bool Is2Node { get; }
	public bool Is4Node { get; }


	public void .ctor(T item, NodeColor color) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>..ctor
	|-SortedSet.Node<KeyValuePair<object, object>>..ctor
	|
	|-SortedSet.Node<object>..ctor
	*/

	public static bool IsNonNullRed(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.IsNonNullRed
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNonNullRed
	|-SortedSet.Node<object>.IsNonNullRed
	*/

	public static bool IsNullOrBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.IsNullOrBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNullOrBlack
	|-SortedSet.Node<object>.IsNullOrBlack
	*/

	[CompilerGeneratedAttribute]
	public T get_Item() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Item
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Item
	|
	|-SortedSet.Node<object>.get_Item
	*/

	[CompilerGeneratedAttribute]
	public void set_Item(T value) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Item
	|
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Item
	|
	|-SortedSet.Node<object>.set_Item
	*/

	[CompilerGeneratedAttribute]
	public SortedSet.Node<T> get_Left() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Left
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Left
	|
	|-SortedSet.Node<object>.get_Left
	*/

	[CompilerGeneratedAttribute]
	public void set_Left(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Left
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Left
	|
	|-SortedSet.Node<object>.set_Left
	*/

	[CompilerGeneratedAttribute]
	public SortedSet.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Right
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Right
	|
	|-SortedSet.Node<object>.get_Right
	*/

	[CompilerGeneratedAttribute]
	public void set_Right(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Right
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Right
	|
	|-SortedSet.Node<object>.set_Right
	*/

	[CompilerGeneratedAttribute]
	public NodeColor get_Color() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Color
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Color
	|
	|-SortedSet.Node<object>.get_Color
	*/

	[CompilerGeneratedAttribute]
	public void set_Color(NodeColor value) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Color
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Color
	|
	|-SortedSet.Node<object>.set_Color
	*/

	public bool get_IsBlack() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.get_IsBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsBlack
	|-SortedSet.Node<object>.get_IsBlack
	*/

	public bool get_IsRed() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.get_IsRed
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsRed
	|-SortedSet.Node<object>.get_IsRed
	*/

	public bool get_Is2Node() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Is2Node
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is2Node
	|-SortedSet.Node<object>.get_Is2Node
	*/

	public bool get_Is4Node() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Is4Node
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is4Node
	|-SortedSet.Node<object>.get_Is4Node
	*/

	public void ColorBlack() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.ColorBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorBlack
	|-SortedSet.Node<object>.ColorBlack
	*/

	public void ColorRed() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.ColorRed
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorRed
	|-SortedSet.Node<object>.ColorRed
	*/

	public TreeRotation GetRotation(SortedSet.Node<T> current, SortedSet.Node<T> sibling) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.GetRotation
	|-SortedSet.Node<KeyValuePair<object, object>>.GetRotation
	|-SortedSet.Node<object>.GetRotation
	*/

	public SortedSet.Node<T> GetSibling(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.GetSibling
	|-SortedSet.Node<KeyValuePair<object, object>>.GetSibling
	|-SortedSet.Node<object>.GetSibling
	*/

	public void Split4Node() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.Split4Node
	|-SortedSet.Node<KeyValuePair<object, object>>.Split4Node
	|-SortedSet.Node<object>.Split4Node
	*/

	public SortedSet.Node<T> Rotate(TreeRotation rotation) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.Rotate
	|-SortedSet.Node<KeyValuePair<object, object>>.Rotate
	|-SortedSet.Node<object>.Rotate
	*/

	public SortedSet.Node<T> RotateLeft() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateLeft
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeft
	|-SortedSet.Node<object>.RotateLeft
	*/

	public SortedSet.Node<T> RotateLeftRight() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateLeftRight
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeftRight
	|-SortedSet.Node<object>.RotateLeftRight
	*/

	public SortedSet.Node<T> RotateRight() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateRight
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRight
	|-SortedSet.Node<object>.RotateRight
	*/

	public SortedSet.Node<T> RotateRightLeft() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateRightLeft
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRightLeft
	|-SortedSet.Node<object>.RotateRightLeft
	*/

	public void Merge2Nodes() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.Merge2Nodes
	|-SortedSet.Node<KeyValuePair<object, object>>.Merge2Nodes
	|-SortedSet.Node<object>.Merge2Nodes
	*/

	public void ReplaceChild(SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Node<KeyValuePair<long, object>>.ReplaceChild
	|-SortedSet.Node<KeyValuePair<object, object>>.ReplaceChild
	|-SortedSet.Node<object>.ReplaceChild
	*/

}

public struct SortedSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 3145
{
	private static readonly SortedSet.Node<T> s_dummyNode;
	private SortedSet<T> _tree;
	private int _version;
	private Stack<SortedSet.Node<T>> _stack;
	private SortedSet.Node<T> _current;
	private bool _reverse;

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	internal bool NotStartedOrEnded { get; }


	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..ctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-SortedSet.Enumerator<object>..ctor
	*/

	internal void .ctor(SortedSet<T> set, bool reverse) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..ctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-SortedSet.Enumerator<object>..ctor
	*/

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Initialize
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Initialize
	|
	|-SortedSet.Enumerator<object>.Initialize
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.MoveNext
	|
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-SortedSet.Enumerator<object>.MoveNext
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Dispose
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Dispose
	|-SortedSet.Enumerator<object>.Dispose
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.get_Current
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-SortedSet.Enumerator<object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<object>.get_NotStartedOrEnded
	*/

	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Reset
	|
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Reset
	|
	|-SortedSet.Enumerator<object>.Reset
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..cctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..cctor
	|
	|-SortedSet.Enumerator<object>..cctor
	*/

}

private sealed class SortedSet.<>c__DisplayClass52_0<T> // TypeDefIndex: 3146
{
	public int index;
	public int count;
	public T[] array;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-SortedSet.<>c
	|-SortedSet.<>c
	|-SortedSet.<>c
	*/

	internal bool <CopyTo>
	/* GenericInstMethod :
	|
	|-SortedSet.<>c
	|
	|-SortedSet.<>c
	|
	|-SortedSet.<>c
	*/

}

private sealed class SortedSet.<>c__DisplayClass53_0<T> // TypeDefIndex: 3147
{
	public int index;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-SortedSet.<>c
	|-SortedSet.<>c
	|-SortedSet.<>c
	*/

}

private sealed class SortedSet.<>c__DisplayClass53_1<T> // TypeDefIndex: 3148
{
	public object[] objects;
	public SortedSet.<>c


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-SortedSet.<>c
	|-SortedSet.<>c
	|-SortedSet.<>c
	*/

	internal bool <System.Collections.ICollection.CopyTo>
	/* GenericInstMethod :
	|
	|-SortedSet.<>c
	|-SortedSet.<>c
	|
	|-SortedSet.<>c
	*/

}

