internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 485
{
	private ResourceManager.ResourceManagerMediator _mediator;


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
{
	private Assembly _containingAssembly;
	private string _containingFileName;
	private ResourceLocation _resourceLocation;

	public virtual Assembly ReferencedAssembly { get; }
	public virtual string FileName { get; }
	public virtual ResourceLocation ResourceLocation { get; }


	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	public virtual Assembly get_ReferencedAssembly() { }

	public virtual string get_FileName() { }

	public virtual ResourceLocation get_ResourceLocation() { }

}

internal class ManifestBuilder // TypeDefIndex: 1624
{
	private Dictionary<int, string> opcodeTab;
	private Dictionary<int, string> taskTab;
	private Dictionary<ulong, string> keywordTab;
	private Dictionary<string, Type> mapsTab;
	private Dictionary<string, string> stringTab;
	private StringBuilder sb;
	private StringBuilder events;
	private StringBuilder templates;
	private ResourceManager resources;
	private EventManifestOptions flags;
	private IList<string> errors;
	private Dictionary<string, List<int>> perEventByteArrayArgIndices;
	private string eventName;
	private int numParams;
	private List<int> byteArrArgIndices;

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
{
	public StringBuilder stringBuilder;
	public string eventMessage;
	public int writtenSoFar;


	public void .ctor() { }

}

private sealed class ManifestBuilder.<>c__DisplayClass22_1 // TypeDefIndex: 1626
{
	public int i;
	public ManifestBuilder.<>c


	public void .ctor() { }

	internal void <TranslateToManifestConvention>

}

internal struct ManifestEnvelope // TypeDefIndex: 1627
{
	public ManifestEnvelope.ManifestFormats Format;
	public byte MajorVersion;
	public byte MinorVersion;
	public byte Magic;
	public ushort TotalChunks;
	public ushort ChunkNumber;

}

public enum ManifestEnvelope.ManifestFormats // TypeDefIndex: 1628
{
	public byte value__;
	public const ManifestEnvelope.ManifestFormats SimpleXmlFormat = 1;

}

public static class Manifest // TypeDefIndex: 6208
{
	[CompilerGeneratedAttribute]
	private static DateTime <LastDownloaded>k__BackingField;
	[CompilerGeneratedAttribute]
	private static string <Contents>k__BackingField;

	public static DateTime LastDownloaded { get; set; }
	public static string Contents { get; set; }


	[CompilerGeneratedAttribute]
	public static DateTime get_LastDownloaded() { }

	[CompilerGeneratedAttribute]
	internal static void set_LastDownloaded(DateTime value) { }

	[CompilerGeneratedAttribute]
	public static string get_Contents() { }

	[CompilerGeneratedAttribute]
	internal static void set_Contents(string value) { }

	internal static void Download() { }

	[IteratorStateMachineAttribute]
	private static IEnumerator UpdateManifest() { }

	private static void LoadManifest(string text) { }

	private static void OnManifestLoaded(Manifest manifest) { }

}

private sealed class Manifest.<>c // TypeDefIndex: 6209
{
	public static readonly Manifest.<>c <>9;
	public static Action<string> <>9__9_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <UpdateManifest>

}

private sealed class Manifest.<UpdateManifest>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6210
{
	private int <>1__state;
	private object <>2__current;
	private string <url>5__2;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

public class Manifest // TypeDefIndex: 6253
{
	public Manifest.NewsInfo News;
	public Manifest.ServersInfo Servers;
	public string ExceptionReportingUrl;
	public string BenchmarkUrl;
	public string AnalyticUrl;
	public string DatabaseUrl;
	public string LeaderboardUrl;
	public string ReportUrl;
	public string AccountUrl;
	public Hero[] Heroes;
	public Manifest.Administrator[] Administrators;
	public JObject Metadata;


	internal static Manifest FromJson(string text) { }

	public void .ctor() { }

}

public class Manifest.Administrator // TypeDefIndex: 6254
{
	public string UserId;
	public string Level;


	public void .ctor() { }

}

public class Manifest.NewsInfo // TypeDefIndex: 6255
{
	public Manifest.NewsInfo.BlogInfo[] Blogs;


	public void .ctor() { }

}

public class Manifest.NewsInfo.BlogInfo // TypeDefIndex: 6256
{
	public DateTime Date;
	public string ShortName;
	public string Title;
	public string HeaderImage;
	public string SummaryHtml;
	public string Url;
	public string Tags;


	public void .ctor() { }

}

public class Manifest.ServersInfo // TypeDefIndex: 6257
{
	public Manifest.ServerDesc[] Official;
	public string[] Banned;


	public bool IsBannedServer(string ip) { }

	public void .ctor() { }

}

public class Manifest.ServerDesc // TypeDefIndex: 6258
{
	public string Address;
	public int Port;


	public void .ctor() { }

}

public class Manifest // TypeDefIndex: 13758
{

	[ClientVar]
	[ServerVar]
	public static object PrintManifest() { }

	[ClientVar]
	[ServerVar]
	public static object PrintManifestRaw() { }

	public void .ctor() { }

}

