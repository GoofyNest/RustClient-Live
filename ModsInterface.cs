public sealed class ModsInterface : Handle // TypeDefIndex: 9015
{
	public const int CopymodinfoApiLatest = 1;
	public const int EnumeratemodsApiLatest = 1;
	public const int InstallmodApiLatest = 1;
	public const int ModIdentifierApiLatest = 1;
	public const int ModinfoApiLatest = 1;
	public const int UninstallmodApiLatest = 1;
	public const int UpdatemodApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyModInfo(ref CopyModInfoOptions options, out Nullable<ModInfo> outEnumeratedMods) { }

	public void EnumerateMods(ref EnumerateModsOptions options, object clientData, OnEnumerateModsCallback completionDelegate) { }

	public void InstallMod(ref InstallModOptions options, object clientData, OnInstallModCallback completionDelegate) { }

	public void UninstallMod(ref UninstallModOptions options, object clientData, OnUninstallModCallback completionDelegate) { }

	public void UpdateMod(ref UpdateModOptions options, object clientData, OnUpdateModCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnEnumerateModsCallbackInternalImplementation(ref EnumerateModsCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnInstallModCallbackInternalImplementation(ref InstallModCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUninstallModCallbackInternalImplementation(ref UninstallModCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUpdateModCallbackInternalImplementation(ref UpdateModCallbackInfoInternal data) { }

}

