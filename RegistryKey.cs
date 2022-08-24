public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 103
{
	private object handle; 
	private SafeRegistryHandle safe_handle; 
	private object hive; 
	private readonly string qname; 
	private readonly bool isRemoteRoot; 
	private readonly bool isWritable; 
	private static readonly IRegistryApi RegistryApi; 

	public string Name { get; }
	[MonoTODOAttribute] 
	[ComVisibleAttribute] 
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }


	private static void .cctor() { }

	internal void .ctor(RegistryHive hiveId) { }

	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	internal void .ctor(object data, string keyName, bool writable) { }

	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	public void Dispose() { }

	public string get_Name() { }

	public void Flush() { }

	public void Close() { }

	public SafeRegistryHandle get_Handle() { }

	public RegistryKey OpenSubKey(string name) { }

	public RegistryKey OpenSubKey(string name, bool writable) { }

	public object GetValue(string name) { }

	public object GetValue(string name, object defaultValue) { }

	public string[] GetSubKeyNames() { }

	public override string ToString() { }

	internal bool get_IsRoot() { }

	internal RegistryHive get_Hive() { }

	internal object get_InternalHandle() { }

	private void AssertKeyStillValid() { }

	private void AssertKeyNameLength(string name) { }

	internal static string DecodeString(byte[] data) { }

	internal static IOException CreateMarkedForDeletionException() { }

	private static string GetHiveName(RegistryHive hive) { }

}

