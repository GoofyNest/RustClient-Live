public class EventArgs // TypeDefIndex: 215
{
	public static readonly EventArgs Empty; 


	public void .ctor() { }

	private static void .cctor() { }

}

public sealed class EventHandler : MulticastDelegate // TypeDefIndex: 216
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, EventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class EventHandler<TEventArgs> : MulticastDelegate // TypeDefIndex: 217
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-EventHandler<LoadCompletedEventArgs>..ctor
	|-EventHandler<LoadProgressEventArgs>..ctor
	|-EventHandler<StateChangedEventArgs>..ctor
	|-EventHandler<RowUpdatingEventArgs>..ctor
	|-EventHandler<object>..ctor
	*/

	public virtual void Invoke(object sender, TEventArgs e) { }
	/* GenericInstMethod :
	|
	|-EventHandler<ErrorEventArgs>.Invoke
	|-EventHandler<EventCommandEventArgs>.Invoke
	|-EventHandler<EventSourceCreatedEventArgs>.Invoke
	|-EventHandler<EventWrittenEventArgs>.Invoke
	|-EventHandler<SocketAsyncEventArgs>.Invoke
	|-EventHandler<object>.Invoke
	|-EventHandler<SafeSerializationEventArgs>.Invoke
	|-EventHandler<UnobservedTaskExceptionEventArgs>.Invoke
	|-EventHandler<XObjectChangeEventArgs>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(object sender, TEventArgs e, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-EventHandler<object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-EventHandler<object>.EndInvoke
	*/

}

public enum EventAttributes // TypeDefIndex: 524
{
	public int value__; 
	public const EventAttributes None = 0;
	public const EventAttributes SpecialName = 512;
	public const EventAttributes ReservedMask = 1024;
	public const EventAttributes RTSpecialName = 1024;

}

public abstract class EventInfo : MemberInfo, _EventInfo // TypeDefIndex: 565
{
	private EventInfo.AddEventAdapter cached_add_event; 

	public virtual Type EventHandlerType { get; }
	public override MemberTypes MemberType { get; }


	public virtual Type get_EventHandlerType() { }

	public override MemberTypes get_MemberType() { }

	protected void .ctor() { }

	public abstract MethodInfo GetAddMethod(bool nonPublic);

	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(EventInfo left, EventInfo right) { }

	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

}

private sealed class EventInfo.AddEventAdapter : MulticastDelegate // TypeDefIndex: 566
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object _this, Delegate dele) { }

	public virtual IAsyncResult BeginInvoke(object _this, Delegate dele, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum EventResetMode // TypeDefIndex: 778
{
	public int value__; 
	public const EventResetMode AutoReset = 0;
	public const EventResetMode ManualReset = 1;

}

public class EventWaitHandle : WaitHandle // TypeDefIndex: 779
{

	public void .ctor(bool initialState, EventResetMode mode) { }

	public void .ctor(bool initialState, EventResetMode mode, string name) { }

	public bool Reset() { }

	public bool Set() { }

}

public enum EventFieldTags // TypeDefIndex: 1516
{
	public int value__; 
	public const EventFieldTags None = 0;

}

public class EventFieldAttribute : Attribute // TypeDefIndex: 1517
{
	[CompilerGeneratedAttribute] 
	private EventFieldTags <Tags>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventFieldFormat <Format>k__BackingField; 

	public EventFieldTags Tags { get; }
	internal string Name { get; }
	public EventFieldFormat Format { get; }


	[CompilerGeneratedAttribute] 
	public EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] 
	internal string get_Name() { }

	[CompilerGeneratedAttribute] 
	public EventFieldFormat get_Format() { }

}

public enum EventFieldFormat // TypeDefIndex: 1518
{
	public int value__; 
	public const EventFieldFormat Default = 0;
	public const EventFieldFormat String = 2;
	public const EventFieldFormat Boolean = 3;
	public const EventFieldFormat Hexadecimal = 4;
	public const EventFieldFormat Xml = 11;
	public const EventFieldFormat Json = 12;
	public const EventFieldFormat HResult = 15;

}

internal class EventPayload : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable // TypeDefIndex: 1520
{

[DefaultMemberAttribute] 
internal class EventPayload : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable 
	private List<string> m_names; 
	private List<object> m_values; 

	public ICollection<string> Keys { get; }
	public ICollection<object> Values { get; }
	public object Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }


	internal void .ctor(List<string> payloadNames, List<object> payloadValues) { }

	public ICollection<string> get_Keys() { }

	public ICollection<object> get_Values() { }

	public object get_Item(string key) { }

	public void set_Item(string key, object value) { }

	public void Add(string key, object value) { }

	public void Add(KeyValuePair<string, object> payloadEntry) { }

	public void Clear() { }

	public bool Contains(KeyValuePair<string, object> entry) { }

	public bool ContainsKey(string key) { }

	public int get_Count() { }

	public bool get_IsReadOnly() { }

	[IteratorStateMachineAttribute] 
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void CopyTo(KeyValuePair<string, object>[] payloadEntries, int count) { }

	public bool Remove(string key) { }

	public bool Remove(KeyValuePair<string, object> entry) { }

	public bool TryGetValue(string key, out object value) { }

}

private sealed class EventPayload.<GetEnumerator>d__17 : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator // TypeDefIndex: 1521
{
	private int <>1__state; 
	private KeyValuePair<string, object> <>2__current; 
	public EventPayload <>4__this; 
	private int <i>5__1; 

	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public struct EventSourceOptions // TypeDefIndex: 1522
{
	internal EventKeywords keywords; 
	internal EventTags tags; 
	internal EventActivityOptions activityOptions; 
	internal byte level; 
	internal byte opcode; 
	internal byte valuesSet; 

	public EventLevel Level { set; }
	public EventOpcode Opcode { set; }
	public EventKeywords Keywords { set; }


	public void set_Level(EventLevel value) { }

	public void set_Opcode(EventOpcode value) { }

	public void set_Keywords(EventKeywords value) { }

}

public class EventSource : IDisposable // TypeDefIndex: 1580
{
	private byte[] providerMetadata; 
	private string m_name; 
	internal int m_id; 
	private Guid m_guid; 
	internal EventSource.EventMetadata[] m_eventData; 
	private byte[] m_rawManifest; 
	private EventHandler<EventCommandEventArgs> m_eventCommandExecuted; 
	private EventSourceSettings m_config; 
	private bool m_eventSourceEnabled; 
	internal EventLevel m_level; 
	internal EventKeywords m_matchAnyKeyword; 
	internal EventDispatcher m_Dispatchers; 
	private EventSource.OverideEventProvider m_provider; 
	private bool m_completelyInited; 
	private Exception m_constructionException; 
	private byte m_outOfBandMessageCount; 
	private EventCommandEventArgs m_deferredCommands; 
	private string[] m_traits; 
	internal static uint s_currentPid; 
	[ThreadStaticAttribute] 
	private static byte m_EventSourceExceptionRecurenceCount; 
	private SessionMask m_curLiveSessions; 
	private EtwSession[] m_etwSessionIdMap; 
	private List<EtwSession> m_legacySessions; 
	internal long m_keywordTriggers; 
	internal SessionMask m_activityFilteringForETWEnabled; 
	internal static Action<Guid> s_activityDying; 
	private ActivityTracker m_activityTracker; 
	private static readonly byte[] namespaceBytes; 
	private static readonly Guid AspNetEventSourceGuid; 

	public string Name { get; }
	public Guid Guid { get; }
	public static Guid CurrentThreadActivityId { get; }
	internal static Guid InternalCurrentThreadActivityId { get; }
	internal static Guid FallbackActivityId { get; }
	private bool IsDisposed { get; }
	private bool ThrowOnEventWriteErrors { get; }
	private bool SelfDescribingEvents { get; }


	private void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, object[] values) { }

	private void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, object[] values) { }

	internal void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventSource.EventData* data) { }

	[NonEventAttribute] 
	[ReliabilityContractAttribute] 
	private void WriteCleanup(GCHandle* pPins, int cPins) { }

	private void InitializeProviderMetadata() { }

	private static int AddValueToMetaData(List<byte> metaData, string value) { }

	private static int HexDigit(char c) { }

	private NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor) { }

	public string get_Name() { }

	public Guid get_Guid() { }

	public bool IsEnabled() { }

	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel) { }

	public static Guid GetGuid(Type eventSourceType) { }

	public static string GetName(Type eventSourceType) { }

	public static void SetCurrentThreadActivityId(Guid activityId) { }

	public static Guid get_CurrentThreadActivityId() { }

	internal static Guid get_InternalCurrentThreadActivityId() { }

	internal static Guid get_FallbackActivityId() { }

	public override string ToString() { }

	protected void .ctor() { }

	protected void .ctor(EventSourceSettings settings) { }

	protected void .ctor(EventSourceSettings settings, string[] traits) { }

	protected virtual void OnEventCommand(EventCommandEventArgs command) { }

	protected void WriteEvent(int eventId, int arg1) { }

	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	protected void WriteEvent(int eventId, long arg1) { }

	protected void WriteEvent(int eventId, string arg1) { }

	protected void WriteEvent(int eventId, string arg1, string arg2) { }

	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	[CLSCompliantAttribute] 
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }

	[CLSCompliantAttribute] 
	protected void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventSource.EventData* data) { }

	protected void WriteEvent(int eventId, object[] args) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	internal void WriteStringToListener(EventListener listener, string msg, SessionMask m) { }

	private void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	private void Initialize(Guid eventSourceGuid, string eventSourceName, string[] traits) { }

	private static string GetName(Type eventSourceType, EventManifestOptions flags) { }

	private static Guid GenerateGuidFromName(string name) { }

	private object DecodeObject(int eventId, int parameterId, ref EventSource.EventData* data) { }

	private EventDispatcher GetDispatcher(EventListener listener) { }

	private void WriteEventVarargs(int eventId, Guid* childActivityID, object[] args) { }

	private object[] SerializeEventArgs(int eventId, object[] args) { }

	private void LogEventArgsMismatches(ParameterInfo[] infos, object[] args) { }

	private int GetParamLengthIncludingByteArray(ParameterInfo[] parameters) { }

	private void WriteToAllListeners(int eventId, Guid* childActivityID, int eventDataCount, EventSource.EventData* data) { }

	private void WriteToAllListeners(int eventId, Guid* childActivityID, object[] args) { }

	private void DispatchToAllListeners(int eventId, Guid* childActivityID, EventWrittenEventArgs eventCallbackArgs) { }

	private void WriteEventString(EventLevel level, long keywords, string msgString) { }

	private void WriteStringToAllListeners(string eventName, string msg) { }

	private SessionMask GetEtwSessionMask(int eventId, Guid* childActivityID) { }

	private bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword) { }

	private bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel) { }

	private void ThrowEventSourceException(string eventName, Exception innerEx) { }

	private void ValidateEventOpcodeForTransfer(ref EventSource.EventMetadata eventData, string eventName) { }

	internal static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName) { }

	internal void SendCommand(EventListener listener, int perEventSourceSessionId, int etwSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> commandArguments) { }

	internal void DoCommand(EventCommandEventArgs commandArgs) { }

	internal void UpdateEtwSession(int sessionIdBit, int etwSessionId, bool bEnable, string activityFilters, bool participateInSampling) { }

	internal static bool ParseCommandArgs(IDictionary<string, string> commandArguments, out bool participateInSampling, out string activityFilters, out int sessionIdBit) { }

	internal void UpdateKwdTriggers(bool enable) { }

	internal bool EnableEventForDispatcher(EventDispatcher dispatcher, int eventId, bool value) { }

	private bool AnyEventEnabled() { }

	private bool get_IsDisposed() { }

	private void EnsureDescriptorsInitialized() { }

	private bool SendManifest(byte[] rawManifest) { }

	internal static Attribute GetCustomAttributeHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = 0) { }

	private static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType) { }

	private static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly) { }

	private static byte[] CreateManifestAndDescriptors(Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = 0) { }

	private static bool RemoveFirstArgIfRelatedActivityId(ref ParameterInfo[] args) { }

	private static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind) { }

	private static void AddEventDescriptor(ref EventSource.EventMetadata[] eventData, string eventName, EventAttribute eventAttribute, ParameterInfo[] eventParameters, bool hasRelatedActivityID) { }

	private static void TrimEventDescriptors(ref EventSource.EventMetadata[] eventData) { }

	internal void AddListener(EventListener listener) { }

	private static void DebugCheckEvent(ref Dictionary<string, string> eventsByName, EventSource.EventMetadata[] eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options) { }

	private static int GetHelperCallFirstArg(MethodInfo method) { }

	internal void ReportOutOfBandMessage(string msg, bool flush) { }

	private EventSourceSettings ValidateSettings(EventSourceSettings settings) { }

	private bool get_ThrowOnEventWriteErrors() { }

	private bool get_SelfDescribingEvents() { }

	private void ReportActivitySamplingInfo(EventListener listener, SessionMask sessions) { }

	private static void .cctor() { }

}

private struct EventSource.Sha1ForNonSecretPurposes // TypeDefIndex: 1582
{
	private long length; 
	private uint[] w; 
	private int pos; 


	public void Start() { }

	public void Append(byte input) { }

	public void Append(byte[] input) { }

	public void Finish(byte[] output) { }

	private void Drain() { }

	private static uint Rol1(uint input) { }

	private static uint Rol5(uint input) { }

	private static uint Rol30(uint input) { }

}

private class EventSource.OverideEventProvider : EventProvider // TypeDefIndex: 1583
{
	private EventSource m_eventSource; 


	public void .ctor(EventSource eventSource) { }

	protected override void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int perEventSourceSessionId, int etwSessionId) { }

}

internal struct EventSource.EventMetadata // TypeDefIndex: 1584
{
	public EventDescriptor Descriptor; 
	public EventTags Tags; 
	public bool EnabledForAnyListener; 
	public bool EnabledForETW; 
	public bool HasRelatedActivityID; 
	public byte TriggersActivityTracking; 
	public string Name; 
	public string Message; 
	public ParameterInfo[] Parameters; 
	public TraceLoggingEventTypes TraceLoggingEventTypes; 
	public EventActivityOptions ActivityOptions; 

}

public enum EventTags // TypeDefIndex: 1585
{
	public int value__; 
	public const EventTags None = 0;

}

public enum EventActivityOptions // TypeDefIndex: 1596
{
	public int value__; 
	public const EventActivityOptions None = 0;
	public const EventActivityOptions Disable = 2;
	public const EventActivityOptions Recursive = 4;
	public const EventActivityOptions Detachable = 8;

}

internal struct EventDescriptor // TypeDefIndex: 1597
{
	private int m_traceloggingId; 
	private ushort m_id; 
	private byte m_version; 
	private byte m_channel; 
	private byte m_level; 
	private byte m_opcode; 
	private ushort m_task; 
	private long m_keywords; 

	public int EventId { get; }
	public byte Version { get; }
	public byte Channel { get; }
	public byte Level { get; }
	public byte Opcode { get; }
	public int Task { get; }
	public long Keywords { get; }


	public void .ctor(int traceloggingId, byte level, byte opcode, long keywords) { }

	public void .ctor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords) { }

	public int get_EventId() { }

	public byte get_Version() { }

	public byte get_Channel() { }

	public byte get_Level() { }

	public byte get_Opcode() { }

	public int get_Task() { }

	public long get_Keywords() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public bool Equals(EventDescriptor other) { }

}

internal class EventProvider : IDisposable // TypeDefIndex: 1599
{
	private static bool m_setInformationMissing; 
	private UnsafeNativeMethods.ManifestEtw.EtwEnableCallback m_etwCallback; 
	private GCHandle m_thisGCHandle; 
	private long m_regHandle; 
	private byte m_level; 
	private long m_anyKeywordMask; 
	private long m_allKeywordMask; 
	private List<EventProvider.SessionInfo> m_liveSessions; 
	private bool m_enabled; 
	private Guid m_providerId; 
	internal bool m_disposed; 
	[ThreadStaticAttribute] 
	private static EventProvider.WriteEventErrorCode s_returnCode; 
	private static int[] nibblebits; 

	protected EventLevel Level { get; }
	protected EventKeywords MatchAnyKeyword { get; }


	internal void .ctor() { }

	internal void Register(Guid providerGuid) { }

	internal int SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS eventInfoClass, void* data, int dataSize) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	private void Deregister() { }

	[EventProvider.MonoPInvokeCallbackAttribute] 
	private static void EtwEnableCallBack(in Guid sourceId, [In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

	private void EtwEnableCallBackImpl([In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData) { }

	protected virtual void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int sessionId, int etwSessionId) { }

	protected EventLevel get_Level() { }

	protected EventKeywords get_MatchAnyKeyword() { }

	private static int FindNull(byte[] buffer, int idx) { }

	private List<Tuple<EventProvider.SessionInfo, bool>> GetSessions() { }

	private static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<EventProvider.SessionInfo> sessionList) { }

	private void GetSessionInfo(Action<int, long> action) { }

	private static int IndexOfSessionInList(List<EventProvider.SessionInfo> sessions, int etwSessionId) { }

	private bool GetDataFromController(int etwSessionId, UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out byte[] data, out int dataStart) { }

	public bool IsEnabled() { }

	public bool IsEnabled(byte level, long keywords) { }

	public static EventProvider.WriteEventErrorCode GetLastWriteEventError() { }

	private static void SetLastError(int error) { }

	private static object EncodeObject(ref object data, ref EventProvider.EventData* dataDescriptor, ref byte* dataBuffer, ref uint totalEventSize) { }

	internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, object[] eventPayload) { }

	protected internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data) { }

	internal bool WriteEventRaw(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	private uint EventUnregister() { }

	private static int bitcount(uint n) { }

	private static int bitindex(uint n) { }

	private static void .cctor() { }

}

public struct EventProvider.EventData // TypeDefIndex: 1600
{
	internal ulong Ptr; 
	internal uint Size; 
	internal uint Reserved; 

}

public struct EventProvider.SessionInfo // TypeDefIndex: 1601
{
	internal int sessionIdBit; 
	internal int etwSessionId; 


	internal void .ctor(int sessionIdBit_, int etwSessionId_) { }

}

public enum EventProvider.WriteEventErrorCode // TypeDefIndex: 1602
{
	public int value__; 
	public const EventProvider.WriteEventErrorCode NoError = 0;
	public const EventProvider.WriteEventErrorCode NoFreeBuffers = 1;
	public const EventProvider.WriteEventErrorCode EventTooBig = 2;
	public const EventProvider.WriteEventErrorCode NullInput = 3;
	public const EventProvider.WriteEventErrorCode TooManyArgs = 4;
	public const EventProvider.WriteEventErrorCode Other = 5;

}

private sealed class EventProvider.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 1603
{

	public void .ctor(Type t) { }

}

private sealed class EventProvider.<>c__DisplayClass44_0 // TypeDefIndex: 1604
{
	public List<EventProvider.SessionInfo> liveSessionList; 


	public void .ctor() { }

	internal void <GetSessions>b__0(int etwSessionId, long matchAllKeywords) { }

}

public enum EventSourceSettings // TypeDefIndex: 1605
{
	public int value__; 
	public const EventSourceSettings Default = 0;
	public const EventSourceSettings ThrowOnEventWriteErrors = 1;
	public const EventSourceSettings EtwManifestEventFormat = 4;
	public const EventSourceSettings EtwSelfDescribingEventFormat = 8;

}

public class EventListener // TypeDefIndex: 1606
{
	private static readonly object s_EventSourceCreatedLock; 
	[CompilerGeneratedAttribute] 
	private EventHandler<EventSourceCreatedEventArgs> _EventSourceCreated; 
	[CompilerGeneratedAttribute] 
	private EventHandler<EventWrittenEventArgs> EventWritten; 
	internal EventListener m_Next; 
	internal ActivityFilter m_activityFilter; 
	internal static EventListener s_Listeners; 
	internal static List<WeakReference> s_EventSources; 
	private static bool s_CreatingListener; 
	private static bool s_EventSourceShutdownRegistered; 

	internal static object EventListenersLock { get; }


	protected internal virtual void OnEventSourceCreated(EventSource eventSource) { }

	protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData) { }

	internal static void AddEventSource(EventSource newEventSource) { }

	private static void DisposeOnShutdown(object sender, EventArgs e) { }

	internal static object get_EventListenersLock() { }

	private static void .cctor() { }

}

public class EventCommandEventArgs : EventArgs // TypeDefIndex: 1607
{
	[CompilerGeneratedAttribute] 
	private EventCommand <Command>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IDictionary<string, string> <Arguments>k__BackingField; 
	internal EventSource eventSource; 
	internal EventDispatcher dispatcher; 
	internal EventListener listener; 
	internal int perEventSourceSessionId; 
	internal int etwSessionId; 
	internal bool enable; 
	internal EventLevel level; 
	internal EventKeywords matchAnyKeyword; 
	internal EventCommandEventArgs nextCommand; 

	public EventCommand Command { get; set; }
	public IDictionary<string, string> Arguments { get; set; }


	[CompilerGeneratedAttribute] 
	public EventCommand get_Command() { }

	[CompilerGeneratedAttribute] 
	internal void set_Command(EventCommand value) { }

	[CompilerGeneratedAttribute] 
	public IDictionary<string, string> get_Arguments() { }

	[CompilerGeneratedAttribute] 
	internal void set_Arguments(IDictionary<string, string> value) { }

	internal void .ctor(EventCommand command, IDictionary<string, string> arguments, EventSource eventSource, EventListener listener, int perEventSourceSessionId, int etwSessionId, bool enable, EventLevel level, EventKeywords matchAnyKeyword) { }

}

public class EventSourceCreatedEventArgs : EventArgs // TypeDefIndex: 1608
{
	[CompilerGeneratedAttribute] 
	private EventSource <EventSource>k__BackingField; 

	internal EventSource EventSource { set; }


	[CompilerGeneratedAttribute] 
	internal void set_EventSource(EventSource value) { }

	public void .ctor() { }

}

public class EventWrittenEventArgs : EventArgs // TypeDefIndex: 1609
{
	[CompilerGeneratedAttribute] 
	private int <EventId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Guid <RelatedActivityId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ReadOnlyCollection<object> <Payload>k__BackingField; 
	private string m_message; 
	private string m_eventName; 
	private EventSource m_eventSource; 
	private ReadOnlyCollection<string> m_payloadNames; 

	internal string EventName { set; }
	internal int EventId { set; }
	internal Guid RelatedActivityId { set; }
	internal ReadOnlyCollection<object> Payload { set; }
	internal ReadOnlyCollection<string> PayloadNames { set; }
	internal string Message { set; }


	internal void set_EventName(string value) { }

	[CompilerGeneratedAttribute] 
	internal void set_EventId(int value) { }

	[CompilerGeneratedAttribute] 
	internal void set_RelatedActivityId(Guid value) { }

	[CompilerGeneratedAttribute] 
	internal void set_Payload(ReadOnlyCollection<object> value) { }

	internal void set_PayloadNames(ReadOnlyCollection<string> value) { }

	internal void set_Message(string value) { }

	internal void .ctor(EventSource eventSource) { }

}

public sealed class EventSourceAttribute : Attribute // TypeDefIndex: 1610
{
	[CompilerGeneratedAttribute] 
	private string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Guid>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <LocalizationResources>k__BackingField; 

	public string Name { get; set; }
	public string Guid { get; set; }
	public string LocalizationResources { get; }


	[CompilerGeneratedAttribute] 
	public string get_Name() { }

	[CompilerGeneratedAttribute] 
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Guid() { }

	[CompilerGeneratedAttribute] 
	public void set_Guid(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_LocalizationResources() { }

	public void .ctor() { }

}

public sealed class EventAttribute : Attribute // TypeDefIndex: 1611
{
	[CompilerGeneratedAttribute] 
	private int <EventId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventLevel <Level>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventKeywords <Keywords>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventTask <Task>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private byte <Version>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Message>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventTags <Tags>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventActivityOptions <ActivityOptions>k__BackingField; 
	private EventOpcode m_opcode; 
	private bool m_opcodeSet; 

	public int EventId { get; set; }
	public EventLevel Level { get; set; }
	public EventKeywords Keywords { get; }
	public EventOpcode Opcode { get; set; }
	internal bool IsOpcodeSet { get; }
	public EventTask Task { get; set; }
	public byte Version { get; }
	public string Message { get; set; }
	public EventTags Tags { get; }
	public EventActivityOptions ActivityOptions { get; set; }


	public void .ctor(int eventId) { }

	[CompilerGeneratedAttribute] 
	public int get_EventId() { }

	[CompilerGeneratedAttribute] 
	private void set_EventId(int value) { }

	[CompilerGeneratedAttribute] 
	public EventLevel get_Level() { }

	[CompilerGeneratedAttribute] 
	public void set_Level(EventLevel value) { }

	[CompilerGeneratedAttribute] 
	public EventKeywords get_Keywords() { }

	public EventOpcode get_Opcode() { }

	public void set_Opcode(EventOpcode value) { }

	internal bool get_IsOpcodeSet() { }

	[CompilerGeneratedAttribute] 
	public EventTask get_Task() { }

	[CompilerGeneratedAttribute] 
	public void set_Task(EventTask value) { }

	[CompilerGeneratedAttribute] 
	public byte get_Version() { }

	[CompilerGeneratedAttribute] 
	public string get_Message() { }

	[CompilerGeneratedAttribute] 
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] 
	public EventTags get_Tags() { }

	[CompilerGeneratedAttribute] 
	public EventActivityOptions get_ActivityOptions() { }

	[CompilerGeneratedAttribute] 
	public void set_ActivityOptions(EventActivityOptions value) { }

}

public enum EventCommand // TypeDefIndex: 1613
{
	public int value__; 
	public const EventCommand Update = 0;
	public const EventCommand SendManifest = -1;
	public const EventCommand Enable = -2;
	public const EventCommand Disable = -3;

}

internal class EventDispatcher // TypeDefIndex: 1622
{
	internal readonly EventListener m_Listener; 
	internal bool[] m_EventEnabled; 
	internal bool m_activityFilteringEnabled; 
	internal EventDispatcher m_Next; 


	internal void .ctor(EventDispatcher next, bool[] eventEnabled, EventListener listener) { }

}

public enum EventManifestOptions // TypeDefIndex: 1623
{
	public int value__; 
	public const EventManifestOptions None = 0;
	public const EventManifestOptions Strict = 1;
	public const EventManifestOptions AllCultures = 2;
	public const EventManifestOptions OnlyIfNeededForRegistration = 4;
	public const EventManifestOptions AllowEventSourceOverride = 8;

}

public class EventSourceException : Exception // TypeDefIndex: 1629
{

	public void .ctor() { }

	public void .ctor(string message, Exception innerException) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(Exception innerException) { }

}

public enum EventLevel // TypeDefIndex: 1630
{
	public int value__; 
	public const EventLevel LogAlways = 0;
	public const EventLevel Critical = 1;
	public const EventLevel Error = 2;
	public const EventLevel Warning = 3;
	public const EventLevel Informational = 4;
	public const EventLevel Verbose = 5;

}

public enum EventTask // TypeDefIndex: 1631
{
	public int value__; 
	public const EventTask None = 0;

}

public enum EventOpcode // TypeDefIndex: 1632
{
	public int value__; 
	public const EventOpcode Info = 0;
	public const EventOpcode Start = 1;
	public const EventOpcode Stop = 2;
	public const EventOpcode DataCollectionStart = 3;
	public const EventOpcode DataCollectionStop = 4;
	public const EventOpcode Extension = 5;
	public const EventOpcode Reply = 6;
	public const EventOpcode Resume = 7;
	public const EventOpcode Suspend = 8;
	public const EventOpcode Send = 9;
	public const EventOpcode Receive = 240;

}

public enum EventChannel // TypeDefIndex: 1633
{
	public byte value__; 
	public const EventChannel None = 0;
	public const EventChannel Admin = 16;
	public const EventChannel Operational = 17;
	public const EventChannel Analytic = 18;
	public const EventChannel Debug = 19;

}

public enum EventKeywords // TypeDefIndex: 1634
{
	public long value__; 
	public const EventKeywords None = 0;
	public const EventKeywords All = -1;
	public const EventKeywords MicrosoftTelemetry = 562949953421312;
	public const EventKeywords WdiContext = 562949953421312;
	public const EventKeywords WdiDiagnostic = 1125899906842624;
	public const EventKeywords Sqm = 2251799813685248;
	public const EventKeywords AuditFailure = 4503599627370496;
	public const EventKeywords AuditSuccess = 9007199254740992;
	public const EventKeywords CorrelationHint = 4503599627370496;
	public const EventKeywords EventLogClassic = 36028797018963968;

}

public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 2703
{

[DefaultMemberAttribute] 
[ComVisibleAttribute] 
public class EventDescriptorCollection : ICollection, IEnumerable, IList 
	private EventDescriptor[] events; 
	private string[] namedSort; 
	private IComparer comparer; 
	private bool eventsOwned; 
	private bool needSort; 
	private int eventCount; 
	private bool readOnly; 
	public static readonly EventDescriptorCollection Empty; 

	public int Count { get; }
	public virtual EventDescriptor Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }


	public void .ctor(EventDescriptor[] events) { }

	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	public int get_Count() { }

	public virtual EventDescriptor get_Item(int index) { }

	public int Add(EventDescriptor value) { }

	public void Clear() { }

	public bool Contains(EventDescriptor value) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private void EnsureEventsOwned() { }

	private void EnsureSize(int sizeNeeded) { }

	public int IndexOf(EventDescriptor value) { }

	public void Insert(int index, EventDescriptor value) { }

	public void Remove(EventDescriptor value) { }

	public void RemoveAt(int index) { }

	public IEnumerator GetEnumerator() { }

	protected void InternalSort(string[] names) { }

	protected void InternalSort(IComparer sorter) { }

	private int System.Collections.ICollection.get_Count() { }

	private object System.Collections.ICollection.get_SyncRoot() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private object System.Collections.IList.get_Item(int index) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

	private int System.Collections.IList.Add(object value) { }

	private void System.Collections.IList.Clear() { }

	private bool System.Collections.IList.Contains(object value) { }

	private int System.Collections.IList.IndexOf(object value) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.IList.RemoveAt(int index) { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private bool System.Collections.IList.get_IsFixedSize() { }

	private static void .cctor() { }

}

public sealed class EventHandlerList : IDisposable // TypeDefIndex: 2704
{
	private EventHandlerList.ListEntry head; 
	private Component parent; 

	public Delegate Item { get; }


	internal void .ctor(Component parent) { }

	public Delegate get_Item(object key) { }

	public void AddHandler(object key, Delegate value) { }

	public void Dispose() { }

	private EventHandlerList.ListEntry Find(object key) { }

	public void RemoveHandler(object key, Delegate value) { }

}

private sealed class EventHandlerList.ListEntry // TypeDefIndex: 2705
{
	internal EventHandlerList.ListEntry next; 
	internal object key; 
	internal Delegate handler; 


	public void .ctor(object key, Delegate handler, EventHandlerList.ListEntry next) { }

}

public sealed class Event // TypeDefIndex: 4025
{

[NativeHeaderAttribute] 
[StaticAccessorAttribute] 
public sealed class Event 
	internal IntPtr m_Ptr; 
	private static Event s_Current; 
	private static Event s_MasterEvent; 

	[NativePropertyAttribute] 
	public EventType rawType { get; }
	[NativePropertyAttribute] 
	public Vector2 mousePosition { get; set; }
	[NativePropertyAttribute] 
	public Vector2 delta { get; }
	[NativePropertyAttribute] 
	public PointerType pointerType { get; }
	[NativePropertyAttribute] 
	public int button { get; }
	[NativePropertyAttribute] 
	public EventModifiers modifiers { get; set; }
	[NativePropertyAttribute] 
	public float pressure { get; }
	[NativePropertyAttribute] 
	public int clickCount { get; }
	[NativePropertyAttribute] 
	public char character { get; set; }
	[NativePropertyAttribute] 
	public KeyCode keyCode { get; set; }
	[NativePropertyAttribute] 
	public int displayIndex { get; set; }
	public EventType type { get; set; }
	public string commandName { get; set; }
	public bool shift { get; }
	public bool control { get; }
	public bool alt { get; }
	public bool command { get; }
	public static Event current { get; set; }
	public bool isKey { get; }
	public bool isMouse { get; }
	internal bool isDirectManipulationDevice { get; }


	public EventType get_rawType() { }

	public Vector2 get_mousePosition() { }

	public void set_mousePosition(Vector2 value) { }

	public Vector2 get_delta() { }

	public PointerType get_pointerType() { }

	public int get_button() { }

	public EventModifiers get_modifiers() { }

	public void set_modifiers(EventModifiers value) { }

	public float get_pressure() { }

	public int get_clickCount() { }

	public char get_character() { }

	public void set_character(char value) { }

	public KeyCode get_keyCode() { }

	public void set_keyCode(KeyCode value) { }

	public int get_displayIndex() { }

	public void set_displayIndex(int value) { }

	[FreeFunctionAttribute] 
	public EventType get_type() { }

	[FreeFunctionAttribute] 
	public void set_type(EventType value) { }

	[FreeFunctionAttribute] 
	public string get_commandName() { }

	[FreeFunctionAttribute] 
	public void set_commandName(string value) { }

	[NativeMethodAttribute] 
	private void Internal_Use() { }

	[FreeFunctionAttribute] 
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunctionAttribute] 
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] 
	private static IntPtr Internal_Copy(IntPtr otherPtr) { }

	[FreeFunctionAttribute] 
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunctionAttribute] 
	[VisibleToOtherModulesAttribute] 
	internal void CopyFromPtr(IntPtr ptr) { }

	public static bool PopEvent(Event outEvent) { }

	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] 
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	public void .ctor() { }

	public void .ctor(int displayIndex) { }

	public void .ctor(Event other) { }

	protected override void Finalize() { }

	[VisibleToOtherModulesAttribute] 
	internal void CopyFrom(Event e) { }

	public bool get_shift() { }

	public bool get_control() { }

	public bool get_alt() { }

	public bool get_command() { }

	public static Event get_current() { }

	public static void set_current(Event value) { }

	public bool get_isKey() { }

	public bool get_isMouse() { }

	[VisibleToOtherModulesAttribute] 
	internal bool get_isDirectManipulationDevice() { }

	public static Event KeyboardEvent(string key) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public override string ToString() { }

	public void Use() { }

	private void get_mousePosition_Injected(out Vector2 ret) { }

	private void set_mousePosition_Injected(ref Vector2 value) { }

	private void get_delta_Injected(out Vector2 ret) { }

}

public enum EventType // TypeDefIndex: 4026
{
	public int value__; 
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	[ObsoleteAttribute] 
	[EditorBrowsableAttribute] 
	public const EventType mouseDown = 0;
	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public const EventType mouseUp = 1;
	[ObsoleteAttribute] 
	[EditorBrowsableAttribute] 
	public const EventType mouseMove = 2;
	[ObsoleteAttribute] 
	[EditorBrowsableAttribute] 
	public const EventType mouseDrag = 3;
	[ObsoleteAttribute] 
	[EditorBrowsableAttribute] 
	public const EventType keyDown = 4;
	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public const EventType keyUp = 5;
	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public const EventType scrollWheel = 6;
	[ObsoleteAttribute] 
	[EditorBrowsableAttribute] 
	public const EventType repaint = 7;
	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public const EventType layout = 8;
	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public const EventType dragUpdated = 9;
	[ObsoleteAttribute] 
	[EditorBrowsableAttribute] 
	public const EventType dragPerform = 10;
	[ObsoleteAttribute] 
	[EditorBrowsableAttribute] 
	public const EventType ignore = 11;
	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public const EventType used = 12;

}

public enum EventModifiers // TypeDefIndex: 4027
{
	public int value__; 
	public const EventModifiers None = 0;
	public const EventModifiers Shift = 1;
	public const EventModifiers Control = 2;
	public const EventModifiers Alt = 4;
	public const EventModifiers Command = 8;
	public const EventModifiers Numeric = 16;
	public const EventModifiers CapsLock = 32;
	public const EventModifiers FunctionKey = 64;

}

internal struct EventInterests // TypeDefIndex: 4029
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <wantsMouseMove>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; 

	public bool wantsMouseMove { get; }
	public bool wantsMouseEnterLeaveWindow { get; }


	[CompilerGeneratedAttribute] 
	public bool get_wantsMouseMove() { }

	[CompilerGeneratedAttribute] 
	public bool get_wantsMouseEnterLeaveWindow() { }

	public bool WantsEvent(EventType type) { }

}

public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate> // TypeDefIndex: 4582
{
	private readonly EventDispatcher m_Dispatcher; 


	public void .ctor(EventDispatcher d) { }

	public void Dispose() { }

	public bool Equals(EventDispatcherGate other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

public sealed class EventDispatcher // TypeDefIndex: 4583
{
	private List<IEventDispatchingStrategy> m_DispatchingStrategies; 
	private static readonly ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool; 
	private Queue<EventDispatcher.EventRecord> m_Queue; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly PointerDispatchState <pointerState>k__BackingField; 
	private uint m_GateCount; 
	private Stack<EventDispatcher.DispatchContext> m_DispatchContexts; 
	private bool m_Immediate; 

	internal PointerDispatchState pointerState { get; }
	private bool dispatchImmediately { get; }


	[CompilerGeneratedAttribute] 
	internal PointerDispatchState get_pointerState() { }

	internal void .ctor() { }

	private bool get_dispatchImmediately() { }

	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	internal void CloseGate() { }

	internal void OpenGate() { }

	private void ProcessEventQueue() { }

	private void ProcessEvent(EventBase evt, IPanel panel) { }

	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	private static void .cctor() { }

}

private struct EventDispatcher.EventRecord // TypeDefIndex: 4584
{
	public EventBase m_Event; 
	public IPanel m_Panel; 

}

private struct EventDispatcher.DispatchContext // TypeDefIndex: 4585
{
	public uint m_GateCount; 
	public Queue<EventDispatcher.EventRecord> m_Queue; 

}

public abstract class EventBase : IDisposable // TypeDefIndex: 4640
{
	private static long s_LastTypeId; 
	private static ulong s_NextEventId; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private long <timestamp>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private ulong <eventId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private ulong <triggerEventId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private EventBase.EventPropagation <propagation>k__BackingField; 
	private PropagationPaths m_Path; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private EventBase.LifeCycleStatus <lifeCycleStatus>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private IEventHandler <leafTarget>k__BackingField; 
	private IEventHandler m_Target; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly List<IEventHandler> <skipElements>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private PropagationPhase <propagationPhase>k__BackingField; 
	private IEventHandler m_CurrentTarget; 
	private Event m_ImguiEvent; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private Vector2 <originalMousePosition>k__BackingField; 

	public virtual long eventTypeId { get; }
	private long timestamp { set; }
	internal ulong eventId { get; set; }
	private ulong triggerEventId { set; }
	internal EventBase.EventPropagation propagation { get; set; }
	internal PropagationPaths path { get; set; }
	private EventBase.LifeCycleStatus lifeCycleStatus { get; set; }
	public bool bubbles { get; }
	public bool tricklesDown { get; }
	internal IEventHandler leafTarget { get; set; }
	public IEventHandler target { get; set; }
	internal List<IEventHandler> skipElements { get; }
	public bool isPropagationStopped { get; set; }
	public bool isImmediatePropagationStopped { get; set; }
	public bool isDefaultPrevented { get; set; }
	public PropagationPhase propagationPhase { get; set; }
	public virtual IEventHandler currentTarget { get; set; }
	public bool dispatch { get; set; }
	private bool dispatched { get; set; }
	internal bool processed { get; set; }
	internal bool stopDispatch { get; set; }
	internal bool propagateToIMGUI { get; set; }
	private bool imguiEventIsValid { get; set; }
	public Event imguiEvent { get; set; }
	public Vector2 originalMousePosition { get; set; }
	protected bool pooled { get; set; }


	protected static long RegisterEventType() { }

	public virtual long get_eventTypeId() { }

	[CompilerGeneratedAttribute] 
	private void set_timestamp(long value) { }

	[CompilerGeneratedAttribute] 
	internal ulong get_eventId() { }

	[CompilerGeneratedAttribute] 
	private void set_eventId(ulong value) { }

	[CompilerGeneratedAttribute] 
	private void set_triggerEventId(ulong value) { }

	internal void SetTriggerEventId(ulong id) { }

	[CompilerGeneratedAttribute] 
	internal EventBase.EventPropagation get_propagation() { }

	[CompilerGeneratedAttribute] 
	internal void set_propagation(EventBase.EventPropagation value) { }

	internal PropagationPaths get_path() { }

	internal void set_path(PropagationPaths value) { }

	[CompilerGeneratedAttribute] 
	private EventBase.LifeCycleStatus get_lifeCycleStatus() { }

	[CompilerGeneratedAttribute] 
	private void set_lifeCycleStatus(EventBase.LifeCycleStatus value) { }

	[ObsoleteAttribute] 
	protected virtual void PreDispatch() { }

	protected internal virtual void PreDispatch(IPanel panel) { }

	[ObsoleteAttribute] 
	protected virtual void PostDispatch() { }

	protected internal virtual void PostDispatch(IPanel panel) { }

	public bool get_bubbles() { }

	public bool get_tricklesDown() { }

	[CompilerGeneratedAttribute] 
	internal IEventHandler get_leafTarget() { }

	[CompilerGeneratedAttribute] 
	private void set_leafTarget(IEventHandler value) { }

	public IEventHandler get_target() { }

	public void set_target(IEventHandler value) { }

	[CompilerGeneratedAttribute] 
	internal List<IEventHandler> get_skipElements() { }

	internal bool Skip(IEventHandler h) { }

	public bool get_isPropagationStopped() { }

	private void set_isPropagationStopped(bool value) { }

	public void StopPropagation() { }

	public bool get_isImmediatePropagationStopped() { }

	private void set_isImmediatePropagationStopped(bool value) { }

	public void StopImmediatePropagation() { }

	public bool get_isDefaultPrevented() { }

	private void set_isDefaultPrevented(bool value) { }

	public void PreventDefault() { }

	[CompilerGeneratedAttribute] 
	public PropagationPhase get_propagationPhase() { }

	[CompilerGeneratedAttribute] 
	internal void set_propagationPhase(PropagationPhase value) { }

	public virtual IEventHandler get_currentTarget() { }

	internal virtual void set_currentTarget(IEventHandler value) { }

	public bool get_dispatch() { }

	internal void set_dispatch(bool value) { }

	internal void MarkReceivedByDispatcher() { }

	private bool get_dispatched() { }

	private void set_dispatched(bool value) { }

	internal bool get_processed() { }

	private void set_processed(bool value) { }

	internal bool get_stopDispatch() { }

	internal void set_stopDispatch(bool value) { }

	internal bool get_propagateToIMGUI() { }

	internal void set_propagateToIMGUI(bool value) { }

	private bool get_imguiEventIsValid() { }

	private void set_imguiEventIsValid(bool value) { }

	public Event get_imguiEvent() { }

	protected void set_imguiEvent(Event value) { }

	[CompilerGeneratedAttribute] 
	public Vector2 get_originalMousePosition() { }

	[CompilerGeneratedAttribute] 
	private void set_originalMousePosition(Vector2 value) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected void .ctor() { }

	protected bool get_pooled() { }

	protected void set_pooled(bool value) { }

	internal abstract void Acquire();

	public abstract void Dispose();

	private static void .cctor() { }

}

internal enum EventBase.EventPropagation // TypeDefIndex: 4641
{
	public int value__; 
	public const EventBase.EventPropagation None = 0;
	public const EventBase.EventPropagation Bubbles = 1;
	public const EventBase.EventPropagation TricklesDown = 2;
	public const EventBase.EventPropagation Cancellable = 4;

}

private enum EventBase.LifeCycleStatus // TypeDefIndex: 4642
{
	public int value__; 
	public const EventBase.LifeCycleStatus None = 0;
	public const EventBase.LifeCycleStatus PropagationStopped = 1;
	public const EventBase.LifeCycleStatus ImmediatePropagationStopped = 2;
	public const EventBase.LifeCycleStatus DefaultPrevented = 4;
	public const EventBase.LifeCycleStatus Dispatching = 8;
	public const EventBase.LifeCycleStatus Pooled = 16;
	public const EventBase.LifeCycleStatus IMGUIEventIsValid = 32;
	public const EventBase.LifeCycleStatus StopDispatch = 64;
	public const EventBase.LifeCycleStatus PropagateToIMGUI = 128;
	public const EventBase.LifeCycleStatus Dispatched = 512;
	public const EventBase.LifeCycleStatus Processed = 1024;

}

internal abstract class EventCallbackFunctorBase // TypeDefIndex: 4644
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private CallbackPhase <phase>k__BackingField; 

	public CallbackPhase phase { get; }


	[CompilerGeneratedAttribute] 
	public CallbackPhase get_phase() { }

	public abstract void Invoke(EventBase evt);

}

internal class EventCallbackListPool // TypeDefIndex: 4646
{
	private readonly Stack<EventCallbackList> m_Stack; 


	public EventCallbackList Get(EventCallbackList initializer) { }

	public void Release(EventCallbackList element) { }

	public void .ctor() { }

}

internal class EventCallbackList // TypeDefIndex: 4647
{
	private List<EventCallbackFunctorBase> m_List; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <trickleDownCallbackCount>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <bubbleUpCallbackCount>k__BackingField; 

	public int trickleDownCallbackCount { get; set; }
	public int bubbleUpCallbackCount { get; set; }
	public int Count { get; }
	public EventCallbackFunctorBase Item { get; }


	[CompilerGeneratedAttribute] 
	public int get_trickleDownCallbackCount() { }

	[CompilerGeneratedAttribute] 
	private void set_trickleDownCallbackCount(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_bubbleUpCallbackCount() { }

	[CompilerGeneratedAttribute] 
	private void set_bubbleUpCallbackCount(int value) { }

	public void .ctor() { }

	public void .ctor(EventCallbackList source) { }

	public void AddRange(EventCallbackList list) { }

	public int get_Count() { }

	public EventCallbackFunctorBase get_Item(int i) { }

	public void Clear() { }

}

internal class EventCallbackRegistry // TypeDefIndex: 4648
{
	private static readonly EventCallbackListPool s_ListPool; 
	private EventCallbackList m_Callbacks; 
	private EventCallbackList m_TemporaryCallbacks; 
	private int m_IsInvoking; 


	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	public void InvokeCallbacks(EventBase evt) { }

	public bool HasTrickleDownHandlers() { }

	public bool HasBubbleHandlers() { }

	private static void .cctor() { }

}

internal static class EventDispatchUtilities // TypeDefIndex: 4658
{

	public static void PropagateEvent(EventBase evt) { }

	internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

	public static void ExecuteDefaultAction(EventBase evt, IPanel panel) { }

}

internal struct EventDebuggerLogIMGUICall : IDisposable // TypeDefIndex: 4703
{

	public void .ctor(EventBase evt) { }

	public void Dispose() { }

}

internal struct EventDebuggerLogExecuteDefaultAction : IDisposable // TypeDefIndex: 4704
{

	public void .ctor(EventBase evt) { }

	public void Dispose() { }

}

internal class EventDebugger // TypeDefIndex: 4705
{

	public static void LogPropagationPaths(EventBase evt, PropagationPaths paths) { }

}

public enum EventHandle // TypeDefIndex: 5052
{
	public int value__; 
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;

}

public class EventSystem : UIBehaviour // TypeDefIndex: 5071
{
	private List<BaseInputModule> m_SystemInputModules; 
	private BaseInputModule m_CurrentInputModule; 
	private static List<EventSystem> m_EventSystems; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private GameObject m_FirstSelected; 
	[SerializeField] 
	private bool m_sendNavigationEvents; 
	[SerializeField] 
	private int m_DragThreshold; 
	private GameObject m_CurrentSelected; 
	private bool m_HasFocus; 
	private bool m_SelectionGuard; 
	private BaseEventData m_DummyData; 
	private static readonly Comparison<RaycastResult> s_RaycastComparer; 

	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[ObsoleteAttribute] 
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }


	public static EventSystem get_current() { }

	public static void set_current(EventSystem value) { }

	public bool get_sendNavigationEvents() { }

	public void set_sendNavigationEvents(bool value) { }

	public int get_pixelDragThreshold() { }

	public void set_pixelDragThreshold(int value) { }

	public BaseInputModule get_currentInputModule() { }

	public GameObject get_firstSelectedGameObject() { }

	public void set_firstSelectedGameObject(GameObject value) { }

	public GameObject get_currentSelectedGameObject() { }

	public GameObject get_lastSelectedGameObject() { }

	public bool get_isFocused() { }

	protected void .ctor() { }

	public void UpdateModules() { }

	public bool get_alreadySelecting() { }

	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	private BaseEventData get_baseEventDataCache() { }

	public void SetSelectedGameObject(GameObject selected) { }

	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	public bool IsPointerOverGameObject() { }

	public bool IsPointerOverGameObject(int pointerId) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	private void TickModules() { }

	protected virtual void OnApplicationFocus(bool hasFocus) { }

	protected virtual void Update() { }

	private void ChangeEventModule(BaseInputModule module) { }

	public override string ToString() { }

	private static void .cctor() { }

}

public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5072
{
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private List<EventTrigger.Entry> m_Delegates; 

	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }


	public List<EventTrigger.Entry> get_delegates() { }

	public void set_delegates(List<EventTrigger.Entry> value) { }

	protected void .ctor() { }

	public List<EventTrigger.Entry> get_triggers() { }

	public void set_triggers(List<EventTrigger.Entry> value) { }

	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnDrop(PointerEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void OnScroll(PointerEventData eventData) { }

	public virtual void OnMove(AxisEventData eventData) { }

	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	public virtual void OnCancel(BaseEventData eventData) { }

}

public class EventTrigger.TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 5073
{

	public void .ctor() { }

}

public class EventTrigger.Entry // TypeDefIndex: 5074
{
	public EventTriggerType eventID; 
	public EventTrigger.TriggerEvent callback; 


	public void .ctor() { }

}

public enum EventTriggerType // TypeDefIndex: 5075
{
	public int value__; 
	public const EventTriggerType PointerEnter = 0;
	public const EventTriggerType PointerExit = 1;
	public const EventTriggerType PointerDown = 2;
	public const EventTriggerType PointerUp = 3;
	public const EventTriggerType PointerClick = 4;
	public const EventTriggerType Drag = 5;
	public const EventTriggerType Drop = 6;
	public const EventTriggerType Scroll = 7;
	public const EventTriggerType UpdateSelected = 8;
	public const EventTriggerType Select = 9;
	public const EventTriggerType Deselect = 10;
	public const EventTriggerType Move = 11;
	public const EventTriggerType InitializePotentialDrag = 12;
	public const EventTriggerType BeginDrag = 13;
	public const EventTriggerType EndDrag = 14;
	public const EventTriggerType Submit = 15;
	public const EventTriggerType Cancel = 16;

}

internal static class EventHandlerExtensions // TypeDefIndex: 7141
{

	[ExtensionAttribute] 
	public static void Raise<T>(EventHandler<T> eventHandler, object sender, T eventArgs) { }
	/* GenericInstMethod :
	|
	|-EventHandlerExtensions.Raise<LoadCompletedEventArgs>
	|-EventHandlerExtensions.Raise<LoadProgressEventArgs>
	|-EventHandlerExtensions.Raise<StateChangedEventArgs>
	|-EventHandlerExtensions.Raise<object>
	*/

}

public sealed class EventsCollection : ICollection<MidiEvent>, IEnumerable<MidiEvent>, IEnumerable // TypeDefIndex: 7514
{
	internal readonly List<MidiEvent> _events; 
	[CompilerGeneratedAttribute] 
	private readonly bool <IsReadOnly>k__BackingField; 

	public MidiEvent Item { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }


	internal void .ctor() { }

	public MidiEvent get_Item(int index) { }

	public int get_Count() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsReadOnly() { }

	public void Add(MidiEvent midiEvent) { }

	public bool Remove(MidiEvent midiEvent) { }

	public void Clear() { }

	public IEnumerator<MidiEvent> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool Contains(MidiEvent item) { }

	public void CopyTo(MidiEvent[] array, int arrayIndex) { }

}

public sealed class EventTypesCollection // TypeDefIndex: 7530
{
	private readonly Dictionary<byte, Type> _types; 


	public bool TryGetType(byte statusByte, out Type type) { }

}

internal static class EventReaderFactory // TypeDefIndex: 7553
{
	private static readonly IEventReader MetaEventReader; 
	private static readonly IEventReader ChannelEventReader; 
	private static readonly IEventReader SysExEventReader; 
	private static readonly IEventReader SystemRealTimeEventReader; 
	private static readonly IEventReader SystemCommonEventReader; 


	internal static IEventReader GetReader(byte statusByte, bool smfOnly) { }

	private static void .cctor() { }

}

public class EventSchedule : BaseMonoBehaviour // TypeDefIndex: 9816
{
	[TooltipAttribute] 
	public float minimumHoursBetween; 
	[TooltipAttribute] 
	public float maxmumHoursBetween; 


	public void .ctor() { }

}

