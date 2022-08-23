public struct Span<T> // TypeDefIndex: 120
{	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	public int Length { get; }
	public T Item { get; }


	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-Span<byte>..ctor
	|
	|-Span<object>..ctor
	*/

	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-Span<byte>.get_Length
	|-Span<object>.get_Length
	*/

	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.get_Item
	|-Span<object>.get_Item
	*/

	[ObsoleteAttribute] // RVA: 0xE94E0 Offset: 0xE88E0 VA: 0x1800E94E0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.Equals
	|
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xE96C0 Offset: 0xE8AC0 VA: 0x1800E96C0
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-Span<byte>.GetHashCode
	|
	|-Span<object>.GetHashCode
	*/

	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.op_Implicit
	|
	|-Span<object>.op_Implicit
	*/

}

internal static class SpanHelpers // TypeDefIndex: 122
{
[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal static class SpanHelpers // TypeDefIndex: 122

	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<char>
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	*/

	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

}

public static class SpanHelpers.PerTypeValues<T> // TypeDefIndex: 123
{	public static readonly bool IsReferenceOrContainsReferences; // 0x0
	public static readonly T[] EmptyArray; // 0x0
	public static readonly IntPtr ArrayAdjustment; // 0x0


	private static IntPtr MeasureArrayAdjustment() { }
	/* GenericInstMethod :
	|
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<char>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-SpanHelpers.PerTypeValues<char>..cctor
	|
	|-SpanHelpers.PerTypeValues<object>..cctor
	*/

}

public class SpanningTree<T> // TypeDefIndex: 4813
{	private List<SpanningTree.Node<T>> nodes; // 0x0
	private List<SpanningTree.Edge<T>> edges; // 0x0


	public int AddNode() { }
	/* GenericInstMethod :
	|
	|-SpanningTree<object>.AddNode
	*/

	public void AddEdge(int a_idx, int b_idx, int cost, T value) { }
	/* GenericInstMethod :
	|
	|-SpanningTree<object>.AddEdge
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-SpanningTree<object>.Clear
	*/

	public void Reset() { }
	/* GenericInstMethod :
	|
	|-SpanningTree<object>.Reset
	*/

	public void CalculateMin() { }
	/* GenericInstMethod :
	|
	|-SpanningTree<object>.CalculateMin
	*/

	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-SpanningTree<object>.ForEach
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-SpanningTree<object>..ctor
	*/

}

private class SpanningTree.Node<T> // TypeDefIndex: 4814
{	public List<SpanningTree.Edge<T>> edges; // 0x0
	public bool connected; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-SpanningTree.Node<object>..ctor
	*/

}

private class SpanningTree.Edge<T> : IMinHeapNode<SpanningTree.Edge<T>> // TypeDefIndex: 4815
{	public SpanningTree.Node<T> source; // 0x0
	public SpanningTree.Node<T> target; // 0x0
	public T value; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <order>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SpanningTree.Edge<T> <child>k__BackingField; // 0x0

	public int order { get; set; }
	public SpanningTree.Edge<T> child { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_order() { }
	/* GenericInstMethod :
	|
	|-SpanningTree.Edge<object>.get_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_order(int value) { }
	/* GenericInstMethod :
	|
	|-SpanningTree.Edge<object>.set_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public SpanningTree.Edge<T> get_child() { }
	/* GenericInstMethod :
	|
	|-SpanningTree.Edge<object>.get_child
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_child(SpanningTree.Edge<T> value) { }
	/* GenericInstMethod :
	|
	|-SpanningTree.Edge<object>.set_child
	*/

	public void .ctor(SpanningTree.Node<T> source, SpanningTree.Node<T> target, int order, T value) { }
	/* GenericInstMethod :
	|
	|-SpanningTree.Edge<object>..ctor
	*/

}

public struct Span<T> // TypeDefIndex: 6729
{	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	public int Length { get; }
	public T Item { get; }
	internal Pinnable<T> Pinnable { get; }
	internal IntPtr ByteOffset { get; }


	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-Span<byte>.get_Length
	|-Span<short>.get_Length
	|-Span<object>.get_Length
	*/

	[ObsoleteAttribute] // RVA: 0xC98D0 Offset: 0xC8CD0 VA: 0x1800C98D0
	[EditorBrowsableAttribute] // RVA: 0xC98D0 Offset: 0xC8CD0 VA: 0x1800C98D0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.Equals
	|
	|-Span<short>.Equals
	|
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xC9A60 Offset: 0xC8E60 VA: 0x1800C9A60
	[EditorBrowsableAttribute] // RVA: 0xC9A60 Offset: 0xC8E60 VA: 0x1800C9A60
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-Span<byte>.GetHashCode
	|
	|-Span<short>.GetHashCode
	|
	|-Span<object>.GetHashCode
	*/

	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.op_Implicit
	|
	|-Span<short>.op_Implicit
	|
	|-Span<object>.op_Implicit
	*/

	public static Span<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.op_Implicit
	|
	|-Span<short>.op_Implicit
	|
	|-Span<object>.op_Implicit
	*/

	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-Span<byte>..ctor
	|
	|-Span<short>..ctor
	|
	|-Span<object>..ctor
	*/

	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-Span<byte>..ctor
	|
	|-Span<short>..ctor
	|
	|-Span<object>..ctor
	*/

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-Span<byte>..ctor
	|
	|-Span<short>..ctor
	|
	|-Span<object>..ctor
	*/

	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-Span<byte>..ctor
	|-Span<short>..ctor
	|-Span<object>..ctor
	*/

	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.get_Item
	|-Span<short>.get_Item
	|-Span<object>.get_Item
	*/

	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.CopyTo
	|-Span<short>.CopyTo
	|-Span<object>.CopyTo
	*/

	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.TryCopyTo
	|-Span<short>.TryCopyTo
	|-Span<object>.TryCopyTo
	*/

	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-Span<byte>.ToString
	|
	|-Span<short>.ToString
	|
	|-Span<object>.ToString
	*/

	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-Span<byte>.Slice
	|-Span<short>.Slice
	|-Span<object>.Slice
	*/

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-Span<byte>.DangerousGetPinnableReference
	|-Span<short>.DangerousGetPinnableReference
	|-Span<object>.DangerousGetPinnableReference
	*/

	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-Span<byte>.get_Pinnable
	|-Span<short>.get_Pinnable
	|-Span<object>.get_Pinnable
	*/

	internal IntPtr get_ByteOffset() { }
	/* GenericInstMethod :
	|
	|-Span<byte>.get_ByteOffset
	|-Span<short>.get_ByteOffset
	|-Span<object>.get_ByteOffset
	*/

}

internal static class SpanHelpers // TypeDefIndex: 6731
{
[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal static class SpanHelpers // TypeDefIndex: 6731

	public static void CopyTo<T>(ref T dst, int dstLength, ref T src, int srcLength) { }
	/* GenericInstMethod :
	|
	|-SpanHelpers.CopyTo<byte>
	|
	|-SpanHelpers.CopyTo<short>
	|
	|-SpanHelpers.CopyTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static IntPtr Add<T>(IntPtr start, int index) { }
	/* GenericInstMethod :
	|
	|-SpanHelpers.Add<byte>
	|-SpanHelpers.Add<short>
	|-SpanHelpers.Add<object>
	*/

	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<short>
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	*/

	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

}

public static class SpanHelpers.PerTypeValues<T> // TypeDefIndex: 6732
{	public static readonly bool IsReferenceOrContainsReferences; // 0x0
	public static readonly T[] EmptyArray; // 0x0
	public static readonly IntPtr ArrayAdjustment; // 0x0


	private static IntPtr MeasureArrayAdjustment() { }
	/* GenericInstMethod :
	|
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<short>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-SpanHelpers.PerTypeValues<short>..cctor
	|
	|-SpanHelpers.PerTypeValues<object>..cctor
	*/

}

internal struct SpanWriter // TypeDefIndex: 6924
{	private readonly Span<byte> _data; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Length>k__BackingField; // 0x18

	public int Length { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Length(int value) { }

	public void .ctor(Span<byte> data) { }

	public void Write<T>(T value, bool reverse = True) { }
	/* GenericInstMethod :
	|
	|-SpanWriter.Write<byte>
	|
	|-SpanWriter.Write<ushort>
	|
	|-SpanWriter.Write<ulong>
	*/

	public void Write<T>(Span<T> values) { }
	/* GenericInstMethod :
	|
	|-SpanWriter.Write<byte>
	*/

}

