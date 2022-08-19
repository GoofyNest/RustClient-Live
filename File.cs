internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 482
{	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0xFE2030 Offset: 0xFE1430 VA: 0x180FE2030 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE1F70 Offset: 0xFE1370 VA: 0x180FE1F70
	private string FindResourceFile(CultureInfo culture, string fileName) { }

	// RVA: 0xFE1BF0 Offset: 0xFE0FF0 VA: 0x180FE1BF0
	private ResourceSet CreateResourceSet(string file) { }

}

public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 623
{	// Fields
	private string _name; // 0x60

	// Properties
	public override string Name { get; }
	public long Length { get; }
	public string DirectoryName { get; }
	public DirectoryInfo Directory { get; }
	public override bool Exists { get; }

	// Methods

	// RVA: 0x1619EE0 Offset: 0x16192E0 VA: 0x181619EE0
	public void .ctor(string fileName) { }

	// RVA: 0x1619A60 Offset: 0x1618E60 VA: 0x181619A60
	private void Init(string fileName, bool checkHost) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	private string GetDisplayPath(string originalPath) { }

	// RVA: 0x161A080 Offset: 0x1619480 VA: 0x18161A080
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1619DE0 Offset: 0x16191E0 VA: 0x181619DE0
	internal void .ctor(string fullPath, bool ignoreThis) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 8
	public override string get_Name() { }

	// RVA: 0x161A3E0 Offset: 0x16197E0 VA: 0x18161A3E0
	public long get_Length() { }

	// RVA: 0x161A250 Offset: 0x1619650 VA: 0x18161A250
	public string get_DirectoryName() { }

	// RVA: 0x161A2B0 Offset: 0x16196B0 VA: 0x18161A2B0
	public DirectoryInfo get_Directory() { }

	// RVA: 0x1619830 Offset: 0x1618C30 VA: 0x181619830
	public StreamWriter CreateText() { }

	// RVA: 0x16195F0 Offset: 0x16189F0 VA: 0x1816195F0
	public StreamWriter AppendText() { }

	// RVA: 0x1619650 Offset: 0x1618A50 VA: 0x181619650
	public FileInfo CopyTo(string destFileName, bool overwrite) { }

	// RVA: 0x1619890 Offset: 0x1618C90 VA: 0x181619890 Slot: 10
	public override void Delete() { }

	// RVA: 0x161A360 Offset: 0x1619760 VA: 0x18161A360 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x1619B50 Offset: 0x1618F50 VA: 0x181619B50
	public void MoveTo(string destFileName) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 3
	public override string ToString() { }

}

public class FileLoadException : IOException // TypeDefIndex: 624
{	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x161A950 Offset: 0x1619D50 VA: 0x18161A950
	public void .ctor() { }

	// RVA: 0x161A910 Offset: 0x1619D10 VA: 0x18161A910
	public void .ctor(string message) { }

	// RVA: 0x161AAB0 Offset: 0x1619EB0 VA: 0x18161AAB0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x161A600 Offset: 0x1619A00 VA: 0x18161A600
	private void SetMessageField() { }

	// RVA: 0x161A690 Offset: 0x1619A90 VA: 0x18161A690 Slot: 3
	public override string ToString() { }

	// RVA: 0x161A9C0 Offset: 0x1619DC0 VA: 0x18161A9C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public string get_FusionLog() { }

	// RVA: 0x161A4C0 Offset: 0x16198C0 VA: 0x18161A4C0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x161A450 Offset: 0x1619850 VA: 0x18161A450
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }

}

public class FileNotFoundException : IOException // TypeDefIndex: 625
{	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x161AF80 Offset: 0x161A380 VA: 0x18161AF80
	public void .ctor() { }

	// RVA: 0x161AFF0 Offset: 0x161A3F0 VA: 0x18161AFF0
	public void .ctor(string message) { }

	// RVA: 0x161B030 Offset: 0x161A430 VA: 0x18161B030
	public void .ctor(string message, string fileName) { }

	// RVA: 0x161B180 Offset: 0x161A580 VA: 0x18161B180 Slot: 5
	public override string get_Message() { }

	// RVA: 0x161AC80 Offset: 0x161A080 VA: 0x18161AC80
	private void SetMessageField() { }

	// RVA: 0x161AD00 Offset: 0x161A100 VA: 0x18161AD00 Slot: 3
	public override string ToString() { }

	// RVA: 0x161B090 Offset: 0x161A490 VA: 0x18161B090
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public string get_FusionLog() { }

	// RVA: 0x161AB40 Offset: 0x1619F40 VA: 0x18161AB40 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

internal static class FileSystemEnumerableFactory // TypeDefIndex: 626
{	// Methods

	// RVA: 0x161EF80 Offset: 0x161E380 VA: 0x18161EF80
	internal static IEnumerable<string> CreateFileNameIterator(string path, string originalUserPath, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

}

internal class FileSystemEnumerableIterator<TSource> : Iterator<TSource> // TypeDefIndex: 628
{	// Fields
	private SearchResultHandler<TSource> _resultHandler; // 0x0
	private List<Directory.SearchData> searchStack; // 0x0
	private Directory.SearchData searchData; // 0x0
	private string searchCriteria; // 0x0
	private SafeFindHandle _hnd; // 0x0
	private bool needsParentPathDiscoveryDemand; // 0x0
	private bool empty; // 0x0
	private string userPath; // 0x0
	private SearchOption searchOption; // 0x0
	private string fullPath; // 0x0
	private string normalizedSearchPath; // 0x0
	private bool _checkHost; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(string path, string originalUserPath, string searchPattern, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F3300 Offset: 0x19F2700 VA: 0x1819F3300
	|-FileSystemEnumerableIterator<object>..ctor
	|-FileSystemEnumerableIterator<string>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CommonInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F27C0 Offset: 0x19F1BC0 VA: 0x1819F27C0
	|-FileSystemEnumerableIterator<object>.CommonInit
	*/

	// RVA: -1 Offset: -1
	private void .ctor(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F3660 Offset: 0x19F2A60 VA: 0x1819F3660
	|-FileSystemEnumerableIterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F26F0 Offset: 0x19F1AF0 VA: 0x1819F26F0
	|-FileSystemEnumerableIterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F2B20 Offset: 0x19F1F20 VA: 0x1819F2B20
	|-FileSystemEnumerableIterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F2DC0 Offset: 0x19F21C0 VA: 0x1819F2DC0
	|-FileSystemEnumerableIterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F2A40 Offset: 0x19F1E40 VA: 0x1819F2A40
	|-FileSystemEnumerableIterator<object>.CreateSearchResult
	*/

	// RVA: -1 Offset: -1
	private void HandleError(int hr, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F2D70 Offset: 0x19F2170 VA: 0x1819F2D70
	|-FileSystemEnumerableIterator<object>.HandleError
	*/

	// RVA: -1 Offset: -1
	private void AddSearchableDirsToStack(Directory.SearchData localSearchData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F23A0 Offset: 0x19F17A0 VA: 0x1819F23A0
	|-FileSystemEnumerableIterator<object>.AddSearchableDirsToStack
	*/

	// RVA: -1 Offset: -1
	internal void DoDemand(string fullPathToDemand) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-FileSystemEnumerableIterator<object>.DoDemand
	*/

	// RVA: -1 Offset: -1
	private static string NormalizeSearchPattern(string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F3240 Offset: 0x19F2640 VA: 0x1819F3240
	|-FileSystemEnumerableIterator<object>.NormalizeSearchPattern
	*/

	// RVA: -1 Offset: -1
	private static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F2CD0 Offset: 0x19F20D0 VA: 0x1819F2CD0
	|-FileSystemEnumerableIterator<object>.GetNormalizedSearchCriteria
	*/

	// RVA: -1 Offset: -1
	private static string GetFullSearchString(string fullPath, string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F2BF0 Offset: 0x19F1FF0 VA: 0x1819F2BF0
	|-FileSystemEnumerableIterator<object>.GetFullSearchString
	*/

}

internal static class FileSystemEnumerableHelpers // TypeDefIndex: 632
{	// Methods

	// RVA: 0x161F070 Offset: 0x161E470 VA: 0x18161F070
	internal static bool IsDir(Win32Native.WIN32_FIND_DATA data) { }

	// RVA: 0x161F0F0 Offset: 0x161E4F0 VA: 0x18161F0F0
	internal static bool IsFile(Win32Native.WIN32_FIND_DATA data) { }

}

public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 633
{	// Fields
	internal MonoIOStat _data; // 0x18
	internal int _dataInitialised; // 0x40
	protected string FullPath; // 0x48
	protected string OriginalPath; // 0x50
	private string _displayPath; // 0x58

	// Properties
	public virtual string FullName { get; }
	public string Extension { get; }
	public abstract string Name { get; }
	public abstract bool Exists { get; }
	public DateTime CreationTime { get; set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public DateTime CreationTimeUtc { get; set; }
	public DateTime LastAccessTime { get; set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public DateTime LastAccessTimeUtc { get; set; }
	public DateTime LastWriteTime { get; set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public DateTime LastWriteTimeUtc { get; set; }
	public FileAttributes Attributes { get; }
	internal string DisplayPath { get; set; }

	// Methods

	// RVA: 0x161F220 Offset: 0x161E620 VA: 0x18161F220
	protected void .ctor() { }

	// RVA: 0x161F270 Offset: 0x161E670 VA: 0x18161F270
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 7
	public virtual string get_FullName() { }

	// RVA: 0x161F550 Offset: 0x161E950 VA: 0x18161F550
	public string get_Extension() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_Exists();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Delete();

	// RVA: 0x161F4B0 Offset: 0x161E8B0 VA: 0x18161F4B0
	public DateTime get_CreationTime() { }

	// RVA: 0x161F990 Offset: 0x161ED90 VA: 0x18161F990
	public void set_CreationTime(DateTime value) { }

	// RVA: 0x161F420 Offset: 0x161E820 VA: 0x18161F420
	public DateTime get_CreationTimeUtc() { }

	// RVA: 0x161F900 Offset: 0x161ED00 VA: 0x18161F900
	public void set_CreationTimeUtc(DateTime value) { }

	// RVA: 0x161F730 Offset: 0x161EB30 VA: 0x18161F730
	public DateTime get_LastAccessTime() { }

	// RVA: 0x161FAC0 Offset: 0x161EEC0 VA: 0x18161FAC0
	public void set_LastAccessTime(DateTime value) { }

	// RVA: 0x161F6A0 Offset: 0x161EAA0 VA: 0x18161F6A0
	public DateTime get_LastAccessTimeUtc() { }

	// RVA: 0x161FA30 Offset: 0x161EE30 VA: 0x18161FA30
	public void set_LastAccessTimeUtc(DateTime value) { }

	// RVA: 0x161F860 Offset: 0x161EC60 VA: 0x18161F860
	public DateTime get_LastWriteTime() { }

	// RVA: 0x161FBF0 Offset: 0x161EFF0 VA: 0x18161FBF0
	public void set_LastWriteTime(DateTime value) { }

	// RVA: 0x161F7D0 Offset: 0x161EBD0 VA: 0x18161F7D0
	public DateTime get_LastWriteTimeUtc() { }

	// RVA: 0x161FB60 Offset: 0x161EF60 VA: 0x18161FB60
	public void set_LastWriteTimeUtc(DateTime value) { }

	// RVA: 0x161F1F0 Offset: 0x161E5F0 VA: 0x18161F1F0
	public void Refresh() { }

	// RVA: 0x161F3D0 Offset: 0x161E7D0 VA: 0x18161F3D0
	public FileAttributes get_Attributes() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x161F110 Offset: 0x161E510 VA: 0x18161F110 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal string get_DisplayPath() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	internal void set_DisplayPath(string value) { }

}

public static class File // TypeDefIndex: 663
{	// Fields
	private static Nullable<DateTime> defaultLocalFileTime; // 0x13060

	// Properties
	private static DateTime DefaultLocalFileTime { get; }

	// Methods

	// RVA: 0x13766E0 Offset: 0x1375AE0 VA: 0x1813766E0
	public static void AppendAllText(string path, string contents) { }

	// RVA: 0x1376EA0 Offset: 0x13762A0 VA: 0x181376EA0
	public static void Copy(string sourceFileName, string destFileName) { }

	// RVA: 0x13767E0 Offset: 0x1375BE0 VA: 0x1813767E0
	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	// RVA: 0x13776F0 Offset: 0x1376AF0 VA: 0x1813776F0
	internal static string InternalCopy(string sourceFileName, string destFileName, bool overwrite, bool checkHost) { }

	// RVA: 0x1376F30 Offset: 0x1376330 VA: 0x181376F30
	public static FileStream Create(string path) { }

	// RVA: 0x1376EB0 Offset: 0x13762B0 VA: 0x181376EB0
	public static FileStream Create(string path, int bufferSize) { }

	// RVA: 0x1376FA0 Offset: 0x13763A0 VA: 0x181376FA0
	public static void Delete(string path) { }

	// RVA: 0x13771E0 Offset: 0x13765E0 VA: 0x1813771E0
	public static bool Exists(string path) { }

	// RVA: 0x13773B0 Offset: 0x13767B0 VA: 0x1813773B0
	public static FileAttributes GetAttributes(string path) { }

	// RVA: 0x1377490 Offset: 0x1376890 VA: 0x181377490
	public static DateTime GetCreationTime(string path) { }

	// RVA: 0x13775C0 Offset: 0x13769C0 VA: 0x1813775C0
	public static DateTime GetLastWriteTime(string path) { }

	// RVA: 0x1377870 Offset: 0x1376C70 VA: 0x181377870
	public static void Move(string sourceFileName, string destFileName) { }

	// RVA: 0x1377DF0 Offset: 0x13771F0 VA: 0x181377DF0
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x1377D20 Offset: 0x1377120 VA: 0x181377D20
	public static FileStream OpenRead(string path) { }

	// RVA: 0x1377D90 Offset: 0x1377190 VA: 0x181377D90
	public static StreamReader OpenText(string path) { }

	// RVA: 0x1378290 Offset: 0x1377690 VA: 0x181378290
	public static void SetCreationTime(string path, DateTime creationTime) { }

	// RVA: 0x1376530 Offset: 0x1375930 VA: 0x181376530
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	// RVA: 0x13783E0 Offset: 0x13777E0 VA: 0x1813783E0
	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	// RVA: 0x1376570 Offset: 0x1375970 VA: 0x181376570
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	// RVA: 0x1378530 Offset: 0x1377930 VA: 0x181378530
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x13765B0 Offset: 0x13759B0 VA: 0x1813765B0
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x1377E70 Offset: 0x1377270 VA: 0x181377E70
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x1378060 Offset: 0x1377460 VA: 0x181378060
	public static string ReadAllText(string path) { }

	// RVA: 0x1378680 Offset: 0x1377A80 VA: 0x181378680
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x13787D0 Offset: 0x1377BD0 VA: 0x1813787D0
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x1378840 Offset: 0x1377C40 VA: 0x181378840
	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	// RVA: 0x1378940 Offset: 0x1377D40 VA: 0x181378940
	private static DateTime get_DefaultLocalFileTime() { }

	// RVA: 0x1378170 Offset: 0x1377570 VA: 0x181378170
	public static IEnumerable<string> ReadLines(string path) { }

	[IteratorStateMachineAttribute] // RVA: 0xA7200 Offset: 0xA6600 VA: 0x1800A7200
	// RVA: 0x1378220 Offset: 0x1377620 VA: 0x181378220
	private static IEnumerable<string> ReadLines(StreamReader reader) { }

	// RVA: 0x13772C0 Offset: 0x13766C0 VA: 0x1813772C0
	internal static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound) { }

}

private sealed class File.<ReadLines>d__58 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 664
{	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private StreamReader reader; // 0x28
	public StreamReader <>3__reader; // 0x30
	private string <s>5__1; // 0x38
	private StreamReader <>7__wrap1; // 0x40

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16318D0 Offset: 0x1630CD0 VA: 0x1816318D0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16316A0 Offset: 0x1630AA0 VA: 0x1816316A0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1631980 Offset: 0x1630D80 VA: 0x181631980
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1631880 Offset: 0x1630C80 VA: 0x181631880 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16317E0 Offset: 0x1630BE0 VA: 0x1816317E0 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16317E0 Offset: 0x1630BE0 VA: 0x1816317E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public enum FileAccess // TypeDefIndex: 665
{	// Fields
	public int value__; // 0x0
	public const FileAccess Read = 1;
	public const FileAccess Write = 2;
	public const FileAccess ReadWrite = 3;

}

public enum FileAttributes // TypeDefIndex: 666
{	// Fields
	public int value__; // 0x0
	public const FileAttributes Archive = 32;
	public const FileAttributes Compressed = 2048;
	public const FileAttributes Device = 64;
	public const FileAttributes Directory = 16;
	public const FileAttributes Encrypted = 16384;
	public const FileAttributes Hidden = 2;
	public const FileAttributes Normal = 128;
	public const FileAttributes NotContentIndexed = 8192;
	public const FileAttributes Offline = 4096;
	public const FileAttributes ReadOnly = 1;
	public const FileAttributes ReparsePoint = 1024;
	public const FileAttributes SparseFile = 512;
	public const FileAttributes System = 4;
	public const FileAttributes Temporary = 256;
	public const FileAttributes IntegrityStream = 32768;
	public const FileAttributes NoScrubData = 131072;

}

public enum FileMode // TypeDefIndex: 667
{	// Fields
	public int value__; // 0x0
	public const FileMode CreateNew = 1;
	public const FileMode Create = 2;
	public const FileMode Open = 3;
	public const FileMode OpenOrCreate = 4;
	public const FileMode Truncate = 5;
	public const FileMode Append = 6;

}

public enum FileOptions // TypeDefIndex: 668
{	// Fields
	public int value__; // 0x0
	public const FileOptions None = 0;
	public const FileOptions Encrypted = 16384;
	public const FileOptions DeleteOnClose = 67108864;
	public const FileOptions SequentialScan = 134217728;
	public const FileOptions RandomAccess = 268435456;
	public const FileOptions Asynchronous = 1073741824;
	public const FileOptions WriteThrough = -2147483648;

}

public enum FileShare // TypeDefIndex: 669
{	// Fields
	public int value__; // 0x0
	public const FileShare None = 0;
	public const FileShare Read = 1;
	public const FileShare Write = 2;
	public const FileShare ReadWrite = 3;
	public const FileShare Delete = 4;
	public const FileShare Inheritable = 16;

}

public class FileStream : Stream // TypeDefIndex: 670
{	// Fields
	private static byte[] buf_recycle; // 0x0
	private static readonly object buf_recycle_lock; // 0x8
	private byte[] buf; // 0x28
	private string name; // 0x30
	private SafeFileHandle safeHandle; // 0x38
	private bool isExposed; // 0x40
	private long append_startpos; // 0x48
	private FileAccess access; // 0x50
	private bool owner; // 0x54
	private bool async; // 0x55
	private bool canseek; // 0x56
	private bool anonymous; // 0x57
	private bool buf_dirty; // 0x58
	private int buf_size; // 0x5C
	private int buf_length; // 0x60
	private int buf_offset; // 0x64
	private long buf_start; // 0x68

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public string Name { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }

	// Methods

	// RVA: 0x161E170 Offset: 0x161D570 VA: 0x18161E170
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x161E0F0 Offset: 0x161D4F0 VA: 0x18161E0F0
	public void .ctor(string path, FileMode mode) { }

	// RVA: 0x161DEA0 Offset: 0x161D2A0 VA: 0x18161DEA0
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x161E140 Offset: 0x161D540 VA: 0x18161E140
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x161DEF0 Offset: 0x161D2F0 VA: 0x18161DEF0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x161DF30 Offset: 0x161D330 VA: 0x18161DF30
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x161EB10 Offset: 0x161DF10 VA: 0x18161EB10
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x161DF80 Offset: 0x161D380 VA: 0x18161DF80
	public void .ctor(SafeFileHandle handle, FileAccess access) { }

	// RVA: 0x161E030 Offset: 0x161D430 VA: 0x18161E030
	public void .ctor(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	// RVA: 0x161DE80 Offset: 0x161D280 VA: 0x18161DE80
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = False, bool checkHost = False) { }

	// RVA: 0x161DE20 Offset: 0x161D220 VA: 0x18161DE20
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x161E2F0 Offset: 0x161D6F0 VA: 0x18161E2F0
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x161C7B0 Offset: 0x161BBB0 VA: 0x18161C7B0
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x161EB50 Offset: 0x161DF50 VA: 0x18161EB50 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x161EB70 Offset: 0x161DF70 VA: 0x18161EB70 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x161EB60 Offset: 0x161DF60 VA: 0x18161EB60 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Name() { }

	// RVA: 0x161EB90 Offset: 0x161DF90 VA: 0x18161EB90 Slot: 10
	public override long get_Length() { }

	// RVA: 0x161ED10 Offset: 0x161E110 VA: 0x18161ED10 Slot: 11
	public override long get_Position() { }

	// RVA: 0x161EEE0 Offset: 0x161E2E0 VA: 0x18161EEE0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x161EEA0 Offset: 0x161E2A0 VA: 0x18161EEA0 Slot: 31
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x161C0C0 Offset: 0x161B4C0 VA: 0x18161C0C0
	private void ExposeHandle() { }

	// RVA: 0x161CAE0 Offset: 0x161BEE0 VA: 0x18161CAE0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x161D750 Offset: 0x161CB50 VA: 0x18161D750 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x161CF20 Offset: 0x161C320 VA: 0x18161CF20 Slot: 27
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x161CD90 Offset: 0x161C190 VA: 0x18161CD90
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x161B3B0 Offset: 0x161A7B0 VA: 0x18161B3B0 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x161BDC0 Offset: 0x161B1C0 VA: 0x18161BDC0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x161DB80 Offset: 0x161CF80 VA: 0x18161DB80 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x161D8C0 Offset: 0x161CCC0 VA: 0x18161D8C0
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x161B6A0 Offset: 0x161AAA0 VA: 0x18161B6A0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x161BF50 Offset: 0x161B350 VA: 0x18161BF50 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x161D270 Offset: 0x161C670 VA: 0x18161D270 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x161D500 Offset: 0x161C900 VA: 0x18161D500 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x161C300 Offset: 0x161B700 VA: 0x18161C300 Slot: 18
	public override void Flush() { }

	// RVA: 0xFF5580 Offset: 0xFF4980 VA: 0x180FF5580 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x161BA80 Offset: 0x161AE80 VA: 0x18161BA80 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x161CAD0 Offset: 0x161BED0 VA: 0x18161CAD0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x161D740 Offset: 0x161CB40 VA: 0x18161D740 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x161CE60 Offset: 0x161C260 VA: 0x18161CE60
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x161DB10 Offset: 0x161CF10 VA: 0x18161DB10
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x161C100 Offset: 0x161B500 VA: 0x18161C100
	private void FlushBuffer() { }

	// RVA: 0x161C0F0 Offset: 0x161B4F0 VA: 0x18161C0F0
	private void FlushBufferIfDirty() { }

	// RVA: 0x161D230 Offset: 0x161C630 VA: 0x18161D230
	private void RefillBuffer() { }

	// RVA: 0x161CC50 Offset: 0x161C050 VA: 0x18161CC50
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x161C520 Offset: 0x161B920 VA: 0x18161C520
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x161C380 Offset: 0x161B780 VA: 0x18161C380
	private string GetSecureFileName(string filename) { }

	// RVA: 0x161C460 Offset: 0x161B860 VA: 0x18161C460
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x161DDC0 Offset: 0x161D1C0 VA: 0x18161DDC0
	private static void .cctor() { }

}

private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 671
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1343920 Offset: 0x1342D20 VA: 0x181343920 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x16292A0 Offset: 0x16286A0 VA: 0x1816292A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 672
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1344630 Offset: 0x1343A30 VA: 0x181344630 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x16332A0 Offset: 0x16326A0 VA: 0x1816332A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 673
{	// Fields
	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	// Properties
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x161B2E0 Offset: 0x161A6E0 VA: 0x18161B2E0
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x161B200 Offset: 0x161A600 VA: 0x18161B200
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0 Slot: 4
	public bool get_IsCompleted() { }

}

internal class FileData // TypeDefIndex: 2840
{	// Fields
	public string Directory; // 0x10
	public FileAttributes Attributes; // 0x18
	public bool NotExists; // 0x1C
	public DateTime CreationTime; // 0x20
	public DateTime LastWriteTime; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal enum FileAction // TypeDefIndex: 2844
{	// Fields
	public int value__; // 0x0
	public const FileAction Added = 1;
	public const FileAction Removed = 2;
	public const FileAction Modified = 3;
	public const FileAction RenamedOldName = 4;
	public const FileAction RenamedNewName = 5;

}

public class FileSystemEventArgs : EventArgs // TypeDefIndex: 2845
{	// Fields
	private WatcherChangeTypes changeType; // 0x10
	private string directory; // 0x18
	private string name; // 0x20

	// Properties
	public string FullPath { get; }

	// Methods

	// RVA: 0x155CAA0 Offset: 0x155BEA0 VA: 0x18155CAA0
	public void .ctor(WatcherChangeTypes changeType, string directory, string name) { }

	// RVA: 0x155CB40 Offset: 0x155BF40 VA: 0x18155CB40
	public string get_FullPath() { }

}

public sealed class FileSystemEventHandler : MulticastDelegate // TypeDefIndex: 2846
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, FileSystemEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, FileSystemEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class FileSystemWatcher : Component // TypeDefIndex: 2847
{	// Fields
	private bool enableRaisingEvents; // 0x28
	private string filter; // 0x30
	private bool includeSubdirectories; // 0x38
	private int internalBufferSize; // 0x3C
	private NotifyFilters notifyFilter; // 0x40
	private string path; // 0x48
	private string fullpath; // 0x50
	private ISynchronizeInvoke synchronizingObject; // 0x58
	private WaitForChangedResult lastData; // 0x60
	private bool waiting; // 0x80
	private SearchPattern2 pattern; // 0x88
	private bool disposed; // 0x90
	private string mangledFilter; // 0x98
	private static IFileWatcher watcher; // 0x0
	private static object lockobj; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FileSystemEventHandler Changed; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FileSystemEventHandler Created; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FileSystemEventHandler Deleted; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ErrorEventHandler Error; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RenamedEventHandler Renamed; // 0xC0

	// Properties
	internal bool Waiting { get; set; }
	internal string MangledFilter { get; }
	internal SearchPattern2 Pattern { get; }
	internal string FullPath { get; }
	[IODescriptionAttribute] // RVA: 0xB1FB0 Offset: 0xB13B0 VA: 0x1800B1FB0
	[DefaultValueAttribute] // RVA: 0xB1FB0 Offset: 0xB13B0 VA: 0x1800B1FB0
	public bool EnableRaisingEvents { set; }
	[SettingsBindableAttribute] // RVA: 0xB20D0 Offset: 0xB14D0 VA: 0x1800B20D0
	[TypeConverterAttribute] // RVA: 0xB20D0 Offset: 0xB14D0 VA: 0x1800B20D0
	[DefaultValueAttribute] // RVA: 0xB20D0 Offset: 0xB14D0 VA: 0x1800B20D0
	[IODescriptionAttribute] // RVA: 0xB20D0 Offset: 0xB14D0 VA: 0x1800B20D0
	public string Filter { set; }
	[DefaultValueAttribute] // RVA: 0xB2390 Offset: 0xB1790 VA: 0x1800B2390
	[IODescriptionAttribute] // RVA: 0xB2390 Offset: 0xB1790 VA: 0x1800B2390
	public bool IncludeSubdirectories { get; }
	[IODescriptionAttribute] // RVA: 0xB2580 Offset: 0xB1980 VA: 0x1800B2580
	[DefaultValueAttribute] // RVA: 0xB2580 Offset: 0xB1980 VA: 0x1800B2580
	public NotifyFilters NotifyFilter { set; }
	[DefaultValueAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	[IODescriptionAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	[EditorAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	[SettingsBindableAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	[TypeConverterAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	public string Path { set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public override ISite Site { get; }

	// Methods

	// RVA: 0x155D870 Offset: 0x155CC70 VA: 0x18155D870
	public void .ctor() { }

	// RVA: 0x155CF30 Offset: 0x155C330 VA: 0x18155CF30
	private void InitWatcher() { }

	// RVA: 0x122B450 Offset: 0x122A850 VA: 0x18122B450
	internal bool get_Waiting() { }

	// RVA: 0x7ACC50 Offset: 0x7AC050 VA: 0x1807ACC50
	internal void set_Waiting(bool value) { }

	// RVA: 0x155DA50 Offset: 0x155CE50 VA: 0x18155DA50
	internal string get_MangledFilter() { }

	// RVA: 0x155DAB0 Offset: 0x155CEB0 VA: 0x18155DAB0
	internal SearchPattern2 get_Pattern() { }

	// RVA: 0x155D9B0 Offset: 0x155CDB0 VA: 0x18155D9B0
	internal string get_FullPath() { }

	// RVA: 0x155DC40 Offset: 0x155D040 VA: 0x18155DC40
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x155DC60 Offset: 0x155D060 VA: 0x18155DC60
	public void set_Filter(string value) { }

	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_IncludeSubdirectories() { }

	// RVA: 0x155DD10 Offset: 0x155D110 VA: 0x18155DD10
	public void set_NotifyFilter(NotifyFilters value) { }

	// RVA: 0x155DD50 Offset: 0x155D150 VA: 0x18155DD50
	public void set_Path(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	public override ISite get_Site() { }

	// RVA: 0x155CE50 Offset: 0x155C250 VA: 0x18155CE50 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x155CE90 Offset: 0x155C290 VA: 0x18155CE90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x155D300 Offset: 0x155C700 VA: 0x18155D300
	private void RaiseEvent(Delegate ev, EventArgs arg, FileSystemWatcher.EventType evtype) { }

	// RVA: 0x155D240 Offset: 0x155C640 VA: 0x18155D240
	protected void OnChanged(FileSystemEventArgs e) { }

	// RVA: 0x155D270 Offset: 0x155C670 VA: 0x18155D270
	protected void OnCreated(FileSystemEventArgs e) { }

	// RVA: 0x155D2A0 Offset: 0x155C6A0 VA: 0x18155D2A0
	protected void OnDeleted(FileSystemEventArgs e) { }

	// RVA: 0x155D2D0 Offset: 0x155C6D0 VA: 0x18155D2D0
	protected void OnRenamed(RenamedEventArgs e) { }

	// RVA: 0x155CBB0 Offset: 0x155BFB0 VA: 0x18155CBB0
	internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed) { }

	// RVA: 0x155D710 Offset: 0x155CB10 VA: 0x18155D710
	private void Start() { }

	// RVA: 0x155D790 Offset: 0x155CB90 VA: 0x18155D790
	private void Stop() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x155D910 Offset: 0x155CD10 VA: 0x18155D910
	public void add_Changed(FileSystemEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x155DBA0 Offset: 0x155CFA0 VA: 0x18155DBA0
	public void remove_Changed(FileSystemEventHandler value) { }

	// RVA: 0x10D8C30 Offset: 0x10D8030 VA: 0x1810D8C30
	private static int InternalSupportsFSW() { }

	// RVA: 0x155D810 Offset: 0x155CC10 VA: 0x18155D810
	private static void .cctor() { }

}

private enum FileSystemWatcher.EventType // TypeDefIndex: 2848
{	// Fields
	public int value__; // 0x0
	public const FileSystemWatcher.EventType FileSystemEvent = 0;
	public const FileSystemWatcher.EventType ErrorEvent = 1;
	public const FileSystemWatcher.EventType RenameEvent = 2;

}

public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 2948
{	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private bool m_preauthenticate; // 0x68
	private IWebProxy m_proxy; // 0x70
	private ManualResetEvent m_readerEvent; // 0x78
	private bool m_readPending; // 0x80
	private WebResponse m_response; // 0x88
	private Stream m_stream; // 0x90
	private bool m_syncHint; // 0x98
	private int m_timeout; // 0x9C
	private Uri m_uri; // 0xA0
	private bool m_writePending; // 0xA8
	private bool m_writing; // 0xA9
	private LazyAsyncResult m_WriteAResult; // 0xB0
	private LazyAsyncResult m_ReadAResult; // 0xB8
	private int m_Aborted; // 0xC0

	// Properties
	internal bool Aborted { get; }
	public override string ConnectionGroupName { set; }
	public override long ContentLength { get; set; }
	public override string ContentType { get; set; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; set; }

	// Methods

	// RVA: 0x155FA80 Offset: 0x155EE80 VA: 0x18155FA80
	internal void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB42C0 Offset: 0xB36C0 VA: 0x1800B42C0
	// RVA: 0x155F7A0 Offset: 0x155EBA0 VA: 0x18155F7A0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1188F90 Offset: 0x1188390 VA: 0x181188F90 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x155EB70 Offset: 0x155DF70 VA: 0x18155EB70 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x155FBD0 Offset: 0x155EFD0 VA: 0x18155FBD0
	internal bool get_Aborted() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x155FC70 Offset: 0x155F070 VA: 0x18155FC70 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x155FBE0 Offset: 0x155EFE0 VA: 0x18155FBE0 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x155FD00 Offset: 0x155F100 VA: 0x18155FD00 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 9
	public override string get_Method() { }

	// RVA: 0x155FD60 Offset: 0x155F160 VA: 0x18155FD60 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x155FE20 Offset: 0x155F220 VA: 0x18155FE20 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0xB96A10 Offset: 0xB95E10 VA: 0x180B96A10 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x155E0E0 Offset: 0x155D4E0 VA: 0x18155E0E0 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x155E430 Offset: 0x155D830 VA: 0x18155E430 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x155E6A0 Offset: 0x155DAA0 VA: 0x18155E6A0
	private bool CanGetRequestStream() { }

	// RVA: 0x155E710 Offset: 0x155DB10 VA: 0x18155E710 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x155E940 Offset: 0x155DD40 VA: 0x18155E940 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x155EF40 Offset: 0x155E340 VA: 0x18155EF40 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x155F420 Offset: 0x155E820 VA: 0x18155F420 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x155ED40 Offset: 0x155E140 VA: 0x18155ED40
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x155F150 Offset: 0x155E550 VA: 0x18155F150
	private static void GetResponseCallback(object state) { }

	// RVA: 0x155F630 Offset: 0x155EA30 VA: 0x18155F630
	internal void UnblockReader() { }

	// RVA: 0x155FC30 Offset: 0x155F030 VA: 0x18155FC30 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x155FE30 Offset: 0x155F230 VA: 0x18155FE30 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x155DE90 Offset: 0x155D290 VA: 0x18155DE90 Slot: 35
	public override void Abort() { }

	// RVA: 0x155F6F0 Offset: 0x155EAF0 VA: 0x18155F6F0
	private static void .cctor() { }

}

internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 2949
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x132A6E0 Offset: 0x1329AE0 VA: 0x18132A6E0 Slot: 4
	public WebRequest Create(Uri uri) { }

}

internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 2950
{	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x132B5F0 Offset: 0x132A9F0 VA: 0x18132B5F0
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x132B530 Offset: 0x132A930 VA: 0x18132B530
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x132B1E0 Offset: 0x132A5E0 VA: 0x18132B1E0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x132B440 Offset: 0x132A840 VA: 0x18132B440 Slot: 32
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x132B3A0 Offset: 0x132A7A0 VA: 0x18132B3A0 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x132B490 Offset: 0x132A890 VA: 0x18132B490 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x132AFE0 Offset: 0x132A3E0 VA: 0x18132AFE0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x132B2A0 Offset: 0x132A6A0 VA: 0x18132B2A0 Slot: 20
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x132B090 Offset: 0x132A490 VA: 0x18132B090 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x132B320 Offset: 0x132A720 VA: 0x18132B320 Slot: 23
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x132B140 Offset: 0x132A540 VA: 0x18132B140
	private void CheckError() { }

}

public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 2951
{	// Fields
	private bool m_closed; // 0x18
	private long m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Properties
	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x132ACF0 Offset: 0x132A0F0 VA: 0x18132ACF0
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[ObsoleteAttribute] // RVA: 0xB42C0 Offset: 0xB36C0 VA: 0x1800B42C0
	// RVA: 0x132AB30 Offset: 0x1329F30 VA: 0x18132AB30
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11879A0 Offset: 0x1186DA0 VA: 0x1811879A0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x132A810 Offset: 0x1329C10 VA: 0x18132A810 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x132AF80 Offset: 0x132A380 VA: 0x18132AF80 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x132AFA0 Offset: 0x132A3A0 VA: 0x18132AFA0 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x132AFC0 Offset: 0x132A3C0 VA: 0x18132AFC0 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x132A740 Offset: 0x1329B40 VA: 0x18132A740
	private void CheckDisposed() { }

	// RVA: 0x132A7D0 Offset: 0x1329BD0 VA: 0x18132A7D0 Slot: 9
	public override void Close() { }

	// RVA: 0x132A9E0 Offset: 0x1329DE0 VA: 0x18132A9E0 Slot: 15
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x132A950 Offset: 0x1329D50 VA: 0x18132A950 Slot: 12
	public override Stream GetResponseStream() { }

}

internal struct FileDetailsResult_t : ICallbackData // TypeDefIndex: 5402
{	// Fields
	internal Result Result; // 0x0
	internal ulong FileSize; // 0x8
	internal byte[] FileSHA; // 0x10
	internal uint Flags; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E55B0 Offset: 0x1E49B0 VA: 0x1801E55B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E55A0 Offset: 0x1E49A0 VA: 0x1801E55A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136AE50 Offset: 0x136A250 VA: 0x18136AE50
	private static void .cctor() { }

}

public class FileStorageCacheData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6465
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public byte[] data; // 0x18
	public uint entityId; // 0x20
	public uint numId; // 0x24
	public uint crc; // 0x28

	// Methods

	// RVA: 0x1D54700 Offset: 0x1D53B00 VA: 0x181D54700
	public static void ResetToPool(FileStorageCacheData instance) { }

	// RVA: 0x1D547B0 Offset: 0x1D53BB0 VA: 0x181D547B0
	public void ResetToPool() { }

	// RVA: 0x1D54390 Offset: 0x1D53790 VA: 0x181D54390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D53080 Offset: 0x1D52480 VA: 0x181D53080
	public void CopyTo(FileStorageCacheData instance) { }

	// RVA: 0x1D53140 Offset: 0x1D52540 VA: 0x181D53140
	public FileStorageCacheData Copy() { }

	// RVA: 0x1D53B30 Offset: 0x1D52F30 VA: 0x181D53B30
	public static FileStorageCacheData Deserialize(Stream stream) { }

	// RVA: 0x1D53530 Offset: 0x1D52930 VA: 0x181D53530
	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D535B0 Offset: 0x1D529B0 VA: 0x181D535B0
	public static FileStorageCacheData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D53D90 Offset: 0x1D53190 VA: 0x181D53D90
	public static FileStorageCacheData Deserialize(byte[] buffer) { }

	// RVA: 0x1D544C0 Offset: 0x1D538C0 VA: 0x181D544C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D54E10 Offset: 0x1D54210 VA: 0x181D54E10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D54E30 Offset: 0x1D54230 VA: 0x181D54E30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, FileStorageCacheData previous) { }

	// RVA: 0x1D546E0 Offset: 0x1D53AE0 VA: 0x181D546E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D540A0 Offset: 0x1D534A0 VA: 0x181D540A0
	public static FileStorageCacheData Deserialize(byte[] buffer, FileStorageCacheData instance, bool isDelta = False) { }

	// RVA: 0x1D53910 Offset: 0x1D52D10 VA: 0x181D53910
	public static FileStorageCacheData Deserialize(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D53240 Offset: 0x1D52640 VA: 0x181D53240
	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D53640 Offset: 0x1D52A40 VA: 0x181D53640
	public static FileStorageCacheData DeserializeLength(Stream stream, int length, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D54860 Offset: 0x1D53C60 VA: 0x181D54860
	public static void SerializeDelta(Stream stream, FileStorageCacheData instance, FileStorageCacheData previous) { }

	// RVA: 0x1D54C50 Offset: 0x1D54050 VA: 0x181D54C50
	public static void Serialize(Stream stream, FileStorageCacheData instance) { }

	// RVA: 0x1D54E00 Offset: 0x1D54200 VA: 0x181D54E00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D54E10 Offset: 0x1D54210 VA: 0x181D54E10
	public void ToProto(Stream stream) { }

	// RVA: 0x1D54B40 Offset: 0x1D53F40 VA: 0x181D54B40
	public static byte[] SerializeToBytes(FileStorageCacheData instance) { }

	// RVA: 0x1D54A90 Offset: 0x1D53E90 VA: 0x181D54A90
	public static void SerializeLengthDelimited(Stream stream, FileStorageCacheData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public static class FileSystem // TypeDefIndex: 6659
{	// Fields
	public static bool LogDebug; // 0x0
	public static bool LogTime; // 0x1
	public static FileSystemBackend Backend; // 0x8

	// Methods

	// RVA: 0x22B8A80 Offset: 0x22B7E80 VA: 0x1822B8A80
	public static GameObject[] LoadPrefabs(string folder) { }

	// RVA: 0x22B8970 Offset: 0x22B7D70 VA: 0x1822B8970
	public static GameObject LoadPrefab(string filePath) { }

	// RVA: 0x22B88E0 Offset: 0x22B7CE0 VA: 0x1822B88E0
	public static string[] FindAll(string folder, string search = "") { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA0030 Offset: 0x1A9F430 VA: 0x181AA0030
	|-FileSystem.LoadAll<Sprite>
	|-FileSystem.LoadAll<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9FF70 Offset: 0x1A9F370 VA: 0x181A9FF70
	|-FileSystem.LoadAllFromBundle<Skinnable>
	|-FileSystem.LoadAllFromBundle<GameObject>
	|-FileSystem.LoadAllFromBundle<object>
	*/

	// RVA: -1 Offset: -1
	public static T Load<T>(string filePath, bool complain = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E70F0 Offset: 0x5E64F0 VA: 0x1805E70F0
	|-FileSystem.Load<GameManifest>
	|-FileSystem.Load<ItemSkin>
	|-FileSystem.Load<ItemSkinDirectory>
	|-FileSystem.Load<SoundDefinition>
	|-FileSystem.Load<SteamInventoryItem>
	|-FileSystem.Load<Font>
	|-FileSystem.Load<GameObject>
	|-FileSystem.Load<Material>
	|-FileSystem.Load<Object>
	|-FileSystem.Load<Sprite>
	|-FileSystem.Load<TextAsset>
	|-FileSystem.Load<Texture>
	|-FileSystem.Load<object>
	*/

	// RVA: 0x22B8BF0 Offset: 0x22B7FF0 VA: 0x1822B8BF0
	public static AssetPreloadResult PreloadAssets(IEnumerable<string> filePaths, int maxConcurrency, int priority = 0) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public abstract class FileSystemBackend // TypeDefIndex: 6660
{	// Fields
	public bool isError; // 0x10
	public string loadingError; // 0x18
	public Dictionary<string, Object> cache; // 0x20

	// Methods

	// RVA: 0x22B8240 Offset: 0x22B7640 VA: 0x1822B8240
	public GameObject[] LoadPrefabs(string folder) { }

	// RVA: 0x22B8180 Offset: 0x22B7580 VA: 0x1822B8180
	public GameObject LoadPrefab(string filePath) { }

	// RVA: 0x22B80E0 Offset: 0x22B74E0 VA: 0x1822B80E0
	public string[] FindAll(string folder, string search = "") { }

	// RVA: -1 Offset: -1
	public T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9FE10 Offset: 0x1A9F210 VA: 0x181A9FE10
	|-FileSystemBackend.LoadAll<object>
	|-FileSystemBackend.LoadAll<GameObject>
	*/

	// RVA: -1 Offset: -1
	public T Load<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E6F60 Offset: 0x5E6360 VA: 0x1805E6F60
	|-FileSystemBackend.Load<object>
	|-FileSystemBackend.Load<GameObject>
	*/

	// RVA: 0x22B8360 Offset: 0x22B7760 VA: 0x1822B8360
	public AssetPreloadResult PreloadAssets(IEnumerable<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22B8100 Offset: 0x22B7500 VA: 0x1822B8100
	protected void LoadError(string err) { }

	// RVA: 0x22B8790 Offset: 0x22B7B90 VA: 0x1822B8790 Slot: 4
	public virtual List<string> UnloadBundles(string partialName) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract T LoadAsset<T>(string filePath);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-FileSystemBackend.LoadAsset<object>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string[] LoadAssetList(string folder, string search);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract T[] LoadAllFromBundle<T>(string bundleName, string editorSearch);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-FileSystemBackend.LoadAllFromBundle<object>
	*/

	// RVA: 0x22B87E0 Offset: 0x22B7BE0 VA: 0x1822B87E0
	protected void .ctor() { }

}

public class FileDialog : MonoBehaviour // TypeDefIndex: 7066
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string result; // 0x18
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FileDialog.FileDialogMode mode; // 0x20
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool finished; // 0x24
	[HeaderAttribute] // RVA: 0x77A20 Offset: 0x76E20 VA: 0x180077A20
	public Image windowIcon; // 0x28
	public Text windowName; // 0x30
	public InputField currentPath; // 0x38
	public InputField fileName; // 0x40
	public Button up; // 0x48
	public Button commit; // 0x50
	public Button cancel; // 0x58
	public GameObject filesScrollRectContent; // 0x60
	public GameObject drivesScrollRectContent; // 0x68
	[HeaderAttribute] // RVA: 0x77B80 Offset: 0x76F80 VA: 0x180077B80
	public GameObject filesScrollRectElement; // 0x70
	public GameObject drivesScrollRectElement; // 0x78
	[HeaderAttribute] // RVA: 0x77C70 Offset: 0x77070 VA: 0x180077C70
	public Sprite folderIcon; // 0x80
	public Sprite fileIcon; // 0x88
	private string workingPath; // 0x90
	private string workingFile; // 0x98
	private string[] allowedExtensions; // 0xA0
	private long maxSize; // 0xA8
	private bool saveLastPath; // 0xB0

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x77D80 Offset: 0x77180 VA: 0x180077D80
	// RVA: 0xFBA500 Offset: 0xFB9900 VA: 0x180FBA500
	public IEnumerator Open(string path, string allowedExtensions, string windowName = "OPEN FILE", Sprite windowIcon, long maxSize = -1, bool saveLastPath = True) { }

	[IteratorStateMachineAttribute] // RVA: 0x77F80 Offset: 0x77380 VA: 0x180077F80
	// RVA: 0xFBA750 Offset: 0xFB9B50 VA: 0x180FBA750
	public IEnumerator Save(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x78180 Offset: 0x77580 VA: 0x180078180
	// RVA: 0xFBA5E0 Offset: 0xFB99E0 VA: 0x180FBA5E0
	public Task<string> SaveAsync(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	private void Hide() { }

	// RVA: 0xFBA0D0 Offset: 0xFB94D0 VA: 0x180FBA0D0
	public void GoUp() { }

	// RVA: 0xFB9E50 Offset: 0xFB9250 VA: 0x180FB9E50
	public void GoTo(string newPath) { }

	// RVA: 0xFBA830 Offset: 0xFB9C30 VA: 0x180FBA830
	public void SelectFile(string file) { }

	// RVA: 0xFBA170 Offset: 0xFB9570 VA: 0x180FBA170
	public void OnCommitClick() { }

	// RVA: 0xFBA120 Offset: 0xFB9520 VA: 0x180FBA120
	public void OnCancelClick() { }

	// RVA: 0xFB9D00 Offset: 0xFB9100 VA: 0x180FB9D00
	public void ClearSelection() { }

	// RVA: 0xFBA380 Offset: 0xFB9780 VA: 0x180FBA380
	public void OnTypedFilename(string newName) { }

	// RVA: 0xFBA250 Offset: 0xFB9650 VA: 0x180FBA250
	public void OnTypedEnd(string newName) { }

	// RVA: 0xFBAD30 Offset: 0xFBA130 VA: 0x180FBAD30
	public void UpdateFileInfo() { }

	// RVA: 0xFBA410 Offset: 0xFB9810 VA: 0x180FBA410
	public void OpenDir(string path) { }

	// RVA: 0xFBAD00 Offset: 0xFBA100 VA: 0x180FBAD00
	private void UpdateElements() { }

	// RVA: 0xFBA9A0 Offset: 0xFB9DA0 VA: 0x180FBA9A0
	private void UpdateDrivesList() { }

	// RVA: 0xFB9D60 Offset: 0xFB9160 VA: 0x180FB9D60
	private string GetFileSizeText(long size) { }

	// RVA: 0xFBAEF0 Offset: 0xFBA2F0 VA: 0x180FBAEF0
	private void UpdateFilesList() { }

	// RVA: 0xFBC070 Offset: 0xFBB470 VA: 0x180FBC070
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFBA920 Offset: 0xFB9D20 VA: 0x180FBA920
	private bool <UpdateFilesList>b__39_0(FileInfo f) { }

}

public enum FileDialog.FileDialogMode // TypeDefIndex: 7067
{	// Fields
	public int value__; // 0x0
	public const FileDialog.FileDialogMode Open = 0;
	public const FileDialog.FileDialogMode Save = 1;

}

private sealed class FileDialog.<Open>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7068
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FileDialog <>4__this; // 0x20
	public long maxSize; // 0x28
	public bool saveLastPath; // 0x30
	public string allowedExtensions; // 0x38
	public string path; // 0x40
	public string windowName; // 0x48
	public Sprite windowIcon; // 0x50

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

	// RVA: 0xFD1B30 Offset: 0xFD0F30 VA: 0x180FD1B30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD1E80 Offset: 0xFD1280 VA: 0x180FD1E80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FileDialog.<Save>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7069
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FileDialog <>4__this; // 0x20
	public bool saveLastPath; // 0x28
	public string allowedExtensions; // 0x30
	public string path; // 0x38
	public string windowName; // 0x40
	public Sprite windowIcon; // 0x48

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

	// RVA: 0xFD2340 Offset: 0xFD1740 VA: 0x180FD2340 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD2680 Offset: 0xFD1A80 VA: 0x180FD2680 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct FileDialog.<SaveAsync>d__24 : IAsyncStateMachine // TypeDefIndex: 7070
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public FileDialog <>4__this; // 0x20
	public bool saveLastPath; // 0x28
	public string allowedExtensions; // 0x30
	public string path; // 0x38
	public string windowName; // 0x40
	public Sprite windowIcon; // 0x48
	private TaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x14B7F0 Offset: 0x14ABF0 VA: 0x18014B7F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14B800 Offset: 0x14AC00 VA: 0x18014B800 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class FileListElement : MonoBehaviour // TypeDefIndex: 7071
{	// Fields
	public Image icon; // 0x18
	public Text elementName; // 0x20
	public Text size; // 0x28
	public FileDialog instance; // 0x30
	public bool isFile; // 0x38
	public string data; // 0x40

	// Methods

	// RVA: 0xFBC090 Offset: 0xFBB490 VA: 0x180FBC090
	public void OnClick() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

internal static class FileUtilities // TypeDefIndex: 7615
{	// Methods

	// RVA: 0x13930A0 Offset: 0x13924A0 VA: 0x1813930A0
	private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	// RVA: 0x1393360 Offset: 0x1392760 VA: 0x181393360
	internal static FileStream OpenFileForRead(string filePath) { }

	// RVA: 0x13931C0 Offset: 0x13925C0 VA: 0x1813931C0
	private static SafeFileHandle GetFileHandle(string filePath, uint fileAccess, uint creationDisposition) { }

}

public class FileSystem_Warmup : MonoBehaviour // TypeDefIndex: 9370
{	// Fields
	public static bool ranInBackground; // 0x0
	private static bool run; // 0x1
	public static string[] ExcludeFilter; // 0x8

	// Methods

	// RVA: 0x785E10 Offset: 0x785210 VA: 0x180785E10
	public static void Run() { }

	// RVA: 0x785F90 Offset: 0x785390 VA: 0x180785F90
	public static IEnumerator Run(string[] assetList, Action<string> statusFunction, string format, int priority = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7AB0 Offset: 0xE6EB0 VA: 0x1800E7AB0
	// RVA: 0x785CC0 Offset: 0x7850C0 VA: 0x180785CC0
	private static IEnumerator RunAsyncImpl(string[] assetList, Action<string> statusFunction, string format, int priority) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7B30 Offset: 0xE6F30 VA: 0x1800E7B30
	// RVA: 0x785D70 Offset: 0x785170 VA: 0x180785D70
	private static IEnumerator RunImpl(string[] assetList, Action<string> statusFunction, string format) { }

	// RVA: 0x785830 Offset: 0x784C30 VA: 0x180785830
	private static float CalculateFrameBudget() { }

	// RVA: 0x786140 Offset: 0x785540 VA: 0x180786140
	private static bool ShouldIgnore(string path) { }

	// RVA: 0x785860 Offset: 0x784C60 VA: 0x180785860
	public static string[] GetAssetList(Nullable<bool> poolFilter) { }

	// RVA: 0x785C40 Offset: 0x785040 VA: 0x180785C40
	private static void PrefabWarmup(string path) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x786270 Offset: 0x785670 VA: 0x180786270
	private static void .cctor() { }

}

private sealed class FileSystem_Warmup.<RunAsyncImpl>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9371
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string[] assetList; // 0x20
	public int priority; // 0x28
	public Action<string> statusFunction; // 0x30
	public string format; // 0x38
	private Stopwatch <sw>5__2; // 0x40
	private AssetPreloadResult <preload>5__3; // 0x48
	private int <warmupIndex>5__4; // 0x50

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

	// RVA: 0x7973D0 Offset: 0x7967D0 VA: 0x1807973D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x797810 Offset: 0x796C10 VA: 0x180797810 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FileSystem_Warmup.<RunImpl>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9372
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string[] assetList; // 0x20
	public Action<string> statusFunction; // 0x28
	public string format; // 0x30
	private Stopwatch <sw>5__2; // 0x38
	private int <i>5__3; // 0x40

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

	// RVA: 0x797860 Offset: 0x796C60 VA: 0x180797860 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x797BC0 Offset: 0x796FC0 VA: 0x180797BC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FileSystem_Warmup.<>c__DisplayClass9_0 // TypeDefIndex: 9373
{	// Fields
	public Nullable<bool> poolFilter; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x798000 Offset: 0x797400 VA: 0x180798000
	internal bool <GetAssetList>b__2(GameManifest.PrefabProperties x) { }

}

private sealed class FileSystem_Warmup.<>c // TypeDefIndex: 9374
{	// Fields
	public static readonly FileSystem_Warmup.<>c <>9; // 0x0
	public static Func<GameManifest.PrefabProperties, string> <>9__9_0; // 0x8
	public static Func<string, bool> <>9__9_1; // 0x10
	public static Func<GameManifest.PrefabProperties, string> <>9__9_3; // 0x18

	// Methods

	// RVA: 0x7981C0 Offset: 0x7975C0 VA: 0x1807981C0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal string <GetAssetList>b__9_0(GameManifest.PrefabProperties x) { }

	// RVA: 0x797C10 Offset: 0x797010 VA: 0x180797C10
	internal bool <GetAssetList>b__9_1(string x) { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal string <GetAssetList>b__9_3(GameManifest.PrefabProperties x) { }

}

public class FileStorage : IDisposable // TypeDefIndex: 10718
{	// Fields
	private Database db; // 0x10
	private CRC32 crc; // 0x18
	private MruDictionary<uint, FileStorage.CacheData> _cache; // 0x20
	public static FileStorage client; // 0x0

	// Methods

	// RVA: 0x785790 Offset: 0x784B90 VA: 0x180785790
	protected void .ctor(string name, bool server) { }

	// RVA: 0x784520 Offset: 0x783920 VA: 0x180784520 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x7844E0 Offset: 0x7838E0 VA: 0x1807844E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x7845C0 Offset: 0x7839C0 VA: 0x1807845C0
	private uint GetCRC(byte[] data, FileStorage.Type type) { }

	// RVA: 0x7854C0 Offset: 0x7848C0 VA: 0x1807854C0
	public uint Store(byte[] data, FileStorage.Type type, uint entityID, uint numID = 0) { }

	// RVA: 0x784940 Offset: 0x783D40 VA: 0x180784940
	public byte[] Get(uint crc, FileStorage.Type type, uint entityID, uint numID = 0) { }

	// RVA: 0x7851D0 Offset: 0x7845D0 VA: 0x1807851D0
	public void Remove(uint crc, FileStorage.Type type, uint entityID) { }

	// RVA: 0x785090 Offset: 0x784490 VA: 0x180785090
	public void RemoveExact(uint crc, FileStorage.Type type, uint entityID, uint numid) { }

	// RVA: 0x784DD0 Offset: 0x7841D0 VA: 0x180784DD0
	public void RemoveEntityNum(uint entityid, uint numid) { }

	// RVA: 0x784CE0 Offset: 0x7840E0 VA: 0x180784CE0
	internal void RemoveAllByEntity(uint entityid) { }

	// RVA: 0x784BE0 Offset: 0x783FE0 VA: 0x180784BE0
	public void ReassignEntityId(uint oldId, uint newId) { }

	// RVA: 0x784730 Offset: 0x783B30 VA: 0x180784730
	public List<FileStorageCacheData> GetCacheData() { }

	// RVA: 0x785300 Offset: 0x784700 VA: 0x180785300
	public void SetCache(List<FileStorageCacheData> data) { }

	// RVA: 0x784490 Offset: 0x783890 VA: 0x180784490
	public void ClearCache() { }

	// RVA: 0x785680 Offset: 0x784A80 VA: 0x180785680
	private static void .cctor() { }

}

private class FileStorage.CacheData // TypeDefIndex: 10719
{	// Fields
	public byte[] data; // 0x10
	public uint entityID; // 0x18
	public uint numID; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum FileStorage.Type // TypeDefIndex: 10720
{	// Fields
	public int value__; // 0x0
	public const FileStorage.Type png = 0;
	public const FileStorage.Type jpg = 1;
	public const FileStorage.Type ogg = 2;

}

private sealed class FileStorage.<>c__DisplayClass14_0 // TypeDefIndex: 10721
{	// Fields
	public uint entityid; // 0x10
	public uint numid; // 0x14
	public Func<KeyValuePair<uint, FileStorage.CacheData>, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x797F20 Offset: 0x797320 VA: 0x180797F20
	internal bool <RemoveEntityNum>b__0(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

private sealed class FileStorage.<>c // TypeDefIndex: 10722
{	// Fields
	public static readonly FileStorage.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, FileStorage.CacheData>, uint> <>9__14_1; // 0x8

	// Methods

	// RVA: 0x798100 Offset: 0x797500 VA: 0x180798100
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x797EB0 Offset: 0x7972B0 VA: 0x180797EB0
	internal uint <RemoveEntityNum>b__14_1(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

public static class FileEx // TypeDefIndex: 11342
{	// Methods

	// RVA: 0x784070 Offset: 0x783470 VA: 0x180784070
	public static void Backup(DirectoryInfo parent, string[] names) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7843E0 Offset: 0x7837E0 VA: 0x1807843E0
	public static bool MoveToSafe(FileInfo parent, string target, int retries = 10) { }

	// RVA: 0x7841A0 Offset: 0x7835A0 VA: 0x1807841A0
	public static void Backup(string[] names) { }

}

public class FileConVar : ConsoleSystem // TypeDefIndex: 11918
{	// Properties
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool time { get; set; }

	// Methods

	// RVA: 0x6DDF30 Offset: 0x6DD330 VA: 0x1806DDF30
	public static bool get_debug() { }

	// RVA: 0x6DDFF0 Offset: 0x6DD3F0 VA: 0x1806DDFF0
	public static void set_debug(bool value) { }

	// RVA: 0x6DDF90 Offset: 0x6DD390 VA: 0x1806DDF90
	public static bool get_time() { }

	// RVA: 0x6DE050 Offset: 0x6DD450 VA: 0x1806DE050
	public static void set_time(bool value) { }

	// RVA: 0x6DDED0 Offset: 0x6DD2D0 VA: 0x1806DDED0
	public void .ctor() { }

}

