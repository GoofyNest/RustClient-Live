public sealed class SerializationInfo // TypeDefIndex: 1058
{	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x12A4630 Offset: 0x12A3A30 VA: 0x1812A4630
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x12A4650 Offset: 0x12A3A50 VA: 0x1812A4650
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_FullTypeName() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public string get_AssemblyName() { }

	// RVA: 0x12A42D0 Offset: 0x12A36D0 VA: 0x1812A42D0
	public void SetType(Type type) { }

	// RVA: 0x12A3190 Offset: 0x12A2590 VA: 0x1812A3190
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x12A3220 Offset: 0x12A2620 VA: 0x1812A3220
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x12A4140 Offset: 0x12A3540 VA: 0x1812A4140
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public int get_MemberCount() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public Type get_ObjectType() { }

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0xAF1470 Offset: 0xAF0870 VA: 0x180AF1470
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x12A3840 Offset: 0x12A2C40 VA: 0x1812A3840
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x12A3230 Offset: 0x12A2630 VA: 0x1812A3230
	private void ExpandArrays() { }

	// RVA: 0x12A2F70 Offset: 0x12A2370 VA: 0x1812A2F70
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x12A2C40 Offset: 0x12A2040 VA: 0x1812A2C40
	public void AddValue(string name, object value) { }

	// RVA: 0x12A24C0 Offset: 0x12A18C0 VA: 0x1812A24C0
	public void AddValue(string name, bool value) { }

	// RVA: 0x12A3050 Offset: 0x12A2450 VA: 0x1812A3050
	public void AddValue(string name, char value) { }

	// RVA: 0x12A2600 Offset: 0x12A1A00 VA: 0x1812A2600
	public void AddValue(string name, byte value) { }

	// RVA: 0x12A2740 Offset: 0x12A1B40 VA: 0x1812A2740
	public void AddValue(string name, short value) { }

	// RVA: 0x12A2880 Offset: 0x12A1C80 VA: 0x1812A2880
	public void AddValue(string name, int value) { }

	// RVA: 0x12A2E30 Offset: 0x12A2230 VA: 0x1812A2E30
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x12A29C0 Offset: 0x12A1DC0 VA: 0x1812A29C0
	public void AddValue(string name, ulong value) { }

	// RVA: 0x12A2370 Offset: 0x12A1770 VA: 0x1812A2370
	public void AddValue(string name, float value) { }

	// RVA: 0x12A2B00 Offset: 0x12A1F00 VA: 0x1812A2B00
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x12A2050 Offset: 0x12A1450 VA: 0x1812A2050
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x12A4470 Offset: 0x12A3870 VA: 0x1812A4470
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x12A3340 Offset: 0x12A2740 VA: 0x1812A3340
	private int FindElement(string name) { }

	// RVA: 0x12A3680 Offset: 0x12A2A80 VA: 0x1812A3680
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x12A3540 Offset: 0x12A2940 VA: 0x1812A3540
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x12A3FB0 Offset: 0x12A33B0 VA: 0x1812A3FB0
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x12A3DF0 Offset: 0x12A31F0 VA: 0x1812A3DF0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x12A33F0 Offset: 0x12A27F0 VA: 0x1812A33F0
	public bool GetBoolean(string name) { }

	// RVA: 0x12A3900 Offset: 0x12A2D00 VA: 0x1812A3900
	public int GetInt32(string name) { }

	// RVA: 0x12A39F0 Offset: 0x12A2DF0 VA: 0x1812A39F0
	public long GetInt64(string name) { }

	// RVA: 0x12A3B40 Offset: 0x12A2F40 VA: 0x1812A3B40
	public float GetSingle(string name) { }

	// RVA: 0x12A3CA0 Offset: 0x12A30A0 VA: 0x1812A3CA0
	public string GetString(string name) { }

}

