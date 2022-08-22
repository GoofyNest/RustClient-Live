public struct Span<T> // TypeDefIndex: 120
{	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	public int Length { get; }
	public T Item { get; }


	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3AB0 Offset: 0x1E2EB0 VA: 0x1801E3AB0
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3940 Offset: 0x1E2D40 VA: 0x1801E3940
	|-Span<object>..ctor
	*/

	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3DA0 Offset: 0xF31A0 VA: 0x1800F3DA0
	|-Span<byte>.get_Length
	|-Span<object>.get_Length
	*/

	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3AD0 Offset: 0x1E2ED0 VA: 0x1801E3AD0
	|-Span<byte>.get_Item
	|-Span<object>.get_Item
	*/

	[ObsoleteAttribute] // RVA: 0xE94E0 Offset: 0xE88E0 VA: 0x1800E94E0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E34E0 Offset: 0x1E28E0 VA: 0x1801E34E0
	|-Span<byte>.Equals
	|
	|-RVA: 0x1E34B0 Offset: 0x1E28B0 VA: 0x1801E34B0
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xE96C0 Offset: 0xE8AC0 VA: 0x1800E96C0
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3540 Offset: 0x1E2940 VA: 0x1801E3540
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x1E3510 Offset: 0x1E2910 VA: 0x1801E3510
	|-Span<object>.GetHashCode
	*/

	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1362F50 Offset: 0x1362350 VA: 0x181362F50
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1363220 Offset: 0x1362620 VA: 0x181363220
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
	|-RVA: 0xBEFA80 Offset: 0xBEEE80 VA: 0x180BEFA80
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
	|-RVA: 0x13604E0 Offset: 0x135F8E0 VA: 0x1813604E0
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<char>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13607F0 Offset: 0x135FBF0 VA: 0x1813607F0
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0x1360610 Offset: 0x135FA10 VA: 0x181360610
	|-SpanHelpers.PerTypeValues<char>..cctor
	|
	|-RVA: 0x1360F70 Offset: 0x1360370 VA: 0x181360F70
	|-SpanHelpers.PerTypeValues<object>..cctor
	*/

}

public class SpanningTree<T> // TypeDefIndex: 4813
{	private List<SpanningTree.Node<T>> nodes; // 0x0
	private List<SpanningTree.Edge<T>> edges; // 0x0


	public int AddNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5DD90 Offset: 0xD5D190 VA: 0x180D5DD90
	|-SpanningTree<object>.AddNode
	*/

	public void AddEdge(int a_idx, int b_idx, int cost, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5DC70 Offset: 0xD5D070 VA: 0x180D5DC70
	|-SpanningTree<object>.AddEdge
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5E510 Offset: 0xD5D910 VA: 0x180D5E510
	|-SpanningTree<object>.Clear
	*/

	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5E780 Offset: 0xD5DB80 VA: 0x180D5E780
	|-SpanningTree<object>.Reset
	*/

	public void CalculateMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5DE50 Offset: 0xD5D250 VA: 0x180D5DE50
	|-SpanningTree<object>.CalculateMin
	*/

	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5E570 Offset: 0xD5D970 VA: 0x180D5E570
	|-SpanningTree<object>.ForEach
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5E9A0 Offset: 0xD5DDA0 VA: 0x180D5E9A0
	|-SpanningTree<object>..ctor
	*/

}

private class SpanningTree.Node<T> // TypeDefIndex: 4814
{	public List<SpanningTree.Edge<T>> edges; // 0x0
	public bool connected; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD54760 Offset: 0xD53B60 VA: 0x180D54760
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
	|-RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	|-SpanningTree.Edge<object>.get_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_order(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	|-SpanningTree.Edge<object>.set_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public SpanningTree.Edge<T> get_child() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	|-SpanningTree.Edge<object>.get_child
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_child(SpanningTree.Edge<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	|-SpanningTree.Edge<object>.set_child
	*/

	public void .ctor(SpanningTree.Node<T> source, SpanningTree.Node<T> target, int order, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD4DFC0 Offset: 0xD4D3C0 VA: 0x180D4DFC0
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
	|-RVA: 0xF3DA0 Offset: 0xF31A0 VA: 0x1800F3DA0
	|-Span<byte>.get_Length
	|-Span<short>.get_Length
	|-Span<object>.get_Length
	*/

	[ObsoleteAttribute] // RVA: 0xC98D0 Offset: 0xC8CD0 VA: 0x1800C98D0
	[EditorBrowsableAttribute] // RVA: 0xC98D0 Offset: 0xC8CD0 VA: 0x1800C98D0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E34D0 Offset: 0x1E28D0 VA: 0x1801E34D0
	|-Span<byte>.Equals
	|
	|-RVA: 0x1E34C0 Offset: 0x1E28C0 VA: 0x1801E34C0
	|-Span<short>.Equals
	|
	|-RVA: 0x1E34F0 Offset: 0x1E28F0 VA: 0x1801E34F0
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xC9A60 Offset: 0xC8E60 VA: 0x1800C9A60
	[EditorBrowsableAttribute] // RVA: 0xC9A60 Offset: 0xC8E60 VA: 0x1800C9A60
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3500 Offset: 0x1E2900 VA: 0x1801E3500
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x1E3520 Offset: 0x1E2920 VA: 0x1801E3520
	|-Span<short>.GetHashCode
	|
	|-RVA: 0x1E3530 Offset: 0x1E2930 VA: 0x1801E3530
	|-Span<object>.GetHashCode
	*/

	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1362EF0 Offset: 0x13622F0 VA: 0x181362EF0
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1362FB0 Offset: 0x13623B0 VA: 0x181362FB0
	|-Span<short>.op_Implicit
	|
	|-RVA: 0x1363280 Offset: 0x1362680 VA: 0x181363280
	|-Span<object>.op_Implicit
	*/

	public static Span<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363170 Offset: 0x1362570 VA: 0x181363170
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1363010 Offset: 0x1362410 VA: 0x181363010
	|-Span<short>.op_Implicit
	|
	|-RVA: 0x13630C0 Offset: 0x13624C0 VA: 0x1813630C0
	|-Span<object>.op_Implicit
	*/

	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3810 Offset: 0x1E2C10 VA: 0x1801E3810
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3960 Offset: 0x1E2D60 VA: 0x1801E3960
	|-Span<short>..ctor
	|
	|-RVA: 0x1E36B0 Offset: 0x1E2AB0 VA: 0x1801E36B0
	|-Span<object>..ctor
	*/

	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3950 Offset: 0x1E2D50 VA: 0x1801E3950
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3AA0 Offset: 0x1E2EA0 VA: 0x1801E3AA0
	|-Span<short>..ctor
	|
	|-RVA: 0x1E3A90 Offset: 0x1E2E90 VA: 0x1801E3A90
	|-Span<object>..ctor
	*/

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3820 Offset: 0x1E2C20 VA: 0x1801E3820
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3970 Offset: 0x1E2D70 VA: 0x1801E3970
	|-Span<short>..ctor
	|
	|-RVA: 0x1E36F0 Offset: 0x1E2AF0 VA: 0x1801E36F0
	|-Span<object>..ctor
	*/

	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36C0 Offset: 0x1E2AC0 VA: 0x1801E36C0
	|-Span<byte>..ctor
	|-Span<short>..ctor
	|-Span<object>..ctor
	*/

	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3AC0 Offset: 0x1E2EC0 VA: 0x1801E3AC0
	|-Span<byte>.get_Item
	|-Span<short>.get_Item
	|-Span<object>.get_Item
	*/

	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3430 Offset: 0x1E2830 VA: 0x1801E3430
	|-Span<byte>.CopyTo
	|-Span<short>.CopyTo
	|-Span<object>.CopyTo
	*/

	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3680 Offset: 0x1E2A80 VA: 0x1801E3680
	|-Span<byte>.TryCopyTo
	|-Span<short>.TryCopyTo
	|-Span<object>.TryCopyTo
	*/

	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3650 Offset: 0x1E2A50 VA: 0x1801E3650
	|-Span<byte>.ToString
	|
	|-RVA: 0x1E3660 Offset: 0x1E2A60 VA: 0x1801E3660
	|-Span<short>.ToString
	|
	|-RVA: 0x1E3670 Offset: 0x1E2A70 VA: 0x1801E3670
	|-Span<object>.ToString
	*/

	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3550 Offset: 0x1E2950 VA: 0x1801E3550
	|-Span<byte>.Slice
	|-Span<short>.Slice
	|-Span<object>.Slice
	*/

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E34A0 Offset: 0x1E28A0 VA: 0x1801E34A0
	|-Span<byte>.DangerousGetPinnableReference
	|-Span<short>.DangerousGetPinnableReference
	|-Span<object>.DangerousGetPinnableReference
	*/

	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	|-Span<byte>.get_Pinnable
	|-Span<short>.get_Pinnable
	|-Span<object>.get_Pinnable
	*/

	internal IntPtr get_ByteOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
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
	|-RVA: 0xF03820 Offset: 0xF02C20 VA: 0x180F03820
	|-SpanHelpers.CopyTo<byte>
	|
	|-RVA: 0xF03D70 Offset: 0xF03170 VA: 0x180F03D70
	|-SpanHelpers.CopyTo<short>
	|
	|-RVA: 0xF042D0 Offset: 0xF036D0 VA: 0x180F042D0
	|-SpanHelpers.CopyTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static IntPtr Add<T>(IntPtr start, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83D70 Offset: 0xE83170 VA: 0x180E83D70
	|-SpanHelpers.Add<byte>
	|-SpanHelpers.Add<short>
	|-SpanHelpers.Add<object>
	*/

	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEFA80 Offset: 0xBEEE80 VA: 0x180BEFA80
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
	|-RVA: 0x13604E0 Offset: 0x135F8E0 VA: 0x1813604E0
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<short>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1360BB0 Offset: 0x135FFB0 VA: 0x181360BB0
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0x13609D0 Offset: 0x135FDD0 VA: 0x1813609D0
	|-SpanHelpers.PerTypeValues<short>..cctor
	|
	|-RVA: 0x1360D90 Offset: 0x1360190 VA: 0x181360D90
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
	|-RVA: 0x1F1DB0 Offset: 0x1F11B0 VA: 0x1801F1DB0
	|-SpanWriter.Write<byte>
	|
	|-RVA: 0x1F1F20 Offset: 0x1F1320 VA: 0x1801F1F20
	|-SpanWriter.Write<ushort>
	|
	|-RVA: 0x1F2090 Offset: 0x1F1490 VA: 0x1801F2090
	|-SpanWriter.Write<ulong>
	*/

	public void Write<T>(Span<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F1C80 Offset: 0x1F1080 VA: 0x1801F1C80
	|-SpanWriter.Write<byte>
	*/

}

