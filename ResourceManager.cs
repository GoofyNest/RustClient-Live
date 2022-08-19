public class ResourceManager // TypeDefIndex: 491
{	// Fields
	protected string BaseNameField; // 0x10
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

	// Properties
	public virtual string BaseName { get; }
	protected UltimateResourceFallbackLocation FallbackLocation { get; }

	// Methods

	// RVA: 0xFE8FE0 Offset: 0xFE83E0 VA: 0x180FE8FE0
	private void Init() { }

	// RVA: 0xFE9B30 Offset: 0xFE8F30 VA: 0x180FE9B30
	protected void .ctor() { }

	// RVA: 0xFE9ED0 Offset: 0xFE92D0 VA: 0x180FE9ED0
	public void .ctor(string baseName, Assembly assembly) { }

	// RVA: 0xFE9C30 Offset: 0xFE9030 VA: 0x180FE9C30
	public void .ctor(Type resourceSource) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFE98B0 Offset: 0xFE8CB0 VA: 0x180FE98B0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFE96E0 Offset: 0xFE8AE0 VA: 0x180FE96E0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFE9900 Offset: 0xFE8D00 VA: 0x180FE9900
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0xFE7930 Offset: 0xFE6D30 VA: 0x180FE7930
	private void CommonAssemblyInit() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public virtual string get_BaseName() { }

	// RVA: 0x58DC00 Offset: 0x58D000 VA: 0x18058DC00
	protected UltimateResourceFallbackLocation get_FallbackLocation() { }

	// RVA: 0xFE8110 Offset: 0xFE7510 VA: 0x180FE8110 Slot: 5
	protected virtual string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0xFE7CF0 Offset: 0xFE70F0 VA: 0x180FE7CF0
	internal ResourceSet GetFirstResourceSet(CultureInfo culture) { }

	// RVA: 0xFE8240 Offset: 0xFE7640 VA: 0x180FE8240 Slot: 6
	public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0xFE9080 Offset: 0xFE8480 VA: 0x180FE9080 Slot: 7
	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0xFE90B0 Offset: 0xFE84B0 VA: 0x180FE90B0
	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE77B0 Offset: 0xFE6BB0 VA: 0x180FE77B0
	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs) { }

	// RVA: 0xFE8640 Offset: 0xFE7A40 VA: 0x180FE8640
	protected static Version GetSatelliteContractVersion(Assembly a) { }

	// RVA: 0xFE7AA0 Offset: 0xFE6EA0 VA: 0x180FE7AA0
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void SetAppXConfiguration() { }

	// RVA: 0xFE8B90 Offset: 0xFE7F90 VA: 0x180FE8B90 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0xFE8BB0 Offset: 0xFE7FB0 VA: 0x180FE8BB0 Slot: 9
	public virtual string GetString(string name, CultureInfo culture) { }

	// RVA: 0xFE9980 Offset: 0xFE8D80 VA: 0x180FE9980
	private static void .cctor() { }

}

internal class ResourceManager.CultureNameResourceSetPair // TypeDefIndex: 492
{	// Fields
	public string lastCultureName; // 0x10
	public ResourceSet lastResourceSet; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class ResourceManager.ResourceManagerMediator // TypeDefIndex: 493
{	// Fields
	private ResourceManager _rm; // 0x10

	// Properties
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

	// Methods

	// RVA: 0xFE7560 Offset: 0xFE6960 VA: 0x180FE7560
	internal void .ctor(ResourceManager rm) { }

	// RVA: 0x524970 Offset: 0x523D70 VA: 0x180524970
	internal string get_ModuleDir() { }

	// RVA: 0xFE7630 Offset: 0xFE6A30 VA: 0x180FE7630
	internal Type get_LocationInfo() { }

	// RVA: 0xFE7740 Offset: 0xFE6B40 VA: 0x180FE7740
	internal Type get_UserResourceSet() { }

	// RVA: 0xB242C0 Offset: 0xB236C0 VA: 0x180B242C0
	internal string get_BaseNameField() { }

	// RVA: 0xFE7700 Offset: 0xFE6B00 VA: 0x180FE7700
	internal CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0xFE74D0 Offset: 0xFE68D0 VA: 0x180FE74D0
	internal string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0xFE7650 Offset: 0xFE6A50 VA: 0x180FE7650
	internal bool get_LookedForSatelliteContractVersion() { }

	// RVA: 0xFE7760 Offset: 0xFE6B60 VA: 0x180FE7760
	internal void set_LookedForSatelliteContractVersion(bool value) { }

	// RVA: 0xFE7720 Offset: 0xFE6B20 VA: 0x180FE7720
	internal Version get_SatelliteContractVersion() { }

	// RVA: 0xFE7780 Offset: 0xFE6B80 VA: 0x180FE7780
	internal void set_SatelliteContractVersion(Version value) { }

	// RVA: 0xFE7500 Offset: 0xFE6900 VA: 0x180FE7500
	internal Version ObtainSatelliteContractVersion(Assembly a) { }

	// RVA: 0xFE7610 Offset: 0xFE6A10 VA: 0x180FE7610
	internal UltimateResourceFallbackLocation get_FallbackLoc() { }

	// RVA: 0xFE75F0 Offset: 0xFE69F0 VA: 0x180FE75F0
	internal RuntimeAssembly get_CallingAssembly() { }

	// RVA: 0xFE7670 Offset: 0xFE6A70 VA: 0x180FE7670
	internal RuntimeAssembly get_MainAssembly() { }

	// RVA: 0x5251D0 Offset: 0x5245D0 VA: 0x1805251D0
	internal string get_BaseName() { }

}

