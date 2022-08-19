public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 103
{	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[MonoTODOAttribute] // RVA: 0xE7B80 Offset: 0xE6F80 VA: 0x1800E7B80
	[ComVisibleAttribute] // RVA: 0xE7B80 Offset: 0xE6F80 VA: 0x1800E7B80
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1644420 Offset: 0x1643820 VA: 0x181644420
	private static void .cctor() { }

	// RVA: 0x1644760 Offset: 0x1643B60 VA: 0x181644760
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1644580 Offset: 0x1643980 VA: 0x181644580
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1644520 Offset: 0x1643920 VA: 0x181644520
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x1644060 Offset: 0x1643460 VA: 0x181644060
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x1643900 Offset: 0x1642D00 VA: 0x181643900 Slot: 6
	public void Dispose() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Name() { }

	// RVA: 0x1643A60 Offset: 0x1642E60 VA: 0x181643A60
	public void Flush() { }

	// RVA: 0x16436E0 Offset: 0x1642AE0 VA: 0x1816436E0
	public void Close() { }

	// RVA: 0x1644950 Offset: 0x1643D50 VA: 0x181644950
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x16440E0 Offset: 0x16434E0 VA: 0x1816440E0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x16440F0 Offset: 0x16434F0 VA: 0x1816440F0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x1643EF0 Offset: 0x16432F0 VA: 0x181643EF0
	public object GetValue(string name) { }

	// RVA: 0x1643D70 Offset: 0x1643170 VA: 0x181643D70
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x1643C30 Offset: 0x1643030 VA: 0x181643C30
	public string[] GetSubKeyNames() { }

	// RVA: 0x16442E0 Offset: 0x16436E0 VA: 0x1816442E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x11769F0 Offset: 0x1175DF0 VA: 0x1811769F0
	internal bool get_IsRoot() { }

	// RVA: 0x1644B00 Offset: 0x1643F00 VA: 0x181644B00
	internal RegistryHive get_Hive() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal object get_InternalHandle() { }

	// RVA: 0x1643670 Offset: 0x1642A70 VA: 0x181643670
	private void AssertKeyStillValid() { }

	// RVA: 0x1643600 Offset: 0x1642A00 VA: 0x181643600
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x1643860 Offset: 0x1642C60 VA: 0x181643860
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x1643800 Offset: 0x1642C00 VA: 0x181643800
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x1643AE0 Offset: 0x1642EE0 VA: 0x181643AE0
	private static string GetHiveName(RegistryHive hive) { }

}

