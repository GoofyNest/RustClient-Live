internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 485
{	private ResourceManager.ResourceManagerMediator _mediator; // 0x10


	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	private string GetSatelliteAssemblyName() { }

	private void HandleSatelliteMissing() { }

	private void HandleResourceStreamMissing(string fileName) { }

	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }

}

public class ManifestResourceInfo // TypeDefIndex: 531
{	private Assembly _containingAssembly; // 0x10
	private string _containingFileName; // 0x18
	private ResourceLocation _resourceLocation; // 0x20

	public virtual Assembly ReferencedAssembly { get; }
	public virtual string FileName { get; }
	public virtual ResourceLocation ResourceLocation { get; }


	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	public virtual Assembly get_ReferencedAssembly() { }

	public virtual string get_FileName() { }

	public virtual ResourceLocation get_ResourceLocation() { }

}

internal class ManifestBuilder // TypeDefIndex: 1624
{	private Dictionary<int, string> opcodeTab; // 0x10
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

	public IList<string> Errors { get; }


	public void .ctor(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags) { }

	public void AddOpcode(string name, int value) { }

	public void AddTask(string name, int value) { }

	public void AddKeyword(string name, ulong value) { }

	public void StartEvent(string eventName, EventAttribute eventAttribute) { }

	public void AddEventParameter(Type type, string name) { }

	public void EndEvent() { }

	public byte[] CreateManifest() { }

	public IList<string> get_Errors() { }

	public void ManifestError(string msg, bool runtimeCritical = False) { }

	private string CreateManifestString() { }

	private void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name) { }

	private void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value) { }

	internal string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat) { }

	private static List<CultureInfo> GetSupportedCultures(ResourceManager resources) { }

	private static string GetLevelName(EventLevel level) { }

	private string GetTaskName(EventTask task, string eventName) { }

	private string GetOpcodeName(EventOpcode opcode, string eventName) { }

	private string GetKeywords(ulong keywords, string eventName) { }

	private string GetTypeName(Type type) { }

	private static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count) { }

	private string TranslateToManifestConvention(string eventMessage, string evtName) { }

	private int TranslateIndexToManifestConvention(int idx, string evtName) { }

}

private sealed class ManifestBuilder.<>c__DisplayClass22_0 // TypeDefIndex: 1625
{	public StringBuilder stringBuilder; // 0x10
	public string eventMessage; // 0x18
	public int writtenSoFar; // 0x20


	public void .ctor() { }

}

private sealed class ManifestBuilder.<>c__DisplayClass22_1 // TypeDefIndex: 1626
{	public int i; // 0x10
	public ManifestBuilder.<>c__DisplayClass22_0 CS$<>8__locals1; // 0x18


	public void .ctor() { }

	internal void <TranslateToManifestConvention>b__0(char ch, string escape) { }

}

internal struct ManifestEnvelope // TypeDefIndex: 1627
{	public ManifestEnvelope.ManifestFormats Format; // 0x0
	public byte MajorVersion; // 0x1
	public byte MinorVersion; // 0x2
	public byte Magic; // 0x3
	public ushort TotalChunks; // 0x4
	public ushort ChunkNumber; // 0x6

}

public enum ManifestEnvelope.ManifestFormats // TypeDefIndex: 1628
{	public byte value__; // 0x0
	public const ManifestEnvelope.ManifestFormats SimpleXmlFormat = 1;

}

public static class Manifest // TypeDefIndex: 6199
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static DateTime <LastDownloaded>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <Contents>k__BackingField; // 0x8

	public static DateTime LastDownloaded { get; set; }
	public static string Contents { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static DateTime get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_LastDownloaded(DateTime value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string get_Contents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_Contents(string value) { }

	internal static void Download() { }

	[IteratorStateMachineAttribute] // RVA: 0xA5380 Offset: 0xA4780 VA: 0x1800A5380
	private static IEnumerator UpdateManifest() { }

	private static void LoadManifest(string text) { }

	private static void OnManifestLoaded(Manifest manifest) { }

}

private sealed class Manifest.<>c // TypeDefIndex: 6200
{	public static readonly Manifest.<>c <>9; // 0x0
	public static Action<string> <>9__9_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <UpdateManifest>b__9_0(string str) { }

}

private sealed class Manifest.<UpdateManifest>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6201
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private string <url>5__2; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public class Manifest // TypeDefIndex: 6244
{	public Manifest.NewsInfo News; // 0x10
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


	internal static Manifest FromJson(string text) { }

	public void .ctor() { }

}

public class Manifest.Administrator // TypeDefIndex: 6245
{	public string UserId; // 0x10
	public string Level; // 0x18


	public void .ctor() { }

}

public class Manifest.NewsInfo // TypeDefIndex: 6246
{	public Manifest.NewsInfo.StatusInfo[] Status; // 0x10


	public void .ctor() { }

}

public class Manifest.NewsInfo.StatusInfo // TypeDefIndex: 6247
{	public DateTime DateTime; // 0x10
	public string Content; // 0x18
	public string Type; // 0x20


	public void .ctor() { }

}

public class Manifest.ServersInfo // TypeDefIndex: 6248
{	public Manifest.ServerDesc[] Official; // 0x10
	public string[] Banned; // 0x18


	public bool IsBannedServer(string ip) { }

	public void .ctor() { }

}

public class Manifest.ServerDesc // TypeDefIndex: 6249
{	public string Address; // 0x10
	public int Port; // 0x18


	public void .ctor() { }

}

public class Manifest // TypeDefIndex: 11939
{
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static object PrintManifest() { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static object PrintManifestRaw() { }

	public void .ctor() { }

}

