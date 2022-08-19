internal class UnixRegistryApi : IRegistryApi // TypeDefIndex: 109
{	// Methods

	// RVA: 0x164D120 Offset: 0x164C520 VA: 0x18164D120
	private static string ToUnix(string keyname) { }

	// RVA: 0x164CC90 Offset: 0x164C090 VA: 0x18164CC90
	private static bool IsWellKnownKey(string parentKeyName, string keyname) { }

	// RVA: 0x164CDC0 Offset: 0x164C1C0 VA: 0x18164CDC0 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x164CAB0 Offset: 0x164BEB0 VA: 0x18164CAB0 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x164C720 Offset: 0x164BB20 VA: 0x18164C720 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x164CBE0 Offset: 0x164BFE0 VA: 0x18164CBE0 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	// RVA: 0x164CB70 Offset: 0x164BF70 VA: 0x18164CB70 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x13EF390 Offset: 0x13EE790 VA: 0x1813EF390 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x164C920 Offset: 0x164BD20 VA: 0x18164C920
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x164C780 Offset: 0x164BB80 VA: 0x18164C780
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile) { }

	// RVA: 0x164CB20 Offset: 0x164BF20 VA: 0x18164CB20 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

