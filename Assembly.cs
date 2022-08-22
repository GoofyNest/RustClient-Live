public class AssemblyLoadEventArgs : EventArgs // TypeDefIndex: 348
{	private Assembly m_loadedAssembly; // 0x10


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
{	public int value__; // 0x0
	public const AssemblyHashAlgorithm None = 0;
	public const AssemblyHashAlgorithm MD5 = 32771;
	public const AssemblyHashAlgorithm SHA1 = 32772;
	public const AssemblyHashAlgorithm SHA256 = 32780;
	public const AssemblyHashAlgorithm SHA384 = 32781;
	public const AssemblyHashAlgorithm SHA512 = 32782;

}

public enum AssemblyVersionCompatibility // TypeDefIndex: 431
{	public int value__; // 0x0
	public const AssemblyVersionCompatibility SameMachine = 1;
	public const AssemblyVersionCompatibility SameProcess = 2;
	public const AssemblyVersionCompatibility SameDomain = 3;

}

public sealed class AssemblyCopyrightAttribute : Attribute // TypeDefIndex: 504
{	private string m_copyright; // 0x10


	public void .ctor(string copyright) { }

}

public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 505
{	private string m_trademark; // 0x10


	public void .ctor(string trademark) { }

}

public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 506
{	private string m_product; // 0x10


	public void .ctor(string product) { }

}

public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 507
{	private string m_company; // 0x10


	public void .ctor(string company) { }

}

public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 508
{	private string m_description; // 0x10


	public void .ctor(string description) { }

}

public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 509
{	private string m_title; // 0x10


	public void .ctor(string title) { }

}

public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 510
{	private string m_configuration; // 0x10


	public void .ctor(string configuration) { }

}

public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 511
{	private string m_defaultAlias; // 0x10


	public void .ctor(string defaultAlias) { }

}

public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 512
{	private string m_informationalVersion; // 0x10


	public void .ctor(string informationalVersion) { }

}

public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 513
{	private string _version; // 0x10


	public void .ctor(string version) { }

}

public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 514
{	private string m_keyFile; // 0x10


	public void .ctor(string keyFile) { }

}

public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 515
{	private bool m_delaySign; // 0x10


	public void .ctor(bool delaySign) { }

}

public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 516
{	private string m_key; // 0x10
	private string m_value; // 0x18


	public void .ctor(string key, string value) { }

}

public enum AssemblyNameFlags // TypeDefIndex: 517
{	public int value__; // 0x0
	public const AssemblyNameFlags None = 0;
	public const AssemblyNameFlags PublicKey = 1;
	public const AssemblyNameFlags EnableJITcompileOptimizer = 16384;
	public const AssemblyNameFlags EnableJITcompileTracking = 32768;
	public const AssemblyNameFlags Retargetable = 256;

}

public enum AssemblyContentType // TypeDefIndex: 518
{	public int value__; // 0x0
	public const AssemblyContentType Default = 0;
	public const AssemblyContentType WindowsRuntime = 1;

}

public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 555
{	internal IntPtr _mono_assembly; // 0x10
	private Assembly.ResolveEventHolder resolve_event_holder; // 0x18
	private object _evidence; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	private bool fromByteArray; // 0x50
	private string assemblyName; // 0x58

	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	public virtual string Location { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual bool ReflectionOnly { get; }
	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[ObsoleteAttribute] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	public static Assembly Load(string assemblyString) { }

	public static Assembly Load(AssemblyName assemblyRef) { }

	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[ObsoleteAttribute] // RVA: 0x9E1B0 Offset: 0x9D5B0 VA: 0x18009E1B0
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
{	private Module module; // 0x68


	public void .ctor(byte* pointer, long length, Module module) { }

	protected override void Dispose(bool disposing) { }

}

public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 558
{	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

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

