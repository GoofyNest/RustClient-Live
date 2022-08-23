internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 482
{	private ResourceManager.ResourceManagerMediator _mediator; // 0x10


	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	private string FindResourceFile(CultureInfo culture, string fileName) { }

	private ResourceSet CreateResourceSet(string file) { }

}

public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 623
{	private string _name; // 0x60

	public override string Name { get; }
	public long Length { get; }
	public string DirectoryName { get; }
	public DirectoryInfo Directory { get; }
	public override bool Exists { get; }


	public void .ctor(string fileName) { }

	private void Init(string fileName, bool checkHost) { }

	private string GetDisplayPath(string originalPath) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(string fullPath, bool ignoreThis) { }

	public override string get_Name() { }

	public long get_Length() { }

	public string get_DirectoryName() { }

	public DirectoryInfo get_Directory() { }

	public StreamWriter CreateText() { }

	public StreamWriter AppendText() { }

	public FileInfo CopyTo(string destFileName, bool overwrite) { }

	public override void Delete() { }

	public override bool get_Exists() { }

	public void MoveTo(string destFileName) { }

	public override string ToString() { }

}

public class FileLoadException : IOException // TypeDefIndex: 624
{	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	public override string Message { get; }
	public string FusionLog { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	public override string get_Message() { }

	private void SetMessageField() { }

	public override string ToString() { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public string get_FusionLog() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }

}

public class FileNotFoundException : IOException // TypeDefIndex: 625
{	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	public override string Message { get; }
	public string FusionLog { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, string fileName) { }

	public override string get_Message() { }

	private void SetMessageField() { }

	public override string ToString() { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public string get_FusionLog() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

internal static class FileSystemEnumerableFactory // TypeDefIndex: 626
{
	internal static IEnumerable<string> CreateFileNameIterator(string path, string originalUserPath, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

}

internal class FileSystemEnumerableIterator<TSource> : Iterator<TSource> // TypeDefIndex: 628
{	private SearchResultHandler<TSource> _resultHandler; // 0x0
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


	internal void .ctor(string path, string originalUserPath, string searchPattern, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>..ctor
	|-FileSystemEnumerableIterator<string>..ctor
	*/

	private void CommonInit() { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.CommonInit
	*/

	private void .ctor(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>..ctor
	*/

	protected override Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.Clone
	*/

	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.MoveNext
	*/

	private SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.CreateSearchResult
	*/

	private void HandleError(int hr, string path) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.HandleError
	*/

	private void AddSearchableDirsToStack(Directory.SearchData localSearchData) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.AddSearchableDirsToStack
	*/

	internal void DoDemand(string fullPathToDemand) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.DoDemand
	*/

	private static string NormalizeSearchPattern(string searchPattern) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.NormalizeSearchPattern
	*/

	private static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.GetNormalizedSearchCriteria
	*/

	private static string GetFullSearchString(string fullPath, string searchPattern) { }
	/* GenericInstMethod :
	|
	|-FileSystemEnumerableIterator<object>.GetFullSearchString
	*/

}

internal static class FileSystemEnumerableHelpers // TypeDefIndex: 632
{
	internal static bool IsDir(Win32Native.WIN32_FIND_DATA data) { }

	internal static bool IsFile(Win32Native.WIN32_FIND_DATA data) { }

}

public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 633
{	internal MonoIOStat _data; // 0x18
	internal int _dataInitialised; // 0x40
	protected string FullPath; // 0x48
	protected string OriginalPath; // 0x50
	private string _displayPath; // 0x58

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


	protected void .ctor() { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public virtual string get_FullName() { }

	public string get_Extension() { }

	public abstract string get_Name();

	public abstract bool get_Exists();

	public abstract void Delete();

	public DateTime get_CreationTime() { }

	public void set_CreationTime(DateTime value) { }

	public DateTime get_CreationTimeUtc() { }

	public void set_CreationTimeUtc(DateTime value) { }

	public DateTime get_LastAccessTime() { }

	public void set_LastAccessTime(DateTime value) { }

	public DateTime get_LastAccessTimeUtc() { }

	public void set_LastAccessTimeUtc(DateTime value) { }

	public DateTime get_LastWriteTime() { }

	public void set_LastWriteTime(DateTime value) { }

	public DateTime get_LastWriteTimeUtc() { }

	public void set_LastWriteTimeUtc(DateTime value) { }

	public void Refresh() { }

	public FileAttributes get_Attributes() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal string get_DisplayPath() { }

	internal void set_DisplayPath(string value) { }

}

public static class File // TypeDefIndex: 663
{	private static Nullable<DateTime> defaultLocalFileTime; // 0x13060

	private static DateTime DefaultLocalFileTime { get; }


	public static void AppendAllText(string path, string contents) { }

	public static void Copy(string sourceFileName, string destFileName) { }

	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	internal static string InternalCopy(string sourceFileName, string destFileName, bool overwrite, bool checkHost) { }

	public static FileStream Create(string path) { }

	public static FileStream Create(string path, int bufferSize) { }

	public static void Delete(string path) { }

	public static bool Exists(string path) { }

	public static FileAttributes GetAttributes(string path) { }

	public static DateTime GetCreationTime(string path) { }

	public static DateTime GetLastWriteTime(string path) { }

	public static void Move(string sourceFileName, string destFileName) { }

	public static FileStream Open(string path, FileMode mode) { }

	public static FileStream OpenRead(string path) { }

	public static StreamReader OpenText(string path) { }

	public static void SetCreationTime(string path, DateTime creationTime) { }

	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	public static byte[] ReadAllBytes(string path) { }

	public static string ReadAllText(string path) { }

	public static void WriteAllBytes(string path, byte[] bytes) { }

	public static void WriteAllText(string path, string contents) { }

	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	private static DateTime get_DefaultLocalFileTime() { }

	public static IEnumerable<string> ReadLines(string path) { }

	[IteratorStateMachineAttribute] // RVA: 0xA7200 Offset: 0xA6600 VA: 0x1800A7200
	private static IEnumerable<string> ReadLines(StreamReader reader) { }

	internal static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound) { }

}

private sealed class File.<ReadLines>d__58 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 664
{	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private StreamReader reader; // 0x28
	public StreamReader <>3__reader; // 0x30
	private string <s>5__1; // 0x38
	private StreamReader <>7__wrap1; // 0x40

	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public enum FileAccess // TypeDefIndex: 665
{	public int value__; // 0x0
	public const FileAccess Read = 1;
	public const FileAccess Write = 2;
	public const FileAccess ReadWrite = 3;

}

public enum FileAttributes // TypeDefIndex: 666
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const FileMode CreateNew = 1;
	public const FileMode Create = 2;
	public const FileMode Open = 3;
	public const FileMode OpenOrCreate = 4;
	public const FileMode Truncate = 5;
	public const FileMode Append = 6;

}

public enum FileOptions // TypeDefIndex: 668
{	public int value__; // 0x0
	public const FileOptions None = 0;
	public const FileOptions Encrypted = 16384;
	public const FileOptions DeleteOnClose = 67108864;
	public const FileOptions SequentialScan = 134217728;
	public const FileOptions RandomAccess = 268435456;
	public const FileOptions Asynchronous = 1073741824;
	public const FileOptions WriteThrough = -2147483648;

}

public enum FileShare // TypeDefIndex: 669
{	public int value__; // 0x0
	public const FileShare None = 0;
	public const FileShare Read = 1;
	public const FileShare Write = 2;
	public const FileShare ReadWrite = 3;
	public const FileShare Delete = 4;
	public const FileShare Inheritable = 16;

}

public class FileStream : Stream // TypeDefIndex: 670
{	private static byte[] buf_recycle; // 0x0
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

	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public string Name { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }


	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	public void .ctor(string path, FileMode mode) { }

	public void .ctor(string path, FileMode mode, FileAccess access) { }

	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	public void .ctor(SafeFileHandle handle, FileAccess access) { }

	public void .ctor(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = False, bool checkHost = False) { }

	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override bool get_CanSeek() { }

	public string get_Name() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public virtual SafeFileHandle get_SafeFileHandle() { }

	private void ExposeHandle() { }

	public override int ReadByte() { }

	public override void WriteByte(byte value) { }

	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	private int ReadInternal(byte[] dest, int offset, int count) { }

	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override void Write(byte[] array, int offset, int count) { }

	private void WriteInternal(byte[] src, int offset, int count) { }

	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	public override void Flush() { }

	protected override void Finalize() { }

	protected override void Dispose(bool disposing) { }

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	private int WriteSegment(byte[] src, int src_offset, int count) { }

	private void FlushBuffer() { }

	private void FlushBufferIfDirty() { }

	private void RefillBuffer() { }

	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	private void InitBuffer(int size, bool isZeroSize) { }

	private string GetSecureFileName(string filename) { }

	private string GetSecureFileName(string filename, bool full) { }

	private static void .cctor() { }

}

private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 671
{
	public void .ctor(object object, IntPtr method) { }

	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 672
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 673
{	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }


	public void .ctor(AsyncCallback cb, object state) { }

	private static void CBWrapper(IAsyncResult ares) { }

	public object get_AsyncState() { }

	public bool get_CompletedSynchronously() { }

	public WaitHandle get_AsyncWaitHandle() { }

	public bool get_IsCompleted() { }

}

internal class FileData // TypeDefIndex: 2840
{	public string Directory; // 0x10
	public FileAttributes Attributes; // 0x18
	public bool NotExists; // 0x1C
	public DateTime CreationTime; // 0x20
	public DateTime LastWriteTime; // 0x28


	public void .ctor() { }

}

internal enum FileAction // TypeDefIndex: 2844
{	public int value__; // 0x0
	public const FileAction Added = 1;
	public const FileAction Removed = 2;
	public const FileAction Modified = 3;
	public const FileAction RenamedOldName = 4;
	public const FileAction RenamedNewName = 5;

}

public class FileSystemEventArgs : EventArgs // TypeDefIndex: 2845
{	private WatcherChangeTypes changeType; // 0x10
	private string directory; // 0x18
	private string name; // 0x20

	public string FullPath { get; }


	public void .ctor(WatcherChangeTypes changeType, string directory, string name) { }

	public string get_FullPath() { }

}

public sealed class FileSystemEventHandler : MulticastDelegate // TypeDefIndex: 2846
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, FileSystemEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, FileSystemEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class FileSystemWatcher : Component // TypeDefIndex: 2847
{	private bool enableRaisingEvents; // 0x28
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


	public void .ctor() { }

	private void InitWatcher() { }

	internal bool get_Waiting() { }

	internal void set_Waiting(bool value) { }

	internal string get_MangledFilter() { }

	internal SearchPattern2 get_Pattern() { }

	internal string get_FullPath() { }

	public void set_EnableRaisingEvents(bool value) { }

	public void set_Filter(string value) { }

	public bool get_IncludeSubdirectories() { }

	public void set_NotifyFilter(NotifyFilters value) { }

	public void set_Path(string value) { }

	public override ISite get_Site() { }

	protected override void Dispose(bool disposing) { }

	protected override void Finalize() { }

	private void RaiseEvent(Delegate ev, EventArgs arg, FileSystemWatcher.EventType evtype) { }

	protected void OnChanged(FileSystemEventArgs e) { }

	protected void OnCreated(FileSystemEventArgs e) { }

	protected void OnDeleted(FileSystemEventArgs e) { }

	protected void OnRenamed(RenamedEventArgs e) { }

	internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed) { }

	private void Start() { }

	private void Stop() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_Changed(FileSystemEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_Changed(FileSystemEventHandler value) { }

	private static int InternalSupportsFSW() { }

	private static void .cctor() { }

}

private enum FileSystemWatcher.EventType // TypeDefIndex: 2848
{	public int value__; // 0x0
	public const FileSystemWatcher.EventType FileSystemEvent = 0;
	public const FileSystemWatcher.EventType ErrorEvent = 1;
	public const FileSystemWatcher.EventType RenameEvent = 2;

}

public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 2948
{	private static WaitCallback s_GetRequestStreamCallback; // 0x0
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


	internal void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB42C0 Offset: 0xB36C0 VA: 0x1800B42C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal bool get_Aborted() { }

	public override void set_ConnectionGroupName(string value) { }

	public override long get_ContentLength() { }

	public override void set_ContentLength(long value) { }

	public override string get_ContentType() { }

	public override void set_ContentType(string value) { }

	public override ICredentials get_Credentials() { }

	public override void set_Credentials(ICredentials value) { }

	public override WebHeaderCollection get_Headers() { }

	public override string get_Method() { }

	public override void set_Method(string value) { }

	public override void set_PreAuthenticate(bool value) { }

	public override IWebProxy get_Proxy() { }

	public override void set_Proxy(IWebProxy value) { }

	public override int get_Timeout() { }

	public override Uri get_RequestUri() { }

	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	private bool CanGetRequestStream() { }

	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	public override Stream GetRequestStream() { }

	public override WebResponse GetResponse() { }

	private static void GetRequestStreamCallback(object state) { }

	private static void GetResponseCallback(object state) { }

	internal void UnblockReader() { }

	public override bool get_UseDefaultCredentials() { }

	public override void set_UseDefaultCredentials(bool value) { }

	public override void Abort() { }

	private static void .cctor() { }

}

internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 2949
{
	internal void .ctor() { }

	public WebRequest Create(Uri uri) { }

}

internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 2950
{	private FileWebRequest m_request; // 0x70


	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	protected override void Dispose(bool disposing) { }

	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	public override int Read(byte[] buffer, int offset, int size) { }

	public override void Write(byte[] buffer, int offset, int size) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public override int EndRead(IAsyncResult ar) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public override void EndWrite(IAsyncResult ar) { }

	private void CheckError() { }

}

public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 2951
{	private bool m_closed; // 0x18
	private long m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }


	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[ObsoleteAttribute] // RVA: 0xB42C0 Offset: 0xB36C0 VA: 0x1800B42C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override long get_ContentLength() { }

	public override WebHeaderCollection get_Headers() { }

	public override Uri get_ResponseUri() { }

	private void CheckDisposed() { }

	public override void Close() { }

	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	public override Stream GetResponseStream() { }

}

internal struct FileDetailsResult_t : ICallbackData // TypeDefIndex: 5402
{	internal Result Result; // 0x0
	internal ulong FileSize; // 0x8
	internal byte[] FileSHA; // 0x10
	internal uint Flags; // 0x18
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public class FileStorageCacheData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6465
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public byte[] data; // 0x18
	public uint entityId; // 0x20
	public uint numId; // 0x24
	public uint crc; // 0x28


	public static void ResetToPool(FileStorageCacheData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(FileStorageCacheData instance) { }

	public FileStorageCacheData Copy() { }

	public static FileStorageCacheData Deserialize(Stream stream) { }

	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream) { }

	public static FileStorageCacheData DeserializeLength(Stream stream, int length) { }

	public static FileStorageCacheData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, FileStorageCacheData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static FileStorageCacheData Deserialize(byte[] buffer, FileStorageCacheData instance, bool isDelta = False) { }

	public static FileStorageCacheData Deserialize(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	public static FileStorageCacheData DeserializeLength(Stream stream, int length, FileStorageCacheData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, FileStorageCacheData instance, FileStorageCacheData previous) { }

	public static void Serialize(Stream stream, FileStorageCacheData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(FileStorageCacheData instance) { }

	public static void SerializeLengthDelimited(Stream stream, FileStorageCacheData instance) { }

	public void .ctor() { }

}

public static class FileSystem // TypeDefIndex: 6659
{	public static bool LogDebug; // 0x0
	public static bool LogTime; // 0x1
	public static FileSystemBackend Backend; // 0x8


	public static GameObject[] LoadPrefabs(string folder) { }

	public static GameObject LoadPrefab(string filePath) { }

	public static string[] FindAll(string folder, string search = "") { }

	public static T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-FileSystem.LoadAll<Sprite>
	|-FileSystem.LoadAll<object>
	*/

	public static T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-FileSystem.LoadAllFromBundle<Skinnable>
	|-FileSystem.LoadAllFromBundle<GameObject>
	|-FileSystem.LoadAllFromBundle<object>
	*/

	public static T Load<T>(string filePath, bool complain = True) { }
	/* GenericInstMethod :
	|
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

	public static AssetPreloadResult PreloadAssets(IEnumerable<string> filePaths, int maxConcurrency, int priority = 0) { }

	private static void .cctor() { }

}

public abstract class FileSystemBackend // TypeDefIndex: 6660
{	public bool isError; // 0x10
	public string loadingError; // 0x18
	public Dictionary<string, Object> cache; // 0x20


	public GameObject[] LoadPrefabs(string folder) { }

	public GameObject LoadPrefab(string filePath) { }

	public string[] FindAll(string folder, string search = "") { }

	public T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-FileSystemBackend.LoadAll<object>
	|-FileSystemBackend.LoadAll<GameObject>
	*/

	public T Load<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-FileSystemBackend.Load<object>
	|-FileSystemBackend.Load<GameObject>
	*/

	public AssetPreloadResult PreloadAssets(IEnumerable<string> filePaths, int maxConcurrency, int priority) { }

	protected void LoadError(string err) { }

	public virtual List<string> UnloadBundles(string partialName) { }

	protected abstract T LoadAsset<T>(string filePath);
	/* GenericInstMethod :
	|
	|-FileSystemBackend.LoadAsset<object>
	*/

	protected abstract LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority);

	protected abstract string[] LoadAssetList(string folder, string search);

	public abstract T[] LoadAllFromBundle<T>(string bundleName, string editorSearch);
	/* GenericInstMethod :
	|
	|-FileSystemBackend.LoadAllFromBundle<object>
	*/

	protected void .ctor() { }

}

public class FileDialog : MonoBehaviour // TypeDefIndex: 7066
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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


	[IteratorStateMachineAttribute] // RVA: 0x77D80 Offset: 0x77180 VA: 0x180077D80
	public IEnumerator Open(string path, string allowedExtensions, string windowName = "OPEN FILE", Sprite windowIcon, long maxSize = -1, bool saveLastPath = True) { }

	[IteratorStateMachineAttribute] // RVA: 0x77F80 Offset: 0x77380 VA: 0x180077F80
	public IEnumerator Save(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x78180 Offset: 0x77580 VA: 0x180078180
	public Task<string> SaveAsync(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	private void Hide() { }

	public void GoUp() { }

	public void GoTo(string newPath) { }

	public void SelectFile(string file) { }

	public void OnCommitClick() { }

	public void OnCancelClick() { }

	public void ClearSelection() { }

	public void OnTypedFilename(string newName) { }

	public void OnTypedEnd(string newName) { }

	public void UpdateFileInfo() { }

	public void OpenDir(string path) { }

	private void UpdateElements() { }

	private void UpdateDrivesList() { }

	private string GetFileSizeText(long size) { }

	private void UpdateFilesList() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <UpdateFilesList>b__39_0(FileInfo f) { }

}

public enum FileDialog.FileDialogMode // TypeDefIndex: 7067
{	public int value__; // 0x0
	public const FileDialog.FileDialogMode Open = 0;
	public const FileDialog.FileDialogMode Save = 1;

}

private sealed class FileDialog.<Open>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7068
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FileDialog <>4__this; // 0x20
	public long maxSize; // 0x28
	public bool saveLastPath; // 0x30
	public string allowedExtensions; // 0x38
	public string path; // 0x40
	public string windowName; // 0x48
	public Sprite windowIcon; // 0x50

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

private sealed class FileDialog.<Save>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7069
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FileDialog <>4__this; // 0x20
	public bool saveLastPath; // 0x28
	public string allowedExtensions; // 0x30
	public string path; // 0x38
	public string windowName; // 0x40
	public Sprite windowIcon; // 0x48

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

private struct FileDialog.<SaveAsync>d__24 : IAsyncStateMachine // TypeDefIndex: 7070
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public FileDialog <>4__this; // 0x20
	public bool saveLastPath; // 0x28
	public string allowedExtensions; // 0x30
	public string path; // 0x38
	public string windowName; // 0x40
	public Sprite windowIcon; // 0x48
	private TaskAwaiter <>u__1; // 0x50


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class FileListElement : MonoBehaviour // TypeDefIndex: 7071
{	public Image icon; // 0x18
	public Text elementName; // 0x20
	public Text size; // 0x28
	public FileDialog instance; // 0x30
	public bool isFile; // 0x38
	public string data; // 0x40


	public void OnClick() { }

	public void .ctor() { }

}

internal static class FileUtilities // TypeDefIndex: 7615
{
	private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	internal static FileStream OpenFileForRead(string filePath) { }

	private static SafeFileHandle GetFileHandle(string filePath, uint fileAccess, uint creationDisposition) { }

}

public class FileSystem_Warmup : MonoBehaviour // TypeDefIndex: 9370
{	public static bool ranInBackground; // 0x0
	private static bool run; // 0x1
	public static string[] ExcludeFilter; // 0x8


	public static void Run() { }

	public static IEnumerator Run(string[] assetList, Action<string> statusFunction, string format, int priority = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7AB0 Offset: 0xE6EB0 VA: 0x1800E7AB0
	private static IEnumerator RunAsyncImpl(string[] assetList, Action<string> statusFunction, string format, int priority) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7B30 Offset: 0xE6F30 VA: 0x1800E7B30
	private static IEnumerator RunImpl(string[] assetList, Action<string> statusFunction, string format) { }

	private static float CalculateFrameBudget() { }

	private static bool ShouldIgnore(string path) { }

	public static string[] GetAssetList(Nullable<bool> poolFilter) { }

	private static void PrefabWarmup(string path) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class FileSystem_Warmup.<RunAsyncImpl>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9371
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string[] assetList; // 0x20
	public int priority; // 0x28
	public Action<string> statusFunction; // 0x30
	public string format; // 0x38
	private Stopwatch <sw>5__2; // 0x40
	private AssetPreloadResult <preload>5__3; // 0x48
	private int <warmupIndex>5__4; // 0x50

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

private sealed class FileSystem_Warmup.<RunImpl>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9372
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string[] assetList; // 0x20
	public Action<string> statusFunction; // 0x28
	public string format; // 0x30
	private Stopwatch <sw>5__2; // 0x38
	private int <i>5__3; // 0x40

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

private sealed class FileSystem_Warmup.<>c__DisplayClass9_0 // TypeDefIndex: 9373
{	public Nullable<bool> poolFilter; // 0x10


	public void .ctor() { }

	internal bool <GetAssetList>b__2(GameManifest.PrefabProperties x) { }

}

private sealed class FileSystem_Warmup.<>c // TypeDefIndex: 9374
{	public static readonly FileSystem_Warmup.<>c <>9; // 0x0
	public static Func<GameManifest.PrefabProperties, string> <>9__9_0; // 0x8
	public static Func<string, bool> <>9__9_1; // 0x10
	public static Func<GameManifest.PrefabProperties, string> <>9__9_3; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal string <GetAssetList>b__9_0(GameManifest.PrefabProperties x) { }

	internal bool <GetAssetList>b__9_1(string x) { }

	internal string <GetAssetList>b__9_3(GameManifest.PrefabProperties x) { }

}

public class FileStorage : IDisposable // TypeDefIndex: 10718
{	private Database db; // 0x10
	private CRC32 crc; // 0x18
	private MruDictionary<uint, FileStorage.CacheData> _cache; // 0x20
	public static FileStorage client; // 0x0


	protected void .ctor(string name, bool server) { }

	protected override void Finalize() { }

	public void Dispose() { }

	private uint GetCRC(byte[] data, FileStorage.Type type) { }

	public uint Store(byte[] data, FileStorage.Type type, uint entityID, uint numID = 0) { }

	public byte[] Get(uint crc, FileStorage.Type type, uint entityID, uint numID = 0) { }

	public void Remove(uint crc, FileStorage.Type type, uint entityID) { }

	public void RemoveExact(uint crc, FileStorage.Type type, uint entityID, uint numid) { }

	public void RemoveEntityNum(uint entityid, uint numid) { }

	internal void RemoveAllByEntity(uint entityid) { }

	public void ReassignEntityId(uint oldId, uint newId) { }

	public List<FileStorageCacheData> GetCacheData() { }

	public void SetCache(List<FileStorageCacheData> data) { }

	public void ClearCache() { }

	private static void .cctor() { }

}

private class FileStorage.CacheData // TypeDefIndex: 10719
{	public byte[] data; // 0x10
	public uint entityID; // 0x18
	public uint numID; // 0x1C


	public void .ctor() { }

}

public enum FileStorage.Type // TypeDefIndex: 10720
{	public int value__; // 0x0
	public const FileStorage.Type png = 0;
	public const FileStorage.Type jpg = 1;
	public const FileStorage.Type ogg = 2;

}

private sealed class FileStorage.<>c__DisplayClass14_0 // TypeDefIndex: 10721
{	public uint entityid; // 0x10
	public uint numid; // 0x14
	public Func<KeyValuePair<uint, FileStorage.CacheData>, bool> <>9__0; // 0x18


	public void .ctor() { }

	internal bool <RemoveEntityNum>b__0(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

private sealed class FileStorage.<>c // TypeDefIndex: 10722
{	public static readonly FileStorage.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, FileStorage.CacheData>, uint> <>9__14_1; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <RemoveEntityNum>b__14_1(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

public static class FileEx // TypeDefIndex: 11342
{
	public static void Backup(DirectoryInfo parent, string[] names) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool MoveToSafe(FileInfo parent, string target, int retries = 10) { }

	public static void Backup(string[] names) { }

}

public class FileConVar : ConsoleSystem // TypeDefIndex: 11918
{	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool time { get; set; }


	public static bool get_debug() { }

	public static void set_debug(bool value) { }

	public static bool get_time() { }

	public static void set_time(bool value) { }

	public void .ctor() { }

}

