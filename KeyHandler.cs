internal class KeyHandler // TypeDefIndex: 108
{	// Fields
	private static Hashtable key_to_handler; // 0x0
	private static Hashtable dir_to_handler; // 0x8
	public string Dir; // 0x10
	private string ActualDir; // 0x18
	public bool IsVolatile; // 0x20
	private Hashtable values; // 0x28
	private string file; // 0x30
	private bool dirty; // 0x38
	private static string user_store; // 0x10
	private static string machine_store; // 0x18

	// Properties
	public bool IsMarkedForDeletion { get; }
	private static string UserStore { get; }
	private static string MachineStore { get; }

	// Methods

	// RVA: 0x163E1C0 Offset: 0x163D5C0 VA: 0x18163E1C0
	private static void .cctor() { }

	// RVA: 0x163E450 Offset: 0x163D850 VA: 0x18163E450
	private void .ctor(RegistryKey rkey, string basedir) { }

	// RVA: 0x163E2C0 Offset: 0x163D6C0 VA: 0x18163E2C0
	private void .ctor(RegistryKey rkey, string basedir, bool is_volatile) { }

	// RVA: 0x163C770 Offset: 0x163BB70 VA: 0x18163C770
	public void Load() { }

	// RVA: 0x163C2B0 Offset: 0x163B6B0 VA: 0x18163C2B0
	private void LoadKey(SecurityElement se) { }

	// RVA: 0x163B010 Offset: 0x163A410 VA: 0x18163B010
	public RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile) { }

	// RVA: 0x163D0C0 Offset: 0x163C4C0 VA: 0x18163D0C0
	public RegistryKey Probe(RegistryKey rkey, string extra, bool writable) { }

	// RVA: 0x163AB40 Offset: 0x1639F40 VA: 0x18163AB40
	private static string CombineName(RegistryKey rkey, string extra) { }

	// RVA: 0x163BD20 Offset: 0x163B120 VA: 0x18163BD20
	private static long GetSystemBootTime() { }

	// RVA: 0x163B520 Offset: 0x163A920 VA: 0x18163B520
	private static long GetRegisteredBootTime(string path) { }

	// RVA: 0x163D580 Offset: 0x163C980 VA: 0x18163D580
	private static void SaveRegisteredBootTime(string path, long btime) { }

	// RVA: 0x163A8D0 Offset: 0x1639CD0 VA: 0x18163A8D0
	private static void CleanVolatileKeys() { }

	// RVA: 0x163DF80 Offset: 0x163D380 VA: 0x18163DF80
	public static bool VolatileKeyExists(string dir) { }

	// RVA: 0x163C0E0 Offset: 0x163B4E0 VA: 0x18163C0E0
	public static string GetVolatileDir(string dir) { }

	// RVA: 0x163CB70 Offset: 0x163BF70 VA: 0x18163CB70
	public static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting) { }

	// RVA: 0x163B700 Offset: 0x163AB00 VA: 0x18163B700
	private static string GetRootFromDir(string dir) { }

	// RVA: 0x163ABD0 Offset: 0x1639FD0 VA: 0x18163ABD0
	public static void Drop(RegistryKey rkey) { }

	// RVA: 0x163BF20 Offset: 0x163B320 VA: 0x18163BF20
	public object GetValue(string name, RegistryValueOptions options) { }

	// RVA: 0x163B840 Offset: 0x163AC40 VA: 0x18163B840
	public string[] GetSubKeyNames() { }

	// RVA: 0x163B410 Offset: 0x163A810 VA: 0x18163B410
	public void Flush() { }

	// RVA: 0x163DE60 Offset: 0x163D260 VA: 0x18163DE60
	public bool ValueExists(string name) { }

	// RVA: 0x163E470 Offset: 0x163D870 VA: 0x18163E470
	public bool get_IsMarkedForDeletion() { }

	// RVA: 0x163B380 Offset: 0x163A780 VA: 0x18163B380 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x163D6A0 Offset: 0x163CAA0 VA: 0x18163D6A0
	private void Save() { }

	// RVA: 0x163E6C0 Offset: 0x163DAC0 VA: 0x18163E6C0
	private static string get_UserStore() { }

	// RVA: 0x163E500 Offset: 0x163D900 VA: 0x18163E500
	private static string get_MachineStore() { }

}

