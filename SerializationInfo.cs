public sealed class SerializationInfo // TypeDefIndex: 1058
{	private const int defaultSize = 4;
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

	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }


	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	public string get_FullTypeName() { }

	public string get_AssemblyName() { }

	public void SetType(Type type) { }

	private static bool Compare(byte[] a, byte[] b) { }

	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	public int get_MemberCount() { }

	public Type get_ObjectType() { }

	public bool get_IsFullTypeNameSetExplicit() { }

	public bool get_IsAssemblyNameSetExplicit() { }

	public SerializationInfoEnumerator GetEnumerator() { }

	private void ExpandArrays() { }

	public void AddValue(string name, object value, Type type) { }

	public void AddValue(string name, object value) { }

	public void AddValue(string name, bool value) { }

	public void AddValue(string name, char value) { }

	public void AddValue(string name, byte value) { }

	public void AddValue(string name, short value) { }

	public void AddValue(string name, int value) { }

	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void AddValue(string name, ulong value) { }

	public void AddValue(string name, float value) { }

	public void AddValue(string name, DateTime value) { }

	internal void AddValueInternal(string name, object value, Type type) { }

	internal void UpdateValue(string name, object value, Type type) { }

	private int FindElement(string name) { }

	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	private object GetElementNoThrow(string name, out Type foundType) { }

	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	internal object GetValueNoThrow(string name, Type type) { }

	public bool GetBoolean(string name) { }

	public int GetInt32(string name) { }

	public long GetInt64(string name) { }

	public float GetSingle(string name) { }

	public string GetString(string name) { }

}

