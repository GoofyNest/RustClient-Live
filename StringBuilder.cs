public sealed class StringBuilder : ISerializable // TypeDefIndex: 463
{	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28
	internal const int DefaultCapacity = 16;
	private const string CapacityField = "Capacity";
	private const string MaxCapacityField = "m_MaxCapacity";
	private const string StringValueField = "m_StringValue";
	private const string ThreadIDField = "m_currentThread";
	internal const int MaxChunkSize = 8000;

	public int Capacity { get; set; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }


	public void .ctor() { }

	public void .ctor(int capacity) { }

	public void .ctor(string value) { }

	public void .ctor(string value, int capacity) { }

	public void .ctor(string value, int startIndex, int length, int capacity) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public int get_Capacity() { }

	public void set_Capacity(int value) { }

	public int get_MaxCapacity() { }

	public override string ToString() { }

	public string ToString(int startIndex, int length) { }

	public StringBuilder Clear() { }

	public int get_Length() { }

	public void set_Length(int value) { }

	public char get_Chars(int index) { }

	public void set_Chars(int index, char value) { }

	public StringBuilder Append(char value, int repeatCount) { }

	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	public StringBuilder Append(string value) { }

	private void AppendHelper(string value) { }

	public StringBuilder Append(string value, int startIndex, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public StringBuilder AppendLine() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public StringBuilder AppendLine(string value) { }

	public StringBuilder Insert(int index, string value, int count) { }

	public StringBuilder Remove(int startIndex, int length) { }

	public StringBuilder Append(byte value) { }

	public StringBuilder Append(char value) { }

	public StringBuilder Append(int value) { }

	public StringBuilder Append(long value) { }

	public StringBuilder Append(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public StringBuilder Append(uint value) { }

	public StringBuilder Append(object value) { }

	public StringBuilder Append(char[] value) { }

	public StringBuilder Insert(int index, string value) { }

	public StringBuilder Insert(int index, char value) { }

	public StringBuilder AppendFormat(string format, object arg0) { }

	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	public StringBuilder AppendFormat(string format, object[] args) { }

	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	private static void FormatError() { }

	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	public StringBuilder Replace(string oldValue, string newValue) { }

	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public StringBuilder Append(char* value, int valueCount) { }

	private void Insert(int index, char* value, int valueCount) { }

	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	private StringBuilder FindChunkForIndex(int index) { }

	private StringBuilder Next(StringBuilder chunk) { }

	private void ExpandByABlock(int minBlockCharCount) { }

	private void .ctor(StringBuilder from) { }

	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

}

