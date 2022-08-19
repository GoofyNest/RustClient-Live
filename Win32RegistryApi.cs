internal class Win32RegistryApi : IRegistryApi // TypeDefIndex: 110
{	// Fields
	private readonly int NativeBytesPerCharacter; // 0x10

	// Methods

	// RVA: 0x164E3B0 Offset: 0x164D7B0 VA: 0x18164E3B0
	private static extern int RegCloseKey(IntPtr keyHandle) { }

	// RVA: 0x164E560 Offset: 0x164D960 VA: 0x18164E560
	private static extern int RegFlushKey(IntPtr keyHandle) { }

	// RVA: 0x164E5E0 Offset: 0x164D9E0 VA: 0x18164E5E0
	private static extern int RegOpenKeyEx(IntPtr keyBase, string keyName, IntPtr reserved, int access, out IntPtr keyHandle) { }

	// RVA: 0x164E430 Offset: 0x164D830 VA: 0x18164E430
	internal static extern int RegEnumKeyEx(IntPtr keyHandle, int dwIndex, char* lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	// RVA: 0x164EB10 Offset: 0x164DF10 VA: 0x18164EB10
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, IntPtr zero, ref int dataSize) { }

	// RVA: 0x164E830 Offset: 0x164DC30 VA: 0x18164E830
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, [Out] byte[] data, ref int dataSize) { }

	// RVA: 0x164E970 Offset: 0x164DD70 VA: 0x18164E970
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref int data, ref int dataSize) { }

	// RVA: 0x164EA40 Offset: 0x164DE40 VA: 0x18164EA40
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref long data, ref int dataSize) { }

	// RVA: 0x164E6A0 Offset: 0x164DAA0 VA: 0x18164E6A0
	internal static extern int RegQueryInfoKey(IntPtr hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	// RVA: 0x164D860 Offset: 0x164CC60 VA: 0x18164D860 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x164E180 Offset: 0x164D580 VA: 0x18164E180
	private static bool IsHandleValid(RegistryKey key) { }

	// RVA: 0x164DC90 Offset: 0x164D090 VA: 0x18164DC90 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x164D670 Offset: 0x164CA70 VA: 0x18164D670
	private int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out byte[] data, int size) { }

	// RVA: 0x164EBE0 Offset: 0x164DFE0 VA: 0x18164EBE0 Slot: 11
	public int SubKeyCount(RegistryKey rkey) { }

	// RVA: 0x164E1A0 Offset: 0x164D5A0 VA: 0x18164E1A0 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable) { }

	// RVA: 0x164D3D0 Offset: 0x164C7D0 VA: 0x18164D3D0 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x164D260 Offset: 0x164C660 VA: 0x18164D260 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x164D8D0 Offset: 0x164CCD0 VA: 0x18164D8D0 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x164D4C0 Offset: 0x164C8C0 VA: 0x18164D4C0
	private void GenerateException(int errorCode) { }

	// RVA: 0x13EF390 Offset: 0x13EE790 VA: 0x1813EF390 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x164D370 Offset: 0x164C770 VA: 0x18164D370
	internal static string CombineName(RegistryKey rkey, string localName) { }

	// RVA: 0x164ED90 Offset: 0x164E190 VA: 0x18164ED90
	public void .ctor() { }

}

