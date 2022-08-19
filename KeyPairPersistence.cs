internal class KeyPairPersistence // TypeDefIndex: 65
{	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x17444D0 Offset: 0x17438D0 VA: 0x1817444D0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1744600 Offset: 0x1743A00 VA: 0x181744600
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x17448A0 Offset: 0x1743CA0 VA: 0x1817448A0
	public string get_Filename() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_KeyValue() { }

	// RVA: 0x17454F0 Offset: 0x17448F0 VA: 0x1817454F0
	public void set_KeyValue(string value) { }

	// RVA: 0x1743D50 Offset: 0x1743150 VA: 0x181743D50
	public bool Load() { }

	// RVA: 0x17440E0 Offset: 0x17434E0 VA: 0x1817440E0
	public void Save() { }

	// RVA: 0x17440C0 Offset: 0x17434C0 VA: 0x1817440C0
	public void Remove() { }

	// RVA: 0x1744FC0 Offset: 0x17443C0 VA: 0x181744FC0
	private static string get_UserPath() { }

	// RVA: 0x1744A50 Offset: 0x1743E50 VA: 0x181744A50
	private static string get_MachinePath() { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760
	internal static bool _CanSecure(string root) { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760
	internal static bool _ProtectUser(string path) { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760
	internal static bool _ProtectMachine(string path) { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760
	internal static bool _IsUserProtected(string path) { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760
	internal static bool _IsMachineProtected(string path) { }

	// RVA: 0x17439B0 Offset: 0x1742DB0 VA: 0x1817439B0
	private static bool CanSecure(string path) { }

	// RVA: 0x1744030 Offset: 0x1743430 VA: 0x181744030
	private static bool ProtectUser(string path) { }

	// RVA: 0x1743FA0 Offset: 0x17433A0 VA: 0x181743FA0
	private static bool ProtectMachine(string path) { }

	// RVA: 0x1743CC0 Offset: 0x17430C0 VA: 0x181743CC0
	private static bool IsUserProtected(string path) { }

	// RVA: 0x1743C30 Offset: 0x1743030 VA: 0x181743C30
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x1744730 Offset: 0x1743B30 VA: 0x181744730
	private bool get_CanChange() { }

	// RVA: 0x1744F80 Offset: 0x1744380 VA: 0x181744F80
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x1744FA0 Offset: 0x17443A0 VA: 0x181744FA0
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x1744740 Offset: 0x1743B40 VA: 0x181744740
	private string get_ContainerName() { }

	// RVA: 0x1743A60 Offset: 0x1742E60 VA: 0x181743A60
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x1743B10 Offset: 0x1742F10 VA: 0x181743B10
	private void FromXml(string xml) { }

	// RVA: 0x17442C0 Offset: 0x17436C0 VA: 0x1817442C0
	private string ToXml() { }

	// RVA: 0x1744470 Offset: 0x1743870 VA: 0x181744470
	private static void .cctor() { }

}

