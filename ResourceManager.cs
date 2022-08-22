public class ResourceManager // TypeDefIndex: 491
{	protected string BaseNameField; // 0x10
	[ObsoleteAttribute] // RVA: 0x96390 Offset: 0x95790 VA: 0x180096390
	protected Hashtable ResourceSets; // 0x18
	private Dictionary<string, ResourceSet> _resourceSets; // 0x20
	private string moduleDir; // 0x28
	protected Assembly MainAssembly; // 0x30
	private Type _locationInfo; // 0x38
	private Type _userResourceSet; // 0x40
	private CultureInfo _neutralResourcesCulture; // 0x48
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; // 0x50
	private bool _ignoreCase; // 0x58
	private bool UseManifest; // 0x59
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	private bool UseSatelliteAssem; // 0x5A
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x5C
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private Version _satelliteContractVersion; // 0x60
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private bool _lookedForSatelliteContractVersion; // 0x68
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	private Assembly _callingAssembly; // 0x70
	[OptionalFieldAttribute] // RVA: 0x7B5F0 Offset: 0x7A9F0 VA: 0x18007B5F0
	private RuntimeAssembly m_callingAssembly; // 0x78
	private IResourceGroveler resourceGroveler; // 0x80
	public static readonly int MagicNumber; // 0x0
	public static readonly int HeaderVersionNumber; // 0x4
	private static readonly Type _minResourceSet; // 0x8
	internal static readonly string ResReaderTypeName; // 0x10
	internal static readonly string ResSetTypeName; // 0x18
	internal static readonly string MscorlibName; // 0x20
	internal static readonly int DEBUG; // 0x28

	public virtual string BaseName { get; }
	protected UltimateResourceFallbackLocation FallbackLocation { get; }


	private void Init() { }

	protected void .ctor() { }

	public void .ctor(string baseName, Assembly assembly) { }

	public void .ctor(Type resourceSource) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnSerializing(StreamingContext ctx) { }

	private void CommonAssemblyInit() { }

	public virtual string get_BaseName() { }

	protected UltimateResourceFallbackLocation get_FallbackLocation() { }

	protected virtual string GetResourceFileName(CultureInfo culture) { }

	internal ResourceSet GetFirstResourceSet(CultureInfo culture) { }

	public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark) { }

	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs) { }

	protected static Version GetSatelliteContractVersion(Assembly a) { }

	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	private void SetAppXConfiguration() { }

	public virtual string GetString(string name) { }

	public virtual string GetString(string name, CultureInfo culture) { }

	private static void .cctor() { }

}

internal class ResourceManager.CultureNameResourceSetPair // TypeDefIndex: 492
{	public string lastCultureName; // 0x10
	public ResourceSet lastResourceSet; // 0x18


	public void .ctor() { }

}

internal class ResourceManager.ResourceManagerMediator // TypeDefIndex: 493
{	private ResourceManager _rm; // 0x10

	internal string ModuleDir { get; }
	internal Type LocationInfo { get; }
	internal Type UserResourceSet { get; }
	internal string BaseNameField { get; }
	internal CultureInfo NeutralResourcesCulture { get; }
	internal bool LookedForSatelliteContractVersion { get; set; }
	internal Version SatelliteContractVersion { get; set; }
	internal UltimateResourceFallbackLocation FallbackLoc { get; }
	internal RuntimeAssembly CallingAssembly { get; }
	internal RuntimeAssembly MainAssembly { get; }
	internal string BaseName { get; }


	internal void .ctor(ResourceManager rm) { }

	internal string get_ModuleDir() { }

	internal Type get_LocationInfo() { }

	internal Type get_UserResourceSet() { }

	internal string get_BaseNameField() { }

	internal CultureInfo get_NeutralResourcesCulture() { }

	internal string GetResourceFileName(CultureInfo culture) { }

	internal bool get_LookedForSatelliteContractVersion() { }

	internal void set_LookedForSatelliteContractVersion(bool value) { }

	internal Version get_SatelliteContractVersion() { }

	internal void set_SatelliteContractVersion(Version value) { }

	internal Version ObtainSatelliteContractVersion(Assembly a) { }

	internal UltimateResourceFallbackLocation get_FallbackLoc() { }

	internal RuntimeAssembly get_CallingAssembly() { }

	internal RuntimeAssembly get_MainAssembly() { }

	internal string get_BaseName() { }

}

