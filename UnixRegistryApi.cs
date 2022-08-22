internal class UnixRegistryApi : IRegistryApi // TypeDefIndex: 109
{
	private static string ToUnix(string keyname) { }

	private static bool IsWellKnownKey(string parentKeyName, string keyname) { }

	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable) { }

	public void Flush(RegistryKey rkey) { }

	public void Close(RegistryKey rkey) { }

	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	public string[] GetSubKeyNames(RegistryKey rkey) { }

	public string ToString(RegistryKey rkey) { }

	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable) { }

	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile) { }

	public IntPtr GetHandle(RegistryKey key) { }

	public void .ctor() { }

}

