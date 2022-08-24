internal class Win32RegistryApi : IRegistryApi // TypeDefIndex: 110
{
	private readonly int NativeBytesPerCharacter; 


	private static extern int RegCloseKey(IntPtr keyHandle) { }

	private static extern int RegFlushKey(IntPtr keyHandle) { }

	private static extern int RegOpenKeyEx(IntPtr keyBase, string keyName, IntPtr reserved, int access, out IntPtr keyHandle) { }

	internal static extern int RegEnumKeyEx(IntPtr keyHandle, int dwIndex, char* lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, IntPtr zero, ref int dataSize) { }

	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, [Out] byte[] data, ref int dataSize) { }

	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref int data, ref int dataSize) { }

	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref long data, ref int dataSize) { }

	internal static extern int RegQueryInfoKey(IntPtr hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	public IntPtr GetHandle(RegistryKey key) { }

	private static bool IsHandleValid(RegistryKey key) { }

	public object GetValue(RegistryKey rkey, string name, object defaultValue, RegistryValueOptions options) { }

	private int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out byte[] data, int size) { }

	public int SubKeyCount(RegistryKey rkey) { }

	public RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable) { }

	public void Flush(RegistryKey rkey) { }

	public void Close(RegistryKey rkey) { }

	public string[] GetSubKeyNames(RegistryKey rkey) { }

	private void GenerateException(int errorCode) { }

	public string ToString(RegistryKey rkey) { }

	internal static string CombineName(RegistryKey rkey, string localName) { }

	public void .ctor() { }

}

