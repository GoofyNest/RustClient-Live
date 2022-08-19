public static class JsonUtility // TypeDefIndex: 4525
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xE7C80 Offset: 0xE7080 VA: 0x1800E7C80
public static class JsonUtility // TypeDefIndex: 4525
	// Methods

	[ThreadSafeAttribute] // RVA: 0xE7D30 Offset: 0xE7130 VA: 0x1800E7D30
	[FreeFunctionAttribute] // RVA: 0xE7D30 Offset: 0xE7130 VA: 0x1800E7D30
	// RVA: 0x231D470 Offset: 0x231C870 VA: 0x18231D470
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BEAA0 Offset: 0x14BDEA0 VA: 0x1814BEAA0
	|-JsonUtility.FromJson<RandomUsernames.DataFile>
	|-JsonUtility.FromJson<object>
	*/

	// RVA: 0x231D4D0 Offset: 0x231C8D0 VA: 0x18231D4D0
	public static object FromJson(string json, Type type) { }

}

internal enum JSONNodeType // TypeDefIndex: 5637
{	// Fields
	public int value__; // 0x0
	public const JSONNodeType Array = 1;
	public const JSONNodeType Object = 2;
	public const JSONNodeType String = 3;
	public const JSONNodeType Number = 4;
	public const JSONNodeType NullValue = 5;
	public const JSONNodeType Boolean = 6;
	public const JSONNodeType None = 7;
	public const JSONNodeType Custom = 255;

}

internal enum JSONTextMode // TypeDefIndex: 5638
{	// Fields
	public int value__; // 0x0
	public const JSONTextMode Compact = 0;
	public const JSONTextMode Indent = 1;

}

internal abstract class JSONNode // TypeDefIndex: 5639
{	// Fields
	public static bool forceASCII; // 0x0
	public static bool longAsString; // 0x1
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static StringBuilder m_EscapeBuilder; // 0x80000000

	// Properties
	public virtual JSONNode Item { get; }
	public virtual JSONNode Item { get; set; }
	public virtual string Value { get; }
	public virtual int Count { get; }
	public virtual bool IsNumber { get; }
	public virtual bool IsBoolean { get; }
	public virtual bool IsArray { get; }
	public virtual IEnumerable<JSONNode> Children { get; }
	public virtual double AsDouble { get; }
	public virtual int AsInt { get; }
	public virtual bool AsBool { get; }
	public virtual long AsLong { get; }
	public virtual JSONArray AsArray { get; }
	public virtual JSONObject AsObject { get; }
	internal static StringBuilder EscapeBuilder { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 4
	public virtual JSONNode get_Item(int aIndex) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C52D0 Offset: 0x13C46D0 VA: 0x1813C52D0 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	public virtual bool get_IsNumber() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 10
	public virtual bool get_IsBoolean() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 11
	public virtual bool get_IsArray() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13C3C00 Offset: 0x13C3000 VA: 0x1813C3C00 Slot: 13
	public virtual void Add(JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB720 Offset: 0xBAB20 VA: 0x1800BB720
	// RVA: 0x13C51E0 Offset: 0x13C45E0 VA: 0x1813C51E0 Slot: 14
	public virtual IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13C4E30 Offset: 0x13C4230 VA: 0x1813C4E30 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract JSONNode.Enumerator GetEnumerator();

	// RVA: 0x13C5010 Offset: 0x13C4410 VA: 0x1813C5010 Slot: 17
	public virtual double get_AsDouble() { }

	// RVA: 0x13C50F0 Offset: 0x13C44F0 VA: 0x1813C50F0 Slot: 18
	public virtual int get_AsInt() { }

	// RVA: 0x13C4F50 Offset: 0x13C4350 VA: 0x1813C4F50 Slot: 19
	public virtual bool get_AsBool() { }

	// RVA: 0x13C5110 Offset: 0x13C4510 VA: 0x1813C5110 Slot: 20
	public virtual long get_AsLong() { }

	// RVA: 0x13C4ED0 Offset: 0x13C42D0 VA: 0x1813C4ED0 Slot: 21
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x13C5160 Offset: 0x13C4560 VA: 0x1813C5160 Slot: 22
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x13C5500 Offset: 0x13C4900 VA: 0x1813C5500
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x13C5560 Offset: 0x13C4960 VA: 0x1813C5560
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x13C55B0 Offset: 0x13C49B0 VA: 0x1813C55B0
	public static JSONNode op_Implicit(double n) { }

	// RVA: 0x13C54A0 Offset: 0x13C48A0 VA: 0x1813C54A0
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x13C5300 Offset: 0x13C4700 VA: 0x1813C5300
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x13C5610 Offset: 0x13C4A10 VA: 0x1813C5610
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C5240 Offset: 0x13C4640 VA: 0x1813C5240
	internal static StringBuilder get_EscapeBuilder() { }

	// RVA: 0x13C3F50 Offset: 0x13C3350 VA: 0x1813C3F50
	internal static string Escape(string aText) { }

	// RVA: 0x13C43B0 Offset: 0x13C37B0 VA: 0x1813C43B0
	private static JSONNode ParseElement(string token, bool quoted) { }

	// RVA: 0x13C4610 Offset: 0x13C3A10 VA: 0x1813C4610
	public static JSONNode Parse(string aJSON) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void SerializeBinary(BinaryWriter aWriter);

	// RVA: 0x13C4DB0 Offset: 0x13C41B0 VA: 0x1813C4DB0
	public void SaveToBinaryStream(Stream aData) { }

	// RVA: 0x13C4C10 Offset: 0x13C4010 VA: 0x1813C4C10
	public string SaveToBinaryBase64() { }

	// RVA: 0x13C3C60 Offset: 0x13C3060 VA: 0x1813C3C60
	public static JSONNode DeserializeBinary(BinaryReader aReader) { }

	// RVA: 0x13C42C0 Offset: 0x13C36C0 VA: 0x1813C42C0
	public static JSONNode LoadFromBinaryStream(Stream aData) { }

	// RVA: 0x13C4210 Offset: 0x13C3610 VA: 0x1813C4210
	public static JSONNode LoadFromBinaryBase64(string aBase64) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public struct JSONNode.Enumerator // TypeDefIndex: 5640
{	// Fields
	private JSONNode.Enumerator.Type type; // 0x0
	private Dictionary.Enumerator<string, JSONNode> m_Object; // 0x8
	private List.Enumerator<JSONNode> m_Array; // 0x30

	// Properties
	public KeyValuePair<string, JSONNode> Current { get; }

	// Methods

	// RVA: 0x1EEE60 Offset: 0x1EE260 VA: 0x1801EEE60
	public void .ctor(List.Enumerator<JSONNode> aArrayEnum) { }

	// RVA: 0x1EEEA0 Offset: 0x1EE2A0 VA: 0x1801EEEA0
	public void .ctor(Dictionary.Enumerator<string, JSONNode> aDictEnum) { }

	// RVA: 0x1EEEF0 Offset: 0x1EE2F0 VA: 0x1801EEEF0
	public KeyValuePair<string, JSONNode> get_Current() { }

	// RVA: 0x1EEDF0 Offset: 0x1EE1F0 VA: 0x1801EEDF0
	public bool MoveNext() { }

}

private enum JSONNode.Enumerator.Type // TypeDefIndex: 5641
{	// Fields
	public int value__; // 0x0
	public const JSONNode.Enumerator.Type None = 0;
	public const JSONNode.Enumerator.Type Array = 1;
	public const JSONNode.Enumerator.Type Object = 2;

}

private sealed class JSONNode.<get_Children>d__40 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5642
{	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20

	// Properties
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CA1C0 Offset: 0x13C95C0 VA: 0x1813CA1C0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13CA260 Offset: 0x13C9660 VA: 0x1813CA260 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13CA1D0 Offset: 0x13C95D0 VA: 0x1813CA1D0 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13CA1D0 Offset: 0x13C95D0 VA: 0x1813CA1D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONArray : JSONNode // TypeDefIndex: 5643
{	// Fields
	private List<JSONNode> m_List; // 0x10
	private bool inline; // 0x18

	// Properties
	public override bool IsArray { get; }
	public override JSONNode Item { get; }
	public override JSONNode Item { get; set; }
	public override int Count { get; }
	public override IEnumerable<JSONNode> Children { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	public override bool get_IsArray() { }

	// RVA: 0x13C2CB0 Offset: 0x13C20B0 VA: 0x1813C2CB0 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C3130 Offset: 0x13C2530 VA: 0x1813C3130 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C30C0 Offset: 0x13C24C0 VA: 0x1813C30C0 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C31F0 Offset: 0x13C25F0 VA: 0x1813C31F0 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C3080 Offset: 0x13C2480 VA: 0x1813C3080 Slot: 8
	public override int get_Count() { }

	// RVA: 0x13C2C20 Offset: 0x13C2020 VA: 0x1813C2C20 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBBC70 Offset: 0xBB070 VA: 0x1800BBC70
	// RVA: 0x13C3010 Offset: 0x13C2410 VA: 0x1813C3010 Slot: 14
	public override IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13C2E40 Offset: 0x13C2240 VA: 0x1813C2E40 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C2D40 Offset: 0x13C2140 VA: 0x1813C2D40 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13C2FA0 Offset: 0x13C23A0 VA: 0x1813C2FA0
	public void .ctor() { }

}

private sealed class JSONArray.<get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5644
{	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONArray <>4__this; // 0x28
	private List.Enumerator<JSONNode> <>7__wrap1; // 0x30

	// Properties
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13C9DA0 Offset: 0x13C91A0 VA: 0x1813C9DA0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13C9B50 Offset: 0x13C8F50 VA: 0x1813C9B50 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x13C9E40 Offset: 0x13C9240 VA: 0x1813C9E40
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13C9D50 Offset: 0x13C9150 VA: 0x1813C9D50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13C9CB0 Offset: 0x13C90B0 VA: 0x1813C9CB0 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13C9CB0 Offset: 0x13C90B0 VA: 0x1813C9CB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONObject : JSONNode // TypeDefIndex: 5645
{	// Fields
	private Dictionary<string, JSONNode> m_Dict; // 0x10
	private bool inline; // 0x18

	// Properties
	public override JSONNode Item { get; set; }
	public override JSONNode Item { get; }
	public override int Count { get; }
	public override IEnumerable<JSONNode> Children { get; }

	// Methods

	// RVA: 0x13C5F40 Offset: 0x13C5340 VA: 0x1813C5F40 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C6620 Offset: 0x13C5A20 VA: 0x1813C6620 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C66F0 Offset: 0x13C5AF0 VA: 0x1813C66F0 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C6590 Offset: 0x13C5990 VA: 0x1813C6590 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C6540 Offset: 0x13C5940 VA: 0x1813C6540 Slot: 8
	public override int get_Count() { }

	// RVA: 0x13C5DF0 Offset: 0x13C51F0 VA: 0x1813C5DF0 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBDC20 Offset: 0xBD020 VA: 0x1800BDC20
	// RVA: 0x13C64D0 Offset: 0x13C58D0 VA: 0x1813C64D0 Slot: 14
	public override IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13C61C0 Offset: 0x13C55C0 VA: 0x1813C61C0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C5FF0 Offset: 0x13C53F0 VA: 0x1813C5FF0 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13C6460 Offset: 0x13C5860 VA: 0x1813C6460
	public void .ctor() { }

}

private sealed class JSONObject.<get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5646
{	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONObject <>4__this; // 0x28
	private Dictionary.Enumerator<string, JSONNode> <>7__wrap1; // 0x30

	// Properties
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13CA0E0 Offset: 0x13C94E0 VA: 0x1813CA0E0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13C9E80 Offset: 0x13C9280 VA: 0x1813C9E80 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x13CA180 Offset: 0x13C9580 VA: 0x1813CA180
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13CA090 Offset: 0x13C9490 VA: 0x1813CA090 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13C9FF0 Offset: 0x13C93F0 VA: 0x1813C9FF0 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13C9FF0 Offset: 0x13C93F0 VA: 0x1813C9FF0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONString : JSONNode // TypeDefIndex: 5647
{	// Fields
	private string m_Data; // 0x10

	// Properties
	public override string Value { get; }

	// Methods

	// RVA: 0x13C3310 Offset: 0x13C2710 VA: 0x1813C3310 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 7
	public override string get_Value() { }

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(string aData) { }

	// RVA: 0x13C69D0 Offset: 0x13C5DD0 VA: 0x1813C69D0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C67D0 Offset: 0x13C5BD0 VA: 0x1813C67D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDDCF60 Offset: 0xDDC360 VA: 0x180DDCF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C6970 Offset: 0x13C5D70 VA: 0x1813C6970 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONNumber : JSONNode // TypeDefIndex: 5648
{	// Fields
	private double m_Data; // 0x10

	// Properties
	public override bool IsNumber { get; }
	public override string Value { get; }
	public override double AsDouble { get; }
	public override long AsLong { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 9
	public override bool get_IsNumber() { }

	// RVA: 0x13C3310 Offset: 0x13C2710 VA: 0x1813C3310 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C5D90 Offset: 0x13C5190 VA: 0x1813C5D90 Slot: 7
	public override string get_Value() { }

	// RVA: 0xB37020 Offset: 0xB36420 VA: 0x180B37020 Slot: 17
	public override double get_AsDouble() { }

	// RVA: 0x13C5D80 Offset: 0x13C5180 VA: 0x1813C5D80 Slot: 20
	public override long get_AsLong() { }

	// RVA: 0x13C5D50 Offset: 0x13C5150 VA: 0x1813C5D50
	public void .ctor(double aData) { }

	// RVA: 0x13C5D10 Offset: 0x13C5110 VA: 0x1813C5D10 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C5B90 Offset: 0x13C4F90 VA: 0x1813C5B90
	private static bool IsNumeric(object value) { }

	// RVA: 0x13C58C0 Offset: 0x13C4CC0 VA: 0x1813C58C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C5B80 Offset: 0x13C4F80 VA: 0x1813C5B80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C5CB0 Offset: 0x13C50B0 VA: 0x1813C5CB0 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONBool : JSONNode // TypeDefIndex: 5649
{	// Fields
	private bool m_Data; // 0x10

	// Properties
	public override bool IsBoolean { get; }
	public override string Value { get; }
	public override bool AsBool { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 10
	public override bool get_IsBoolean() { }

	// RVA: 0x13C3310 Offset: 0x13C2710 VA: 0x1813C3310 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C3400 Offset: 0x13C2800 VA: 0x1813C3400 Slot: 7
	public override string get_Value() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0xF835B0 Offset: 0xF829B0 VA: 0x180F835B0
	public void .ctor(bool aData) { }

	// RVA: 0x13C33A0 Offset: 0x13C27A0 VA: 0x1813C33A0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C3280 Offset: 0x13C2680 VA: 0x1813C3280 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C3330 Offset: 0x13C2730 VA: 0x1813C3330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C3340 Offset: 0x13C2740 VA: 0x1813C3340 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONNull : JSONNode // TypeDefIndex: 5650
{	// Fields
	private static JSONNull m_StaticInstance; // 0x0
	public static bool reuseSameInstance; // 0x8

	// Properties
	public override string Value { get; }
	public override bool AsBool { get; }

	// Methods

	// RVA: 0x13C5630 Offset: 0x13C4A30 VA: 0x1813C5630
	public static JSONNull CreateOrGet() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x13C3310 Offset: 0x13C2710 VA: 0x1813C3310 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C5890 Offset: 0x13C4C90 VA: 0x1813C5890 Slot: 7
	public override string get_Value() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0x13C56E0 Offset: 0x13C4AE0 VA: 0x1813C56E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C57D0 Offset: 0x13C4BD0 VA: 0x1813C57D0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C57A0 Offset: 0x13C4BA0 VA: 0x1813C57A0 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13C5820 Offset: 0x13C4C20 VA: 0x1813C5820
	private static void .cctor() { }

}

internal class JSONLazyCreator : JSONNode // TypeDefIndex: 5651
{	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Properties
	public override JSONNode Item { get; }
	public override JSONNode Item { get; set; }
	public override int AsInt { get; }
	public override double AsDouble { get; }
	public override long AsLong { get; }
	public override bool AsBool { get; }
	public override JSONArray AsArray { get; }
	public override JSONObject AsObject { get; }

	// Methods

	// RVA: 0x13C3310 Offset: 0x13C2710 VA: 0x1813C3310 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C3640 Offset: 0x13C2A40 VA: 0x1813C3640
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: -1 Offset: -1
	private T Set<T>(T aVal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E8180 Offset: 0x5E7580 VA: 0x1805E8180
	|-JSONLazyCreator.Set<JSONArray>
	|-JSONLazyCreator.Set<JSONBool>
	|-JSONLazyCreator.Set<JSONNumber>
	|-JSONLazyCreator.Set<JSONObject>
	|-JSONLazyCreator.Set<JSONString>
	|-JSONLazyCreator.Set<object>
	*/

	// RVA: 0x13C3AA0 Offset: 0x13C2EA0 VA: 0x1813C3AA0 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C3A20 Offset: 0x13C2E20 VA: 0x1813C3A20 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C3B10 Offset: 0x13C2F10 VA: 0x1813C3B10 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C3500 Offset: 0x13C2900 VA: 0x1813C3500 Slot: 13
	public override void Add(JSONNode aItem) { }

	// RVA: 0x13C3410 Offset: 0x13C2810 VA: 0x1813C3410 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13C35E0 Offset: 0x13C29E0 VA: 0x1813C35E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C3820 Offset: 0x13C2C20 VA: 0x1813C3820 Slot: 18
	public override int get_AsInt() { }

	// RVA: 0x13C37B0 Offset: 0x13C2BB0 VA: 0x1813C37B0 Slot: 17
	public override double get_AsDouble() { }

	// RVA: 0x13C3890 Offset: 0x13C2C90 VA: 0x1813C3890 Slot: 20
	public override long get_AsLong() { }

	// RVA: 0x13C3740 Offset: 0x13C2B40 VA: 0x1813C3740 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0x13C3690 Offset: 0x13C2A90 VA: 0x1813C3690 Slot: 21
	public override JSONArray get_AsArray() { }

	// RVA: 0x13C3970 Offset: 0x13C2D70 VA: 0x1813C3970 Slot: 22
	public override JSONObject get_AsObject() { }

	// RVA: 0x13C35F0 Offset: 0x13C29F0 VA: 0x1813C35F0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal static class JSON // TypeDefIndex: 5652
{	// Methods

	// RVA: 0x13C6A40 Offset: 0x13C5E40 VA: 0x1813C6A40
	public static JSONNode Parse(string aJSON) { }

}

public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 5872
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class JsonException : Exception // TypeDefIndex: 5874
{	// Methods

	// RVA: 0xF860F0 Offset: 0xF854F0 VA: 0x180F860F0
	public void .ctor() { }

	// RVA: 0xF861D0 Offset: 0xF855D0 VA: 0x180F861D0
	public void .ctor(string message) { }

	// RVA: 0xF86150 Offset: 0xF85550 VA: 0x180F86150
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xF86070 Offset: 0xF85470 VA: 0x180F86070
	public void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class JsonExtensionDataAttribute : Attribute // TypeDefIndex: 5875
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <WriteData>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ReadData>k__BackingField; // 0x11

	// Properties
	public bool WriteData { get; set; }
	public bool ReadData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_WriteData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	public void set_WriteData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260
	public bool get_ReadData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86270 Offset: 0xF85670 VA: 0x180F86270
	public void set_ReadData(bool value) { }

	// RVA: 0xF86240 Offset: 0xF85640 VA: 0x180F86240
	public void .ctor() { }

}

internal enum JsonContainerType // TypeDefIndex: 5876
{	// Fields
	public int value__; // 0x0
	public const JsonContainerType None = 0;
	public const JsonContainerType Object = 1;
	public const JsonContainerType Array = 2;
	public const JsonContainerType Constructor = 3;

}

internal struct JsonPosition // TypeDefIndex: 5877
{	// Fields
	private static readonly char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x0
	internal int Position; // 0x4
	internal string PropertyName; // 0x8
	internal bool HasIndex; // 0x10

	// Methods

	// RVA: 0x141E00 Offset: 0x141200 VA: 0x180141E00
	public void .ctor(JsonContainerType type) { }

	// RVA: 0x141DE0 Offset: 0x1411E0 VA: 0x180141DE0
	internal int CalculateLength() { }

	// RVA: 0x141DF0 Offset: 0x1411F0 VA: 0x180141DF0
	internal void WriteTo(StringBuilder sb) { }

	// RVA: 0x4B9B30 Offset: 0x4B8F30 VA: 0x1804B9B30
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0xF86280 Offset: 0xF85680 VA: 0x180F86280
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0xF866A0 Offset: 0xF85AA0 VA: 0x180F866A0
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xF869E0 Offset: 0xF85DE0 VA: 0x180F869E0
	private static void .cctor() { }

}

public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 5878
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 5884
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 5885
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Type <ItemConverterType>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object[] <ItemConverterParameters>k__BackingField; // 0x18
	internal Nullable<bool> _isReference; // 0x20
	internal Nullable<bool> _itemIsReference; // 0x22
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x24
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x2C

	// Properties
	public Type ItemConverterType { get; }
	public object[] ItemConverterParameters { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public object[] get_ItemConverterParameters() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

}

public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 5887
{	// Fields
	private readonly Type _converterType; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object[] <ConverterParameters>k__BackingField; // 0x18

	// Properties
	public Type ConverterType { get; }
	public object[] ConverterParameters { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Type get_ConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public object[] get_ConverterParameters() { }

	// RVA: 0xF85FA0 Offset: 0xF853A0 VA: 0x180F85FA0
	public void .ctor(Type converterType) { }

}

public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 5888
{	// Fields
	private MemberSerialization _memberSerialization; // 0x38
	internal Nullable<Required> _itemRequired; // 0x3C

	// Properties
	public MemberSerialization MemberSerialization { get; }

	// Methods

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class JsonSerializerSettings // TypeDefIndex: 5889
{	// Fields
	internal static readonly StreamingContext DefaultContext; // 0x0
	internal static readonly CultureInfo DefaultCulture; // 0x10
	internal Nullable<Formatting> _formatting; // 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; // 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; // 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; // 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; // 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; // 0x40
	internal CultureInfo _culture; // 0x48
	internal Nullable<bool> _checkAdditionalContent; // 0x50
	internal Nullable<int> _maxDepth; // 0x54
	internal bool _maxDepthSet; // 0x5C
	internal string _dateFormatString; // 0x60
	internal bool _dateFormatStringSet; // 0x68
	internal Nullable<FormatterAssemblyStyle> _typeNameAssemblyFormat; // 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; // 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x9C
	internal Nullable<StreamingContext> _context; // 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; // 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IContractResolver <ContractResolver>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SerializationBinder <Binder>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108

	// Properties
	public ReferenceLoopHandling ReferenceLoopHandling { get; }
	public MissingMemberHandling MissingMemberHandling { get; }
	public ObjectCreationHandling ObjectCreationHandling { get; }
	public NullValueHandling NullValueHandling { get; }
	public DefaultValueHandling DefaultValueHandling { get; }
	public IList<JsonConverter> Converters { get; set; }
	public PreserveReferencesHandling PreserveReferencesHandling { get; }
	public TypeNameHandling TypeNameHandling { get; }
	public MetadataPropertyHandling MetadataPropertyHandling { get; }
	public FormatterAssemblyStyle TypeNameAssemblyFormat { get; }
	public ConstructorHandling ConstructorHandling { get; }
	public IContractResolver ContractResolver { get; }
	public IEqualityComparer EqualityComparer { get; }
	public Func<IReferenceResolver> ReferenceResolverProvider { get; }
	public ITraceWriter TraceWriter { get; }
	public SerializationBinder Binder { get; }
	public EventHandler<ErrorEventArgs> Error { get; }
	public StreamingContext Context { get; }

	// Methods

	// RVA: 0xF8B6A0 Offset: 0xF8AAA0 VA: 0x180F8B6A0
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xF8B5A0 Offset: 0xF8A9A0 VA: 0x180F8B5A0
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xF8B620 Offset: 0xF8AA20 VA: 0x180F8B620
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xF8B5E0 Offset: 0xF8A9E0 VA: 0x180F8B5E0
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0xF8B520 Offset: 0xF8A920 VA: 0x180F8B520
	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9A430 Offset: 0xD99830 VA: 0x180D9A430
	public IList<JsonConverter> get_Converters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD300D0 Offset: 0xD2F4D0 VA: 0x180D300D0
	public void set_Converters(IList<JsonConverter> value) { }

	// RVA: 0xF8B660 Offset: 0xF8AA60 VA: 0x180F8B660
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xF8B720 Offset: 0xF8AB20 VA: 0x180F8B720
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xF8B560 Offset: 0xF8A960 VA: 0x180F8B560
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xF8B6E0 Offset: 0xF8AAE0 VA: 0x180F8B6E0
	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0xF8B440 Offset: 0xF8A840 VA: 0x180F8B440
	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	public IContractResolver get_ContractResolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0A550 Offset: 0xB09950 VA: 0x180B0A550
	public ITraceWriter get_TraceWriter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09500 Offset: 0xA08900 VA: 0x180A09500
	public SerializationBinder get_Binder() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62850 Offset: 0xC61C50 VA: 0x180C62850
	public EventHandler<ErrorEventArgs> get_Error() { }

	// RVA: 0xF8B480 Offset: 0xF8A880 VA: 0x180F8B480
	public StreamingContext get_Context() { }

	// RVA: 0xF8B250 Offset: 0xF8A650 VA: 0x180F8B250
	private static void .cctor() { }

	// RVA: 0xF8B2D0 Offset: 0xF8A6D0 VA: 0x180F8B2D0
	public void .ctor() { }

}

private sealed class JsonSerializerSettings.<>c__DisplayClass90_0 // TypeDefIndex: 5890
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5894
{	// Fields
	private readonly TextReader _reader; // 0x78
	private char[] _chars; // 0x80
	private int _charsUsed; // 0x88
	private int _charPos; // 0x8C
	private int _lineStartPos; // 0x90
	private int _lineNumber; // 0x94
	private bool _isEndOfFile; // 0x98
	private StringBuffer _stringBuffer; // 0xA0
	private StringReference _stringReference; // 0xB0
	private IArrayPool<char> _arrayPool; // 0xC0
	internal PropertyNameTable NameTable; // 0xC8

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0xF962B0 Offset: 0xF956B0 VA: 0x180F962B0
	public void .ctor(TextReader reader) { }

	// RVA: 0xF8E6D0 Offset: 0xF8DAD0 VA: 0x180F8E6D0
	private void EnsureBufferNotEmpty() { }

	// RVA: 0xF8EEF0 Offset: 0xF8E2F0 VA: 0x180F8EEF0
	private void OnNewLine(int pos) { }

	// RVA: 0xF917E0 Offset: 0xF90BE0 VA: 0x180F917E0
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0xBAF6F0 Offset: 0xBAEAF0 VA: 0x180BAF6F0
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0xF960E0 Offset: 0xF954E0 VA: 0x180F960E0
	private void ShiftBufferIfNeeded() { }

	// RVA: 0xF943C0 Offset: 0xF937C0 VA: 0x180F943C0
	private int ReadData(bool append) { }

	// RVA: 0xF94130 Offset: 0xF93530 VA: 0x180F94130
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0xF8E7B0 Offset: 0xF8DBB0 VA: 0x180F8E7B0
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xF940A0 Offset: 0xF934A0 VA: 0x180F940A0
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xF95DF0 Offset: 0xF951F0 VA: 0x180F95DF0 Slot: 10
	public override bool Read() { }

	// RVA: 0xF93FB0 Offset: 0xF933B0 VA: 0x180F93FB0 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0xF93DD0 Offset: 0xF931D0 VA: 0x180F93DD0 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0xF94040 Offset: 0xF93440 VA: 0x180F94040 Slot: 12
	public override string ReadAsString() { }

	// RVA: 0xF936B0 Offset: 0xF92AB0 VA: 0x180F936B0 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0xF95480 Offset: 0xF94880 VA: 0x180F95480
	private object ReadStringValue(ReadType readType) { }

	// RVA: 0xF8E460 Offset: 0xF8D860 VA: 0x180F8E460
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0xF92D80 Offset: 0xF92180 VA: 0x180F92D80 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0xF92D10 Offset: 0xF92110 VA: 0x180F92D10
	private void ProcessValueComma() { }

	// RVA: 0xF947F0 Offset: 0xF93BF0 VA: 0x180F947F0
	private object ReadNumberValue(ReadType readType) { }

	// RVA: 0xF93D30 Offset: 0xF93130 VA: 0x180F93D30 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xF93E70 Offset: 0xF93270 VA: 0x180F93E70 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0xF93F10 Offset: 0xF93310 VA: 0x180F93F10 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0xF8E850 Offset: 0xF8DC50 VA: 0x180F8E850
	private void HandleNull() { }

	// RVA: 0xF943D0 Offset: 0xF937D0 VA: 0x180F943D0
	private void ReadFinished() { }

	// RVA: 0xF94560 Offset: 0xF93960 VA: 0x180F94560
	private bool ReadNullChar() { }

	// RVA: 0xF8E740 Offset: 0xF8DB40 VA: 0x180F8E740
	private void EnsureBuffer() { }

	// RVA: 0xF94DD0 Offset: 0xF941D0 VA: 0x180F94DD0
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0xF96230 Offset: 0xF95630 VA: 0x180F96230
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xF91E40 Offset: 0xF91240 VA: 0x180F91E40
	private char ParseUnicode() { }

	// RVA: 0xF945B0 Offset: 0xF939B0 VA: 0x180F945B0
	private void ReadNumberIntoBuffer() { }

	// RVA: 0xF8E3A0 Offset: 0xF8D7A0 VA: 0x180F8E3A0
	private void ClearRecentString() { }

	// RVA: 0xF91160 Offset: 0xF90560 VA: 0x180F91160
	private bool ParsePostValue() { }

	// RVA: 0xF90F90 Offset: 0xF90390 VA: 0x180F90F90
	private bool ParseObject() { }

	// RVA: 0xF914A0 Offset: 0xF908A0 VA: 0x180F914A0
	private bool ParseProperty() { }

	// RVA: 0xF961C0 Offset: 0xF955C0 VA: 0x180F961C0
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0xF91F30 Offset: 0xF91330 VA: 0x180F91F30
	private void ParseUnquotedProperty() { }

	// RVA: 0xF92180 Offset: 0xF91580 VA: 0x180F92180
	private bool ParseValue() { }

	// RVA: 0xF92CF0 Offset: 0xF920F0 VA: 0x180F92CF0
	private void ProcessLineFeed() { }

	// RVA: 0xF92C00 Offset: 0xF92000 VA: 0x180F92C00
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0xF8E510 Offset: 0xF8D910 VA: 0x180F8E510
	private bool EatWhitespace(bool oneOrMore) { }

	// RVA: 0xF8F2F0 Offset: 0xF8E6F0 VA: 0x180F8F2F0
	private void ParseConstructor() { }

	// RVA: 0xF8FF80 Offset: 0xF8F380 VA: 0x180F8FF80
	private void ParseNumber(ReadType readType) { }

	// RVA: 0xF8EF00 Offset: 0xF8E300 VA: 0x180F8EF00
	private void ParseComment(bool setToken) { }

	// RVA: 0xF8E660 Offset: 0xF8DA60 VA: 0x180F8E660
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xF8EDE0 Offset: 0xF8E1E0 VA: 0x180F8EDE0
	private bool MatchValue(string value) { }

	// RVA: 0xF8EAD0 Offset: 0xF8DED0 VA: 0x180F8EAD0
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xF8E980 Offset: 0xF8DD80 VA: 0x180F8E980
	private bool IsSeparator(char c) { }

	// RVA: 0xF91C30 Offset: 0xF91030 VA: 0x180F91C30
	private void ParseTrue() { }

	// RVA: 0xF8F800 Offset: 0xF8EC00 VA: 0x180F8F800
	private void ParseNull() { }

	// RVA: 0xF91D40 Offset: 0xF91140 VA: 0x180F91D40
	private void ParseUndefined() { }

	// RVA: 0xF8F6F0 Offset: 0xF8EAF0 VA: 0x180F8F6F0
	private void ParseFalse() { }

	// RVA: 0xF8FB20 Offset: 0xF8EF20 VA: 0x180F8FB20
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xF8FD50 Offset: 0xF8F150 VA: 0x180F8FD50
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xF8F8F0 Offset: 0xF8ECF0 VA: 0x180F8F8F0
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xF8E3C0 Offset: 0xF8D7C0 VA: 0x180F8E3C0 Slot: 20
	public override void Close() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 21
	public bool HasLineInfo() { }

	// RVA: 0xF96360 Offset: 0xF95760 VA: 0x180F96360 Slot: 22
	public int get_LineNumber() { }

	// RVA: 0xF963B0 Offset: 0xF957B0 VA: 0x180F963B0 Slot: 23
	public int get_LinePosition() { }

}

public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 5895
{	// Fields
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0x30
	internal Nullable<bool> _isReference; // 0x38
	internal Nullable<int> _order; // 0x3C
	internal Nullable<Required> _required; // 0x44
	internal Nullable<bool> _itemIsReference; // 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Type <ItemConverterType>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object[] <ItemConverterParameters>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <PropertyName>k__BackingField; // 0x70

	// Properties
	public Type ItemConverterType { get; }
	public object[] ItemConverterParameters { get; }
	public string PropertyName { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public object[] get_ItemConverterParameters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public string get_PropertyName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_PropertyName(string value) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xF86AD0 Offset: 0xF85ED0 VA: 0x180F86AD0
	public void .ctor(string propertyName) { }

}

public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 5896
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class JsonTextWriter : JsonWriter // TypeDefIndex: 5897
{	// Fields
	private readonly TextWriter _writer; // 0x60
	private Base64Encoder _base64Encoder; // 0x68
	private char _indentChar; // 0x70
	private int _indentation; // 0x74
	private char _quoteChar; // 0x78
	private bool _quoteName; // 0x7A
	private bool[] _charEscapeFlags; // 0x80
	private char[] _writeBuffer; // 0x88
	private IArrayPool<char> _arrayPool; // 0x90
	private char[] _indentChars; // 0x98

	// Properties
	private Base64Encoder Base64Encoder { get; }
	public char QuoteChar { get; }

	// Methods

	// RVA: 0xE42510 Offset: 0xE41910 VA: 0x180E42510
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0xE42590 Offset: 0xE41990 VA: 0x180E42590
	public char get_QuoteChar() { }

	// RVA: 0xE42430 Offset: 0xE41830 VA: 0x180E42430
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0xE40780 Offset: 0xE3FB80 VA: 0x180E40780 Slot: 6
	public override void Close() { }

	// RVA: 0xE41230 Offset: 0xE40630 VA: 0x180E41230 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0xE41130 Offset: 0xE40530 VA: 0x180E41130 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0xE41180 Offset: 0xE40580 VA: 0x180E41180 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE409C0 Offset: 0xE3FDC0 VA: 0x180E409C0 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE41090 Offset: 0xE40490 VA: 0x180E41090 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0xE40FA0 Offset: 0xE403A0 VA: 0x180E40FA0 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE40880 Offset: 0xE3FC80 VA: 0x180E40880 Slot: 5
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0xE40890 Offset: 0xE3FC90 VA: 0x180E40890
	private void UpdateCharEscapeFlags() { }

	// RVA: 0xE40BD0 Offset: 0xE3FFD0 VA: 0x180E40BD0 Slot: 18
	protected override void WriteIndent() { }

	// RVA: 0xE41320 Offset: 0xE40720 VA: 0x180E41320 Slot: 19
	protected override void WriteValueDelimiter() { }

	// RVA: 0xE40BA0 Offset: 0xE3FFA0 VA: 0x180E40BA0 Slot: 20
	protected override void WriteIndentSpace() { }

	// RVA: 0xE41100 Offset: 0xE40500 VA: 0x180E41100
	private void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xE359C0 Offset: 0xE34DC0 VA: 0x180E359C0 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0xE40F00 Offset: 0xE40300 VA: 0x180E40F00 Slot: 21
	public override void WriteNull() { }

	// RVA: 0xE41280 Offset: 0xE40680 VA: 0x180E41280 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0xE41100 Offset: 0xE40500 VA: 0x180E41100 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0xE421E0 Offset: 0xE415E0 VA: 0x180E421E0 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0xE40AA0 Offset: 0xE3FEA0 VA: 0x180E40AA0
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xE421A0 Offset: 0xE415A0 VA: 0x180E421A0 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE41F10 Offset: 0xE41310 VA: 0x180E41F10 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0xE420E0 Offset: 0xE414E0 VA: 0x180E420E0 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE415D0 Offset: 0xE409D0 VA: 0x180E415D0 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0xE41410 Offset: 0xE40810 VA: 0x180E41410 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0xE414E0 Offset: 0xE408E0 VA: 0x180E414E0 Slot: 47
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0xE41610 Offset: 0xE40A10 VA: 0x180E41610 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0xE41F50 Offset: 0xE41350 VA: 0x180E41F50 Slot: 48
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0xE42040 Offset: 0xE41440 VA: 0x180E42040 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0xE41D40 Offset: 0xE41140 VA: 0x180E41D40 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE42120 Offset: 0xE41520 VA: 0x180E42120 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0xE41E70 Offset: 0xE41270 VA: 0x180E41E70 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0xE42160 Offset: 0xE41560 VA: 0x180E42160 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE423F0 Offset: 0xE417F0 VA: 0x180E423F0 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0xE422A0 Offset: 0xE416A0 VA: 0x180E422A0 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE417C0 Offset: 0xE40BC0 VA: 0x180E417C0 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE416E0 Offset: 0xE40AE0 VA: 0x180E416E0 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0xE41A90 Offset: 0xE40E90 VA: 0x180E41A90 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE41D80 Offset: 0xE41180 VA: 0x180E41D80 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0xE42350 Offset: 0xE41750 VA: 0x180E42350 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE41350 Offset: 0xE40750 VA: 0x180E41350 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0xE40910 Offset: 0xE3FD10 VA: 0x180E40910 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0xE40840 Offset: 0xE3FC40 VA: 0x180E40840
	private void EnsureWriteBuffer() { }

	// RVA: 0xE40E70 Offset: 0xE40270 VA: 0x180E40E70
	private void WriteIntegerValue(long value) { }

	// RVA: 0xE40D30 Offset: 0xE40130 VA: 0x180E40D30
	private void WriteIntegerValue(ulong uvalue) { }

}

public class JsonWriterException : JsonException // TypeDefIndex: 5898
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Path>k__BackingField; // 0x88

	// Properties
	private string Path { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	private void set_Path(string value) { }

	// RVA: 0xE42800 Offset: 0xE41C00 VA: 0x180E42800
	public void .ctor() { }

	// RVA: 0xE427E0 Offset: 0xE41BE0 VA: 0x180E427E0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE427A0 Offset: 0xE41BA0 VA: 0x180E427A0
	internal void .ctor(string message, Exception innerException, string path) { }

	// RVA: 0xE425A0 Offset: 0xE419A0 VA: 0x180E425A0
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xE426E0 Offset: 0xE41AE0 VA: 0x180E426E0
	internal static JsonWriterException Create(string path, string message, Exception ex) { }

}

public class JsonReaderException : JsonException // TypeDefIndex: 5899
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <LineNumber>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <LinePosition>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Path>k__BackingField; // 0x90

	// Properties
	private int LineNumber { set; }
	private int LinePosition { set; }
	private string Path { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86EB0 Offset: 0xF862B0 VA: 0x180F86EB0
	private void set_LineNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86EC0 Offset: 0xF862C0 VA: 0x180F86EC0
	private void set_LinePosition(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	private void set_Path(string value) { }

	// RVA: 0xF860F0 Offset: 0xF854F0 VA: 0x180F860F0
	public void .ctor() { }

	// RVA: 0xF86070 Offset: 0xF85470 VA: 0x180F86070
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF86E00 Offset: 0xF86200 VA: 0x180F86E00
	internal void .ctor(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

	// RVA: 0xF86B00 Offset: 0xF85F00 VA: 0x180F86B00
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xF86B10 Offset: 0xF85F10 VA: 0x180F86B10
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xF86CB0 Offset: 0xF860B0 VA: 0x180F86CB0
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

public abstract class JsonConverter // TypeDefIndex: 5900
{	// Properties
	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool CanConvert(Type objectType);

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public virtual bool get_CanRead() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	public virtual bool get_CanWrite() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 5901
{	// Methods

	// RVA: 0xF86030 Offset: 0xF85430 VA: 0x180F86030
	public void .ctor() { }

}

public abstract class JsonReader : IDisposable // TypeDefIndex: 5902
{	// Fields
	private JsonToken _tokenType; // 0x10
	private object _value; // 0x18
	internal char _quoteChar; // 0x20
	internal JsonReader.State _currentState; // 0x24
	private JsonPosition _currentPosition; // 0x28
	private CultureInfo _culture; // 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
	private Nullable<int> _maxDepth; // 0x4C
	private bool _hasExceededMaxDepth; // 0x54
	internal DateParseHandling _dateParseHandling; // 0x58
	internal FloatParseHandling _floatParseHandling; // 0x5C
	private string _dateFormatString; // 0x60
	private List<JsonPosition> _stack; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <CloseInput>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <SupportMultipleContent>k__BackingField; // 0x71

	// Properties
	protected JsonReader.State CurrentState { get; }
	public bool CloseInput { get; set; }
	public bool SupportMultipleContent { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public virtual JsonToken TokenType { get; }
	public virtual object Value { get; }
	public virtual Type ValueType { get; }
	public virtual int Depth { get; }
	public virtual string Path { get; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	protected JsonReader.State get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2CA80 Offset: 0xC2BE80 VA: 0x180C2CA80
	public bool get_CloseInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2DBA0 Offset: 0xC2CFA0 VA: 0x180C2DBA0
	public void set_CloseInput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE891D0 Offset: 0xE885D0 VA: 0x180E891D0
	public bool get_SupportMultipleContent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE89200 Offset: 0xE88600 VA: 0x180E89200
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xF8AEC0 Offset: 0xF8A2C0 VA: 0x180F8AEC0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0xF8AE50 Offset: 0xF8A250 VA: 0x180F8AE50
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x58DC00 Offset: 0x58D000 VA: 0x18058DC00
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xF8AF30 Offset: 0xF8A330 VA: 0x180F8AF30
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public string get_DateFormatString() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_DateFormatString(string value) { }

	// RVA: 0xF8AD20 Offset: 0xF8A120 VA: 0x180F8AD20
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0xF8AFA0 Offset: 0xF8A3A0 VA: 0x180F8AFA0
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 5
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	public virtual object get_Value() { }

	// RVA: 0xF8AE30 Offset: 0xF8A230 VA: 0x180F8AE30 Slot: 7
	public virtual Type get_ValueType() { }

	// RVA: 0xF8ACB0 Offset: 0xF8A0B0 VA: 0x180F8ACB0 Slot: 8
	public virtual int get_Depth() { }

	// RVA: 0xF8AD30 Offset: 0xF8A130 VA: 0x180F8AD30 Slot: 9
	public virtual string get_Path() { }

	// RVA: 0xF8AC50 Offset: 0xF8A050 VA: 0x180F8AC50
	public CultureInfo get_Culture() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xF86FE0 Offset: 0xF863E0 VA: 0x180F86FE0
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0xF8AC20 Offset: 0xF8A020 VA: 0x180F8AC20
	protected void .ctor() { }

	// RVA: 0xF872D0 Offset: 0xF866D0 VA: 0x180F872D0
	private void Push(JsonContainerType value) { }

	// RVA: 0xF871D0 Offset: 0xF865D0 VA: 0x180F871D0
	private JsonContainerType Pop() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Read();

	// RVA: 0xF88C10 Offset: 0xF88010 VA: 0x180F88C10 Slot: 11
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0xF8A040 Offset: 0xF89440 VA: 0x180F8A040
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0xF88EF0 Offset: 0xF882F0 VA: 0x180F88EF0 Slot: 12
	public virtual string ReadAsString() { }

	// RVA: 0xF87BD0 Offset: 0xF86FD0 VA: 0x180F87BD0 Slot: 13
	public virtual byte[] ReadAsBytes() { }

	// RVA: 0xF87670 Offset: 0xF86A70 VA: 0x180F87670
	internal byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xF88940 Offset: 0xF87D40 VA: 0x180F88940 Slot: 14
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0xF89DF0 Offset: 0xF891F0 VA: 0x180F89DF0
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0xF878E0 Offset: 0xF86CE0 VA: 0x180F878E0 Slot: 15
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0xF89310 Offset: 0xF88710 VA: 0x180F89310
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0xF88640 Offset: 0xF87A40 VA: 0x180F88640 Slot: 16
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0xF89B70 Offset: 0xF88F70 VA: 0x180F89B70
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0xF88370 Offset: 0xF87770 VA: 0x180F88370 Slot: 17
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0xF89870 Offset: 0xF88C70 VA: 0x180F89870
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xF88070 Offset: 0xF87470 VA: 0x180F88070 Slot: 18
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xF89500 Offset: 0xF88900 VA: 0x180F89500
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xF8A4A0 Offset: 0xF898A0 VA: 0x180F8A4A0
	internal void ReaderReadAndAssert() { }

	// RVA: 0xF86EF0 Offset: 0xF862F0 VA: 0x180F86EF0
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xF8A250 Offset: 0xF89650 VA: 0x180F8A250
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0xF8A860 Offset: 0xF89C60 VA: 0x180F8A860
	public void Skip() { }

	// RVA: 0xF8A840 Offset: 0xF89C40 VA: 0x180F8A840
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0xF8A820 Offset: 0xF89C20 VA: 0x180F8A820
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xF8A660 Offset: 0xF89A60 VA: 0x180F8A660
	internal void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xF8A520 Offset: 0xF89920 VA: 0x180F8A520
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0xF8A980 Offset: 0xF89D80 VA: 0x180F8A980
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0xF8A990 Offset: 0xF89D90 VA: 0x180F8A990
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xF8A550 Offset: 0xF89950 VA: 0x180F8A550
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0xF8A500 Offset: 0xF89900 VA: 0x180F8A500
	private void SetFinished() { }

	// RVA: 0xF87080 Offset: 0xF86480 VA: 0x180F87080
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xF8A910 Offset: 0xF89D10 VA: 0x180F8A910 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xF86F30 Offset: 0xF86330 VA: 0x180F86F30 Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xF86ED0 Offset: 0xF862D0 VA: 0x180F86ED0 Slot: 20
	public virtual void Close() { }

	// RVA: 0xF875A0 Offset: 0xF869A0 VA: 0x180F875A0
	internal void ReadAndAssert() { }

	// RVA: 0xF87610 Offset: 0xF86A10 VA: 0x180F87610
	internal bool ReadAndMoveToContent() { }

	// RVA: 0xF87170 Offset: 0xF86570 VA: 0x180F87170
	internal bool MoveToContent() { }

	// RVA: 0xF86F60 Offset: 0xF86360 VA: 0x180F86F60
	private JsonToken GetContentToken() { }

}

public static class JsonConvert // TypeDefIndex: 5904
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38
	private static readonly JsonSerializerSettings InitialSerializerSettings; // 0x40

	// Properties
	public static Func<JsonSerializerSettings> DefaultSettings { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF85EE0 Offset: 0xF852E0 VA: 0x180F85EE0
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF85F40 Offset: 0xF85340 VA: 0x180F85F40
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	// RVA: 0xF85BE0 Offset: 0xF84FE0 VA: 0x180F85BE0
	private static void .cctor() { }

	// RVA: 0xF84E20 Offset: 0xF84220 VA: 0x180F84E20
	internal static JsonSerializerSettings GetDefaultSettings() { }

	// RVA: 0xF85980 Offset: 0xF84D80 VA: 0x180F85980
	public static string ToString(bool value) { }

	// RVA: 0xF85560 Offset: 0xF84960 VA: 0x180F85560
	public static string ToString(char value) { }

	// RVA: 0xF856B0 Offset: 0xF84AB0 VA: 0x180F856B0
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF84CC0 Offset: 0xF840C0 VA: 0x180F84CC0
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF85AE0 Offset: 0xF84EE0 VA: 0x180F85AE0
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF84BC0 Offset: 0xF83FC0 VA: 0x180F84BC0
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0xF84B50 Offset: 0xF83F50 VA: 0x180F84B50
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0xF857B0 Offset: 0xF84BB0 VA: 0x180F857B0
	public static string ToString(Decimal value) { }

	// RVA: 0xF85480 Offset: 0xF84880 VA: 0x180F85480
	public static string ToString(string value) { }

	// RVA: 0xF85890 Offset: 0xF84C90 VA: 0x180F85890
	public static string ToString(string value, char delimiter) { }

	// RVA: 0xF85A20 Offset: 0xF84E20 VA: 0x180F85A20
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xF85100 Offset: 0xF84500 VA: 0x180F85100
	public static string SerializeObject(object value) { }

	// RVA: 0xF85370 Offset: 0xF84770 VA: 0x180F85370
	public static string SerializeObject(object value, Formatting formatting) { }

	// RVA: 0xF85060 Offset: 0xF84460 VA: 0x180F85060
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xF851B0 Offset: 0xF845B0 VA: 0x180F851B0
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0xF852A0 Offset: 0xF846A0 VA: 0x180F852A0
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0xF84E80 Offset: 0xF84280 VA: 0x180F84E80
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0xF84AE0 Offset: 0xF83EE0 VA: 0x180F84AE0
	public static object DeserializeObject(string value, Type type) { }

	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E94D0 Offset: 0x5E88D0 VA: 0x1805E94D0
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-RVA: 0x5E9A50 Offset: 0x5E8E50 VA: 0x1805E9A50
	|-JsonConvert.DeserializeObject<ClientFrametimeRequest>
	|-JsonConvert.DeserializeObject<CompanionSubscription.Status>
	|-JsonConvert.DeserializeObject<Account.AccountJson>
	|-JsonConvert.DeserializeObject<BuildInfo>
	|-JsonConvert.DeserializeObject<AddResponse>
	|-JsonConvert.DeserializeObject<BaseResponse>
	|-JsonConvert.DeserializeObject<QueryResponse[]>
	|-JsonConvert.DeserializeObject<Entry[]>
	|-JsonConvert.DeserializeObject<Rank>
	|-JsonConvert.DeserializeObject<Manifest>
	|-JsonConvert.DeserializeObject<SteamInventoryCrafting.MarketPrice>
	|-JsonConvert.DeserializeObject<Skin.Manifest>
	|-JsonConvert.DeserializeObject<Dictionary<string, CameraMan.CameraState>>
	|-JsonConvert.DeserializeObject<Dictionary<string, int>>
	|-JsonConvert.DeserializeObject<Dictionary<string, string>>
	|-JsonConvert.DeserializeObject<Dictionary<ulong, Chat.MuteEntry>>
	|-JsonConvert.DeserializeObject<List<Admin.PlayerInfo>>
	|-JsonConvert.DeserializeObject<List<Admin.ServerConvarInfo>>
	|-JsonConvert.DeserializeObject<List<Admin.ServerUGCInfo>>
	|-JsonConvert.DeserializeObject<Telephone.CensoredNumbers>
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0x5E9890 Offset: 0x5E8C90 VA: 0x1805E9890
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-RVA: 0x5E9680 Offset: 0x5E8A80 VA: 0x1805E9680
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-RVA: 0x5E9720 Offset: 0x5E8B20 VA: 0x1805E9720
	|-JsonConvert.DeserializeObject<CorePropsFile>
	*/

	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E93B0 Offset: 0x5E87B0 VA: 0x1805E93B0
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-RVA: 0x5E9930 Offset: 0x5E8D30 VA: 0x1805E9930
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-RVA: 0x5E9560 Offset: 0x5E8960 VA: 0x1805E9560
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-RVA: 0x5E9790 Offset: 0x5E8B90 VA: 0x1805E9790
	|-JsonConvert.DeserializeObject<CorePropsFile>
	|
	|-RVA: 0x5E9AC0 Offset: 0x5E8EC0 VA: 0x1805E9AC0
	|-JsonConvert.DeserializeObject<object>
	*/

	// RVA: 0xF848C0 Offset: 0xF83CC0 VA: 0x180F848C0
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

}

public class JsonSerializationException : JsonException // TypeDefIndex: 5905
{	// Methods

	// RVA: 0xF860F0 Offset: 0xF854F0 VA: 0x180F860F0
	public void .ctor() { }

	// RVA: 0xF861D0 Offset: 0xF855D0 VA: 0x180F861D0
	public void .ctor(string message) { }

	// RVA: 0xF86150 Offset: 0xF85550 VA: 0x180F86150
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xF86070 Offset: 0xF85470 VA: 0x180F86070
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF8B110 Offset: 0xF8A510 VA: 0x180F8B110
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xF8B120 Offset: 0xF8A520 VA: 0x180F8B120
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xF8B030 Offset: 0xF8A430 VA: 0x180F8B030
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

public class JsonSerializer // TypeDefIndex: 5906
{	// Fields
	internal TypeNameHandling _typeNameHandling; // 0x10
	internal FormatterAssemblyStyle _typeNameAssemblyFormat; // 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
	internal MissingMemberHandling _missingMemberHandling; // 0x20
	internal ObjectCreationHandling _objectCreationHandling; // 0x24
	internal NullValueHandling _nullValueHandling; // 0x28
	internal DefaultValueHandling _defaultValueHandling; // 0x2C
	internal ConstructorHandling _constructorHandling; // 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
	internal JsonConverterCollection _converters; // 0x38
	internal IContractResolver _contractResolver; // 0x40
	internal ITraceWriter _traceWriter; // 0x48
	internal IEqualityComparer _equalityComparer; // 0x50
	internal SerializationBinder _binder; // 0x58
	internal StreamingContext _context; // 0x60
	private IReferenceResolver _referenceResolver; // 0x70
	private Nullable<Formatting> _formatting; // 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; // 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x88
	private Nullable<DateParseHandling> _dateParseHandling; // 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; // 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; // 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; // 0xA8
	private CultureInfo _culture; // 0xB0
	private Nullable<int> _maxDepth; // 0xB8
	private bool _maxDepthSet; // 0xC0
	private Nullable<bool> _checkAdditionalContent; // 0xC1
	private string _dateFormatString; // 0xC8
	private bool _dateFormatStringSet; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler<ErrorEventArgs> Error; // 0xD8

	// Properties
	public virtual IReferenceResolver ReferenceResolver { set; }
	public virtual SerializationBinder Binder { set; }
	public virtual ITraceWriter TraceWriter { get; set; }
	public virtual IEqualityComparer EqualityComparer { set; }
	public virtual TypeNameHandling TypeNameHandling { set; }
	public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { set; }
	public virtual PreserveReferencesHandling PreserveReferencesHandling { set; }
	public virtual ReferenceLoopHandling ReferenceLoopHandling { set; }
	public virtual MissingMemberHandling MissingMemberHandling { set; }
	public virtual NullValueHandling NullValueHandling { set; }
	public virtual DefaultValueHandling DefaultValueHandling { set; }
	public virtual ObjectCreationHandling ObjectCreationHandling { get; set; }
	public virtual ConstructorHandling ConstructorHandling { set; }
	public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public virtual JsonConverterCollection Converters { get; }
	public virtual IContractResolver ContractResolver { get; set; }
	public virtual StreamingContext Context { get; set; }
	public virtual Formatting Formatting { get; set; }
	public virtual bool CheckAdditionalContent { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF8DA20 Offset: 0xF8CE20 VA: 0x180F8DA20 Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF8DBD0 Offset: 0xF8CFD0 VA: 0x180F8DBD0 Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0xF8E230 Offset: 0xF8D630 VA: 0x180F8E230 Slot: 6
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xF8DC70 Offset: 0xF8D070 VA: 0x180F8DC70 Slot: 7
	public virtual void set_Binder(SerializationBinder value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 8
	public virtual ITraceWriter get_TraceWriter() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 9
	public virtual void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 10
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xF8E330 Offset: 0xF8D730 VA: 0x180F8E330 Slot: 11
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xF8E2C0 Offset: 0xF8D6C0 VA: 0x180F8E2C0 Slot: 12
	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0xF8E150 Offset: 0xF8D550 VA: 0x180F8E150 Slot: 13
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xF8E1C0 Offset: 0xF8D5C0 VA: 0x180F8E1C0 Slot: 14
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xF8E000 Offset: 0xF8D400 VA: 0x180F8E000 Slot: 15
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xF8E070 Offset: 0xF8D470 VA: 0x180F8E070 Slot: 16
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xF8DEC0 Offset: 0xF8D2C0 VA: 0x180F8DEC0 Slot: 17
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0 Slot: 18
	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xF8E0E0 Offset: 0xF8D4E0 VA: 0x180F8E0E0 Slot: 19
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xF8DD60 Offset: 0xF8D160 VA: 0x180F8DD60 Slot: 20
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780 Slot: 21
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xF8DF90 Offset: 0xF8D390 VA: 0x180F8DF90 Slot: 22
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xF8DB00 Offset: 0xF8CF00 VA: 0x180F8DB00 Slot: 23
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 24
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0xF8DDF0 Offset: 0xF8D1F0 VA: 0x180F8DDF0 Slot: 25
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xC2D5D0 Offset: 0xC2C9D0 VA: 0x180C2D5D0 Slot: 26
	public virtual StreamingContext get_Context() { }

	// RVA: 0xF8DDD0 Offset: 0xF8D1D0 VA: 0x180F8DDD0 Slot: 27
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0xF8DB90 Offset: 0xF8CF90 VA: 0x180F8DB90 Slot: 28
	public virtual Formatting get_Formatting() { }

	// RVA: 0xF8DF30 Offset: 0xF8D330 VA: 0x180F8DF30 Slot: 29
	public virtual void set_Formatting(Formatting value) { }

	// RVA: 0xF8DAC0 Offset: 0xF8CEC0 VA: 0x180F8DAC0 Slot: 30
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0xF8DD00 Offset: 0xF8D100 VA: 0x180F8DD00 Slot: 31
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xF8CAC0 Offset: 0xF8BEC0 VA: 0x180F8CAC0
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0xF8D8B0 Offset: 0xF8CCB0 VA: 0x180F8D8B0
	public void .ctor() { }

	// RVA: 0xF8C200 Offset: 0xF8B600 VA: 0x180F8C200
	public static JsonSerializer Create() { }

	// RVA: 0xF8C3A0 Offset: 0xF8B7A0 VA: 0x180F8C3A0
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xF8BF60 Offset: 0xF8B360 VA: 0x180F8BF60
	public static JsonSerializer CreateDefault() { }

	// RVA: 0xF8C1C0 Offset: 0xF8B5C0 VA: 0x180F8C1C0
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xF8B760 Offset: 0xF8AB60 VA: 0x180F8B760
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xF8CE90 Offset: 0xF8C290 VA: 0x180F8CE90
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xF8CB60 Offset: 0xF8BF60 VA: 0x180F8CB60 Slot: 32
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	// RVA: -1 Offset: -1
	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EA380 Offset: 0x5E9780 VA: 0x1805EA380
	|-JsonSerializer.Deserialize<Int32Enum>
	|-JsonSerializer.Deserialize<RegexOptions>
	|
	|-RVA: 0x5EA460 Offset: 0x5E9860 VA: 0x1805EA460
	|-JsonSerializer.Deserialize<object>
	*/

	// RVA: 0xF8C8B0 Offset: 0xF8BCB0 VA: 0x180F8C8B0
	public object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xF8C560 Offset: 0xF8B960 VA: 0x180F8C560 Slot: 33
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xF8D500 Offset: 0xF8C900 VA: 0x180F8D500
	private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	// RVA: 0xF8CEB0 Offset: 0xF8C2B0 VA: 0x180F8CEB0
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xF8D4E0 Offset: 0xF8C8E0 VA: 0x180F8D4E0
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xF8D4B0 Offset: 0xF8C8B0 VA: 0x180F8D4B0
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xF8D020 Offset: 0xF8C420 VA: 0x180F8D020 Slot: 34
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xF8CA50 Offset: 0xF8BE50 VA: 0x180F8CA50
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xF8C8D0 Offset: 0xF8BCD0 VA: 0x180F8C8D0
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xF8C990 Offset: 0xF8BD90 VA: 0x180F8C990
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0xF8CB00 Offset: 0xF8BF00 VA: 0x180F8CB00
	internal void OnError(ErrorEventArgs e) { }

}

public enum JsonToken // TypeDefIndex: 5911
{	// Fields
	public int value__; // 0x0
	public const JsonToken None = 0;
	public const JsonToken StartObject = 1;
	public const JsonToken StartArray = 2;
	public const JsonToken StartConstructor = 3;
	public const JsonToken PropertyName = 4;
	public const JsonToken Comment = 5;
	public const JsonToken Raw = 6;
	public const JsonToken Integer = 7;
	public const JsonToken Float = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
	public const JsonToken Undefined = 12;
	public const JsonToken EndObject = 13;
	public const JsonToken EndArray = 14;
	public const JsonToken EndConstructor = 15;
	public const JsonToken Date = 16;
	public const JsonToken Bytes = 17;

}

public abstract class JsonWriter : IDisposable // TypeDefIndex: 5912
{	// Fields
	private static readonly JsonWriter.State[][] StateArray; // 0x0
	internal static readonly JsonWriter.State[][] StateArrayTempate; // 0x8
	private List<JsonPosition> _stack; // 0x10
	private JsonPosition _currentPosition; // 0x18
	private JsonWriter.State _currentState; // 0x30
	private Formatting _formatting; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <CloseOutput>k__BackingField; // 0x38
	private DateFormatHandling _dateFormatHandling; // 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
	private StringEscapeHandling _stringEscapeHandling; // 0x44
	private FloatFormatHandling _floatFormatHandling; // 0x48
	private string _dateFormatString; // 0x50
	private CultureInfo _culture; // 0x58

	// Properties
	public bool CloseOutput { get; set; }
	protected internal int Top { get; }
	public WriteState WriteState { get; }
	internal string ContainerPath { get; }
	public string Path { get; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	public string DateFormatString { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0xE42E00 Offset: 0xE42200 VA: 0x180E42E00
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0xE46260 Offset: 0xE45660 VA: 0x180E46260
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_CloseOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x78BED0 Offset: 0x78B2D0 VA: 0x18078BED0
	public void set_CloseOutput(bool value) { }

	// RVA: 0xE47240 Offset: 0xE46640 VA: 0x180E47240
	protected internal int get_Top() { }

	// RVA: 0xE472A0 Offset: 0xE466A0 VA: 0x180E472A0
	public WriteState get_WriteState() { }

	// RVA: 0xE47050 Offset: 0xE46450 VA: 0x180E47050
	internal string get_ContainerPath() { }

	// RVA: 0xE47140 Offset: 0xE46540 VA: 0x180E47140
	public string get_Path() { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public Formatting get_Formatting() { }

	// RVA: 0xE47500 Offset: 0xE46900 VA: 0x180E47500
	public void set_Formatting(Formatting value) { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xE473B0 Offset: 0xE467B0 VA: 0x180E473B0
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xE47420 Offset: 0xE46820 VA: 0x180E47420
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xE47570 Offset: 0xE46970 VA: 0x180E47570
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xE47490 Offset: 0xE46890 VA: 0x180E47490
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_DateFormatString() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_DateFormatString(string value) { }

	// RVA: 0xE470E0 Offset: 0xE464E0 VA: 0x180E470E0
	public CultureInfo get_Culture() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xE47020 Offset: 0xE46420 VA: 0x180E47020
	protected void .ctor() { }

	// RVA: 0xE436E0 Offset: 0xE42AE0 VA: 0x180E436E0
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0xE43570 Offset: 0xE42970 VA: 0x180E43570
	private void Push(JsonContainerType value) { }

	// RVA: 0xE43480 Offset: 0xE42880 VA: 0x180E43480
	private JsonContainerType Pop() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	private JsonContainerType Peek() { }

	// RVA: 0xE34920 Offset: 0xE33D20 VA: 0x180E34920 Slot: 6
	public virtual void Close() { }

	// RVA: 0xE43BE0 Offset: 0xE42FE0 VA: 0x180E43BE0 Slot: 7
	public virtual void WriteStartObject() { }

	// RVA: 0xE43950 Offset: 0xE42D50 VA: 0x180E43950 Slot: 8
	public virtual void WriteEndObject() { }

	// RVA: 0xE43BC0 Offset: 0xE42FC0 VA: 0x180E43BC0 Slot: 9
	public virtual void WriteStartArray() { }

	// RVA: 0xE43930 Offset: 0xE42D30 VA: 0x180E43930 Slot: 10
	public virtual void WriteEndArray() { }

	// RVA: 0xE43BD0 Offset: 0xE42FD0 VA: 0x180E43BD0 Slot: 11
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0xE43940 Offset: 0xE42D40 VA: 0x180E43940 Slot: 12
	public virtual void WriteEndConstructor() { }

	// RVA: 0xE43320 Offset: 0xE42720 VA: 0x180E43320 Slot: 13
	public virtual void WritePropertyName(string name) { }

	// RVA: 0xE43B50 Offset: 0xE42F50 VA: 0x180E43B50 Slot: 14
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE43A50 Offset: 0xE42E50 VA: 0x180E43A50 Slot: 15
	public virtual void WriteEnd() { }

	// RVA: 0xE43E00 Offset: 0xE43200 VA: 0x180E43E00
	public void WriteToken(JsonReader reader) { }

	// RVA: 0xE44680 Offset: 0xE43A80 VA: 0x180E44680
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xE43E70 Offset: 0xE43270 VA: 0x180E43E70
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0xE43BF0 Offset: 0xE42FF0 VA: 0x180E43BF0 Slot: 16
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xE436F0 Offset: 0xE42AF0 VA: 0x180E436F0
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xE43960 Offset: 0xE42D60 VA: 0x180E43960
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0xE34920 Offset: 0xE33D20 VA: 0x180E34920
	private void AutoCompleteAll() { }

	// RVA: 0xE43240 Offset: 0xE42640 VA: 0x180E43240
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xE42810 Offset: 0xE41C10 VA: 0x180E42810
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 17
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	protected virtual void WriteIndent() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 19
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	protected virtual void WriteIndentSpace() { }

	// RVA: 0xE42BA0 Offset: 0xE41FA0 VA: 0x180E42BA0
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xE43B30 Offset: 0xE42F30 VA: 0x180E43B30 Slot: 21
	public virtual void WriteNull() { }

	// RVA: 0xE44700 Offset: 0xE43B00 VA: 0x180E44700 Slot: 22
	public virtual void WriteUndefined() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 23
	public virtual void WriteRaw(string json) { }

	// RVA: 0xE43B70 Offset: 0xE42F70 VA: 0x180E43B70 Slot: 24
	public virtual void WriteRawValue(string json) { }

	// RVA: 0xE44790 Offset: 0xE43B90 VA: 0x180E44790 Slot: 25
	public virtual void WriteValue(string value) { }

	// RVA: 0xE45940 Offset: 0xE44D40 VA: 0x180E45940 Slot: 26
	public virtual void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE45940 Offset: 0xE44D40 VA: 0x180E45940 Slot: 27
	public virtual void WriteValue(uint value) { }

	// RVA: 0xE45940 Offset: 0xE44D40 VA: 0x180E45940 Slot: 28
	public virtual void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE45940 Offset: 0xE44D40 VA: 0x180E45940 Slot: 29
	public virtual void WriteValue(ulong value) { }

	// RVA: 0xE45DC0 Offset: 0xE451C0 VA: 0x180E45DC0 Slot: 30
	public virtual void WriteValue(float value) { }

	// RVA: 0xE45DC0 Offset: 0xE451C0 VA: 0x180E45DC0 Slot: 31
	public virtual void WriteValue(double value) { }

	// RVA: 0xE45C40 Offset: 0xE45040 VA: 0x180E45C40 Slot: 32
	public virtual void WriteValue(bool value) { }

	// RVA: 0xE45940 Offset: 0xE44D40 VA: 0x180E45940 Slot: 33
	public virtual void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE45940 Offset: 0xE44D40 VA: 0x180E45940 Slot: 34
	public virtual void WriteValue(ushort value) { }

	// RVA: 0xE44790 Offset: 0xE43B90 VA: 0x180E44790 Slot: 35
	public virtual void WriteValue(char value) { }

	// RVA: 0xE45940 Offset: 0xE44D40 VA: 0x180E45940 Slot: 36
	public virtual void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE45940 Offset: 0xE44D40 VA: 0x180E45940 Slot: 37
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0xE45DC0 Offset: 0xE451C0 VA: 0x180E45DC0 Slot: 38
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0xE45DA0 Offset: 0xE451A0 VA: 0x180E45DA0 Slot: 39
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0xE45DA0 Offset: 0xE451A0 VA: 0x180E45DA0 Slot: 40
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE44790 Offset: 0xE43B90 VA: 0x180E44790 Slot: 41
	public virtual void WriteValue(Guid value) { }

	// RVA: 0xE44790 Offset: 0xE43B90 VA: 0x180E44790 Slot: 42
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0xE45AE0 Offset: 0xE44EE0 VA: 0x180E45AE0 Slot: 43
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE461F0 Offset: 0xE455F0 VA: 0x180E461F0 Slot: 44
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0xE46090 Offset: 0xE45490 VA: 0x180E46090 Slot: 45
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE44720 Offset: 0xE43B20 VA: 0x180E44720 Slot: 46
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0xE46100 Offset: 0xE45500 VA: 0x180E46100 Slot: 47
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0xE459D0 Offset: 0xE44DD0 VA: 0x180E459D0 Slot: 48
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0xE45EC0 Offset: 0xE452C0 VA: 0x180E45EC0 Slot: 49
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0xE45DE0 Offset: 0xE451E0 VA: 0x180E45DE0 Slot: 50
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE45B50 Offset: 0xE44F50 VA: 0x180E45B50 Slot: 51
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0xE45E50 Offset: 0xE45250 VA: 0x180E45E50 Slot: 52
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0xE45C60 Offset: 0xE45060 VA: 0x180E45C60 Slot: 53
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE45960 Offset: 0xE44D60 VA: 0x180E45960 Slot: 54
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0xE45BC0 Offset: 0xE44FC0 VA: 0x180E45BC0 Slot: 55
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0xE46020 Offset: 0xE45420 VA: 0x180E46020 Slot: 56
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0xE46170 Offset: 0xE45570 VA: 0x180E46170 Slot: 57
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0xE45F30 Offset: 0xE45330 VA: 0x180E45F30 Slot: 58
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0xE45FB0 Offset: 0xE453B0 VA: 0x180E45FB0 Slot: 59
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0xE447B0 Offset: 0xE43BB0 VA: 0x180E447B0 Slot: 60
	public virtual void WriteValue(byte[] value) { }

	// RVA: 0xE45A40 Offset: 0xE44E40 VA: 0x180E45A40 Slot: 61
	public virtual void WriteValue(Uri value) { }

	// RVA: 0xE45CD0 Offset: 0xE450D0 VA: 0x180E45CD0 Slot: 62
	public virtual void WriteValue(object value) { }

	// RVA: 0xE43300 Offset: 0xE42700 VA: 0x180E43300 Slot: 63
	public virtual void WriteComment(string text) { }

	// RVA: 0xE43670 Offset: 0xE42A70 VA: 0x180E43670 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE43210 Offset: 0xE42610 VA: 0x180E43210 Slot: 64
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xE447E0 Offset: 0xE43BE0 VA: 0x180E447E0
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xE43160 Offset: 0xE42560 VA: 0x180E43160
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xE43310 Offset: 0xE42710 VA: 0x180E43310
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xE43320 Offset: 0xE42720 VA: 0x180E43320
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void InternalWriteRaw() { }

	// RVA: 0xE43350 Offset: 0xE42750 VA: 0x180E43350
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xE43460 Offset: 0xE42860 VA: 0x180E43460
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0xE43300 Offset: 0xE42700 VA: 0x180E43300
	internal void InternalWriteComment() { }

}

internal enum JsonWriter.State // TypeDefIndex: 5913
{	// Fields
	public int value__; // 0x0
	public const JsonWriter.State Start = 0;
	public const JsonWriter.State Property = 1;
	public const JsonWriter.State ObjectStart = 2;
	public const JsonWriter.State Object = 3;
	public const JsonWriter.State ArrayStart = 4;
	public const JsonWriter.State Array = 5;
	public const JsonWriter.State ConstructorStart = 6;
	public const JsonWriter.State Constructor = 7;
	public const JsonWriter.State Closed = 8;
	public const JsonWriter.State Error = 9;

}

internal static class JsonTokenUtils // TypeDefIndex: 5918
{	// Methods

	// RVA: 0x1803B30 Offset: 0x1802F30 VA: 0x181803B30
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0x1803BA0 Offset: 0x1802FA0 VA: 0x181803BA0
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0x1803B50 Offset: 0x1802F50 VA: 0x181803B50
	internal static bool IsPrimitiveToken(JsonToken token) { }

}

public class JsonContainerContract : JsonContract // TypeDefIndex: 5977
{	// Fields
	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	// Properties
	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }

	// Methods

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	internal JsonContract get_ItemContract() { }

	// RVA: 0x13EC610 Offset: 0x13EBA10 VA: 0x1813EC610
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	internal JsonContract get_FinalItemContract() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC5E0 Offset: 0x13EB9E0 VA: 0x1813EC5E0
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC670 Offset: 0x13EBA70 VA: 0x1813EC670
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC5F0 Offset: 0x13EB9F0 VA: 0x1813EC5F0
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC680 Offset: 0x13EBA80 VA: 0x1813EC680
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC600 Offset: 0x13EBA00 VA: 0x1813EC600
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC690 Offset: 0x13EBA90 VA: 0x1813EC690
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	// RVA: 0x13EC4E0 Offset: 0x13EB8E0 VA: 0x1813EC4E0
	internal void .ctor(Type underlyingType) { }

}

internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5980
{	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Properties
	public override int Depth { get; }
	public override string Path { get; }
	public override JsonToken TokenType { get; }
	public override object Value { get; }
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x180DFA0 Offset: 0x180D3A0 VA: 0x18180DFA0
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x180DA10 Offset: 0x180CE10 VA: 0x18180DA10
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x180DF30 Offset: 0x180D330 VA: 0x18180DF30 Slot: 10
	public override bool Read() { }

	// RVA: 0x180DE50 Offset: 0x180D250 VA: 0x18180DE50 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x180DEC0 Offset: 0x180D2C0 VA: 0x18180DEC0 Slot: 12
	public override string ReadAsString() { }

	// RVA: 0x180DBD0 Offset: 0x180CFD0 VA: 0x18180DBD0 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0x180DD50 Offset: 0x180D150 VA: 0x18180DD50 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x180DDD0 Offset: 0x180D1D0 VA: 0x18180DDD0 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x180DB60 Offset: 0x180CF60 VA: 0x18180DB60 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x180DCD0 Offset: 0x180D0D0 VA: 0x18180DCD0 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x180DC40 Offset: 0x180D040 VA: 0x18180DC40 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x180E0F0 Offset: 0x180D4F0 VA: 0x18180E0F0 Slot: 8
	public override int get_Depth() { }

	// RVA: 0x180E120 Offset: 0x180D520 VA: 0x18180E120 Slot: 9
	public override string get_Path() { }

	// RVA: 0x180E150 Offset: 0x180D550 VA: 0x18180E150 Slot: 5
	public override JsonToken get_TokenType() { }

	// RVA: 0x180E1B0 Offset: 0x180D5B0 VA: 0x18180E1B0 Slot: 6
	public override object get_Value() { }

	// RVA: 0x180E180 Offset: 0x180D580 VA: 0x18180E180 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x180D9E0 Offset: 0x180CDE0 VA: 0x18180D9E0 Slot: 20
	public override void Close() { }

	// RVA: 0x180DA40 Offset: 0x180CE40 VA: 0x18180DA40 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x180DAA0 Offset: 0x180CEA0 VA: 0x18180DAA0 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x180DB00 Offset: 0x180CF00 VA: 0x18180DB00 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

}

internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 5981
{	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x180F120 Offset: 0x180E520 VA: 0x18180F120
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x180E230 Offset: 0x180D630 VA: 0x18180E230
	public string GetSerializedJsonMessage() { }

	// RVA: 0x180ED70 Offset: 0x180E170 VA: 0x18180ED70 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x180E960 Offset: 0x180DD60 VA: 0x18180E960 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x180EED0 Offset: 0x180E2D0 VA: 0x18180EED0 Slot: 36
	public override void WriteValue(byte value) { }

	// RVA: 0x180ED00 Offset: 0x180E100 VA: 0x18180ED00 Slot: 53
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x180E810 Offset: 0x180DC10 VA: 0x18180E810 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x180E740 Offset: 0x180DB40 VA: 0x18180E740 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x180EFB0 Offset: 0x180E3B0 VA: 0x18180EFB0 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x180F020 Offset: 0x180E420 VA: 0x18180F020 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x180EB40 Offset: 0x180DF40 VA: 0x18180EB40 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x180E6F0 Offset: 0x180DAF0 VA: 0x18180E6F0 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0x180E3C0 Offset: 0x180D7C0 VA: 0x18180E3C0 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x180EF40 Offset: 0x180E340 VA: 0x18180EF40 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x180EA40 Offset: 0x180DE40 VA: 0x18180EA40 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x180E7B0 Offset: 0x180DBB0 VA: 0x18180E7B0 Slot: 26
	public override void WriteValue(int value) { }

	// RVA: 0x180E880 Offset: 0x180DC80 VA: 0x18180E880 Slot: 28
	public override void WriteValue(long value) { }

	// RVA: 0x180E9D0 Offset: 0x180DDD0 VA: 0x18180E9D0 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x180EE00 Offset: 0x180E200 VA: 0x18180EE00 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x180EAD0 Offset: 0x180DED0 VA: 0x18180EAD0 Slot: 33
	public override void WriteValue(short value) { }

	// RVA: 0x180EC20 Offset: 0x180E020 VA: 0x18180EC20 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x180F0B0 Offset: 0x180E4B0 VA: 0x18180F0B0 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x180EE70 Offset: 0x180E270 VA: 0x18180EE70 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x180E8F0 Offset: 0x180DCF0 VA: 0x18180E8F0 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x180EBB0 Offset: 0x180DFB0 VA: 0x18180EBB0 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0x180EC90 Offset: 0x180E090 VA: 0x18180EC90 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x180E260 Offset: 0x180D660 VA: 0x18180E260 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x180E5E0 Offset: 0x180D9E0 VA: 0x18180E5E0 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0x180E2D0 Offset: 0x180D6D0 VA: 0x18180E2D0 Slot: 10
	public override void WriteEndArray() { }

	// RVA: 0x180E630 Offset: 0x180DA30 VA: 0x18180E630 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x180E320 Offset: 0x180D720 VA: 0x18180E320 Slot: 12
	public override void WriteEndConstructor() { }

	// RVA: 0x180E490 Offset: 0x180D890 VA: 0x18180E490 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x180E410 Offset: 0x180D810 VA: 0x18180E410 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x180E6A0 Offset: 0x180DAA0 VA: 0x18180E6A0 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0x180E370 Offset: 0x180D770 VA: 0x18180E370 Slot: 8
	public override void WriteEndObject() { }

	// RVA: 0x180E500 Offset: 0x180D900 VA: 0x18180E500 Slot: 24
	public override void WriteRawValue(string json) { }

	// RVA: 0x180E570 Offset: 0x180D970 VA: 0x18180E570 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0x180E1E0 Offset: 0x180D5E0 VA: 0x18180E1E0 Slot: 6
	public override void Close() { }

}

internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 5982
{	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x13EE650 Offset: 0x13EDA50 VA: 0x1813EE650
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: -1 Offset: -1
	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E9BB0 Offset: 0x5E8FB0 VA: 0x1805E9BB0
	|-JsonFormatterConverter.GetTokenValue<bool>
	|
	|-RVA: 0x5E9D40 Offset: 0x5E9140 VA: 0x1805E9D40
	|-JsonFormatterConverter.GetTokenValue<int>
	|
	|-RVA: 0x5E9ED0 Offset: 0x5E92D0 VA: 0x1805E9ED0
	|-JsonFormatterConverter.GetTokenValue<long>
	|
	|-RVA: 0x5EA060 Offset: 0x5E9460 VA: 0x1805EA060
	|-JsonFormatterConverter.GetTokenValue<object>
	|-JsonFormatterConverter.GetTokenValue<string>
	|
	|-RVA: 0x5EA1F0 Offset: 0x5E95F0 VA: 0x1805EA1F0
	|-JsonFormatterConverter.GetTokenValue<float>
	*/

	// RVA: 0x13EE260 Offset: 0x13ED660 VA: 0x1813EE260 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x13EE4C0 Offset: 0x13ED8C0 VA: 0x1813EE4C0 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x13EE510 Offset: 0x13ED910 VA: 0x1813EE510 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x13EE560 Offset: 0x13ED960 VA: 0x1813EE560 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x13EE5B0 Offset: 0x13ED9B0 VA: 0x1813EE5B0 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x13EE600 Offset: 0x13EDA00 VA: 0x1813EE600 Slot: 9
	public string ToString(object value) { }

}

public class JsonLinqContract : JsonContract // TypeDefIndex: 5984
{	// Methods

	// RVA: 0x13EE720 Offset: 0x13EDB20 VA: 0x1813EE720
	public void .ctor(Type underlyingType) { }

}

public class JsonPrimitiveContract : JsonContract // TypeDefIndex: 5985
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x90
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; // 0x0

	// Properties
	internal PrimitiveTypeCode TypeCode { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD22840 Offset: 0xD21C40 VA: 0x180D22840
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD227B0 Offset: 0xD21BB0 VA: 0x180D227B0
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x13EF040 Offset: 0x13EE440 VA: 0x1813EF040
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13EEE00 Offset: 0x13EE200 VA: 0x1813EEE00
	private static void .cctor() { }

}

public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 6005
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Type <CollectionItemType>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsMultidimensionalArray>k__BackingField; // 0xC8
	private readonly Type _genericCollectionDefinitionType; // 0xD0
	private Type _genericWrapperType; // 0xD8
	private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
	private Func<object> _genericTemporaryCollectionCreator; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsArray>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ShouldCreateWrapper>k__BackingField; // 0xF1
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <CanDeserialize>k__BackingField; // 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
	private ObjectConstructor<object> _parameterizedCreator; // 0x100
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <HasParameterizedCreator>k__BackingField; // 0x110

	// Properties
	public Type CollectionItemType { get; set; }
	public bool IsMultidimensionalArray { get; set; }
	internal bool IsArray { get; set; }
	internal bool ShouldCreateWrapper { get; set; }
	internal bool CanDeserialize { get; set; }
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104A060 Offset: 0x1049460 VA: 0x18104A060
	public Type get_CollectionItemType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEF5DD0 Offset: 0xEF51D0 VA: 0x180EF5DD0
	private void set_CollectionItemType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC3A0 Offset: 0x13EB7A0 VA: 0x1813EC3A0
	public bool get_IsMultidimensionalArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC490 Offset: 0x13EB890 VA: 0x1813EC490
	private void set_IsMultidimensionalArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B0B0 Offset: 0xD9A4B0 VA: 0x180D9B0B0
	internal bool get_IsArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B490 Offset: 0xD9A890 VA: 0x180D9B490
	private void set_IsArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC460 Offset: 0x13EB860 VA: 0x1813EC460
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC4D0 Offset: 0x13EB8D0 VA: 0x1813EC4D0
	private void set_ShouldCreateWrapper(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC350 Offset: 0x13EB750 VA: 0x1813EC350
	internal bool get_CanDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC470 Offset: 0x13EB870 VA: 0x1813EC470
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x13EC3B0 Offset: 0x13EB7B0 VA: 0x1813EC3B0
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0xC62850 Offset: 0xC61C50 VA: 0x180C62850
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x13EC4A0 Offset: 0x13EB8A0 VA: 0x1813EC4A0
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC390 Offset: 0x13EB790 VA: 0x1813EC390
	public bool get_HasParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EC480 Offset: 0x13EB880 VA: 0x1813EC480
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x13EC360 Offset: 0x13EB760 VA: 0x1813EC360
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0x13EB800 Offset: 0x13EAC00 VA: 0x1813EB800
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13EB390 Offset: 0x13EA790 VA: 0x1813EB390
	internal IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0x13EB170 Offset: 0x13EA570 VA: 0x1813EB170
	internal IList CreateTemporaryCollection() { }

}

internal enum JsonContractType // TypeDefIndex: 6006
{	// Fields
	public int value__; // 0x0
	public const JsonContractType None = 0;
	public const JsonContractType Object = 1;
	public const JsonContractType Array = 2;
	public const JsonContractType Primitive = 3;
	public const JsonContractType String = 4;
	public const JsonContractType Dictionary = 5;
	public const JsonContractType Dynamic = 6;
	public const JsonContractType Serializable = 7;
	public const JsonContractType Linq = 8;

}

public abstract class JsonContract // TypeDefIndex: 6011
{	// Fields
	internal bool IsNullable; // 0x10
	internal bool IsConvertable; // 0x11
	internal bool IsEnum; // 0x12
	internal Type NonNullableUnderlyingType; // 0x18
	internal ReadType InternalReadType; // 0x20
	internal JsonContractType ContractType; // 0x24
	internal bool IsReadOnlyOrFixedSize; // 0x28
	internal bool IsSealed; // 0x29
	internal bool IsInstantiable; // 0x2A
	private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
	private IList<SerializationCallback> _onDeserializingCallbacks; // 0x38
	private IList<SerializationCallback> _onSerializedCallbacks; // 0x40
	private IList<SerializationCallback> _onSerializingCallbacks; // 0x48
	private IList<SerializationErrorCallback> _onErrorCallbacks; // 0x50
	private Type _createdType; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Type <UnderlyingType>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<bool> <IsReference>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JsonConverter <Converter>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JsonConverter <InternalConverter>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Func<object> <DefaultCreator>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

	// Properties
	public Type UnderlyingType { get; set; }
	public Type CreatedType { get; set; }
	public Nullable<bool> IsReference { get; set; }
	public JsonConverter Converter { get; set; }
	internal JsonConverter InternalConverter { get; set; }
	public IList<SerializationCallback> OnDeserializedCallbacks { get; }
	public IList<SerializationCallback> OnDeserializingCallbacks { get; }
	public IList<SerializationCallback> OnSerializedCallbacks { get; }
	public IList<SerializationCallback> OnSerializingCallbacks { get; }
	public IList<SerializationErrorCallback> OnErrorCallbacks { get; }
	public Func<object> DefaultCreator { get; set; }
	public bool DefaultCreatorNonPublic { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public Type get_UnderlyingType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	private void set_UnderlyingType(Type value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public Type get_CreatedType() { }

	// RVA: 0x13ED370 Offset: 0x13EC770 VA: 0x1813ED370
	public void set_CreatedType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13ED130 Offset: 0x13EC530 VA: 0x1813ED130
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13ED3E0 Offset: 0x13EC7E0 VA: 0x1813ED3E0
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	internal JsonConverter get_InternalConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0x13ED140 Offset: 0x13EC540 VA: 0x1813ED140
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x13ED1B0 Offset: 0x13EC5B0 VA: 0x1813ED1B0
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x13ED290 Offset: 0x13EC690 VA: 0x1813ED290
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x13ED300 Offset: 0x13EC700 VA: 0x1813ED300
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x13ED220 Offset: 0x13EC620 VA: 0x1813ED220
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public Func<object> get_DefaultCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC20 Offset: 0x69C020 VA: 0x18069CC20
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC30 Offset: 0x69C030 VA: 0x18069CC30
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x13ECFC0 Offset: 0x13EC3C0 VA: 0x1813ECFC0
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x13ECE10 Offset: 0x13EC210 VA: 0x1813ECE10
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x13ECC60 Offset: 0x13EC060 VA: 0x1813ECC60
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x13EC8F0 Offset: 0x13EBCF0 VA: 0x1813EC8F0
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x13EC7C0 Offset: 0x13EBBC0 VA: 0x1813EC7C0
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x13ECAA0 Offset: 0x13EBEA0 VA: 0x1813ECAA0
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x13EC6A0 Offset: 0x13EBAA0 VA: 0x1813EC6A0
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x13EC730 Offset: 0x13EBB30 VA: 0x1813EC730
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

}

private sealed class JsonContract.<>c__DisplayClass73_0 // TypeDefIndex: 6012
{	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14039A0 Offset: 0x1402DA0 VA: 0x1814039A0
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

private sealed class JsonContract.<>c__DisplayClass74_0 // TypeDefIndex: 6013
{	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1403A90 Offset: 0x1402E90 VA: 0x181403A90
	internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

}

public class JsonProperty // TypeDefIndex: 6015
{	// Fields
	internal Nullable<Required> _required; // 0x10
	internal bool _hasExplicitDefaultValue; // 0x18
	private object _defaultValue; // 0x20
	private bool _hasGeneratedDefaultValue; // 0x28
	private string _propertyName; // 0x30
	internal bool _skipPropertyNameEscape; // 0x38
	private Type _propertyType; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JsonContract <PropertyContract>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Type <DeclaringType>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<int> <Order>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <UnderlyingName>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IValueProvider <ValueProvider>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JsonConverter <Converter>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JsonConverter <MemberConverter>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Ignored>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Readable>k__BackingField; // 0x89
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Writable>k__BackingField; // 0x8A
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <HasMemberAttribute>k__BackingField; // 0x8B
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<bool> <IsReference>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<object, object> <SetIsSpecified>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JsonConverter <ItemConverter>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xEC

	// Properties
	internal JsonContract PropertyContract { get; set; }
	public string PropertyName { get; set; }
	public Type DeclaringType { get; set; }
	public Nullable<int> Order { get; set; }
	public string UnderlyingName { get; set; }
	public IValueProvider ValueProvider { get; set; }
	public IAttributeProvider AttributeProvider { set; }
	public Type PropertyType { get; set; }
	public JsonConverter Converter { get; set; }
	public JsonConverter MemberConverter { get; set; }
	public bool Ignored { get; set; }
	public bool Readable { get; set; }
	public bool Writable { get; set; }
	public bool HasMemberAttribute { get; set; }
	public object DefaultValue { get; set; }
	public Required Required { get; }
	public Nullable<bool> IsReference { get; set; }
	public Nullable<NullValueHandling> NullValueHandling { get; set; }
	public Nullable<DefaultValueHandling> DefaultValueHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling { get; set; }
	public Nullable<ObjectCreationHandling> ObjectCreationHandling { get; set; }
	public Nullable<TypeNameHandling> TypeNameHandling { get; set; }
	public Predicate<object> ShouldSerialize { get; set; }
	public Predicate<object> ShouldDeserialize { get; }
	public Predicate<object> GetIsSpecified { get; set; }
	public Action<object, object> SetIsSpecified { get; set; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal JsonContract get_PropertyContract() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_PropertyName() { }

	// RVA: 0x13EF9A0 Offset: 0x13EEDA0 VA: 0x1813EF9A0
	public void set_PropertyName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public Type get_DeclaringType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_DeclaringType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public Nullable<int> get_Order() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8BB0 Offset: 0x8C7FB0 VA: 0x1808C8BB0
	public void set_Order(Nullable<int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public string get_UnderlyingName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_UnderlyingName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public IValueProvider get_ValueProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Type get_PropertyType() { }

	// RVA: 0x13EFA40 Offset: 0x13EEE40 VA: 0x1813EFA40
	public void set_PropertyType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public JsonConverter get_MemberConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	public void set_MemberConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC20 Offset: 0x69C020 VA: 0x18069CC20
	public bool get_Ignored() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC30 Offset: 0x69C030 VA: 0x18069CC30
	public void set_Ignored(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xED4B60 Offset: 0xED3F60 VA: 0x180ED4B60
	public bool get_Readable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xED5200 Offset: 0xED4600 VA: 0x180ED5200
	public void set_Readable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF900 Offset: 0x13EED00 VA: 0x1813EF900
	public bool get_Writable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EFA90 Offset: 0x13EEE90 VA: 0x1813EFA90
	public void set_Writable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF870 Offset: 0x13EEC70 VA: 0x1813EF870
	public bool get_HasMemberAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF930 Offset: 0x13EED30 VA: 0x1813EF930
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x13EF860 Offset: 0x13EEC60 VA: 0x1813EF860
	public object get_DefaultValue() { }

	// RVA: 0x13EF920 Offset: 0x13EED20 VA: 0x1813EF920
	public void set_DefaultValue(object value) { }

	// RVA: 0x13EF770 Offset: 0x13EEB70 VA: 0x1813EF770
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x13EF8C0 Offset: 0x13EECC0 VA: 0x1813EF8C0
	public Required get_Required() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF880 Offset: 0x13EEC80 VA: 0x1813EF880
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF940 Offset: 0x13EED40 VA: 0x1813EF940
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF980 Offset: 0x13EED80 VA: 0x1813EF980
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF910 Offset: 0x13EED10 VA: 0x1813EF910
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EFA70 Offset: 0x13EEE70 VA: 0x1813EFA70
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF990 Offset: 0x13EED90 VA: 0x1813EF990
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EFA80 Offset: 0x13EEE80 VA: 0x1813EFA80
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104A060 Offset: 0x1049460 VA: 0x18104A060
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B480 Offset: 0xD9A880 VA: 0x180D9B480
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53280 Offset: 0xC52680 VA: 0x180C53280
	public void set_SetIsSpecified(Action<object, object> value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 3
	public override string ToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9A430 Offset: 0xD99830 VA: 0x180D9A430
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD300D0 Offset: 0xD2F4D0 VA: 0x180D300D0
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF890 Offset: 0x13EEC90 VA: 0x1813EF890
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF950 Offset: 0x13EED50 VA: 0x1813EF950
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF8B0 Offset: 0x13EECB0 VA: 0x1813EF8B0
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF970 Offset: 0x13EED70 VA: 0x1813EF970
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF8A0 Offset: 0x13EECA0 VA: 0x1813EF8A0
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EF960 Offset: 0x13EED60 VA: 0x1813EF960
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	// RVA: 0x13EF810 Offset: 0x13EEC10 VA: 0x1813EF810
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 6016
{	// Fields
	private readonly Type _type; // 0x38
	private readonly List<JsonProperty> _list; // 0x40

	// Methods

	// RVA: 0x13EF630 Offset: 0x13EEA30 VA: 0x1813EF630
	public void .ctor(Type type) { }

	// RVA: 0x13EF390 Offset: 0x13EE790 VA: 0x1813EF390 Slot: 38
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x13EF130 Offset: 0x13EE530 VA: 0x1813EF130
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x13EF350 Offset: 0x13EE750 VA: 0x1813EF350
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x13EF550 Offset: 0x13EE950 VA: 0x1813EF550
	private bool TryGetValue(string key, out JsonProperty item) { }

	// RVA: 0x13EF3B0 Offset: 0x13EE7B0 VA: 0x1813EF3B0
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 6018
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MemberSerialization <MemberSerialization>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<Required> <ItemRequired>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JsonPropertyCollection <Properties>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xE0
	internal bool ExtensionDataIsJToken; // 0xE8
	private Nullable<bool> _hasRequiredOrDefaultValueProperties; // 0xE9
	private ConstructorInfo _parametrizedConstructor; // 0xF0
	private ConstructorInfo _overrideConstructor; // 0xF8
	private ObjectConstructor<object> _overrideCreator; // 0x100
	private ObjectConstructor<object> _parameterizedCreator; // 0x108
	private JsonPropertyCollection _creatorParameters; // 0x110
	private Type _extensionDataValueType; // 0x118

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public Nullable<Required> ItemRequired { get; set; }
	public JsonPropertyCollection Properties { get; set; }
	public JsonPropertyCollection CreatorParameters { get; }
	[ObsoleteAttribute] // RVA: 0x8E040 Offset: 0x8D440 VA: 0x18008E040
	public ConstructorInfo OverrideConstructor { set; }
	[ObsoleteAttribute] // RVA: 0x8E0C0 Offset: 0x8D4C0 VA: 0x18008E0C0
	public ConstructorInfo ParametrizedConstructor { set; }
	public ObjectConstructor<object> OverrideCreator { get; }
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	public ExtensionDataSetter ExtensionDataSetter { get; set; }
	public ExtensionDataGetter ExtensionDataGetter { get; set; }
	public Type ExtensionDataValueType { set; }
	internal bool HasRequiredOrDefaultValueProperties { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074CF0 Offset: 0x10740F0 VA: 0x181074CF0
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E60 Offset: 0x1074260 VA: 0x181074E60
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EEBC0 Offset: 0x13EDFC0 VA: 0x1813EEBC0
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13EEC90 Offset: 0x13EE090 VA: 0x1813EEC90
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	public JsonPropertyCollection get_Properties() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53280 Offset: 0xC52680 VA: 0x180C53280
	private void set_Properties(JsonPropertyCollection value) { }

	// RVA: 0x13EE8D0 Offset: 0x13EDCD0 VA: 0x1813EE8D0
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x13EECA0 Offset: 0x13EE0A0 VA: 0x1813EECA0
	public void set_OverrideConstructor(ConstructorInfo value) { }

	// RVA: 0x13EED50 Offset: 0x13EE150 VA: 0x1813EED50
	public void set_ParametrizedConstructor(ConstructorInfo value) { }

	// RVA: 0xA09500 Offset: 0xA08900 VA: 0x180A09500
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0xC62850 Offset: 0xC61C50 VA: 0x180C62850
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9A430 Offset: 0xD99830 VA: 0x180D9A430
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD300D0 Offset: 0xD2F4D0 VA: 0x180D300D0
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD50 Offset: 0x4EB150 VA: 0x1804EBD50
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x13EEBD0 Offset: 0x13EDFD0 VA: 0x1813EEBD0
	public void set_ExtensionDataValueType(Type value) { }

	// RVA: 0x13EE950 Offset: 0x13EDD50 VA: 0x1813EE950
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0x13EE840 Offset: 0x13EDC40 VA: 0x1813EE840
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13EE740 Offset: 0x13EDB40 VA: 0x1813EE740
	internal object GetUninitializedObject() { }

}

internal abstract class JsonSerializerInternalBase // TypeDefIndex: 6019
{	// Fields
	private ErrorContext _currentErrorContext; // 0x10
	private BidirectionalDictionary<string, object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	internal readonly ITraceWriter TraceWriter; // 0x28
	protected JsonSerializerProxy InternalSerializer; // 0x30

	// Properties
	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }

	// Methods

	// RVA: 0x13EFFF0 Offset: 0x13EF3F0 VA: 0x1813EFFF0
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x13F0080 Offset: 0x13EF480 VA: 0x1813F0080
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x13EFB20 Offset: 0x13EEF20 VA: 0x1813EFB20
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x13EFAA0 Offset: 0x13EEEA0 VA: 0x1813EFAA0
	protected void ClearErrorContext() { }

	// RVA: 0x13EFC40 Offset: 0x13EF040 VA: 0x1813EFC40
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

}

private class JsonSerializerInternalBase.ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 6020
{	// Methods

	// RVA: 0x13CA350 Offset: 0x13C9750 VA: 0x1813CA350 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0x1402CE0 Offset: 0x14020E0 VA: 0x181402CE0 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 6021
{	// Methods

	// RVA: 0x13EFFF0 Offset: 0x13EF3F0 VA: 0x1813EFFF0
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x13F9720 Offset: 0x13F8B20 VA: 0x1813F9720
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x13F67F0 Offset: 0x13F5BF0 VA: 0x1813F67F0
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x13F5A20 Offset: 0x13F4E20 VA: 0x1813F5A20
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x13F69D0 Offset: 0x13F5DD0 VA: 0x1813F69D0
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0x13F1420 Offset: 0x13F0820 VA: 0x1813F1420
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x13F11C0 Offset: 0x13F05C0 VA: 0x1813F11C0
	private JToken CreateJObject(JsonReader reader) { }

	// RVA: 0x13F5270 Offset: 0x13F4670 VA: 0x1813F5270
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0x13F08C0 Offset: 0x13EFCC0 VA: 0x1813F08C0
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x13F6900 Offset: 0x13F5D00 VA: 0x1813F6900
	internal string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0x13F6860 Offset: 0x13F5C60 VA: 0x1813F6860
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x13F39F0 Offset: 0x13F2DF0 VA: 0x1813F39F0
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0x13F9F80 Offset: 0x13F9380 VA: 0x1813F9F80
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0x13FA5E0 Offset: 0x13F99E0 VA: 0x1813FA5E0
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0x13FB6B0 Offset: 0x13FAAB0 VA: 0x1813FB6B0
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x13F6340 Offset: 0x13F5740 VA: 0x1813F6340
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0x13F1640 Offset: 0x13F0A40 VA: 0x1813F1640
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0x13F6AE0 Offset: 0x13F5EE0 VA: 0x1813F6AE0
	private bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0x13F64E0 Offset: 0x13F58E0 VA: 0x1813F64E0
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x13FBD60 Offset: 0x13FB160 VA: 0x1813FBD60
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0x13F0380 Offset: 0x13EF780 VA: 0x1813F0380
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue) { }

	// RVA: 0x13F0150 Offset: 0x13EF550 VA: 0x1813F0150
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xF96E90 Offset: 0xF96290 VA: 0x180F96E90
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x13FC5D0 Offset: 0x13FB9D0 VA: 0x1813FC5D0
	private bool ShouldSetPropertyValue(JsonProperty property, object value) { }

	// RVA: 0x13F2130 Offset: 0x13F1530 VA: 0x1813F2130
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13F1EA0 Offset: 0x13F12A0 VA: 0x1813F1EA0
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13F6D00 Offset: 0x13F6100 VA: 0x1813F6D00
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x13F6B70 Offset: 0x13F5F70 VA: 0x1813F6B70
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x13F6E90 Offset: 0x13F6290 VA: 0x1813F6E90
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13F8120 Offset: 0x13F7520 VA: 0x1813F8120
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13FC700 Offset: 0x13FBB00 VA: 0x1813FC700
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x13F7A00 Offset: 0x13F6E00 VA: 0x1813F7A00
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13F0B60 Offset: 0x13EFF60 VA: 0x1813F0B60
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x13F09B0 Offset: 0x13EFDB0 VA: 0x1813F09B0
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x13F26C0 Offset: 0x13F1AC0 VA: 0x1813F26C0
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x13F5720 Offset: 0x13F4B20 VA: 0x1813F5720
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x13FAC00 Offset: 0x13FA000 VA: 0x1813FAC00
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x13F9D40 Offset: 0x13F9140 VA: 0x1813F9D40
	private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter) { }

	// RVA: 0x13F2460 Offset: 0x13F1860 VA: 0x1813F2460
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13F89B0 Offset: 0x13F7DB0 VA: 0x1813F89B0
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x13FC420 Offset: 0x13FB820 VA: 0x1813FC420
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x13F07D0 Offset: 0x13EFBD0 VA: 0x1813F07D0
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x13FBAF0 Offset: 0x13FAEF0 VA: 0x1813FBAF0
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x13F9C80 Offset: 0x13F9080 VA: 0x1813F9C80
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x13F5F00 Offset: 0x13F5300 VA: 0x1813F5F00
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x13FBC40 Offset: 0x13FB040 VA: 0x1813FBC40
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x13F6A50 Offset: 0x13F5E50 VA: 0x1813F6A50
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }

}

internal enum JsonSerializerInternalReader.PropertyPresence // TypeDefIndex: 6022
{	// Fields
	public int value__; // 0x0
	public const JsonSerializerInternalReader.PropertyPresence None = 0;
	public const JsonSerializerInternalReader.PropertyPresence Null = 1;
	public const JsonSerializerInternalReader.PropertyPresence Value = 2;

}

internal class JsonSerializerInternalReader.CreatorPropertyContext // TypeDefIndex: 6023
{	// Fields
	public string Name; // 0x10
	public JsonProperty Property; // 0x18
	public JsonProperty ConstructorProperty; // 0x20
	public Nullable<JsonSerializerInternalReader.PropertyPresence> Presence; // 0x28
	public object Value; // 0x30
	public bool Used; // 0x38

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class JsonSerializerInternalReader.<>c__DisplayClass36_0 // TypeDefIndex: 6024
{	// Fields
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1403850 Offset: 0x1402C50 VA: 0x181403850
	internal bool <CreateObjectUsingCreatorWithParameters>b__1(JsonSerializerInternalReader.CreatorPropertyContext p) { }

}

private sealed class JsonSerializerInternalReader.<>c // TypeDefIndex: 6025
{	// Fields
	public static readonly JsonSerializerInternalReader.<>c <>9; // 0x0
	public static Func<JsonProperty, string> <>9__36_0; // 0x8
	public static Func<JsonProperty, string> <>9__36_2; // 0x10
	public static Func<JsonProperty, JsonProperty> <>9__41_0; // 0x18
	public static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> <>9__41_1; // 0x20

	// Methods

	// RVA: 0x1403BF0 Offset: 0x1402FF0 VA: 0x181403BF0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13EF390 Offset: 0x13EE790 VA: 0x1813EF390
	internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p) { }

	// RVA: 0x13EF390 Offset: 0x13EE790 VA: 0x1813EF390
	internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal JsonProperty <PopulateObject>b__41_0(JsonProperty m) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__41_1(JsonProperty m) { }

}

internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 6026
{	// Fields
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48

	// Methods

	// RVA: 0x1402C00 Offset: 0x1402000 VA: 0x181402C00
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x1401540 Offset: 0x1400940 VA: 0x181401540
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x13FD3B0 Offset: 0x13FC7B0 VA: 0x1813FD3B0
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0x13FD330 Offset: 0x13FC730 VA: 0x1813FD330
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x14004F0 Offset: 0x13FF8F0 VA: 0x1814004F0
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1400830 Offset: 0x13FFC30 VA: 0x181400830
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x13FDE40 Offset: 0x13FD240 VA: 0x1813FDE40
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1401AB0 Offset: 0x1400EB0 VA: 0x181401AB0
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x14019C0 Offset: 0x1400DC0 VA: 0x1814019C0
	private bool ShouldWriteProperty(object memberValue, JsonProperty property) { }

	// RVA: 0x13FCF80 Offset: 0x13FC380 VA: 0x1813FCF80
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1402470 Offset: 0x1401870 VA: 0x181402470
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x13FD7A0 Offset: 0x13FCBA0 VA: 0x1813FD7A0
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x1401E00 Offset: 0x1401200 VA: 0x181401E00
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x1400780 Offset: 0x13FFB80 VA: 0x181400780
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x13FDCD0 Offset: 0x13FD0D0 VA: 0x1813FDCD0
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x13FDB60 Offset: 0x13FCF60 VA: 0x1813FDB60
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x13FFC30 Offset: 0x13FF030 VA: 0x1813FFC30
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x13FC810 Offset: 0x13FBC10 VA: 0x1813FC810
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x1402050 Offset: 0x1401450 VA: 0x181402050
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x14022E0 Offset: 0x14016E0 VA: 0x1814022E0
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x1402A40 Offset: 0x1401E40 VA: 0x181402A40
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xF96E90 Offset: 0xF96290 VA: 0x180F96E90
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xF96E90 Offset: 0xF96290 VA: 0x180F96E90
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xF96E90 Offset: 0xF96290 VA: 0x180F96E90
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x13FDEF0 Offset: 0x13FD2F0 VA: 0x1813FDEF0
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x13FF1D0 Offset: 0x13FE5D0 VA: 0x1813FF1D0
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x13FFAC0 Offset: 0x13FEEC0 VA: 0x1813FFAC0
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x13FF6C0 Offset: 0x13FEAC0 VA: 0x1813FF6C0
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x1402640 Offset: 0x1401A40 VA: 0x181402640
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x13FEB10 Offset: 0x13FDF10 VA: 0x1813FEB10
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1401C90 Offset: 0x1401090 VA: 0x181401C90
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x13FE290 Offset: 0x13FD690 VA: 0x1813FE290
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x13FD430 Offset: 0x13FC830 VA: 0x1813FD430
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x13FD930 Offset: 0x13FCD30 VA: 0x1813FD930
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x1401810 Offset: 0x1400C10 VA: 0x181401810
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x13FD9B0 Offset: 0x13FCDB0 VA: 0x1813FD9B0
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }

}

internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 6027
{	// Fields
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	private readonly JsonSerializer _serializer; // 0xF0

	// Properties
	public override IReferenceResolver ReferenceResolver { set; }
	public override ITraceWriter TraceWriter { get; set; }
	public override IEqualityComparer EqualityComparer { set; }
	public override JsonConverterCollection Converters { get; }
	public override DefaultValueHandling DefaultValueHandling { set; }
	public override IContractResolver ContractResolver { get; set; }
	public override MissingMemberHandling MissingMemberHandling { set; }
	public override NullValueHandling NullValueHandling { set; }
	public override ObjectCreationHandling ObjectCreationHandling { get; set; }
	public override ReferenceLoopHandling ReferenceLoopHandling { set; }
	public override PreserveReferencesHandling PreserveReferencesHandling { set; }
	public override TypeNameHandling TypeNameHandling { set; }
	public override MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public override FormatterAssemblyStyle TypeNameAssemblyFormat { set; }
	public override ConstructorHandling ConstructorHandling { set; }
	public override SerializationBinder Binder { set; }
	public override StreamingContext Context { get; set; }
	public override Formatting Formatting { get; set; }
	public override bool CheckAdditionalContent { get; set; }

	// Methods

	// RVA: 0x1803560 Offset: 0x1802960 VA: 0x181803560 Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1803720 Offset: 0x1802B20 VA: 0x181803720 Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1803A00 Offset: 0x1802E00 VA: 0x181803A00 Slot: 6
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x18036F0 Offset: 0x1802AF0 VA: 0x1818036F0 Slot: 8
	public override ITraceWriter get_TraceWriter() { }

	// RVA: 0x1803A30 Offset: 0x1802E30 VA: 0x181803A30 Slot: 9
	public override void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x1803880 Offset: 0x1802C80 VA: 0x181803880 Slot: 10
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x1803630 Offset: 0x1802A30 VA: 0x181803630 Slot: 23
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x1803850 Offset: 0x1802C50 VA: 0x181803850 Slot: 17
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x1803600 Offset: 0x1802A00 VA: 0x181803600 Slot: 24
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x1803820 Offset: 0x1802C20 VA: 0x181803820 Slot: 25
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x1803910 Offset: 0x1802D10 VA: 0x181803910 Slot: 15
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x1803940 Offset: 0x1802D40 VA: 0x181803940 Slot: 16
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x18036C0 Offset: 0x1802AC0 VA: 0x1818036C0 Slot: 18
	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1803970 Offset: 0x1802D70 VA: 0x181803970 Slot: 19
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x18039D0 Offset: 0x1802DD0 VA: 0x1818039D0 Slot: 14
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x18039A0 Offset: 0x1802DA0 VA: 0x1818039A0 Slot: 13
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x1803A90 Offset: 0x1802E90 VA: 0x181803A90 Slot: 11
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1803690 Offset: 0x1802A90 VA: 0x181803690 Slot: 21
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x18038E0 Offset: 0x1802CE0 VA: 0x1818038E0 Slot: 22
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x1803A60 Offset: 0x1802E60 VA: 0x181803A60 Slot: 12
	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x18037B0 Offset: 0x1802BB0 VA: 0x1818037B0 Slot: 20
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x1803750 Offset: 0x1802B50 VA: 0x181803750 Slot: 7
	public override void set_Binder(SerializationBinder value) { }

	// RVA: 0x18035C0 Offset: 0x18029C0 VA: 0x1818035C0 Slot: 26
	public override StreamingContext get_Context() { }

	// RVA: 0x18037E0 Offset: 0x1802BE0 VA: 0x1818037E0 Slot: 27
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x1803660 Offset: 0x1802A60 VA: 0x181803660 Slot: 28
	public override Formatting get_Formatting() { }

	// RVA: 0x18038B0 Offset: 0x1802CB0 VA: 0x1818038B0 Slot: 29
	public override void set_Formatting(Formatting value) { }

	// RVA: 0x1803590 Offset: 0x1802990 VA: 0x181803590 Slot: 30
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x1803780 Offset: 0x1802B80 VA: 0x181803780 Slot: 31
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1803310 Offset: 0x1802710 VA: 0x181803310
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x18033C0 Offset: 0x18027C0 VA: 0x1818033C0
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x1803490 Offset: 0x1802890 VA: 0x181803490
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0x18032C0 Offset: 0x18026C0 VA: 0x1818032C0 Slot: 33
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x1803330 Offset: 0x1802730 VA: 0x181803330 Slot: 32
	internal override void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x1803370 Offset: 0x1802770 VA: 0x181803370 Slot: 34
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 6028
{	// Methods

	// RVA: 0x1803AC0 Offset: 0x1802EC0 VA: 0x181803AC0
	public void .ctor(Type underlyingType) { }

}

internal static class JsonTypeReflector // TypeDefIndex: 6029
{	// Fields
	private static Nullable<bool> _fullyTrusted; // 0x0
	private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache; // 0x8
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	// Properties
	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EAA20 Offset: 0x5E9E20 VA: 0x1805EAA20
	|-JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonConverterAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>
	|-JsonTypeReflector.GetCachedAttribute<object>
	|-JsonTypeReflector.GetCachedAttribute<SerializableAttribute>
	*/

	// RVA: 0x1803FA0 Offset: 0x18033A0 VA: 0x181803FA0
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x1804030 Offset: 0x1803430 VA: 0x181804030
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x18047C0 Offset: 0x1803BC0 VA: 0x1818047C0
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x18046F0 Offset: 0x1803AF0 VA: 0x1818046F0
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x1803BC0 Offset: 0x1802FC0 VA: 0x181803BC0
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs) { }

	// RVA: 0x18045A0 Offset: 0x18039A0 VA: 0x1818045A0
	private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType) { }

	// RVA: 0x1804960 Offset: 0x1803D60 VA: 0x181804960
	public static TypeConverter GetTypeConverter(Type type) { }

	// RVA: 0x1803F20 Offset: 0x1803320 VA: 0x181803F20
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x1803C60 Offset: 0x1803060 VA: 0x181803C60
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EA8A0 Offset: 0x5E9CA0 VA: 0x1805EA8A0
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EA540 Offset: 0x5E9940 VA: 0x1805EA540
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EA790 Offset: 0x5E9B90 VA: 0x1805EA790
	|-JsonTypeReflector.GetAttribute<JsonExtensionDataAttribute>
	|-JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>
	|-JsonTypeReflector.GetAttribute<JsonPropertyAttribute>
	|-JsonTypeReflector.GetAttribute<JsonRequiredAttribute>
	|-JsonTypeReflector.GetAttribute<DefaultValueAttribute>
	|-JsonTypeReflector.GetAttribute<NonSerializedAttribute>
	|-JsonTypeReflector.GetAttribute<object>
	|-JsonTypeReflector.GetAttribute<DataMemberAttribute>
	*/

	// RVA: 0x1804AC0 Offset: 0x1803EC0 VA: 0x181804AC0
	public static bool get_FullyTrusted() { }

	// RVA: 0x1804C40 Offset: 0x1804040 VA: 0x181804C40
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x18049C0 Offset: 0x1803DC0 VA: 0x1818049C0
	private static void .cctor() { }

}

private sealed class JsonTypeReflector.<>c__DisplayClass18_0 // TypeDefIndex: 6030
{	// Fields
	public Type converterType; // 0x10
	public Func<object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x180FB70 Offset: 0x180EF70 VA: 0x18180FB70
	internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters) { }

}

private sealed class JsonTypeReflector.<>c // TypeDefIndex: 6031
{	// Fields
	public static readonly JsonTypeReflector.<>c <>9; // 0x0
	public static Func<object, Type> <>9__18_1; // 0x8

	// Methods

	// RVA: 0x1810380 Offset: 0x180F780 VA: 0x181810380
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9CA440 Offset: 0x9C9840 VA: 0x1809CA440
	internal Type <GetJsonConverterCreator>b__18_1(object param) { }

}

public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 6038
{	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0xE30CA0 Offset: 0xE300A0 VA: 0x180E30CA0
	public void .ctor(string name) { }

	// RVA: 0xE30870 Offset: 0xE2FC70 VA: 0x180E30870
	private static JObject CastInstance(object instance) { }

	// RVA: 0xE308F0 Offset: 0xE2FCF0 VA: 0x180E308F0 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0xE30A10 Offset: 0xE2FE10 VA: 0x180E30A10 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xE30CB0 Offset: 0xE300B0 VA: 0x180E30CB0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xE30D10 Offset: 0xE30110 VA: 0x180E30D10 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 8
	protected override int get_NameHashCode() { }

}

internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 6039
{	// Fields
	private static readonly IEqualityComparer<string> Comparer; // 0x0
	private Dictionary<string, JToken> _dictionary; // 0x20

	// Properties
	public ICollection<string> Keys { get; }

	// Methods

	// RVA: 0xE31960 Offset: 0xE30D60 VA: 0x180E31960
	public void .ctor() { }

	// RVA: 0xE30D70 Offset: 0xE30170 VA: 0x180E30D70
	private void AddKey(string key, JToken item) { }

	// RVA: 0xE30DE0 Offset: 0xE301E0 VA: 0x180E30DE0 Slot: 34
	protected override void ClearItems() { }

	// RVA: 0xE311C0 Offset: 0xE305C0 VA: 0x180E311C0
	public bool Contains(string key) { }

	// RVA: 0xE31250 Offset: 0xE30650 VA: 0x180E31250
	private void EnsureDictionary() { }

	// RVA: 0xE31300 Offset: 0xE30700 VA: 0x180E31300
	private string GetKeyForItem(JToken item) { }

	// RVA: 0xE31460 Offset: 0xE30860 VA: 0x180E31460 Slot: 35
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0xE31520 Offset: 0xE30920 VA: 0x180E31520 Slot: 36
	protected override void RemoveItem(int index) { }

	// RVA: 0xE315E0 Offset: 0xE309E0 VA: 0x180E315E0
	private void RemoveKey(string key) { }

	// RVA: 0xE31630 Offset: 0xE30A30 VA: 0x180E31630 Slot: 37
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0xE31830 Offset: 0xE30C30 VA: 0x180E31830
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0xE319D0 Offset: 0xE30DD0 VA: 0x180E319D0
	public ICollection<string> get_Keys() { }

	// RVA: 0xE313C0 Offset: 0xE307C0 VA: 0x180E313C0
	public int IndexOfReference(JToken t) { }

	// RVA: 0xE30E40 Offset: 0xE30240 VA: 0x180E30E40
	public bool Compare(JPropertyKeyedCollection other) { }

	// RVA: 0xE318B0 Offset: 0xE30CB0 VA: 0x180E318B0
	private static void .cctor() { }

}

public class JsonLoadSettings // TypeDefIndex: 6040
{	// Fields
	private CommentHandling _commentHandling; // 0x10
	private LineInfoHandling _lineInfoHandling; // 0x14

	// Properties
	public CommentHandling CommentHandling { get; }
	public LineInfoHandling LineInfoHandling { get; }

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public CommentHandling get_CommentHandling() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class JsonMergeSettings // TypeDefIndex: 6041
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 6046
{
// Namespace: Newtonsoft.Json.Linq
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 6046
	// Methods

	// RVA: 0xE33080 Offset: 0xE32480 VA: 0x180E33080 Slot: 4
	public bool Equals(JToken x, JToken y) { }

	// RVA: 0xE33120 Offset: 0xE32520 VA: 0x180E33120 Slot: 5
	public int GetHashCode(JToken obj) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class JConstructor : JContainer // TypeDefIndex: 6056
{
// Namespace: Newtonsoft.Json.Linq
[PreserveAttribute] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
[DefaultMemberAttribute] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
public class JConstructor : JContainer // TypeDefIndex: 6056
	// Fields
	private string _name; // 0x48
	private readonly List<JToken> _values; // 0x50

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0xE2B990 Offset: 0xE2AD90 VA: 0x180E2B990 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public string get_Name() { }

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE2BDC0 Offset: 0xE2B1C0 VA: 0x180E2BDC0
	public void .ctor() { }

	// RVA: 0xE2BFB0 Offset: 0xE2B3B0 VA: 0x180E2BFB0
	public void .ctor(JConstructor other) { }

	// RVA: 0xE2BE70 Offset: 0xE2B270 VA: 0x180E2BE70
	public void .ctor(string name) { }

	// RVA: 0xE2B780 Offset: 0xE2AB80 VA: 0x180E2B780 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE2B6C0 Offset: 0xE2AAC0 VA: 0x180E2B6C0 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE2BBD0 Offset: 0xE2AFD0 VA: 0x180E2BBD0 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE2B940 Offset: 0xE2AD40 VA: 0x180E2B940 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE2B9E0 Offset: 0xE2ADE0 VA: 0x180E2B9E0
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

}

public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, IList, ICollection // TypeDefIndex: 6057
{	// Fields
	internal ListChangedEventHandler _listChanged; // 0x30
	private object _syncRoot; // 0x38
	private bool _busy; // 0x40

	// Properties
	protected abstract IList<JToken> ChildrenTokens { get; }
	public override bool HasValues { get; }
	public override JToken First { get; }
	public override JToken Last { get; }
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract IList<JToken> get_ChildrenTokens();

	// RVA: 0xE2E9B0 Offset: 0xE2DDB0 VA: 0x180E2E9B0
	internal void .ctor() { }

	// RVA: 0xE2EA10 Offset: 0xE2DE10 VA: 0x180E2EA10
	internal void .ctor(JContainer other) { }

	// RVA: 0xE2C460 Offset: 0xE2B860 VA: 0x180E2C460
	internal void CheckReentrancy() { }

	// RVA: 0xE2D3A0 Offset: 0xE2C7A0 VA: 0x180E2D3A0 Slot: 46
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE2ECE0 Offset: 0xE2E0E0 VA: 0x180E2ECE0 Slot: 13
	public override bool get_HasValues() { }

	// RVA: 0xE2C7C0 Offset: 0xE2BBC0 VA: 0x180E2C7C0
	internal bool ContentsEqual(JContainer container) { }

	// RVA: 0xE2EC60 Offset: 0xE2E060 VA: 0x180E2EC60 Slot: 14
	public override JToken get_First() { }

	// RVA: 0xE2ED40 Offset: 0xE2E140 VA: 0x180E2ED40 Slot: 15
	public override JToken get_Last() { }

	// RVA: 0xE2C510 Offset: 0xE2B910 VA: 0x180E2C510 Slot: 16
	public override JEnumerable<JToken> Children() { }

	// RVA: 0xE2D210 Offset: 0xE2C610 VA: 0x180E2D210
	internal bool IsMultiContent(object content) { }

	// RVA: 0xE2CDF0 Offset: 0xE2C1F0 VA: 0x180E2CDF0
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck) { }

	// RVA: -1 Offset: -1 Slot: 47
	internal abstract int IndexOfItem(JToken item);

	// RVA: 0xE2CFA0 Offset: 0xE2C3A0 VA: 0x180E2CFA0 Slot: 48
	internal virtual void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE2DCD0 Offset: 0xE2D0D0 VA: 0x180E2DCD0 Slot: 49
	internal virtual void RemoveItemAt(int index) { }

	// RVA: 0xE2DF70 Offset: 0xE2D370 VA: 0x180E2DF70 Slot: 50
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0xE2CF30 Offset: 0xE2C330 VA: 0x180E2CF30 Slot: 51
	internal virtual JToken GetItem(int index) { }

	// RVA: 0xE2E010 Offset: 0xE2D410 VA: 0x180E2E010 Slot: 52
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0xE2C570 Offset: 0xE2B970 VA: 0x180E2C570 Slot: 53
	internal virtual void ClearItems() { }

	// RVA: 0xE2DFC0 Offset: 0xE2D3C0 VA: 0x180E2DFC0 Slot: 54
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xE2C7A0 Offset: 0xE2BBA0 VA: 0x180E2C7A0 Slot: 55
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0xE2CAD0 Offset: 0xE2BED0 VA: 0x180E2CAD0 Slot: 56
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xE2D2C0 Offset: 0xE2C6C0 VA: 0x180E2D2C0
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xE2E8A0 Offset: 0xE2DCA0 VA: 0x180E2E8A0 Slot: 57
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE2C3E0 Offset: 0xE2B7E0 VA: 0x180E2C3E0 Slot: 58
	public virtual void Add(object content) { }

	// RVA: 0xE2C050 Offset: 0xE2B450 VA: 0x180E2C050
	internal void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xE2C0D0 Offset: 0xE2B4D0 VA: 0x180E2C0D0
	internal void AddInternal(int index, object content, bool skipParentCheck) { }

	// RVA: 0xE2CD40 Offset: 0xE2C140 VA: 0x180E2CD40
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0xE2ADD0 Offset: 0xE2A1D0 VA: 0x180E2ADD0
	public void RemoveAll() { }

	// RVA: 0xE2DB20 Offset: 0xE2CF20 VA: 0x180E2DB20
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xE2D440 Offset: 0xE2C840 VA: 0x180E2D440
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xE2C900 Offset: 0xE2BD00 VA: 0x180E2C900
	internal int ContentsHashCode() { }

	// RVA: 0xE2B140 Offset: 0xE2A540 VA: 0x180E2B140 Slot: 21
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xE2B160 Offset: 0xE2A560 VA: 0x180E2B160 Slot: 22
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xE2B340 Offset: 0xE2A740 VA: 0x180E2B340 Slot: 23
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xE2B680 Offset: 0xE2AA80 VA: 0x180E2B680 Slot: 19
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xE2B6A0 Offset: 0xE2AAA0 VA: 0x180E2B6A0 Slot: 20
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xE2ADB0 Offset: 0xE2A1B0 VA: 0x180E2ADB0 Slot: 26
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xE2ADD0 Offset: 0xE2A1D0 VA: 0x180E2ADD0 Slot: 27
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xE2AEA0 Offset: 0xE2A2A0 VA: 0x180E2AEA0 Slot: 28
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xE2AEC0 Offset: 0xE2A2C0 VA: 0x180E2AEC0 Slot: 29
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 25
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xE2B360 Offset: 0xE2A760 VA: 0x180E2B360 Slot: 30
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xE2CE90 Offset: 0xE2C290 VA: 0x180E2CE90
	private JToken EnsureValue(object value) { }

	// RVA: 0xE2E3A0 Offset: 0xE2D7A0 VA: 0x180E2E3A0 Slot: 33
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xE2ADD0 Offset: 0xE2A1D0 VA: 0x180E2ADD0 Slot: 35
	private void System.Collections.IList.Clear() { }

	// RVA: 0xE2E4B0 Offset: 0xE2D8B0 VA: 0x180E2E4B0 Slot: 34
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xE2E570 Offset: 0xE2D970 VA: 0x180E2E570 Slot: 38
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xE2E630 Offset: 0xE2DA30 VA: 0x180E2E630 Slot: 39
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 37
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 36
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xE2E710 Offset: 0xE2DB10 VA: 0x180E2E710 Slot: 40
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xE2B340 Offset: 0xE2A740 VA: 0x180E2B340 Slot: 41
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xE2B680 Offset: 0xE2AA80 VA: 0x180E2B680 Slot: 31
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xE2E7D0 Offset: 0xE2DBD0 VA: 0x180E2E7D0 Slot: 32
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xE2AEC0 Offset: 0xE2A2C0 VA: 0x180E2AEC0 Slot: 42
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xE2EC00 Offset: 0xE2E000 VA: 0x180E2EC00 Slot: 43
	public int get_Count() { }

	// RVA: 0xE2E330 Offset: 0xE2D730 VA: 0x180E2E330 Slot: 44
	private object System.Collections.ICollection.get_SyncRoot() { }

}

public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 6060
{	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PropertyChangedEventHandler PropertyChanged; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PropertyChangingEventHandler PropertyChanging; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; }
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0xE305D0 Offset: 0xE2F9D0 VA: 0x180E305D0
	public void .ctor() { }

	// RVA: 0xE30510 Offset: 0xE2F910 VA: 0x180E30510
	public void .ctor(JObject other) { }

	// RVA: 0xE2EF40 Offset: 0xE2E340 VA: 0x180E2EF40 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE2F050 Offset: 0xE2E450 VA: 0x180E2F050 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE2F0F0 Offset: 0xE2E4F0 VA: 0x180E2F0F0 Slot: 48
	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE30150 Offset: 0xE2F550 VA: 0x180E30150 Slot: 57
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE2F160 Offset: 0xE2E560 VA: 0x180E2F160
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xE2F220 Offset: 0xE2E620 VA: 0x180E2F220
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xE2EE50 Offset: 0xE2E250 VA: 0x180E2EE50 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE2F540 Offset: 0xE2E940 VA: 0x180E2F540
	public JProperty Property(string name) { }

	// RVA: 0xE306C0 Offset: 0xE2FAC0 VA: 0x180E306C0 Slot: 59
	public JToken get_Item(string propertyName) { }

	// RVA: 0xE30740 Offset: 0xE2FB40 VA: 0x180E30740 Slot: 60
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0xE2F410 Offset: 0xE2E810 VA: 0x180E2F410
	public static JObject Load(JsonReader reader) { }

	// RVA: 0xE2F250 Offset: 0xE2E650 VA: 0x180E2F250
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE30410 Offset: 0xE2F810 VA: 0x180E30410 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE2EDC0 Offset: 0xE2E1C0 VA: 0x180E2EDC0 Slot: 64
	public void Add(string propertyName, JToken value) { }

	// RVA: 0xE2FC20 Offset: 0xE2F020 VA: 0x180E2FC20 Slot: 63
	private bool System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key) { }

	// RVA: 0xE2FCC0 Offset: 0xE2F0C0 VA: 0x180E2FCC0 Slot: 61
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xE2F650 Offset: 0xE2EA50 VA: 0x180E2F650 Slot: 65
	public bool Remove(string propertyName) { }

	// RVA: 0xE300F0 Offset: 0xE2F4F0 VA: 0x180E300F0 Slot: 66
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0xE2FD20 Offset: 0xE2F120 VA: 0x180E2FD20 Slot: 62
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xE2F6E0 Offset: 0xE2EAE0 VA: 0x180E2F6E0 Slot: 69
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE2ADD0 Offset: 0xE2A1D0 VA: 0x180E2ADD0 Slot: 70
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xE2F760 Offset: 0xE2EB60 VA: 0x180E2F760 Slot: 71
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE2F7D0 Offset: 0xE2EBD0 VA: 0x180E2F7D0 Slot: 72
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 68
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xE2FAD0 Offset: 0xE2EED0 VA: 0x180E2FAD0 Slot: 73
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE2B080 Offset: 0xE2A480 VA: 0x180E2B080 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE2EFE0 Offset: 0xE2E3E0 VA: 0x180E2EFE0 Slot: 74
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0xE2F420 Offset: 0xE2E820 VA: 0x180E2F420 Slot: 80
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0xE2F4B0 Offset: 0xE2E8B0 VA: 0x180E2F4B0 Slot: 81
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0xE30040 Offset: 0xE2F440 VA: 0x180E30040 Slot: 77
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xE2FE20 Offset: 0xE2F220 VA: 0x180E2FE20 Slot: 78
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xE2FD70 Offset: 0xE2F170 VA: 0x180E2FD70 Slot: 75
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xE2FDD0 Offset: 0xE2F1D0 VA: 0x180E2FDD0 Slot: 76
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 79
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class JObject.<>c // TypeDefIndex: 6061
{	// Fields
	public static readonly JObject.<>c <>9; // 0x2B0ABBC

	// Methods

	// RVA: 0xE47AC0 Offset: 0xE46EC0 VA: 0x180E47AC0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class JObject.<GetEnumerator>d__58 : IEnumerator<KeyValuePair<string, JToken>>, IDisposable, IEnumerator // TypeDefIndex: 6062
{	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, JToken> <>2__current; // 0x18
	public JObject <>4__this; // 0x28
	private IEnumerator<JToken> <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE47960 Offset: 0xE46D60 VA: 0x180E47960 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE476B0 Offset: 0xE46AB0 VA: 0x180E476B0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0xE47A10 Offset: 0xE46E10 VA: 0x180E47A10
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0C9C0 Offset: 0xB0BDC0 VA: 0x180B0C9C0 Slot: 4
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE478C0 Offset: 0xE46CC0 VA: 0x180E478C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE47910 Offset: 0xE46D10 VA: 0x180E47910 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6063
{	// Fields
	private readonly List<JToken> _values; // 0x48

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE2B480 Offset: 0xE2A880 VA: 0x180E2B480
	public void .ctor() { }

	// RVA: 0xE2B600 Offset: 0xE2AA00 VA: 0x180E2B600
	public void .ctor(JArray other) { }

	// RVA: 0xE2B530 Offset: 0xE2A930 VA: 0x180E2B530
	public void .ctor(object content) { }

	// RVA: 0xE2AEE0 Offset: 0xE2A2E0 VA: 0x180E2AEE0 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE2ADF0 Offset: 0xE2A1F0 VA: 0x180E2ADF0 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE2B330 Offset: 0xE2A730 VA: 0x180E2B330
	public static JArray Load(JsonReader reader) { }

	// RVA: 0xE2B190 Offset: 0xE2A590 VA: 0x180E2B190
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE2B380 Offset: 0xE2A780 VA: 0x180E2B380 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE2B680 Offset: 0xE2AA80 VA: 0x180E2B680 Slot: 19
	public JToken get_Item(int index) { }

	// RVA: 0xE2B6A0 Offset: 0xE2AAA0 VA: 0x180E2B6A0 Slot: 20
	public void set_Item(int index, JToken value) { }

	// RVA: 0xE2B0F0 Offset: 0xE2A4F0 VA: 0x180E2B0F0 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE2B140 Offset: 0xE2A540 VA: 0x180E2B140 Slot: 21
	public int IndexOf(JToken item) { }

	// RVA: 0xE2B160 Offset: 0xE2A560 VA: 0x180E2B160 Slot: 22
	public void Insert(int index, JToken item) { }

	// RVA: 0xE2B340 Offset: 0xE2A740 VA: 0x180E2B340 Slot: 23
	public void RemoveAt(int index) { }

	// RVA: 0xE2B090 Offset: 0xE2A490 VA: 0x180E2B090 Slot: 4
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0xE2ADB0 Offset: 0xE2A1B0 VA: 0x180E2ADB0 Slot: 26
	public void Add(JToken item) { }

	// RVA: 0xE2ADD0 Offset: 0xE2A1D0 VA: 0x180E2ADD0 Slot: 27
	public void Clear() { }

	// RVA: 0xE2AEA0 Offset: 0xE2A2A0 VA: 0x180E2AEA0 Slot: 28
	public bool Contains(JToken item) { }

	// RVA: 0xE2AEC0 Offset: 0xE2A2C0 VA: 0x180E2AEC0 Slot: 29
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0xE2B360 Offset: 0xE2A760 VA: 0x180E2B360 Slot: 30
	public bool Remove(JToken item) { }

	// RVA: 0xE2B080 Offset: 0xE2A480 VA: 0x180E2B080 Slot: 18
	internal override int GetDeepHashCode() { }

}

public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 6064
{	// Fields
	private readonly JToken _root; // 0x78
	private string _initialPath; // 0x80
	private JToken _parent; // 0x88
	private JToken _current; // 0x90

	// Properties
	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }

	// Methods

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public JToken get_CurrentToken() { }

	// RVA: 0xE345A0 Offset: 0xE339A0 VA: 0x180E345A0
	public void .ctor(JToken token) { }

	// RVA: 0xE33570 Offset: 0xE32970 VA: 0x180E33570 Slot: 10
	public override bool Read() { }

	// RVA: 0xE33440 Offset: 0xE32840 VA: 0x180E33440
	private bool ReadOver(JToken t) { }

	// RVA: 0xE33530 Offset: 0xE32930 VA: 0x180E33530
	private bool ReadToEnd() { }

	// RVA: 0xE33140 Offset: 0xE32540 VA: 0x180E33140
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xE333A0 Offset: 0xE327A0 VA: 0x180E333A0
	private bool ReadInto(JContainer c) { }

	// RVA: 0xE338B0 Offset: 0xE32CB0 VA: 0x180E338B0
	private bool SetEnd(JContainer c) { }

	// RVA: 0xE33A50 Offset: 0xE32E50 VA: 0x180E33A50
	private void SetToken(JToken token) { }

	// RVA: 0xE33890 Offset: 0xE32C90 VA: 0x180E33890
	private string SafeToString(object value) { }

	// RVA: 0xE33280 Offset: 0xE32680 VA: 0x180E33280 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE332E0 Offset: 0xE326E0 VA: 0x180E332E0 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE33340 Offset: 0xE32740 VA: 0x180E33340 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE34600 Offset: 0xE33A00 VA: 0x180E34600 Slot: 9
	public override string get_Path() { }

}

public class JTokenWriter : JsonWriter // TypeDefIndex: 6065
{	// Fields
	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	// Properties
	public JToken Token { get; }

	// Methods

	// RVA: 0xE35B40 Offset: 0xE34F40 VA: 0x180E35B40
	public JToken get_Token() { }

	// RVA: 0xE35AD0 Offset: 0xE34ED0 VA: 0x180E35AD0
	public void .ctor() { }

	// RVA: 0xE34920 Offset: 0xE33D20 VA: 0x180E34920 Slot: 6
	public override void Close() { }

	// RVA: 0xE34D50 Offset: 0xE34150 VA: 0x180E34D50 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0xE346F0 Offset: 0xE33AF0 VA: 0x180E346F0
	private void AddParent(JContainer container) { }

	// RVA: 0xE34990 Offset: 0xE33D90 VA: 0x180E34990
	private void RemoveParent() { }

	// RVA: 0xE34C60 Offset: 0xE34060 VA: 0x180E34C60 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0xE34CD0 Offset: 0xE340D0 VA: 0x180E34CD0 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE34990 Offset: 0xE33D90 VA: 0x180E34990 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE34AA0 Offset: 0xE33EA0 VA: 0x180E34AA0 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0xE347C0 Offset: 0xE33BC0 VA: 0x180E347C0
	private void AddValue(object value, JsonToken token) { }

	// RVA: 0xE34850 Offset: 0xE33C50 VA: 0x180E34850
	internal void AddValue(JValue value, JsonToken token) { }

	// RVA: 0xE359C0 Offset: 0xE34DC0 VA: 0x180E359C0 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0xE34A60 Offset: 0xE33E60 VA: 0x180E34A60 Slot: 21
	public override void WriteNull() { }

	// RVA: 0xE35060 Offset: 0xE34460 VA: 0x180E35060 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0xE34BF0 Offset: 0xE33FF0 VA: 0x180E34BF0 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0xE34A10 Offset: 0xE33E10 VA: 0x180E34A10 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0xE35690 Offset: 0xE34A90 VA: 0x180E35690 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0xE35860 Offset: 0xE34C60 VA: 0x180E35860 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE35390 Offset: 0xE34790 VA: 0x180E35390 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0xE35590 Offset: 0xE34990 VA: 0x180E35590 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE359D0 Offset: 0xE34DD0 VA: 0x180E359D0 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0xE35260 Offset: 0xE34660 VA: 0x180E35260 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0xE35760 Offset: 0xE34B60 VA: 0x180E35760 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0xE358E0 Offset: 0xE34CE0 VA: 0x180E358E0 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0xE35A50 Offset: 0xE34E50 VA: 0x180E35A50 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE35610 Offset: 0xE34A10 VA: 0x180E35610 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0xE351D0 Offset: 0xE345D0 VA: 0x180E351D0 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0xE35490 Offset: 0xE34890 VA: 0x180E35490 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE357E0 Offset: 0xE34BE0 VA: 0x180E357E0 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0xE350A0 Offset: 0xE344A0 VA: 0x180E350A0 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE35120 Offset: 0xE34520 VA: 0x180E35120 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE356E0 Offset: 0xE34AE0 VA: 0x180E356E0 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE35960 Offset: 0xE34D60 VA: 0x180E35960 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0xE35510 Offset: 0xE34910 VA: 0x180E35510 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE35410 Offset: 0xE34810 VA: 0x180E35410 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0xE352E0 Offset: 0xE346E0 VA: 0x180E352E0 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0xE34DC0 Offset: 0xE341C0 VA: 0x180E34DC0 Slot: 16
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable // TypeDefIndex: 6066
{	// Fields
	private JContainer _parent; // 0x10
	private JToken _previous; // 0x18
	private JToken _next; // 0x20
	private object _annotations; // 0x28
	private static readonly JTokenType[] BooleanTypes; // 0x0
	private static readonly JTokenType[] NumberTypes; // 0x8
	private static readonly JTokenType[] StringTypes; // 0x10
	private static readonly JTokenType[] GuidTypes; // 0x18
	private static readonly JTokenType[] TimeSpanTypes; // 0x20
	private static readonly JTokenType[] UriTypes; // 0x28
	private static readonly JTokenType[] CharTypes; // 0x30
	private static readonly JTokenType[] DateTimeTypes; // 0x38
	private static readonly JTokenType[] BytesTypes; // 0x40

	// Properties
	public JContainer Parent { get; set; }
	public JToken Root { get; }
	public abstract JTokenType Type { get; }
	public abstract bool HasValues { get; }
	public JToken Next { get; set; }
	public JToken Previous { get; set; }
	public string Path { get; }
	public virtual JToken First { get; }
	public virtual JToken Last { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	[DebuggerStepThroughAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public JContainer get_Parent() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_Parent(JContainer value) { }

	// RVA: 0xE38B90 Offset: 0xE37F90 VA: 0x180E38B90
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract JToken CloneToken();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool DeepEquals(JToken node);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_HasValues();

	// RVA: 0xE35F30 Offset: 0xE35330 VA: 0x180E35F30
	public static bool DeepEquals(JToken t1, JToken t2) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public JToken get_Next() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_Next(JToken value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public JToken get_Previous() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_Previous(JToken value) { }

	// RVA: 0xE388E0 Offset: 0xE37CE0 VA: 0x180E388E0
	public string get_Path() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0xE387A0 Offset: 0xE37BA0 VA: 0x180E387A0 Slot: 14
	public virtual JToken get_First() { }

	// RVA: 0xE38840 Offset: 0xE37C40 VA: 0x180E38840 Slot: 15
	public virtual JToken get_Last() { }

	// RVA: 0xE35E20 Offset: 0xE35220 VA: 0x180E35E20 Slot: 16
	public virtual JEnumerable<JToken> Children() { }

	// RVA: 0xE36940 Offset: 0xE35D40 VA: 0x180E36940
	public void Remove() { }

	// RVA: 0xE369C0 Offset: 0xE35DC0 VA: 0x180E369C0
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0xE37E00 Offset: 0xE37200 VA: 0x180E37E00 Slot: 3
	public override string ToString() { }

	// RVA: 0xE37C10 Offset: 0xE37010 VA: 0x180E37C10
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xE35F60 Offset: 0xE35360 VA: 0x180E35F60
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0xE360F0 Offset: 0xE354F0 VA: 0x180E360F0
	private static string GetType(JToken token) { }

	// RVA: 0xE37E50 Offset: 0xE37250 VA: 0x180E37E50
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xE3D870 Offset: 0xE3CC70 VA: 0x180E3D870
	public static bool op_Explicit(JToken value) { }

	// RVA: 0xE3AE30 Offset: 0xE3A230 VA: 0x180E3AE30
	public static DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xE3BC30 Offset: 0xE3B030 VA: 0x180E3BC30
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0xE38FF0 Offset: 0xE383F0 VA: 0x180E38FF0
	public static long op_Explicit(JToken value) { }

	// RVA: 0xE393B0 Offset: 0xE387B0 VA: 0x180E393B0
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	// RVA: 0xE3C9A0 Offset: 0xE3BDA0 VA: 0x180E3C9A0
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xE3A460 Offset: 0xE39860 VA: 0x180E3A460
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	// RVA: 0xE3C750 Offset: 0xE3BB50 VA: 0x180E3C750
	public static Nullable<double> op_Explicit(JToken value) { }

	// RVA: 0xE39B00 Offset: 0xE38F00 VA: 0x180E39B00
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0xE3DD20 Offset: 0xE3D120 VA: 0x180E3DD20
	public static int op_Explicit(JToken value) { }

	// RVA: 0xE3B300 Offset: 0xE3A700 VA: 0x180E3B300
	public static short op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE3CFA0 Offset: 0xE3C3A0 VA: 0x180E3CFA0
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE38BC0 Offset: 0xE37FC0 VA: 0x180E38BC0
	public static char op_Explicit(JToken value) { }

	// RVA: 0xE3AC50 Offset: 0xE3A050 VA: 0x180E3AC50
	public static byte op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE39920 Offset: 0xE38D20 VA: 0x180E39920
	public static sbyte op_Explicit(JToken value) { }

	// RVA: 0xE3BE80 Offset: 0xE3B280 VA: 0x180E3BE80
	public static Nullable<int> op_Explicit(JToken value) { }

	// RVA: 0xE3C320 Offset: 0xE3B720 VA: 0x180E3C320
	public static Nullable<short> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE3D180 Offset: 0xE3C580 VA: 0x180E3D180
	public static Nullable<ushort> op_Explicit(JToken value) { }

	// RVA: 0xE3C0D0 Offset: 0xE3B4D0 VA: 0x180E3C0D0
	public static Nullable<byte> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE3B4E0 Offset: 0xE3A8E0 VA: 0x180E3B4E0
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0xE3CD60 Offset: 0xE3C160 VA: 0x180E3CD60
	public static DateTime op_Explicit(JToken value) { }

	// RVA: 0xE39F30 Offset: 0xE39330 VA: 0x180E39F30
	public static Nullable<long> op_Explicit(JToken value) { }

	// RVA: 0xE3B9E0 Offset: 0xE3ADE0 VA: 0x180E3B9E0
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0xE3A6E0 Offset: 0xE39AE0 VA: 0x180E3A6E0
	public static Decimal op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE3D620 Offset: 0xE3CA20 VA: 0x180E3D620
	public static Nullable<uint> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE3D3D0 Offset: 0xE3C7D0 VA: 0x180E3D3D0
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0xE39D50 Offset: 0xE39150 VA: 0x180E39D50
	public static double op_Explicit(JToken value) { }

	// RVA: 0xE3C570 Offset: 0xE3B970 VA: 0x180E3C570
	public static float op_Explicit(JToken value) { }

	// RVA: 0xE3B730 Offset: 0xE3AB30 VA: 0x180E3B730
	public static string op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE3B120 Offset: 0xE3A520 VA: 0x180E3B120
	public static uint op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE391D0 Offset: 0xE385D0 VA: 0x180E391D0
	public static ulong op_Explicit(JToken value) { }

	// RVA: 0xE3DA50 Offset: 0xE3CE50 VA: 0x180E3DA50
	public static Guid op_Explicit(JToken value) { }

	// RVA: 0xE3A8D0 Offset: 0xE39CD0 VA: 0x180E3A8D0
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0xE38DA0 Offset: 0xE381A0 VA: 0x180E38DA0
	public static TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xE39660 Offset: 0xE38A60 VA: 0x180E39660
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xE3A180 Offset: 0xE39580 VA: 0x180E3A180
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0xE36C20 Offset: 0xE36020 VA: 0x180E36C20 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xE36BC0 Offset: 0xE35FC0 VA: 0x180E36BC0 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract int GetDeepHashCode();

	// RVA: 0xE35E80 Offset: 0xE35280 VA: 0x180E35E80
	public JsonReader CreateReader() { }

	// RVA: -1 Offset: -1
	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E92E0 Offset: 0x5E86E0 VA: 0x1805E92E0
	|-JToken.ToObject<UITwitchTrophy.TrophyPage>
	|-JToken.ToObject<object>
	*/

	// RVA: 0xE36DB0 Offset: 0xE361B0 VA: 0x180E36DB0
	public object ToObject(Type objectType) { }

	// RVA: 0xE36C60 Offset: 0xE36060 VA: 0x180E36C60
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xE365E0 Offset: 0xE359E0 VA: 0x180E365E0
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xE36640 Offset: 0xE35A40 VA: 0x180E36640
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE36580 Offset: 0xE35980 VA: 0x180E36580
	public static JToken Parse(string json) { }

	// RVA: 0xE363B0 Offset: 0xE357B0 VA: 0x180E363B0
	public static JToken Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0xE36260 Offset: 0xE35660 VA: 0x180E36260
	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE36AD0 Offset: 0xE35ED0 VA: 0x180E36AD0
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xE36A50 Offset: 0xE35E50 VA: 0x180E36A50
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xE362D0 Offset: 0xE356D0 VA: 0x180E362D0 Slot: 6
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE36310 Offset: 0xE35710 VA: 0x180E36310 Slot: 7
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE36360 Offset: 0xE35760 VA: 0x180E36360 Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE35F10 Offset: 0xE35310 VA: 0x180E35F10 Slot: 9
	private object System.ICloneable.Clone() { }

	// RVA: 0xE35F10 Offset: 0xE35310 VA: 0x180E35F10
	public JToken DeepClone() { }

	// RVA: 0xE35B50 Offset: 0xE34F50 VA: 0x180E35B50
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E9140 Offset: 0x5E8540 VA: 0x1805E9140
	|-JToken.Annotation<JToken.LineInfoAnnotation>
	|-JToken.Annotation<object>
	*/

	// RVA: 0xE37F30 Offset: 0xE37330 VA: 0x180E37F30
	private static void .cctor() { }

}

private class JToken.LineInfoAnnotation // TypeDefIndex: 6067
{	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0x45B750 Offset: 0x45AB50 VA: 0x18045B750
	public void .ctor(int lineNumber, int linePosition) { }

}

public class JProperty : JContainer // TypeDefIndex: 6073
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
private sealed class JToken.<AfterSelf>d__42 // TypeDefIndex: 6069

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
private sealed class JToken.<BeforeSelf>d__43 // TypeDefIndex: 6070

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
private sealed class JToken.<Annotations>d__171<T> // TypeDefIndex: 6071

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
private sealed class JToken.<Annotations>d__172 // TypeDefIndex: 6072

// Namespace: Newtonsoft.Json.Linq
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public class JProperty : JContainer // TypeDefIndex: 6073
	// Fields
	private readonly JProperty.JPropertyList _content; // 0x48
	private readonly string _name; // 0x50

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Name() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE32BE0 Offset: 0xE31FE0 VA: 0x180E32BE0
	public JToken get_Value() { }

	// RVA: 0xE32C00 Offset: 0xE32000 VA: 0x180E32C00
	public void set_Value(JToken value) { }

	// RVA: 0xE32850 Offset: 0xE31C50 VA: 0x180E32850
	public void .ctor(JProperty other) { }

	// RVA: 0xE31FD0 Offset: 0xE313D0 VA: 0x180E31FD0 Slot: 51
	internal override JToken GetItem(int index) { }

	// RVA: 0xE32530 Offset: 0xE31930 VA: 0x180E32530 Slot: 52
	internal override void SetItem(int index, JToken item) { }

	// RVA: 0xE32460 Offset: 0xE31860 VA: 0x180E32460 Slot: 50
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0xE32390 Offset: 0xE31790 VA: 0x180E32390 Slot: 49
	internal override void RemoveItemAt(int index) { }

	// RVA: 0xE32050 Offset: 0xE31450 VA: 0x180E32050 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE32080 Offset: 0xE31480 VA: 0x180E32080 Slot: 48
	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE31D80 Offset: 0xE31180 VA: 0x180E31D80 Slot: 55
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0xE31BF0 Offset: 0xE30FF0 VA: 0x180E31BF0 Slot: 53
	internal override void ClearItems() { }

	// RVA: 0xE31DA0 Offset: 0xE311A0 VA: 0x180E31DA0 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE31CC0 Offset: 0xE310C0 VA: 0x180E31CC0 Slot: 10
	internal override JToken CloneToken() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE32BD0 Offset: 0xE31FD0 VA: 0x180E32BD0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE32B00 Offset: 0xE31F00 VA: 0x180E32B00
	internal void .ctor(string name) { }

	// RVA: 0xE328E0 Offset: 0xE31CE0 VA: 0x180E328E0
	public void .ctor(string name, object content) { }

	// RVA: 0xE327B0 Offset: 0xE31BB0 VA: 0x180E327B0 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE31F60 Offset: 0xE31360 VA: 0x180E31F60 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE321A0 Offset: 0xE315A0 VA: 0x180E321A0
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

private class JProperty.JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6074
{	// Fields
	internal JToken _token; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public JToken Item { get; set; }

	// Methods

	// RVA: 0xE31AE0 Offset: 0xE30EE0 VA: 0x180E31AE0 Slot: 16
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0xE31AE0 Offset: 0xE30EE0 VA: 0x180E31AE0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 11
	public void Add(JToken item) { }

	// RVA: 0xE31A20 Offset: 0xE30E20 VA: 0x180E31A20 Slot: 12
	public void Clear() { }

	// RVA: 0xE31A40 Offset: 0xE30E40 VA: 0x180E31A40 Slot: 13
	public bool Contains(JToken item) { }

	// RVA: 0xE31A50 Offset: 0xE30E50 VA: 0x180E31A50 Slot: 14
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE31BA0 Offset: 0xE30FA0 VA: 0x180E31BA0 Slot: 15
	public bool Remove(JToken item) { }

	// RVA: 0xE31BD0 Offset: 0xE30FD0 VA: 0x180E31BD0 Slot: 9
	public int get_Count() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0xE31B50 Offset: 0xE30F50 VA: 0x180E31B50 Slot: 6
	public int IndexOf(JToken item) { }

	// RVA: 0xE31B60 Offset: 0xE30F60 VA: 0x180E31B60 Slot: 7
	public void Insert(int index, JToken item) { }

	// RVA: 0xE31B80 Offset: 0xE30F80 VA: 0x180E31B80 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0xE31BE0 Offset: 0xE30FE0 VA: 0x180E31BE0 Slot: 4
	public JToken get_Item(int index) { }

	// RVA: 0xE31B60 Offset: 0xE30F60 VA: 0x180E31B60 Slot: 5
	public void set_Item(int index, JToken value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class JProperty.JPropertyList.<GetEnumerator>d__1 : IEnumerator<JToken>, IDisposable, IEnumerator // TypeDefIndex: 6075
{	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	public JProperty.JPropertyList <>4__this; // 0x20

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE47600 Offset: 0xE46A00 VA: 0x180E47600 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE47660 Offset: 0xE46A60 VA: 0x180E47660 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public enum JTokenType // TypeDefIndex: 6076
{	// Fields
	public int value__; // 0x0
	public const JTokenType None = 0;
	public const JTokenType Object = 1;
	public const JTokenType Array = 2;
	public const JTokenType Constructor = 3;
	public const JTokenType Property = 4;
	public const JTokenType Comment = 5;
	public const JTokenType Integer = 6;
	public const JTokenType Float = 7;
	public const JTokenType String = 8;
	public const JTokenType Boolean = 9;
	public const JTokenType Null = 10;
	public const JTokenType Undefined = 11;
	public const JTokenType Date = 12;
	public const JTokenType Raw = 13;
	public const JTokenType Bytes = 14;
	public const JTokenType Guid = 15;
	public const JTokenType Uri = 16;
	public const JTokenType TimeSpan = 17;

}

public class JValue : JToken, IFormattable, IComparable, IConvertible // TypeDefIndex: 6077
{	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Properties
	public override bool HasValues { get; }
	public override JTokenType Type { get; }
	public object Value { get; }

	// Methods

	// RVA: 0xE40700 Offset: 0xE3FB00 VA: 0x180E40700
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0xE32F70 Offset: 0xE32370 VA: 0x180E32F70
	public void .ctor(JValue other) { }

	// RVA: 0xE406C0 Offset: 0xE3FAC0 VA: 0x180E406C0
	public void .ctor(object value) { }

	// RVA: 0xE3EC00 Offset: 0xE3E000 VA: 0x180E3EC00 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 13
	public override bool get_HasValues() { }

	// RVA: 0xE3E0B0 Offset: 0xE3D4B0 VA: 0x180E3E0B0
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xE3DFC0 Offset: 0xE3D3C0 VA: 0x180E3DFC0
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0xE3DF00 Offset: 0xE3D300 VA: 0x180E3DF00 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE3EA20 Offset: 0xE3DE20 VA: 0x180E3EA20
	public static JValue CreateComment(string value) { }

	// RVA: 0xE3EAC0 Offset: 0xE3DEC0 VA: 0x180E3EAC0
	public static JValue CreateNull() { }

	// RVA: 0xE3EB60 Offset: 0xE3DF60 VA: 0x180E3EB60
	public static JValue CreateUndefined() { }

	// RVA: 0xE3EEC0 Offset: 0xE3E2C0 VA: 0x180E3EEC0
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	// RVA: 0xE3EE60 Offset: 0xE3E260 VA: 0x180E3EE60
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public object get_Value() { }

	// RVA: 0xE3FCD0 Offset: 0xE3F0D0 VA: 0x180E3FCD0 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE3EDF0 Offset: 0xE3E1F0 VA: 0x180E3EDF0 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE3FC80 Offset: 0xE3F080 VA: 0x180E3FC80
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xE3EDA0 Offset: 0xE3E1A0 VA: 0x180E3EDA0
	public bool Equals(JValue other) { }

	// RVA: 0xE3ECC0 Offset: 0xE3E0C0 VA: 0x180E3ECC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xE3EE40 Offset: 0xE3E240 VA: 0x180E3EE40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xE3F9C0 Offset: 0xE3EDC0 VA: 0x180E3F9C0 Slot: 3
	public override string ToString() { }

	// RVA: 0xE3FA20 Offset: 0xE3EE20 VA: 0x180E3FA20 Slot: 36
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xE3FB40 Offset: 0xE3EF40 VA: 0x180E3FB40 Slot: 19
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xE3F2D0 Offset: 0xE3E6D0 VA: 0x180E3F2D0 Slot: 20
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xE3F3F0 Offset: 0xE3E7F0 VA: 0x180E3F3F0 Slot: 21
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xE3F460 Offset: 0xE3E860 VA: 0x180E3F460 Slot: 22
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xE3F520 Offset: 0xE3E920 VA: 0x180E3F520 Slot: 23
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xE3F7D0 Offset: 0xE3EBD0 VA: 0x180E3F7D0 Slot: 24
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xE3F4C0 Offset: 0xE3E8C0 VA: 0x180E3F4C0 Slot: 25
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xE3F6B0 Offset: 0xE3EAB0 VA: 0x180E3F6B0 Slot: 26
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xE3F8A0 Offset: 0xE3ECA0 VA: 0x180E3F8A0 Slot: 27
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xE3F710 Offset: 0xE3EB10 VA: 0x180E3F710 Slot: 28
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xE3F900 Offset: 0xE3ED00 VA: 0x180E3F900 Slot: 29
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xE3F770 Offset: 0xE3EB70 VA: 0x180E3F770 Slot: 30
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xE3F960 Offset: 0xE3ED60 VA: 0x180E3F960 Slot: 31
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xE3F830 Offset: 0xE3EC30 VA: 0x180E3F830 Slot: 32
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xE3F650 Offset: 0xE3EA50 VA: 0x180E3F650 Slot: 33
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xE3F5E0 Offset: 0xE3E9E0 VA: 0x180E3F5E0 Slot: 34
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xE3F580 Offset: 0xE3E980 VA: 0x180E3F580 Slot: 35
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xE3F890 Offset: 0xE3EC90 VA: 0x180E3F890 Slot: 37
	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

}

public static class JSON // TypeDefIndex: 11578
{	// Fields
	private static readonly Type includeAttrType; // 0x0
	private static readonly Type excludeAttrType; // 0x8
	private static readonly Type decodeAliasAttrType; // 0x10
	private static readonly Dictionary<string, Type> typeCache; // 0x18
	private const BindingFlags instanceBindingFlags = 52;
	private const BindingFlags staticBindingFlags = 56;
	private static readonly MethodInfo decodeTypeMethod; // 0x20
	private static readonly MethodInfo decodeListMethod; // 0x28
	private static readonly MethodInfo decodeDictionaryMethod; // 0x30
	private static readonly MethodInfo decodeArrayMethod; // 0x38
	private static readonly MethodInfo decodeMultiRankArrayMethod; // 0x40

	// Methods

	// RVA: 0x83F1B0 Offset: 0x83E5B0 VA: 0x18083F1B0
	public static Variant Load(string json) { }

	// RVA: 0x83EF90 Offset: 0x83E390 VA: 0x18083EF90
	public static string Dump(object data) { }

	// RVA: 0x83EDA0 Offset: 0x83E1A0 VA: 0x18083EDA0
	public static string Dump(object data, EncodeOptions options) { }

	// RVA: -1 Offset: -1
	public static void MakeInto<T>(Variant data, out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E83B0 Offset: 0x5E77B0 VA: 0x1805E83B0
	|-JSON.MakeInto<object>
	*/

	// RVA: 0x83EFF0 Offset: 0x83E3F0 VA: 0x18083EFF0
	private static Type FindType(string fullName) { }

	[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private static T DecodeType<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5690 Offset: 0xBD4A90 VA: 0x180BD5690
	|-JSON.DecodeType<bool>
	|
	|-RVA: 0xBD7670 Offset: 0xBD6A70 VA: 0x180BD7670
	|-JSON.DecodeType<Decimal>
	|
	|-RVA: 0xBD9630 Offset: 0xBD8A30 VA: 0x180BD9630
	|-JSON.DecodeType<double>
	|
	|-RVA: 0x14AED60 Offset: 0x14AE160 VA: 0x1814AED60
	|-JSON.DecodeType<short>
	|
	|-RVA: 0x14B0D30 Offset: 0x14B0130 VA: 0x1814B0D30
	|-JSON.DecodeType<int>
	|
	|-RVA: 0x14B2CD0 Offset: 0x14B20D0 VA: 0x1814B2CD0
	|-JSON.DecodeType<long>
	|
	|-RVA: 0x14B4CA0 Offset: 0x14B40A0 VA: 0x1814B4CA0
	|-JSON.DecodeType<object>
	|
	|-RVA: 0x14B6BC0 Offset: 0x14B5FC0 VA: 0x1814B6BC0
	|-JSON.DecodeType<float>
	|
	|-RVA: 0x14B8B60 Offset: 0x14B7F60 VA: 0x1814B8B60
	|-JSON.DecodeType<ushort>
	|
	|-RVA: 0x14BAB30 Offset: 0x14B9F30 VA: 0x1814BAB30
	|-JSON.DecodeType<uint>
	|
	|-RVA: 0x14BCAD0 Offset: 0x14BBED0 VA: 0x1814BCAD0
	|-JSON.DecodeType<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private static List<T> DecodeList<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A7F50 Offset: 0x12A7350 VA: 0x1812A7F50
	|-JSON.DecodeList<bool>
	|
	|-RVA: 0x12A8140 Offset: 0x12A7540 VA: 0x1812A8140
	|-JSON.DecodeList<Decimal>
	|
	|-RVA: 0x12A8340 Offset: 0x12A7740 VA: 0x1812A8340
	|-JSON.DecodeList<double>
	|
	|-RVA: 0x12A8530 Offset: 0x12A7930 VA: 0x1812A8530
	|-JSON.DecodeList<short>
	|
	|-RVA: 0x12A8720 Offset: 0x12A7B20 VA: 0x1812A8720
	|-JSON.DecodeList<int>
	|
	|-RVA: 0x12A8910 Offset: 0x12A7D10 VA: 0x1812A8910
	|-JSON.DecodeList<long>
	|
	|-RVA: 0x12A8B00 Offset: 0x12A7F00 VA: 0x1812A8B00
	|-JSON.DecodeList<object>
	|
	|-RVA: 0x12A8CF0 Offset: 0x12A80F0 VA: 0x1812A8CF0
	|-JSON.DecodeList<float>
	|
	|-RVA: 0x12A8EE0 Offset: 0x12A82E0 VA: 0x1812A8EE0
	|-JSON.DecodeList<ushort>
	|
	|-RVA: 0x12A90D0 Offset: 0x12A84D0 VA: 0x1812A90D0
	|-JSON.DecodeList<uint>
	|
	|-RVA: 0x12A92C0 Offset: 0x12A86C0 VA: 0x1812A92C0
	|-JSON.DecodeList<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> DecodeDictionary<TKey, TValue>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1565E00 Offset: 0x1565200 VA: 0x181565E00
	|-JSON.DecodeDictionary<bool, bool>
	|
	|-RVA: 0x1566190 Offset: 0x1565590 VA: 0x181566190
	|-JSON.DecodeDictionary<bool, Decimal>
	|
	|-RVA: 0x1566520 Offset: 0x1565920 VA: 0x181566520
	|-JSON.DecodeDictionary<bool, double>
	|
	|-RVA: 0x15668B0 Offset: 0x1565CB0 VA: 0x1815668B0
	|-JSON.DecodeDictionary<bool, short>
	|
	|-RVA: 0x1566C40 Offset: 0x1566040 VA: 0x181566C40
	|-JSON.DecodeDictionary<bool, int>
	|
	|-RVA: 0x1566FD0 Offset: 0x15663D0 VA: 0x181566FD0
	|-JSON.DecodeDictionary<bool, long>
	|
	|-RVA: 0x1567360 Offset: 0x1566760 VA: 0x181567360
	|-JSON.DecodeDictionary<bool, object>
	|
	|-RVA: 0x15676F0 Offset: 0x1566AF0 VA: 0x1815676F0
	|-JSON.DecodeDictionary<bool, float>
	|
	|-RVA: 0x1567A80 Offset: 0x1566E80 VA: 0x181567A80
	|-JSON.DecodeDictionary<bool, ushort>
	|
	|-RVA: 0x1567E10 Offset: 0x1567210 VA: 0x181567E10
	|-JSON.DecodeDictionary<bool, uint>
	|
	|-RVA: 0x15681A0 Offset: 0x15675A0 VA: 0x1815681A0
	|-JSON.DecodeDictionary<bool, ulong>
	|
	|-RVA: 0x1568530 Offset: 0x1567930 VA: 0x181568530
	|-JSON.DecodeDictionary<Decimal, bool>
	|
	|-RVA: 0x15688C0 Offset: 0x1567CC0 VA: 0x1815688C0
	|-JSON.DecodeDictionary<Decimal, Decimal>
	|
	|-RVA: 0x1568C60 Offset: 0x1568060 VA: 0x181568C60
	|-JSON.DecodeDictionary<Decimal, double>
	|
	|-RVA: 0x1568FF0 Offset: 0x15683F0 VA: 0x181568FF0
	|-JSON.DecodeDictionary<Decimal, short>
	|
	|-RVA: 0x1569380 Offset: 0x1568780 VA: 0x181569380
	|-JSON.DecodeDictionary<Decimal, int>
	|
	|-RVA: 0x1569710 Offset: 0x1568B10 VA: 0x181569710
	|-JSON.DecodeDictionary<Decimal, long>
	|
	|-RVA: 0x1569AA0 Offset: 0x1568EA0 VA: 0x181569AA0
	|-JSON.DecodeDictionary<Decimal, object>
	|
	|-RVA: 0x1569E30 Offset: 0x1569230 VA: 0x181569E30
	|-JSON.DecodeDictionary<Decimal, float>
	|
	|-RVA: 0x156A1C0 Offset: 0x15695C0 VA: 0x18156A1C0
	|-JSON.DecodeDictionary<Decimal, ushort>
	|
	|-RVA: 0x156A550 Offset: 0x1569950 VA: 0x18156A550
	|-JSON.DecodeDictionary<Decimal, uint>
	|
	|-RVA: 0x156A8E0 Offset: 0x1569CE0 VA: 0x18156A8E0
	|-JSON.DecodeDictionary<Decimal, ulong>
	|
	|-RVA: 0x156AC70 Offset: 0x156A070 VA: 0x18156AC70
	|-JSON.DecodeDictionary<double, bool>
	|
	|-RVA: 0x156B000 Offset: 0x156A400 VA: 0x18156B000
	|-JSON.DecodeDictionary<double, Decimal>
	|
	|-RVA: 0x156B3A0 Offset: 0x156A7A0 VA: 0x18156B3A0
	|-JSON.DecodeDictionary<double, double>
	|
	|-RVA: 0x156B730 Offset: 0x156AB30 VA: 0x18156B730
	|-JSON.DecodeDictionary<double, short>
	|
	|-RVA: 0x156BAC0 Offset: 0x156AEC0 VA: 0x18156BAC0
	|-JSON.DecodeDictionary<double, int>
	|
	|-RVA: 0x156BE50 Offset: 0x156B250 VA: 0x18156BE50
	|-JSON.DecodeDictionary<double, long>
	|
	|-RVA: 0x156C1E0 Offset: 0x156B5E0 VA: 0x18156C1E0
	|-JSON.DecodeDictionary<double, object>
	|
	|-RVA: 0x156C570 Offset: 0x156B970 VA: 0x18156C570
	|-JSON.DecodeDictionary<double, float>
	|
	|-RVA: 0x156C900 Offset: 0x156BD00 VA: 0x18156C900
	|-JSON.DecodeDictionary<double, ushort>
	|
	|-RVA: 0x156CC90 Offset: 0x156C090 VA: 0x18156CC90
	|-JSON.DecodeDictionary<double, uint>
	|
	|-RVA: 0x156D020 Offset: 0x156C420 VA: 0x18156D020
	|-JSON.DecodeDictionary<double, ulong>
	|
	|-RVA: 0x156D3B0 Offset: 0x156C7B0 VA: 0x18156D3B0
	|-JSON.DecodeDictionary<short, bool>
	|
	|-RVA: 0x156D740 Offset: 0x156CB40 VA: 0x18156D740
	|-JSON.DecodeDictionary<short, Decimal>
	|
	|-RVA: 0x156DAD0 Offset: 0x156CED0 VA: 0x18156DAD0
	|-JSON.DecodeDictionary<short, double>
	|
	|-RVA: 0x156DE60 Offset: 0x156D260 VA: 0x18156DE60
	|-JSON.DecodeDictionary<short, short>
	|
	|-RVA: 0x156E1F0 Offset: 0x156D5F0 VA: 0x18156E1F0
	|-JSON.DecodeDictionary<short, int>
	|
	|-RVA: 0x156E580 Offset: 0x156D980 VA: 0x18156E580
	|-JSON.DecodeDictionary<short, long>
	|
	|-RVA: 0x156E910 Offset: 0x156DD10 VA: 0x18156E910
	|-JSON.DecodeDictionary<short, object>
	|
	|-RVA: 0x156ECA0 Offset: 0x156E0A0 VA: 0x18156ECA0
	|-JSON.DecodeDictionary<short, float>
	|
	|-RVA: 0x156F030 Offset: 0x156E430 VA: 0x18156F030
	|-JSON.DecodeDictionary<short, ushort>
	|
	|-RVA: 0x156F3C0 Offset: 0x156E7C0 VA: 0x18156F3C0
	|-JSON.DecodeDictionary<short, uint>
	|
	|-RVA: 0x156F750 Offset: 0x156EB50 VA: 0x18156F750
	|-JSON.DecodeDictionary<short, ulong>
	|
	|-RVA: 0x156FAE0 Offset: 0x156EEE0 VA: 0x18156FAE0
	|-JSON.DecodeDictionary<int, bool>
	|
	|-RVA: 0x156FE70 Offset: 0x156F270 VA: 0x18156FE70
	|-JSON.DecodeDictionary<int, Decimal>
	|
	|-RVA: 0x1570200 Offset: 0x156F600 VA: 0x181570200
	|-JSON.DecodeDictionary<int, double>
	|
	|-RVA: 0x1570590 Offset: 0x156F990 VA: 0x181570590
	|-JSON.DecodeDictionary<int, short>
	|
	|-RVA: 0x1570920 Offset: 0x156FD20 VA: 0x181570920
	|-JSON.DecodeDictionary<int, int>
	|
	|-RVA: 0x1570CB0 Offset: 0x15700B0 VA: 0x181570CB0
	|-JSON.DecodeDictionary<int, long>
	|
	|-RVA: 0x1571040 Offset: 0x1570440 VA: 0x181571040
	|-JSON.DecodeDictionary<int, object>
	|
	|-RVA: 0x15713D0 Offset: 0x15707D0 VA: 0x1815713D0
	|-JSON.DecodeDictionary<int, float>
	|
	|-RVA: 0x1571760 Offset: 0x1570B60 VA: 0x181571760
	|-JSON.DecodeDictionary<int, ushort>
	|
	|-RVA: 0x1571AF0 Offset: 0x1570EF0 VA: 0x181571AF0
	|-JSON.DecodeDictionary<int, uint>
	|
	|-RVA: 0x1571E80 Offset: 0x1571280 VA: 0x181571E80
	|-JSON.DecodeDictionary<int, ulong>
	|
	|-RVA: 0x1572210 Offset: 0x1571610 VA: 0x181572210
	|-JSON.DecodeDictionary<long, bool>
	|
	|-RVA: 0x15725A0 Offset: 0x15719A0 VA: 0x1815725A0
	|-JSON.DecodeDictionary<long, Decimal>
	|
	|-RVA: 0x1572930 Offset: 0x1571D30 VA: 0x181572930
	|-JSON.DecodeDictionary<long, double>
	|
	|-RVA: 0x1572CC0 Offset: 0x15720C0 VA: 0x181572CC0
	|-JSON.DecodeDictionary<long, short>
	|
	|-RVA: 0x1573050 Offset: 0x1572450 VA: 0x181573050
	|-JSON.DecodeDictionary<long, int>
	|
	|-RVA: 0x15733E0 Offset: 0x15727E0 VA: 0x1815733E0
	|-JSON.DecodeDictionary<long, long>
	|
	|-RVA: 0x1573770 Offset: 0x1572B70 VA: 0x181573770
	|-JSON.DecodeDictionary<long, object>
	|
	|-RVA: 0x1573B00 Offset: 0x1572F00 VA: 0x181573B00
	|-JSON.DecodeDictionary<long, float>
	|
	|-RVA: 0x1573E90 Offset: 0x1573290 VA: 0x181573E90
	|-JSON.DecodeDictionary<long, ushort>
	|
	|-RVA: 0x1574220 Offset: 0x1573620 VA: 0x181574220
	|-JSON.DecodeDictionary<long, uint>
	|
	|-RVA: 0x15745B0 Offset: 0x15739B0 VA: 0x1815745B0
	|-JSON.DecodeDictionary<long, ulong>
	|
	|-RVA: 0x1574940 Offset: 0x1573D40 VA: 0x181574940
	|-JSON.DecodeDictionary<object, bool>
	|
	|-RVA: 0x1574CE0 Offset: 0x15740E0 VA: 0x181574CE0
	|-JSON.DecodeDictionary<object, Decimal>
	|
	|-RVA: 0x1575080 Offset: 0x1574480 VA: 0x181575080
	|-JSON.DecodeDictionary<object, double>
	|
	|-RVA: 0x1575420 Offset: 0x1574820 VA: 0x181575420
	|-JSON.DecodeDictionary<object, short>
	|
	|-RVA: 0x15757C0 Offset: 0x1574BC0 VA: 0x1815757C0
	|-JSON.DecodeDictionary<object, int>
	|
	|-RVA: 0x1575B60 Offset: 0x1574F60 VA: 0x181575B60
	|-JSON.DecodeDictionary<object, long>
	|
	|-RVA: 0x1575F00 Offset: 0x1575300 VA: 0x181575F00
	|-JSON.DecodeDictionary<object, object>
	|
	|-RVA: 0x15762A0 Offset: 0x15756A0 VA: 0x1815762A0
	|-JSON.DecodeDictionary<object, float>
	|
	|-RVA: 0x1576640 Offset: 0x1575A40 VA: 0x181576640
	|-JSON.DecodeDictionary<object, ushort>
	|
	|-RVA: 0x15769E0 Offset: 0x1575DE0 VA: 0x1815769E0
	|-JSON.DecodeDictionary<object, uint>
	|
	|-RVA: 0x1576D80 Offset: 0x1576180 VA: 0x181576D80
	|-JSON.DecodeDictionary<object, ulong>
	|
	|-RVA: 0x1577120 Offset: 0x1576520 VA: 0x181577120
	|-JSON.DecodeDictionary<float, bool>
	|
	|-RVA: 0x15774B0 Offset: 0x15768B0 VA: 0x1815774B0
	|-JSON.DecodeDictionary<float, Decimal>
	|
	|-RVA: 0x1577850 Offset: 0x1576C50 VA: 0x181577850
	|-JSON.DecodeDictionary<float, double>
	|
	|-RVA: 0x1577BE0 Offset: 0x1576FE0 VA: 0x181577BE0
	|-JSON.DecodeDictionary<float, short>
	|
	|-RVA: 0x1577F70 Offset: 0x1577370 VA: 0x181577F70
	|-JSON.DecodeDictionary<float, int>
	|
	|-RVA: 0x1578300 Offset: 0x1577700 VA: 0x181578300
	|-JSON.DecodeDictionary<float, long>
	|
	|-RVA: 0x1578690 Offset: 0x1577A90 VA: 0x181578690
	|-JSON.DecodeDictionary<float, object>
	|
	|-RVA: 0x1578A20 Offset: 0x1577E20 VA: 0x181578A20
	|-JSON.DecodeDictionary<float, float>
	|
	|-RVA: 0x1578DB0 Offset: 0x15781B0 VA: 0x181578DB0
	|-JSON.DecodeDictionary<float, ushort>
	|
	|-RVA: 0x1579140 Offset: 0x1578540 VA: 0x181579140
	|-JSON.DecodeDictionary<float, uint>
	|
	|-RVA: 0x15794D0 Offset: 0x15788D0 VA: 0x1815794D0
	|-JSON.DecodeDictionary<float, ulong>
	|
	|-RVA: 0x1579860 Offset: 0x1578C60 VA: 0x181579860
	|-JSON.DecodeDictionary<ushort, bool>
	|
	|-RVA: 0x1579BF0 Offset: 0x1578FF0 VA: 0x181579BF0
	|-JSON.DecodeDictionary<ushort, Decimal>
	|
	|-RVA: 0x1579F80 Offset: 0x1579380 VA: 0x181579F80
	|-JSON.DecodeDictionary<ushort, double>
	|
	|-RVA: 0x157A310 Offset: 0x1579710 VA: 0x18157A310
	|-JSON.DecodeDictionary<ushort, short>
	|
	|-RVA: 0x157A6A0 Offset: 0x1579AA0 VA: 0x18157A6A0
	|-JSON.DecodeDictionary<ushort, int>
	|
	|-RVA: 0x157AA30 Offset: 0x1579E30 VA: 0x18157AA30
	|-JSON.DecodeDictionary<ushort, long>
	|
	|-RVA: 0x157ADC0 Offset: 0x157A1C0 VA: 0x18157ADC0
	|-JSON.DecodeDictionary<ushort, object>
	|
	|-RVA: 0x157B150 Offset: 0x157A550 VA: 0x18157B150
	|-JSON.DecodeDictionary<ushort, float>
	|
	|-RVA: 0x157B4E0 Offset: 0x157A8E0 VA: 0x18157B4E0
	|-JSON.DecodeDictionary<ushort, ushort>
	|
	|-RVA: 0x157B870 Offset: 0x157AC70 VA: 0x18157B870
	|-JSON.DecodeDictionary<ushort, uint>
	|
	|-RVA: 0x157BC00 Offset: 0x157B000 VA: 0x18157BC00
	|-JSON.DecodeDictionary<ushort, ulong>
	|
	|-RVA: 0x157BF90 Offset: 0x157B390 VA: 0x18157BF90
	|-JSON.DecodeDictionary<uint, bool>
	|
	|-RVA: 0x157C320 Offset: 0x157B720 VA: 0x18157C320
	|-JSON.DecodeDictionary<uint, Decimal>
	|
	|-RVA: 0x157C6B0 Offset: 0x157BAB0 VA: 0x18157C6B0
	|-JSON.DecodeDictionary<uint, double>
	|
	|-RVA: 0x157CA40 Offset: 0x157BE40 VA: 0x18157CA40
	|-JSON.DecodeDictionary<uint, short>
	|
	|-RVA: 0x157CDD0 Offset: 0x157C1D0 VA: 0x18157CDD0
	|-JSON.DecodeDictionary<uint, int>
	|
	|-RVA: 0x157D160 Offset: 0x157C560 VA: 0x18157D160
	|-JSON.DecodeDictionary<uint, long>
	|
	|-RVA: 0xCFA990 Offset: 0xCF9D90 VA: 0x180CFA990
	|-JSON.DecodeDictionary<uint, object>
	|
	|-RVA: 0xCFAD20 Offset: 0xCFA120 VA: 0x180CFAD20
	|-JSON.DecodeDictionary<uint, float>
	|
	|-RVA: 0xCFB0B0 Offset: 0xCFA4B0 VA: 0x180CFB0B0
	|-JSON.DecodeDictionary<uint, ushort>
	|
	|-RVA: 0xCFB440 Offset: 0xCFA840 VA: 0x180CFB440
	|-JSON.DecodeDictionary<uint, uint>
	|
	|-RVA: 0xCFB7D0 Offset: 0xCFABD0 VA: 0x180CFB7D0
	|-JSON.DecodeDictionary<uint, ulong>
	|
	|-RVA: 0xCFBB60 Offset: 0xCFAF60 VA: 0x180CFBB60
	|-JSON.DecodeDictionary<ulong, bool>
	|
	|-RVA: 0xCFBEF0 Offset: 0xCFB2F0 VA: 0x180CFBEF0
	|-JSON.DecodeDictionary<ulong, Decimal>
	|
	|-RVA: 0xCFC280 Offset: 0xCFB680 VA: 0x180CFC280
	|-JSON.DecodeDictionary<ulong, double>
	|
	|-RVA: 0xCFC610 Offset: 0xCFBA10 VA: 0x180CFC610
	|-JSON.DecodeDictionary<ulong, short>
	|
	|-RVA: 0xCFC9A0 Offset: 0xCFBDA0 VA: 0x180CFC9A0
	|-JSON.DecodeDictionary<ulong, int>
	|
	|-RVA: 0xCFCD30 Offset: 0xCFC130 VA: 0x180CFCD30
	|-JSON.DecodeDictionary<ulong, long>
	|
	|-RVA: 0xCFD0C0 Offset: 0xCFC4C0 VA: 0x180CFD0C0
	|-JSON.DecodeDictionary<ulong, object>
	|
	|-RVA: 0xCFD450 Offset: 0xCFC850 VA: 0x180CFD450
	|-JSON.DecodeDictionary<ulong, float>
	|
	|-RVA: 0xCFD7E0 Offset: 0xCFCBE0 VA: 0x180CFD7E0
	|-JSON.DecodeDictionary<ulong, ushort>
	|
	|-RVA: 0xCFDB70 Offset: 0xCFCF70 VA: 0x180CFDB70
	|-JSON.DecodeDictionary<ulong, uint>
	|
	|-RVA: 0xCFDF00 Offset: 0xCFD300 VA: 0x180CFDF00
	|-JSON.DecodeDictionary<ulong, ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private static T[] DecodeArray<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA0FA0 Offset: 0x1AA03A0 VA: 0x181AA0FA0
	|-JSON.DecodeArray<bool>
	|
	|-RVA: 0x1AA11C0 Offset: 0x1AA05C0 VA: 0x181AA11C0
	|-JSON.DecodeArray<Decimal>
	|
	|-RVA: 0x1AA1400 Offset: 0x1AA0800 VA: 0x181AA1400
	|-JSON.DecodeArray<double>
	|
	|-RVA: 0x1AA1630 Offset: 0x1AA0A30 VA: 0x181AA1630
	|-JSON.DecodeArray<short>
	|
	|-RVA: 0x1AA1850 Offset: 0x1AA0C50 VA: 0x181AA1850
	|-JSON.DecodeArray<int>
	|
	|-RVA: 0x1AA1A70 Offset: 0x1AA0E70 VA: 0x181AA1A70
	|-JSON.DecodeArray<long>
	|
	|-RVA: 0x1AA1C90 Offset: 0x1AA1090 VA: 0x181AA1C90
	|-JSON.DecodeArray<object>
	|
	|-RVA: 0x1AA1EA0 Offset: 0x1AA12A0 VA: 0x181AA1EA0
	|-JSON.DecodeArray<float>
	|
	|-RVA: 0x1AA20D0 Offset: 0x1AA14D0 VA: 0x181AA20D0
	|-JSON.DecodeArray<ushort>
	|
	|-RVA: 0x1AA22F0 Offset: 0x1AA16F0 VA: 0x181AA22F0
	|-JSON.DecodeArray<uint>
	|
	|-RVA: 0x1AA2510 Offset: 0x1AA1910 VA: 0x181AA2510
	|-JSON.DecodeArray<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private static void DecodeMultiRankArray<T>(ProxyArray arrayData, Array array, int arrayRank, int[] indices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E8200 Offset: 0x5E7600 VA: 0x1805E8200
	|-JSON.DecodeMultiRankArray<object>
	*/

	[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void SupportTypeForAOT<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E8430 Offset: 0x5E7830 VA: 0x1805E8430
	|-JSON.SupportTypeForAOT<bool>
	|
	|-RVA: 0x5E8560 Offset: 0x5E7960 VA: 0x1805E8560
	|-JSON.SupportTypeForAOT<Decimal>
	|
	|-RVA: 0x5E8690 Offset: 0x5E7A90 VA: 0x1805E8690
	|-JSON.SupportTypeForAOT<double>
	|
	|-RVA: 0x5E87C0 Offset: 0x5E7BC0 VA: 0x1805E87C0
	|-JSON.SupportTypeForAOT<short>
	|
	|-RVA: 0x5E88F0 Offset: 0x5E7CF0 VA: 0x1805E88F0
	|-JSON.SupportTypeForAOT<int>
	|
	|-RVA: 0x5E8A20 Offset: 0x5E7E20 VA: 0x1805E8A20
	|-JSON.SupportTypeForAOT<long>
	|
	|-RVA: 0x5E8B50 Offset: 0x5E7F50 VA: 0x1805E8B50
	|-JSON.SupportTypeForAOT<object>
	|-JSON.SupportTypeForAOT<string>
	|
	|-RVA: 0x5E8C80 Offset: 0x5E8080 VA: 0x1805E8C80
	|-JSON.SupportTypeForAOT<float>
	|
	|-RVA: 0x5E8DB0 Offset: 0x5E81B0 VA: 0x1805E8DB0
	|-JSON.SupportTypeForAOT<ushort>
	|
	|-RVA: 0x5E8EE0 Offset: 0x5E82E0 VA: 0x1805E8EE0
	|-JSON.SupportTypeForAOT<uint>
	|
	|-RVA: 0x5E9010 Offset: 0x5E8410 VA: 0x1805E9010
	|-JSON.SupportTypeForAOT<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x83F220 Offset: 0x83E620 VA: 0x18083F220
	private static void SupportValueTypesForAOT() { }

	// RVA: 0x83F2F0 Offset: 0x83E6F0 VA: 0x18083F2F0
	private static void .cctor() { }

}

