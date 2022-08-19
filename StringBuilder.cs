public sealed class StringBuilder : ISerializable // TypeDefIndex: 463
{	// Fields
	internal char[] m_ChunkChars; // 0x10
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

	// Properties
	public int Capacity { get; set; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }

	// Methods

	// RVA: 0x191EFA0 Offset: 0x191E3A0 VA: 0x18191EFA0
	public void .ctor() { }

	// RVA: 0x191EAE0 Offset: 0x191DEE0 VA: 0x18191EAE0
	public void .ctor(int capacity) { }

	// RVA: 0x191EE80 Offset: 0x191E280 VA: 0x18191EE80
	public void .ctor(string value) { }

	// RVA: 0x191EEC0 Offset: 0x191E2C0 VA: 0x18191EEC0
	public void .ctor(string value, int capacity) { }

	// RVA: 0x191E830 Offset: 0x191DC30 VA: 0x18191E830
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x191EBC0 Offset: 0x191DFC0 VA: 0x18191EBC0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191E180 Offset: 0x191D580 VA: 0x18191E180 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191F010 Offset: 0x191E410 VA: 0x18191F010
	public int get_Capacity() { }

	// RVA: 0x191F110 Offset: 0x191E510 VA: 0x18191F110
	public void set_Capacity(int value) { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public int get_MaxCapacity() { }

	// RVA: 0x191E6F0 Offset: 0x191DAF0 VA: 0x18191E6F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x191E440 Offset: 0x191D840 VA: 0x18191E440
	public string ToString(int startIndex, int length) { }

	// RVA: 0x191BDA0 Offset: 0x191B1A0 VA: 0x18191BDA0
	public StringBuilder Clear() { }

	// RVA: 0x128EE00 Offset: 0x128E200 VA: 0x18128EE00
	public int get_Length() { }

	// RVA: 0x191F3B0 Offset: 0x191E7B0 VA: 0x18191F3B0
	public void set_Length(int value) { }

	// RVA: 0x191F030 Offset: 0x191E430 VA: 0x18191F030
	public char get_Chars(int index) { }

	// RVA: 0x191F290 Offset: 0x191E690 VA: 0x18191F290
	public void set_Chars(int index, char value) { }

	// RVA: 0x191B830 Offset: 0x191AC30 VA: 0x18191B830
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x191B560 Offset: 0x191A960 VA: 0x18191B560
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x191BC00 Offset: 0x191B000 VA: 0x18191BC00
	public StringBuilder Append(string value) { }

	// RVA: 0x191B210 Offset: 0x191A610 VA: 0x18191B210
	private void AppendHelper(string value) { }

	// RVA: 0x191B930 Offset: 0x191AD30 VA: 0x18191B930
	public StringBuilder Append(string value, int startIndex, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x191B290 Offset: 0x191A690 VA: 0x18191B290
	public StringBuilder AppendLine() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x191B260 Offset: 0x191A660 VA: 0x18191B260
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x191C680 Offset: 0x191BA80 VA: 0x18191C680
	public StringBuilder Insert(int index, string value, int count) { }

	// RVA: 0x191D360 Offset: 0x191C760 VA: 0x18191D360
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x191B4F0 Offset: 0x191A8F0 VA: 0x18191B4F0
	public StringBuilder Append(byte value) { }

	// RVA: 0x191B2C0 Offset: 0x191A6C0 VA: 0x18191B2C0
	public StringBuilder Append(char value) { }

	// RVA: 0x191B740 Offset: 0x191AB40 VA: 0x18191B740
	public StringBuilder Append(int value) { }

	// RVA: 0x191BB80 Offset: 0x191AF80 VA: 0x18191BB80
	public StringBuilder Append(long value) { }

	// RVA: 0x191B7B0 Offset: 0x191ABB0 VA: 0x18191B7B0
	public StringBuilder Append(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x191BD30 Offset: 0x191B130 VA: 0x18191BD30
	public StringBuilder Append(uint value) { }

	// RVA: 0x191BAF0 Offset: 0x191AEF0 VA: 0x18191BAF0
	public StringBuilder Append(object value) { }

	// RVA: 0x191BB30 Offset: 0x191AF30 VA: 0x18191BB30
	public StringBuilder Append(char[] value) { }

	// RVA: 0x191C590 Offset: 0x191B990 VA: 0x18191C590
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x191C650 Offset: 0x191BA50 VA: 0x18191C650
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x191B1A0 Offset: 0x191A5A0 VA: 0x18191B1A0
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x191B120 Offset: 0x191A520 VA: 0x18191B120
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x191B000 Offset: 0x191A400 VA: 0x18191B000
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x191AF20 Offset: 0x191A320 VA: 0x18191AF20
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x191AEA0 Offset: 0x191A2A0 VA: 0x18191AEA0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x191B090 Offset: 0x191A490 VA: 0x18191B090
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x191BFB0 Offset: 0x191B3B0 VA: 0x18191BFB0
	private static void FormatError() { }

	// RVA: 0x191A870 Offset: 0x1919C70 VA: 0x18191A870
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x191E070 Offset: 0x191D470 VA: 0x18191E070
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x191DC00 Offset: 0x191D000 VA: 0x18191DC00
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x191B3C0 Offset: 0x191A7C0 VA: 0x18191B3C0
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x191C020 Offset: 0x191B420 VA: 0x18191C020
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x191D6D0 Offset: 0x191CAD0 VA: 0x18191D6D0
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x191E0A0 Offset: 0x191D4A0 VA: 0x18191E0A0
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x191DAC0 Offset: 0x191CEC0 VA: 0x18191DAC0
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x191E360 Offset: 0x191D760 VA: 0x18191E360
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x191E270 Offset: 0x191D670 VA: 0x18191E270
	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x191BF70 Offset: 0x191B370 VA: 0x18191BF70
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x191D0E0 Offset: 0x191C4E0 VA: 0x18191D0E0
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x191BDC0 Offset: 0x191B1C0 VA: 0x18191BDC0
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x191EB60 Offset: 0x191DF60 VA: 0x18191EB60
	private void .ctor(StringBuilder from) { }

	// RVA: 0x191CCE0 Offset: 0x191C0E0 VA: 0x18191CCE0
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	// RVA: 0x191EF00 Offset: 0x191E300 VA: 0x18191EF00
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x191D130 Offset: 0x191C530 VA: 0x18191D130
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

}

