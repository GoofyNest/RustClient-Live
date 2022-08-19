internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 485
{	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0xFE40E0 Offset: 0xFE34E0 VA: 0x180FE40E0 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE4C20 Offset: 0xFE4020 VA: 0x180FE4C20
	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

	// RVA: 0xFE3BB0 Offset: 0xFE2FB0 VA: 0x180FE3BB0
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0xFE2F60 Offset: 0xFE2360 VA: 0x180FE2F60
	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	// RVA: 0xFE3A30 Offset: 0xFE2E30 VA: 0x180FE3A30
	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE2BA0 Offset: 0xFE1FA0 VA: 0x180FE2BA0
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	// RVA: 0xFE3F00 Offset: 0xFE3300 VA: 0x180FE3F00
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE2A10 Offset: 0xFE1E10 VA: 0x180FE2A10
	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	// RVA: 0xFE3EA0 Offset: 0xFE32A0 VA: 0x180FE3EA0
	private string GetSatelliteAssemblyName() { }

	// RVA: 0xFE48A0 Offset: 0xFE3CA0 VA: 0x180FE48A0
	private void HandleSatelliteMissing() { }

	// RVA: 0xFE4580 Offset: 0xFE3980 VA: 0x180FE4580
	private void HandleResourceStreamMissing(string fileName) { }

	// RVA: 0xFE3B20 Offset: 0xFE2F20 VA: 0x180FE3B20
	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }

}

public class ManifestResourceInfo // TypeDefIndex: 531
{	// Fields
	private Assembly _containingAssembly; // 0x10
	private string _containingFileName; // 0x18
	private ResourceLocation _resourceLocation; // 0x20

	// Properties
	public virtual Assembly ReferencedAssembly { get; }
	public virtual string FileName { get; }
	public virtual ResourceLocation ResourceLocation { get; }

	// Methods

	// RVA: 0x1380A40 Offset: 0x137FE40 VA: 0x181380A40
	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public virtual Assembly get_ReferencedAssembly() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 5
	public virtual string get_FileName() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 6
	public virtual ResourceLocation get_ResourceLocation() { }

}

internal class ManifestBuilder // TypeDefIndex: 1624
{	// Fields
	private Dictionary<int, string> opcodeTab; // 0x10
	private Dictionary<int, string> taskTab; // 0x18
	private Dictionary<ulong, string> keywordTab; // 0x20
	private Dictionary<string, Type> mapsTab; // 0x28
	private Dictionary<string, string> stringTab; // 0x30
	private StringBuilder sb; // 0x38
	private StringBuilder events; // 0x40
	private StringBuilder templates; // 0x48
	private ResourceManager resources; // 0x50
	private EventManifestOptions flags; // 0x58
	private IList<string> errors; // 0x60
	private Dictionary<string, List<int>> perEventByteArrayArgIndices; // 0x68
	private string eventName; // 0x70
	private int numParams; // 0x78
	private List<int> byteArrArgIndices; // 0x80

	// Properties
	public IList<string> Errors { get; }

	// Methods

	// RVA: 0x10DEEA0 Offset: 0x10DE2A0 VA: 0x1810DEEA0
	public void .ctor(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags) { }

	// RVA: 0x10DAC10 Offset: 0x10DA010 VA: 0x1810DAC10
	public void AddOpcode(string name, int value) { }

	// RVA: 0x10DAF50 Offset: 0x10DA350 VA: 0x1810DAF50
	public void AddTask(string name, int value) { }

	// RVA: 0x10DA6A0 Offset: 0x10D9AA0 VA: 0x1810DA6A0
	public void AddKeyword(string name, ulong value) { }

	// RVA: 0x10DDAA0 Offset: 0x10DCEA0 VA: 0x1810DDAA0
	public void StartEvent(string eventName, EventAttribute eventAttribute) { }

	// RVA: 0x10DA150 Offset: 0x10D9550 VA: 0x1810DA150
	public void AddEventParameter(Type type, string name) { }

	// RVA: 0x10DC920 Offset: 0x10DBD20 VA: 0x1810DC920
	public void EndEvent() { }

	// RVA: 0x10DC8E0 Offset: 0x10DBCE0 VA: 0x1810DC8E0
	public byte[] CreateManifest() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public IList<string> get_Errors() { }

	// RVA: 0x10DD990 Offset: 0x10DCD90 VA: 0x1810DD990
	public void ManifestError(string msg, bool runtimeCritical = False) { }

	// RVA: 0x10DB2D0 Offset: 0x10DA6D0 VA: 0x1810DB2D0
	private string CreateManifestString() { }

	// RVA: 0x10DEDE0 Offset: 0x10DE1E0 VA: 0x1810DEDE0
	private void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name) { }

	// RVA: 0x10DEBC0 Offset: 0x10DDFC0 VA: 0x1810DEBC0
	private void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value) { }

	// RVA: 0x10DCE50 Offset: 0x10DC250 VA: 0x1810DCE50
	internal string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat) { }

	// RVA: 0x10DD230 Offset: 0x10DC630 VA: 0x1810DD230
	private static List<CultureInfo> GetSupportedCultures(ResourceManager resources) { }

	// RVA: 0x10DCDA0 Offset: 0x10DC1A0 VA: 0x1810DCDA0
	private static string GetLevelName(EventLevel level) { }

	// RVA: 0x10DD3E0 Offset: 0x10DC7E0 VA: 0x1810DD3E0
	private string GetTaskName(EventTask task, string eventName) { }

	// RVA: 0x10DCF70 Offset: 0x10DC370 VA: 0x1810DCF70
	private string GetOpcodeName(EventOpcode opcode, string eventName) { }

	// RVA: 0x10DCB10 Offset: 0x10DBF10 VA: 0x1810DCB10
	private string GetKeywords(ulong keywords, string eventName) { }

	// RVA: 0x10DD4F0 Offset: 0x10DC8F0 VA: 0x1810DD4F0
	private string GetTypeName(Type type) { }

	// RVA: 0x10DEB10 Offset: 0x10DDF10 VA: 0x1810DEB10
	private static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count) { }

	// RVA: 0x10DE090 Offset: 0x10DD490 VA: 0x1810DE090
	private string TranslateToManifestConvention(string eventMessage, string evtName) { }

	// RVA: 0x10DDF20 Offset: 0x10DD320 VA: 0x1810DDF20
	private int TranslateIndexToManifestConvention(int idx, string evtName) { }

}

private sealed class ManifestBuilder.<>c__DisplayClass22_0 // TypeDefIndex: 1625
{	// Fields
	public StringBuilder stringBuilder; // 0x10
	public string eventMessage; // 0x18
	public int writtenSoFar; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class ManifestBuilder.<>c__DisplayClass22_1 // TypeDefIndex: 1626
{	// Fields
	public int i; // 0x10
	public ManifestBuilder.<>c__DisplayClass22_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10E4C90 Offset: 0x10E4090 VA: 0x1810E4C90
	internal void <TranslateToManifestConvention>b__0(char ch, string escape) { }

}

internal struct ManifestEnvelope // TypeDefIndex: 1627
{	// Fields
	public ManifestEnvelope.ManifestFormats Format; // 0x0
	public byte MajorVersion; // 0x1
	public byte MinorVersion; // 0x2
	public byte Magic; // 0x3
	public ushort TotalChunks; // 0x4
	public ushort ChunkNumber; // 0x6

}

public enum ManifestEnvelope.ManifestFormats // TypeDefIndex: 1628
{	// Fields
	public byte value__; // 0x0
	public const ManifestEnvelope.ManifestFormats SimpleXmlFormat = 1;

}

public static class Manifest // TypeDefIndex: 6199
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static DateTime <LastDownloaded>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <Contents>k__BackingField; // 0x8

	// Properties
	public static DateTime LastDownloaded { get; set; }
	public static string Contents { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14ECE10 Offset: 0x14EC210 VA: 0x1814ECE10
	public static DateTime get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14ECEA0 Offset: 0x14EC2A0 VA: 0x1814ECEA0
	internal static void set_LastDownloaded(DateTime value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14ECDD0 Offset: 0x14EC1D0 VA: 0x1814ECDD0
	public static string get_Contents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14ECE50 Offset: 0x14EC250 VA: 0x1814ECE50
	internal static void set_Contents(string value) { }

	// RVA: 0x14EC220 Offset: 0x14EB620 VA: 0x1814EC220
	internal static void Download() { }

	[IteratorStateMachineAttribute] // RVA: 0xA5380 Offset: 0xA4780 VA: 0x1800A5380
	// RVA: 0x14ECD80 Offset: 0x14EC180 VA: 0x1814ECD80
	private static IEnumerator UpdateManifest() { }

	// RVA: 0x14EC490 Offset: 0x14EB890 VA: 0x1814EC490
	private static void LoadManifest(string text) { }

	// RVA: 0x14ECCB0 Offset: 0x14EC0B0 VA: 0x1814ECCB0
	private static void OnManifestLoaded(Manifest manifest) { }

}

private sealed class Manifest.<>c // TypeDefIndex: 6200
{	// Fields
	public static readonly Manifest.<>c <>9; // 0x0
	public static Action<string> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x14F4430 Offset: 0x14F3830 VA: 0x1814F4430
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F3C80 Offset: 0x14F3080 VA: 0x1814F3C80
	internal void <UpdateManifest>b__9_0(string str) { }

}

private sealed class Manifest.<UpdateManifest>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6201
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private string <url>5__2; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14F4610 Offset: 0x14F3A10 VA: 0x1814F4610 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14F4970 Offset: 0x14F3D70 VA: 0x1814F4970 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class Manifest // TypeDefIndex: 6244
{	// Fields
	public Manifest.NewsInfo News; // 0x10
	public Manifest.ServersInfo Servers; // 0x18
	public string ExceptionReportingUrl; // 0x20
	public string BenchmarkUrl; // 0x28
	public string AnalyticUrl; // 0x30
	public string DatabaseUrl; // 0x38
	public string LeaderboardUrl; // 0x40
	public string ReportUrl; // 0x48
	public string AccountUrl; // 0x50
	public Hero[] Heroes; // 0x58
	public Manifest.Administrator[] Administrators; // 0x60
	public JObject Metadata; // 0x68

	// Methods

	// RVA: 0x14EC390 Offset: 0x14EB790 VA: 0x1814EC390
	internal static Manifest FromJson(string text) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Manifest.Administrator // TypeDefIndex: 6245
{	// Fields
	public string UserId; // 0x10
	public string Level; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Manifest.NewsInfo // TypeDefIndex: 6246
{	// Fields
	public Manifest.NewsInfo.StatusInfo[] Status; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Manifest.NewsInfo.StatusInfo // TypeDefIndex: 6247
{	// Fields
	public DateTime DateTime; // 0x10
	public string Content; // 0x18
	public string Type; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Manifest.ServersInfo // TypeDefIndex: 6248
{	// Fields
	public Manifest.ServerDesc[] Official; // 0x10
	public string[] Banned; // 0x18

	// Methods

	// RVA: 0x14F0350 Offset: 0x14EF750 VA: 0x1814F0350
	public bool IsBannedServer(string ip) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Manifest.ServerDesc // TypeDefIndex: 6249
{	// Fields
	public string Address; // 0x10
	public int Port; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Manifest // TypeDefIndex: 11939
{	// Methods

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x364DB0 Offset: 0x3641B0 VA: 0x180364DB0
	public static object PrintManifest() { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x364D70 Offset: 0x364170 VA: 0x180364D70
	public static object PrintManifestRaw() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

