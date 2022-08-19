public class AssemblyLoadEventArgs : EventArgs // TypeDefIndex: 348
{	// Fields
	private Assembly m_loadedAssembly; // 0x10

	// Methods

	// RVA: 0x15889E0 Offset: 0x1587DE0 VA: 0x1815889E0
	public void .ctor(Assembly loadedAssembly) { }

}

public sealed class AssemblyLoadEventHandler : MulticastDelegate // TypeDefIndex: 349
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, AssemblyLoadEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum AssemblyHashAlgorithm // TypeDefIndex: 430
{	// Fields
	public int value__; // 0x0
	public const AssemblyHashAlgorithm None = 0;
	public const AssemblyHashAlgorithm MD5 = 32771;
	public const AssemblyHashAlgorithm SHA1 = 32772;
	public const AssemblyHashAlgorithm SHA256 = 32780;
	public const AssemblyHashAlgorithm SHA384 = 32781;
	public const AssemblyHashAlgorithm SHA512 = 32782;

}

public enum AssemblyVersionCompatibility // TypeDefIndex: 431
{	// Fields
	public int value__; // 0x0
	public const AssemblyVersionCompatibility SameMachine = 1;
	public const AssemblyVersionCompatibility SameProcess = 2;
	public const AssemblyVersionCompatibility SameDomain = 3;

}

public sealed class AssemblyCopyrightAttribute : Attribute // TypeDefIndex: 504
{	// Fields
	private string m_copyright; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string copyright) { }

}

public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 505
{	// Fields
	private string m_trademark; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string trademark) { }

}

public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 506
{	// Fields
	private string m_product; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string product) { }

}

public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 507
{	// Fields
	private string m_company; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string company) { }

}

public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 508
{	// Fields
	private string m_description; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string description) { }

}

public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 509
{	// Fields
	private string m_title; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string title) { }

}

public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 510
{	// Fields
	private string m_configuration; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string configuration) { }

}

public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 511
{	// Fields
	private string m_defaultAlias; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string defaultAlias) { }

}

public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 512
{	// Fields
	private string m_informationalVersion; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string informationalVersion) { }

}

public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 513
{	// Fields
	private string _version; // 0x10

	// Methods

	// RVA: 0x18BE4B0 Offset: 0x18BD8B0 VA: 0x1818BE4B0
	public void .ctor(string version) { }

}

public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 514
{	// Fields
	private string m_keyFile; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string keyFile) { }

}

public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 515
{	// Fields
	private bool m_delaySign; // 0x10

	// Methods

	// RVA: 0xFD7A30 Offset: 0xFD6E30 VA: 0x180FD7A30
	public void .ctor(bool delaySign) { }

}

public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 516
{	// Fields
	private string m_key; // 0x10
	private string m_value; // 0x18

	// Methods

	// RVA: 0x805420 Offset: 0x804820 VA: 0x180805420
	public void .ctor(string key, string value) { }

}

public enum AssemblyNameFlags // TypeDefIndex: 517
{	// Fields
	public int value__; // 0x0
	public const AssemblyNameFlags None = 0;
	public const AssemblyNameFlags PublicKey = 1;
	public const AssemblyNameFlags EnableJITcompileOptimizer = 16384;
	public const AssemblyNameFlags EnableJITcompileTracking = 32768;
	public const AssemblyNameFlags Retargetable = 256;

}

public enum AssemblyContentType // TypeDefIndex: 518
{	// Fields
	public int value__; // 0x0
	public const AssemblyContentType Default = 0;
	public const AssemblyContentType WindowsRuntime = 1;

}

public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 555
{	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private Assembly.ResolveEventHolder resolve_event_holder; // 0x18
	private object _evidence; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	private bool fromByteArray; // 0x50
	private string assemblyName; // 0x58

	// Properties
	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	public virtual string Location { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual bool ReflectionOnly { get; }
	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x18C10E0 Offset: 0x18C04E0 VA: 0x1818C10E0
	protected void .ctor() { }

	// RVA: 0x18BFC00 Offset: 0x18BF000 VA: 0x1818BFC00
	private string get_code_base(bool escaped) { }

	// RVA: 0x18C11B0 Offset: 0x18C05B0 VA: 0x1818C11B0
	private string get_fullname() { }

	// RVA: 0x18C11C0 Offset: 0x18C05C0 VA: 0x1818C11C0
	private string get_location() { }

	// RVA: 0x17C4A20 Offset: 0x17C3E20 VA: 0x1817C4A20
	internal static string GetAotId() { }

	// RVA: 0x18BFC00 Offset: 0x18BF000 VA: 0x1818BFC00
	private string GetCodeBase(bool escaped) { }

	// RVA: 0x18C1150 Offset: 0x18C0550 VA: 0x1818C1150 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0xD81B90 Offset: 0xD80F90 VA: 0x180D81B90 Slot: 9
	public virtual string get_FullName() { }

	// RVA: 0x18C1160 Offset: 0x18C0560 VA: 0x1818C1160 Slot: 10
	public virtual string get_Location() { }

	// RVA: 0x18C06E0 Offset: 0x18BFAE0 VA: 0x1818C06E0 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C0E90 Offset: 0x18C0290 VA: 0x1818C0E90 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18BFC10 Offset: 0x18BF010 VA: 0x1818BFC10 Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18BFC80 Offset: 0x18BF080 VA: 0x1818BFC80 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17C4A20 Offset: 0x17C3E20 VA: 0x1817C4A20
	private object GetFilesInternal(string name, bool getResourceModules) { }

	// RVA: 0x18BFD30 Offset: 0x18BF130 VA: 0x1818BFD30 Slot: 15
	public virtual FileStream GetFile(string name) { }

	// RVA: 0x18BFFA0 Offset: 0x18BF3A0 VA: 0x1818BFFA0
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x18BFFC0 Offset: 0x18BF3C0 VA: 0x1818BFFC0 Slot: 16
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x18C0440 Offset: 0x18BF840 VA: 0x1818C0440
	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	// RVA: 0x18C0330 Offset: 0x18BF730 VA: 0x1818C0330
	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	// RVA: 0x18C0A00 Offset: 0x18BFE00 VA: 0x1818C0A00
	internal string GetSimpleName() { }

	// RVA: 0x18C0730 Offset: 0x18BFB30 VA: 0x1818C0730
	internal byte[] GetPublicKey() { }

	// RVA: 0x18C0B00 Offset: 0x18BFF00 VA: 0x1818C0B00
	internal Version GetVersion() { }

	// RVA: 0x18BFE50 Offset: 0x18BF250 VA: 0x1818BFE50
	private AssemblyNameFlags GetFlags() { }

	// RVA: 0x18C0AF0 Offset: 0x18BFEF0 VA: 0x1818C0AF0 Slot: 17
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x18C0AD0 Offset: 0x18BFED0 VA: 0x1818C0AD0 Slot: 18
	public virtual Type[] GetTypes() { }

	// RVA: 0x18C0A70 Offset: 0x18BFE70 VA: 0x1818C0A70 Slot: 19
	public virtual Type GetType(string name, bool throwOnError) { }

	// RVA: 0x18C0AA0 Offset: 0x18BFEA0 VA: 0x1818C0AA0 Slot: 20
	public virtual Type GetType(string name) { }

	// RVA: 0x18C0E80 Offset: 0x18C0280 VA: 0x1818C0E80
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C0670 Offset: 0x18BFA70 VA: 0x1818C0670 Slot: 21
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x18C06C0 Offset: 0x18BFAC0 VA: 0x1818C06C0 Slot: 22
	public virtual AssemblyName GetName() { }

	// RVA: 0x18C10B0 Offset: 0x18C04B0 VA: 0x1818C10B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18BFB40 Offset: 0x18BEF40 VA: 0x1818BFB40
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x18C0B40 Offset: 0x18BFF40 VA: 0x1818C0B40
	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	// RVA: 0x18C0F20 Offset: 0x18C0320 VA: 0x1818C0F20
	private static Assembly LoadFrom(string assemblyFile, bool refonly) { }

	// RVA: 0x18C0F10 Offset: 0x18C0310 VA: 0x1818C0F10
	public static Assembly LoadFrom(string assemblyFile) { }

	[ObsoleteAttribute] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	// RVA: 0x18C0F10 Offset: 0x18C0310 VA: 0x1818C0F10
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	// RVA: 0x18C1050 Offset: 0x18C0450 VA: 0x1818C1050
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x18C1080 Offset: 0x18C0480 VA: 0x1818C1080
	public static Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x18C11D0 Offset: 0x18C05D0 VA: 0x1818C11D0
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[ObsoleteAttribute] // RVA: 0x9E1B0 Offset: 0x9D5B0 VA: 0x18009E1B0
	// RVA: 0x18C0F30 Offset: 0x18C0330 VA: 0x1818C0F30
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x18C0FA0 Offset: 0x18C03A0 VA: 0x1818C0FA0
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x18C0620 Offset: 0x18BFA20 VA: 0x1818C0620 Slot: 23
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x18BFFB0 Offset: 0x18BF3B0 VA: 0x1818BFFB0 Slot: 24
	public virtual string[] GetManifestResourceNames() { }

	// RVA: 0x18BFD00 Offset: 0x18BF100 VA: 0x1818BFD00
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x18BFBF0 Offset: 0x18BEFF0 VA: 0x1818BFBF0
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x18C0B30 Offset: 0x18BFF30 VA: 0x1818C0B30
	internal static IntPtr InternalGetReferencedAssemblies(Assembly module) { }

	// RVA: 0x18C0760 Offset: 0x18BFB60 VA: 0x1818C0760
	internal static AssemblyName[] GetReferencedAssemblies(Assembly module) { }

	// RVA: 0x18BFE80 Offset: 0x18BF280 VA: 0x1818BFE80
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x18BFE90 Offset: 0x18BF290 VA: 0x1818BFE90 Slot: 25
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760 Slot: 26
	public virtual bool get_ReflectionOnly() { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18BFA50 Offset: 0x18BEE50 VA: 0x1818BFA50 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x18BFA00 Offset: 0x18BEE00 VA: 0x1818BFA00
	private static Exception CreateNIE() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool get_IsFullyTrusted() { }

	// RVA: 0x18C0A30 Offset: 0x18BFE30 VA: 0x1818C0A30 Slot: 27
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C05E0 Offset: 0x18BF9E0 VA: 0x1818C05E0 Slot: 28
	public virtual Module GetModule(string name) { }

	// RVA: 0x18C09C0 Offset: 0x18BFDC0 VA: 0x1818C09C0 Slot: 29
	public virtual AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x18C0630 Offset: 0x18BFA30 VA: 0x1818C0630 Slot: 30
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x18C11E0 Offset: 0x18C05E0 VA: 0x1818C11E0
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x18C1230 Offset: 0x18C0630 VA: 0x1818C1230
	public static bool op_Inequality(Assembly left, Assembly right) { }

}

internal class Assembly.ResolveEventHolder // TypeDefIndex: 556
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class Assembly.UnmanagedMemoryStreamForModule : UnmanagedMemoryStream // TypeDefIndex: 557
{	// Fields
	private Module module; // 0x68

	// Methods

	// RVA: 0x18D2C80 Offset: 0x18D2080 VA: 0x1818D2C80
	public void .ctor(byte* pointer, long length, Module module) { }

	// RVA: 0x18D2C30 Offset: 0x18D2030 VA: 0x1818D2C30 Slot: 17
	protected override void Dispose(bool disposing) { }

}

public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 558
{	// Fields
	private string name; // 0x10
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

	// Properties
	public string Name { get; set; }
	public string CodeBase { get; }
	public CultureInfo CultureInfo { get; set; }
	public AssemblyNameFlags Flags { get; set; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }

	// Methods

	// RVA: 0x18BF4E0 Offset: 0x18BE8E0 VA: 0x1818BF4E0
	public void .ctor() { }

	// RVA: 0x18BEE70 Offset: 0x18BE270 VA: 0x1818BEE70
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x18BEEE0 Offset: 0x18BE2E0 VA: 0x1818BEEE0
	public void .ctor(string assemblyName) { }

	// RVA: 0x18BF120 Offset: 0x18BE520 VA: 0x1818BF120
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Name(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_CodeBase() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_CultureInfo(CultureInfo value) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	public void set_Flags(AssemblyNameFlags value) { }

	// RVA: 0x18BF500 Offset: 0x18BE900 VA: 0x1818BF500
	public string get_FullName() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public Version get_Version() { }

	// RVA: 0x18BF950 Offset: 0x18BED50 VA: 0x1818BF950
	public void set_Version(Version value) { }

	// RVA: 0x18BEEB0 Offset: 0x18BE2B0 VA: 0x1818BEEB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public byte[] GetPublicKey() { }

	// RVA: 0x18BEC90 Offset: 0x18BE090 VA: 0x1818BEC90
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x18BF8A0 Offset: 0x18BECA0 VA: 0x1818BF8A0
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x18BED90 Offset: 0x18BE190 VA: 0x1818BED90
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x18BE640 Offset: 0x18BDA40 VA: 0x1818BE640
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x18BEE80 Offset: 0x18BE280 VA: 0x1818BEE80
	public void SetPublicKey(byte[] publicKey) { }

	// RVA: 0x18BEA90 Offset: 0x18BDE90 VA: 0x1818BEA90 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18BE540 Offset: 0x18BD940 VA: 0x1818BE540 Slot: 4
	public object Clone() { }

	// RVA: 0x18BEE60 Offset: 0x18BE260 VA: 0x1818BEE60 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x18BEA80 Offset: 0x18BDE80 VA: 0x1818BEA80
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x18BE7A0 Offset: 0x18BDBA0 VA: 0x1818BE7A0
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x18BE6D0 Offset: 0x18BDAD0 VA: 0x1818BE6D0
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

}

