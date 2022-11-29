internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 482
{
	private ResourceManager.ResourceManagerMediator _mediator; 


	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	private string FindResourceFile(CultureInfo culture, string fileName) { }

	private ResourceSet CreateResourceSet(string file) { }

}

public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 623
{
	private string _name; 

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
{
	private string _fileName; 
	private string _fusionLog; 

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
{
	private string _fileName; 
	private string _fusionLog; 

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
{
	private SearchResultHandler<TSource> _resultHandler; 
	private List<Directory.SearchData> searchStack; 
	private Directory.SearchData searchData; 
	private string searchCriteria; 
	private SafeFindHandle _hnd; 
	private bool needsParentPathDiscoveryDemand; 
	private bool empty; 
	private string userPath; 
	private SearchOption searchOption; 
	private string fullPath; 
	private string normalizedSearchPath; 
	private bool _checkHost; 


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
{
	internal MonoIOStat _data; 
	internal int _dataInitialised; 
	protected string FullPath; 
	protected string OriginalPath; 
	private string _displayPath; 

	public virtual string FullName { get; }
	public string Extension { get; }
	public abstract string Name { get; }
	public abstract bool Exists { get; }
	public DateTime CreationTime { get; set; }
	[ComVisibleAttribute] 
	public DateTime CreationTimeUtc { get; set; }
	public DateTime LastAccessTime { get; set; }
	[ComVisibleAttribute] 
	public DateTime LastAccessTimeUtc { get; set; }
	public DateTime LastWriteTime { get; set; }
	[ComVisibleAttribute] 
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

	[ComVisibleAttribute] 
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal string get_DisplayPath() { }

	internal void set_DisplayPath(string value) { }

}

public static class File // TypeDefIndex: 663
{
	private static Nullable<DateTime> defaultLocalFileTime; 

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

	[IteratorStateMachineAttribute] 
	private static IEnumerable<string> ReadLines(StreamReader reader) { }

	internal static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound) { }

}

private sealed class File.<ReadLines>d__58 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 664
{
	private int <>1__state; 
	private string <>2__current; 
	private int <>l__initialThreadId; 
	private StreamReader reader; 
	public StreamReader <>3__reader; 
	private string <s>5__1; 
	private StreamReader <>7__wrap1; 

	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public enum FileAccess // TypeDefIndex: 665
{
	public int value__; 
	public const FileAccess Read = 1;
	public const FileAccess Write = 2;
	public const FileAccess ReadWrite = 3;

}

public enum FileAttributes // TypeDefIndex: 666
{
	public int value__; 
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
{
	public int value__; 
	public const FileMode CreateNew = 1;
	public const FileMode Create = 2;
	public const FileMode Open = 3;
	public const FileMode OpenOrCreate = 4;
	public const FileMode Truncate = 5;
	public const FileMode Append = 6;

}

public enum FileOptions // TypeDefIndex: 668
{
	public int value__; 
	public const FileOptions None = 0;
	public const FileOptions Encrypted = 16384;
	public const FileOptions DeleteOnClose = 67108864;
	public const FileOptions SequentialScan = 134217728;
	public const FileOptions RandomAccess = 268435456;
	public const FileOptions Asynchronous = 1073741824;
	public const FileOptions WriteThrough = -2147483648;

}

public enum FileShare // TypeDefIndex: 669
{
	public int value__; 
	public const FileShare None = 0;
	public const FileShare Read = 1;
	public const FileShare Write = 2;
	public const FileShare ReadWrite = 3;
	public const FileShare Delete = 4;
	public const FileShare Inheritable = 16;

}

public class FileStream : Stream // TypeDefIndex: 670
{
	private static byte[] buf_recycle; 
	private static readonly object buf_recycle_lock; 
	private byte[] buf; 
	private string name; 
	private SafeFileHandle safeHandle; 
	private bool isExposed; 
	private long append_startpos; 
	private FileAccess access; 
	private bool owner; 
	private bool async; 
	private bool canseek; 
	private bool anonymous; 
	private bool buf_dirty; 
	private int buf_size; 
	private int buf_length; 
	private int buf_offset; 
	private long buf_start; 

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
{
	private object state; 
	private bool completed; 
	private ManualResetEvent wh; 
	private AsyncCallback cb; 
	private bool completedSynch; 
	public int Count; 
	public int OriginalCount; 
	public int BytesRead; 
	private AsyncCallback realcb; 

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
{
	public string Directory; 
	public FileAttributes Attributes; 
	public bool NotExists; 
	public DateTime CreationTime; 
	public DateTime LastWriteTime; 


	public void .ctor() { }

}

internal enum FileAction // TypeDefIndex: 2844
{
	public int value__; 
	public const FileAction Added = 1;
	public const FileAction Removed = 2;
	public const FileAction Modified = 3;
	public const FileAction RenamedOldName = 4;
	public const FileAction RenamedNewName = 5;

}

public class FileSystemEventArgs : EventArgs // TypeDefIndex: 2845
{
	private WatcherChangeTypes changeType; 
	private string directory; 
	private string name; 

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
{
	private bool enableRaisingEvents; 
	private string filter; 
	private bool includeSubdirectories; 
	private int internalBufferSize; 
	private NotifyFilters notifyFilter; 
	private string path; 
	private string fullpath; 
	private ISynchronizeInvoke synchronizingObject; 
	private WaitForChangedResult lastData; 
	private bool waiting; 
	private SearchPattern2 pattern; 
	private bool disposed; 
	private string mangledFilter; 
	private static IFileWatcher watcher; 
	private static object lockobj; 
	[CompilerGeneratedAttribute] 
	private FileSystemEventHandler Changed; 
	[CompilerGeneratedAttribute] 
	private FileSystemEventHandler Created; 
	[CompilerGeneratedAttribute] 
	private FileSystemEventHandler Deleted; 
	[CompilerGeneratedAttribute] 
	private ErrorEventHandler Error; 
	[CompilerGeneratedAttribute] 
	private RenamedEventHandler Renamed; 

	internal bool Waiting { get; set; }
	internal string MangledFilter { get; }
	internal SearchPattern2 Pattern { get; }
	internal string FullPath { get; }
	[IODescriptionAttribute] 
	[DefaultValueAttribute] 
	public bool EnableRaisingEvents { set; }
	[SettingsBindableAttribute] 
	[TypeConverterAttribute] 
	[DefaultValueAttribute] 
	[IODescriptionAttribute] 
	public string Filter { set; }
	[DefaultValueAttribute] 
	[IODescriptionAttribute] 
	public bool IncludeSubdirectories { get; }
	[IODescriptionAttribute] 
	[DefaultValueAttribute] 
	public NotifyFilters NotifyFilter { set; }
	[DefaultValueAttribute] 
	[IODescriptionAttribute] 
	[EditorAttribute] 
	[SettingsBindableAttribute] 
	[TypeConverterAttribute] 
	public string Path { set; }
	[BrowsableAttribute] 
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

	[CompilerGeneratedAttribute] 
	public void add_Changed(FileSystemEventHandler value) { }

	[CompilerGeneratedAttribute] 
	public void remove_Changed(FileSystemEventHandler value) { }

	private static int InternalSupportsFSW() { }

	private static void .cctor() { }

}

private enum FileSystemWatcher.EventType // TypeDefIndex: 2848
{
	public int value__; 
	public const FileSystemWatcher.EventType FileSystemEvent = 0;
	public const FileSystemWatcher.EventType ErrorEvent = 1;
	public const FileSystemWatcher.EventType RenameEvent = 2;

}

public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 2948
{
	private static WaitCallback s_GetRequestStreamCallback; 
	private static WaitCallback s_GetResponseCallback; 
	private string m_connectionGroupName; 
	private long m_contentLength; 
	private ICredentials m_credentials; 
	private FileAccess m_fileAccess; 
	private WebHeaderCollection m_headers; 
	private string m_method; 
	private bool m_preauthenticate; 
	private IWebProxy m_proxy; 
	private ManualResetEvent m_readerEvent; 
	private bool m_readPending; 
	private WebResponse m_response; 
	private Stream m_stream; 
	private bool m_syncHint; 
	private int m_timeout; 
	private Uri m_uri; 
	private bool m_writePending; 
	private bool m_writing; 
	private LazyAsyncResult m_WriteAResult; 
	private LazyAsyncResult m_ReadAResult; 
	private int m_Aborted; 

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

	[ObsoleteAttribute] 
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
{
	private FileWebRequest m_request; 


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
{
	private bool m_closed; 
	private long m_contentLength; 
	private FileAccess m_fileAccess; 
	private WebHeaderCollection m_headers; 
	private Stream m_stream; 
	private Uri m_uri; 

	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }


	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[ObsoleteAttribute] 
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

internal struct FileDetailsResult_t : ICallbackData // TypeDefIndex: 5408
{
	internal Result Result; 
	internal ulong FileSize; 
	internal byte[] FileSHA; 
	internal uint Flags; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public class FileStorageCacheData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6475
{
	public bool ShouldPool; 
	private bool _disposed; 
	public byte[] data; 
	public uint entityId; 
	public uint numId; 
	public uint crc; 


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

public static class FileSystem // TypeDefIndex: 6669
{
	public static bool LogDebug; 
	public static bool LogTime; 
	public static FileSystemBackend Backend; 


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

public abstract class FileSystemBackend // TypeDefIndex: 6670
{
	public bool isError; 
	public string loadingError; 
	public Dictionary<string, Object> cache; 


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

public class FileDialog : MonoBehaviour // TypeDefIndex: 7106
{
	[HideInInspector] 
	public string result; 
	[HideInInspector] 
	private FileDialog.FileDialogMode mode; 
	[HideInInspector] 
	public bool finished; 
	[HeaderAttribute] 
	public Image windowIcon; 
	public Text windowName; 
	public InputField currentPath; 
	public InputField fileName; 
	public Button up; 
	public Button commit; 
	public Button cancel; 
	public GameObject filesScrollRectContent; 
	public GameObject drivesScrollRectContent; 
	[HeaderAttribute] 
	public GameObject filesScrollRectElement; 
	public GameObject drivesScrollRectElement; 
	[HeaderAttribute] 
	public Sprite folderIcon; 
	public Sprite fileIcon; 
	private string workingPath; 
	private string workingFile; 
	private string[] allowedExtensions; 
	private long maxSize; 
	private bool saveLastPath; 


	[IteratorStateMachineAttribute] 
	public IEnumerator Open(string path, string allowedExtensions, string windowName = "OPEN FILE", Sprite windowIcon, long maxSize = -1, bool saveLastPath = True) { }

	[IteratorStateMachineAttribute] 
	public IEnumerator Save(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	[AsyncStateMachineAttribute] 
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

	[CompilerGeneratedAttribute] 
	private bool <UpdateFilesList>

}

public enum FileDialog.FileDialogMode // TypeDefIndex: 7107
{
	public int value__; 
	public const FileDialog.FileDialogMode Open = 0;
	public const FileDialog.FileDialogMode Save = 1;

}

private sealed class FileDialog.<Open>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7108
{
	private int <>1__state; 
	private object <>2__current; 
	public FileDialog <>4__this; 
	public long maxSize; 
	public bool saveLastPath; 
	public string allowedExtensions; 
	public string path; 
	public string windowName; 
	public Sprite windowIcon; 

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

private sealed class FileDialog.<Save>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7109
{
	private int <>1__state; 
	private object <>2__current; 
	public FileDialog <>4__this; 
	public bool saveLastPath; 
	public string allowedExtensions; 
	public string path; 
	public string windowName; 
	public Sprite windowIcon; 

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

private struct FileDialog.<SaveAsync>d__24 : IAsyncStateMachine // TypeDefIndex: 7110
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<string> <>t__builder; 
	public FileDialog <>4__this; 
	public bool saveLastPath; 
	public string allowedExtensions; 
	public string path; 
	public string windowName; 
	public Sprite windowIcon; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class FileListElement : MonoBehaviour // TypeDefIndex: 7111
{
	public Image icon; 
	public Text elementName; 
	public Text size; 
	public FileDialog instance; 
	public bool isFile; 
	public string data; 


	public void OnClick() { }

	public void .ctor() { }

}

internal static class FileUtilities // TypeDefIndex: 7629
{

	private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	internal static FileStream OpenFileForRead(string filePath) { }

	private static SafeFileHandle GetFileHandle(string filePath, uint fileAccess, uint creationDisposition) { }

}

public struct FileMetadata // TypeDefIndex: 8391
{
	[CompilerGeneratedAttribute] 
	private uint <FileSizeBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <MD5Hash>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Filename>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <UnencryptedDataSizeBytes>k__BackingField; 

	public uint FileSizeBytes { get; set; }
	public Utf8String MD5Hash { get; set; }
	public Utf8String Filename { get; set; }
	public uint UnencryptedDataSizeBytes { get; set; }


	[CompilerGeneratedAttribute] 
	public uint get_FileSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_FileSizeBytes(uint value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_MD5Hash() { }

	[CompilerGeneratedAttribute] 
	public void set_MD5Hash(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Filename() { }

	[CompilerGeneratedAttribute] 
	public void set_Filename(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public uint get_UnencryptedDataSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_UnencryptedDataSizeBytes(uint value) { }

	internal void Set(ref FileMetadataInternal other) { }

}

internal struct FileMetadataInternal : IGettable<FileMetadata>, ISettable<FileMetadata>, IDisposable // TypeDefIndex: 8392
{
	private int m_ApiVersion; 
	private uint m_FileSizeBytes; 
	private IntPtr m_MD5Hash; 
	private IntPtr m_Filename; 
	private uint m_UnencryptedDataSizeBytes; 

	public uint FileSizeBytes { get; set; }
	public Utf8String MD5Hash { get; set; }
	public Utf8String Filename { get; set; }
	public uint UnencryptedDataSizeBytes { get; set; }


	public uint get_FileSizeBytes() { }

	public void set_FileSizeBytes(uint value) { }

	public Utf8String get_MD5Hash() { }

	public void set_MD5Hash(Utf8String value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public uint get_UnencryptedDataSizeBytes() { }

	public void set_UnencryptedDataSizeBytes(uint value) { }

	public void Set(ref FileMetadata other) { }

	public void Set(ref Nullable<FileMetadata> other) { }

	public void Dispose() { }

	public void Get(out FileMetadata output) { }

}

public struct FileTransferProgressCallbackInfo : ICallbackInfo // TypeDefIndex: 8393
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Filename>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <BytesTransferred>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <TotalFileSizeBytes>k__BackingField; 

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint BytesTransferred { get; set; }
	public uint TotalFileSizeBytes { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Filename() { }

	[CompilerGeneratedAttribute] 
	public void set_Filename(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public uint get_BytesTransferred() { }

	[CompilerGeneratedAttribute] 
	public void set_BytesTransferred(uint value) { }

	[CompilerGeneratedAttribute] 
	public uint get_TotalFileSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_TotalFileSizeBytes(uint value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref FileTransferProgressCallbackInfoInternal other) { }

}

internal struct FileTransferProgressCallbackInfoInternal : ICallbackInfoInternal, IGettable<FileTransferProgressCallbackInfo>, ISettable<FileTransferProgressCallbackInfo>, IDisposable // TypeDefIndex: 8394
{
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Filename; 
	private uint m_BytesTransferred; 
	private uint m_TotalFileSizeBytes; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint BytesTransferred { get; set; }
	public uint TotalFileSizeBytes { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public uint get_BytesTransferred() { }

	public void set_BytesTransferred(uint value) { }

	public uint get_TotalFileSizeBytes() { }

	public void set_TotalFileSizeBytes(uint value) { }

	public void Set(ref FileTransferProgressCallbackInfo other) { }

	public void Set(ref Nullable<FileTransferProgressCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out FileTransferProgressCallbackInfo output) { }

}

public struct FileMetadata // TypeDefIndex: 8884
{
	[CompilerGeneratedAttribute] 
	private uint <FileSizeBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <MD5Hash>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Filename>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <LastModifiedTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <UnencryptedDataSizeBytes>k__BackingField; 

	public uint FileSizeBytes { get; set; }
	public Utf8String MD5Hash { get; set; }
	public Utf8String Filename { get; set; }
	public Nullable<DateTimeOffset> LastModifiedTime { get; set; }
	public uint UnencryptedDataSizeBytes { get; set; }


	[CompilerGeneratedAttribute] 
	public uint get_FileSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_FileSizeBytes(uint value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_MD5Hash() { }

	[CompilerGeneratedAttribute] 
	public void set_MD5Hash(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Filename() { }

	[CompilerGeneratedAttribute] 
	public void set_Filename(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_LastModifiedTime() { }

	[CompilerGeneratedAttribute] 
	public void set_LastModifiedTime(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] 
	public uint get_UnencryptedDataSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_UnencryptedDataSizeBytes(uint value) { }

	internal void Set(ref FileMetadataInternal other) { }

}

internal struct FileMetadataInternal : IGettable<FileMetadata>, ISettable<FileMetadata>, IDisposable // TypeDefIndex: 8885
{
	private int m_ApiVersion; 
	private uint m_FileSizeBytes; 
	private IntPtr m_MD5Hash; 
	private IntPtr m_Filename; 
	private long m_LastModifiedTime; 
	private uint m_UnencryptedDataSizeBytes; 

	public uint FileSizeBytes { get; set; }
	public Utf8String MD5Hash { get; set; }
	public Utf8String Filename { get; set; }
	public Nullable<DateTimeOffset> LastModifiedTime { get; set; }
	public uint UnencryptedDataSizeBytes { get; set; }


	public uint get_FileSizeBytes() { }

	public void set_FileSizeBytes(uint value) { }

	public Utf8String get_MD5Hash() { }

	public void set_MD5Hash(Utf8String value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public Nullable<DateTimeOffset> get_LastModifiedTime() { }

	public void set_LastModifiedTime(Nullable<DateTimeOffset> value) { }

	public uint get_UnencryptedDataSizeBytes() { }

	public void set_UnencryptedDataSizeBytes(uint value) { }

	public void Set(ref FileMetadata other) { }

	public void Set(ref Nullable<FileMetadata> other) { }

	public void Dispose() { }

	public void Get(out FileMetadata output) { }

}

public struct FileTransferProgressCallbackInfo : ICallbackInfo // TypeDefIndex: 8886
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Filename>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <BytesTransferred>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <TotalFileSizeBytes>k__BackingField; 

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint BytesTransferred { get; set; }
	public uint TotalFileSizeBytes { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Filename() { }

	[CompilerGeneratedAttribute] 
	public void set_Filename(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public uint get_BytesTransferred() { }

	[CompilerGeneratedAttribute] 
	public void set_BytesTransferred(uint value) { }

	[CompilerGeneratedAttribute] 
	public uint get_TotalFileSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_TotalFileSizeBytes(uint value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref FileTransferProgressCallbackInfoInternal other) { }

}

internal struct FileTransferProgressCallbackInfoInternal : ICallbackInfoInternal, IGettable<FileTransferProgressCallbackInfo>, ISettable<FileTransferProgressCallbackInfo>, IDisposable // TypeDefIndex: 8887
{
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Filename; 
	private uint m_BytesTransferred; 
	private uint m_TotalFileSizeBytes; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint BytesTransferred { get; set; }
	public uint TotalFileSizeBytes { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public uint get_BytesTransferred() { }

	public void set_BytesTransferred(uint value) { }

	public uint get_TotalFileSizeBytes() { }

	public void set_TotalFileSizeBytes(uint value) { }

	public void Set(ref FileTransferProgressCallbackInfo other) { }

	public void Set(ref Nullable<FileTransferProgressCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out FileTransferProgressCallbackInfo output) { }

}

public class FileSystem_Warmup : MonoBehaviour // TypeDefIndex: 11105
{
	public static bool ranInBackground; 
	public static Coroutine warmupTask; 
	private static bool run; 
	public static string[] ExcludeFilter; 


	public static void Run() { }

	public static IEnumerator Run(string[] assetList, Action<string> statusFunction, string format, int priority = 0) { }

	[IteratorStateMachineAttribute] 
	private static IEnumerator RunAsyncImpl(string[] assetList, Action<string> statusFunction, string format, int priority) { }

	[IteratorStateMachineAttribute] 
	private static IEnumerator RunImpl(string[] assetList, Action<string> statusFunction, string format) { }

	private static float CalculateFrameBudget() { }

	private static bool ShouldIgnore(string path) { }

	public static string[] GetAssetList(Nullable<bool> poolFilter) { }

	private static void PrefabWarmup(string path) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class FileSystem_Warmup.<RunAsyncImpl>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11106
{
	private int <>1__state; 
	private object <>2__current; 
	public string[] assetList; 
	public int priority; 
	public Action<string> statusFunction; 
	public string format; 
	private Stopwatch <sw>5__2; 
	private AssetPreloadResult <preload>5__3; 
	private int <warmupIndex>5__4; 

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

private sealed class FileSystem_Warmup.<RunImpl>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11107
{
	private int <>1__state; 
	private object <>2__current; 
	public string[] assetList; 
	public Action<string> statusFunction; 
	public string format; 
	private Stopwatch <sw>5__2; 
	private int <i>5__3; 

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

private sealed class FileSystem_Warmup.<>c__DisplayClass10_0 // TypeDefIndex: 11108
{
	public Nullable<bool> poolFilter; 


	public void .ctor() { }

	internal bool <GetAssetList>

}

private sealed class FileSystem_Warmup.<>c // TypeDefIndex: 11109
{
	public static readonly FileSystem_Warmup.<>c <>9; 
	public static Func<GameManifest.PrefabProperties, string> <>9__10_0; 
	public static Func<string, bool> <>9__10_1; 
	public static Func<GameManifest.PrefabProperties, string> <>9__10_3; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <GetAssetList>

	internal bool <GetAssetList>

	internal string <GetAssetList>

}

public class FileStorage : IDisposable // TypeDefIndex: 12469
{
	private Database db; 
	private CRC32 crc; 
	private MruDictionary<uint, FileStorage.CacheData> _cache; 
	public static FileStorage client; 


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

private class FileStorage.CacheData // TypeDefIndex: 12470
{
	public byte[] data; 
	public uint entityID; 
	public uint numID; 


	public void .ctor() { }

}

public enum FileStorage.Type // TypeDefIndex: 12471
{
	public int value__; 
	public const FileStorage.Type png = 0;
	public const FileStorage.Type jpg = 1;
	public const FileStorage.Type ogg = 2;

}

private sealed class FileStorage.<>c__DisplayClass14_0 // TypeDefIndex: 12472
{
	public uint entityid; 
	public uint numid; 
	public Func<KeyValuePair<uint, FileStorage.CacheData>, bool> <>9__0; 


	public void .ctor() { }

	internal bool <RemoveEntityNum>

}

private sealed class FileStorage.<>c // TypeDefIndex: 12473
{
	public static readonly FileStorage.<>c <>9; 
	public static Func<KeyValuePair<uint, FileStorage.CacheData>, uint> <>9__14_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <RemoveEntityNum>

}

public static class FileEx // TypeDefIndex: 13135
{

	public static void Backup(DirectoryInfo parent, string[] names) { }

	[ExtensionAttribute] 
	public static bool MoveToSafe(FileInfo parent, string target, int retries = 10) { }

	public static void Backup(string[] names) { }

}

public class FileConVar : ConsoleSystem // TypeDefIndex: 13710
{
	[ClientVar] 
	public static bool debug { get; set; }
	[ClientVar] 
	public static bool time { get; set; }


	public static bool get_debug() { }

	public static void set_debug(bool value) { }

	public static bool get_time() { }

	public static void set_time(bool value) { }

	public void .ctor() { }

}

