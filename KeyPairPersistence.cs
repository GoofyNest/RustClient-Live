internal class KeyPairPersistence // TypeDefIndex: 65
{
	private static bool _userPathExists;
	private static string _userPath;
	private static bool _machinePathExists;
	private static string _machinePath;
	private CspParameters _params;
	private string _keyvalue;
	private string _filename;
	private string _container;
	private static object lockobj;

	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }


	public void .ctor(CspParameters parameters) { }

	public void .ctor(CspParameters parameters, string keyPair) { }

	public string get_Filename() { }

	public string get_KeyValue() { }

	public void set_KeyValue(string value) { }

	public bool Load() { }

	public void Save() { }

	public void Remove() { }

	private static string get_UserPath() { }

	private static string get_MachinePath() { }

	internal static bool _CanSecure(string root) { }

	internal static bool _ProtectUser(string path) { }

	internal static bool _ProtectMachine(string path) { }

	internal static bool _IsUserProtected(string path) { }

	internal static bool _IsMachineProtected(string path) { }

	private static bool CanSecure(string path) { }

	private static bool ProtectUser(string path) { }

	private static bool ProtectMachine(string path) { }

	private static bool IsUserProtected(string path) { }

	private static bool IsMachineProtected(string path) { }

	private bool get_CanChange() { }

	private bool get_UseDefaultKeyContainer() { }

	private bool get_UseMachineKeyStore() { }

	private string get_ContainerName() { }

	private CspParameters Copy(CspParameters p) { }

	private void FromXml(string xml) { }

	private string ToXml() { }

	private static void .cctor() { }

}

