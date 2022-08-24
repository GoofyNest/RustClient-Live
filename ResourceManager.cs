public class ResourceManager // TypeDefIndex: 491
{
	protected string BaseNameField; 
	[ObsoleteAttribute] 
	protected Hashtable ResourceSets; 
	private Dictionary<string, ResourceSet> _resourceSets; 
	private string moduleDir; 
	protected Assembly MainAssembly; 
	private Type _locationInfo; 
	private Type _userResourceSet; 
	private CultureInfo _neutralResourcesCulture; 
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; 
	private bool _ignoreCase; 
	private bool UseManifest; 
	[OptionalFieldAttribute] 
	private bool UseSatelliteAssem; 
	[OptionalFieldAttribute] 
	private UltimateResourceFallbackLocation _fallbackLoc; 
	[OptionalFieldAttribute] 
	private Version _satelliteContractVersion; 
	[OptionalFieldAttribute] 
	private bool _lookedForSatelliteContractVersion; 
	[OptionalFieldAttribute] 
	private Assembly _callingAssembly; 
	[OptionalFieldAttribute] 
	private RuntimeAssembly m_callingAssembly; 
	private IResourceGroveler resourceGroveler; 
	public static readonly int MagicNumber; 
	public static readonly int HeaderVersionNumber; 
	private static readonly Type _minResourceSet; 
	internal static readonly string ResReaderTypeName; 
	internal static readonly string ResSetTypeName; 
	internal static readonly string MscorlibName; 
	internal static readonly int DEBUG; 

public virtual string BaseName { get; }
protected UltimateResourceFallbackLocation FallbackLocation { get; }


private void Init() { }

protected void .ctor() { }

public void .ctor(string baseName, Assembly assembly) { }

public void .ctor(Type resourceSource) { }

	[OnDeserializingAttribute] 
private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] 
private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] 
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
{
	public string lastCultureName; 
	public ResourceSet lastResourceSet; 


public void .ctor() { }

}

internal class ResourceManager.ResourceManagerMediator // TypeDefIndex: 493
{
	private ResourceManager _rm; 

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

