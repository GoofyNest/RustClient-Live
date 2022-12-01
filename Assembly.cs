public class AssemblyLoadEventArgs : EventArgs // TypeDefIndex: 348
{
	private Assembly m_loadedAssembly;


	public void .ctor(Assembly loadedAssembly) { }

}

public sealed class AssemblyLoadEventHandler : MulticastDelegate // TypeDefIndex: 349
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }

	public virtual IAsyncResult BeginInvoke(object sender, AssemblyLoadEventArgs args, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum AssemblyHashAlgorithm // TypeDefIndex: 430
{
	public int value__;
	public const AssemblyHashAlgorithm None = 0;
	public const AssemblyHashAlgorithm MD5 = 32771;
	public const AssemblyHashAlgorithm SHA1 = 32772;
	public const AssemblyHashAlgorithm SHA256 = 32780;
	public const AssemblyHashAlgorithm SHA384 = 32781;
	public const AssemblyHashAlgorithm SHA512 = 32782;

}

public enum AssemblyVersionCompatibility // TypeDefIndex: 431
{
	public int value__;
	public const AssemblyVersionCompatibility SameMachine = 1;
	public const AssemblyVersionCompatibility SameProcess = 2;
	public const AssemblyVersionCompatibility SameDomain = 3;

}

public sealed class AssemblyCopyrightAttribute : Attribute // TypeDefIndex: 504
{
	private string m_copyright;


	public void .ctor(string copyright) { }

}

public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 505
{
	private string m_trademark;


	public void .ctor(string trademark) { }

}

public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 506
{
	private string m_product;


	public void .ctor(string product) { }

}

public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 507
{
	private string m_company;


	public void .ctor(string company) { }

}

public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 508
{
	private string m_description;


	public void .ctor(string description) { }

}

public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 509
{
	private string m_title;


	public void .ctor(string title) { }

}

public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 510
{
	private string m_configuration;


	public void .ctor(string configuration) { }

}

public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 511
{
	private string m_defaultAlias;


	public void .ctor(string defaultAlias) { }

}

public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 512
{
	private string m_informationalVersion;


	public void .ctor(string informationalVersion) { }

}

public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 513
{
	private string _version;


	public void .ctor(string version) { }

}

public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 514
{
	private string m_keyFile;


	public void .ctor(string keyFile) { }

}

public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 515
{
	private bool m_delaySign;


	public void .ctor(bool delaySign) { }

}

public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 516
{
	private string m_key;
	private string m_value;


	public void .ctor(string key, string value) { }

}

public enum AssemblyNameFlags // TypeDefIndex: 517
{
	public int value__;
	public const AssemblyNameFlags None = 0;
	public const AssemblyNameFlags PublicKey = 1;
	public const AssemblyNameFlags EnableJITcompileOptimizer = 16384;
	public const AssemblyNameFlags EnableJITcompileTracking = 32768;
	public const AssemblyNameFlags Retargetable = 256;

}

public enum AssemblyContentType // TypeDefIndex: 518
{
	public int value__;
	public const AssemblyContentType Default = 0;
	public const AssemblyContentType WindowsRuntime = 1;

}

public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 555
{
	internal IntPtr _mono_assembly;
	private Assembly.ResolveEventHolder resolve_event_holder;
	private object _evidence;
	private object _minimum;
	private object _optional;
	private object _refuse;
	private object _granted;
	private object _denied;
	private bool fromByteArray;
	private string assemblyName;

	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	public virtual string Location { get; }
	[ComVisibleAttribute]
	public virtual bool ReflectionOnly { get; }
	[MonoTODOAttribute]
	public bool IsFullyTrusted { get; }


	protected void .ctor() { }

	private string get_code_base(bool escaped) { }

	private string get_fullname() { }

	private string get_location() { }

	internal static string GetAotId() { }

	private string GetCodeBase(bool escaped) { }

	public virtual string get_CodeBase() { }

	public virtual string get_FullName() { }

	public virtual string get_Location() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual object[] GetCustomAttributes(bool inherit) { }

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	private object GetFilesInternal(string name, bool getResourceModules) { }

	public virtual FileStream GetFile(string name) { }

	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	public virtual Stream GetManifestResourceStream(string name) { }

	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	internal string GetSimpleName() { }

	internal byte[] GetPublicKey() { }

	internal Version GetVersion() { }

	private AssemblyNameFlags GetFlags() { }

	internal virtual Type[] GetTypes(bool exportedOnly) { }

	public virtual Type[] GetTypes() { }

	public virtual Type GetType(string name, bool throwOnError) { }

	public virtual Type GetType(string name) { }

	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	public virtual AssemblyName GetName(bool copiedName) { }

	public virtual AssemblyName GetName() { }

	public override string ToString() { }

	public static Assembly GetAssembly(Type type) { }

	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	private static Assembly LoadFrom(string assemblyFile, bool refonly) { }

	public static Assembly LoadFrom(string assemblyFile) { }

	[ObsoleteAttribute]
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	public static Assembly Load(string assemblyString) { }

	public static Assembly Load(AssemblyName assemblyRef) { }

	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[ObsoleteAttribute]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	internal virtual Module[] GetModulesInternal() { }

	public virtual string[] GetManifestResourceNames() { }

	public static Assembly GetExecutingAssembly() { }

	public static Assembly GetCallingAssembly() { }

	internal static IntPtr InternalGetReferencedAssemblies(Assembly module) { }

	internal static AssemblyName[] GetReferencedAssemblies(Assembly module) { }

	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	public virtual bool get_ReflectionOnly() { }

	public override int GetHashCode() { }

	public override bool Equals(object o) { }

	private static Exception CreateNIE() { }

	public bool get_IsFullyTrusted() { }

	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	public virtual Module GetModule(string name) { }

	public virtual AssemblyName[] GetReferencedAssemblies() { }

	public virtual Module[] GetModules(bool getResourceModules) { }

	public static bool op_Equality(Assembly left, Assembly right) { }

	public static bool op_Inequality(Assembly left, Assembly right) { }

}

internal class Assembly.ResolveEventHolder // TypeDefIndex: 556
{

	public void .ctor() { }

}

internal class Assembly.UnmanagedMemoryStreamForModule : UnmanagedMemoryStream // TypeDefIndex: 557
{
	private Module module;


	public void .ctor(byte* pointer, long length, Module module) { }

	protected override void Dispose(bool disposing) { }

}

public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 558
{
	private string name;
	private string codebase;
	private int major;
	private int minor;
	private int build;
	private int revision;
	private CultureInfo cultureinfo;
	private AssemblyNameFlags flags;
	private AssemblyHashAlgorithm hashalg;
	private StrongNameKeyPair keypair;
	private byte[] publicKey;
	private byte[] keyToken;
	private AssemblyVersionCompatibility versioncompat;
	private Version version;
	private ProcessorArchitecture processor_architecture;
	private AssemblyContentType contentType;

	public string Name { get; set; }
	public string CodeBase { get; }
	public CultureInfo CultureInfo { get; set; }
	public AssemblyNameFlags Flags { get; set; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }


	public void .ctor() { }

	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	public void .ctor(string assemblyName) { }

	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	public string get_Name() { }

	public void set_Name(string value) { }

	public string get_CodeBase() { }

	public CultureInfo get_CultureInfo() { }

	public void set_CultureInfo(CultureInfo value) { }

	public AssemblyNameFlags get_Flags() { }

	public void set_Flags(AssemblyNameFlags value) { }

	public string get_FullName() { }

	public Version get_Version() { }

	public void set_Version(Version value) { }

	public override string ToString() { }

	public byte[] GetPublicKey() { }

	public byte[] GetPublicKeyToken() { }

	private bool get_IsPublicKeyValid() { }

	private byte[] InternalGetPublicKeyToken() { }

	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	private byte[] ComputePublicKeyToken() { }

	public void SetPublicKey(byte[] publicKey) { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public object Clone() { }

	public void OnDeserialization(object sender) { }

	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

}

