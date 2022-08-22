public class EventArgs // TypeDefIndex: 215
{	public static readonly EventArgs Empty; // 0x12F30


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
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-EventHandler<LoadCompletedEventArgs>..ctor
	|-EventHandler<LoadProgressEventArgs>..ctor
	|-EventHandler<StateChangedEventArgs>..ctor
	|-EventHandler<RowUpdatingEventArgs>..ctor
	|-EventHandler<object>..ctor
	*/

	public virtual void Invoke(object sender, TEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50
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
	|-RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10
	|-EventHandler<object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-EventHandler<object>.EndInvoke
	*/

}

public enum EventAttributes // TypeDefIndex: 524
{	public int value__; // 0x0
	public const EventAttributes None = 0;
	public const EventAttributes SpecialName = 512;
	public const EventAttributes ReservedMask = 1024;
	public const EventAttributes RTSpecialName = 1024;

}

public abstract class EventInfo : MemberInfo, _EventInfo // TypeDefIndex: 565
{	private EventInfo.AddEventAdapter cached_add_event; // 0x10

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
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const EventFieldTags None = 0;

}

public class EventFieldAttribute : Attribute // TypeDefIndex: 1517
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventFieldTags <Tags>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventFieldFormat <Format>k__BackingField; // 0x20

	public EventFieldTags Tags { get; }
	internal string Name { get; }
	public EventFieldFormat Format { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventFieldFormat get_Format() { }

}

public enum EventFieldFormat // TypeDefIndex: 1518
{	public int value__; // 0x0
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
[DefaultMemberAttribute] // RVA: 0x70A90 Offset: 0x6FE90 VA: 0x180070A90
internal class EventPayload : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable // TypeDefIndex: 1520
	private List<string> m_names; // 0x10
	private List<object> m_values; // 0x18

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

	[IteratorStateMachineAttribute] // RVA: 0xF0A10 Offset: 0xEFE10 VA: 0x1800F0A10
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void CopyTo(KeyValuePair<string, object>[] payloadEntries, int count) { }

	public bool Remove(string key) { }

	public bool Remove(KeyValuePair<string, object> entry) { }

	public bool TryGetValue(string key, out object value) { }

}

private sealed class EventPayload.<GetEnumerator>d__17 : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator // TypeDefIndex: 1521
{	private int <>1__state; // 0x10
	private KeyValuePair<string, object> <>2__current; // 0x18
	public EventPayload <>4__this; // 0x28
	private int <i>5__1; // 0x30

	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public struct EventSourceOptions // TypeDefIndex: 1522
{	internal EventKeywords keywords; // 0x0
	internal EventTags tags; // 0x8
	internal EventActivityOptions activityOptions; // 0xC
	internal byte level; // 0x10
	internal byte opcode; // 0x11
	internal byte valuesSet; // 0x12

	public EventLevel Level { set; }
	public EventOpcode Opcode { set; }
	public EventKeywords Keywords { set; }


	public void set_Level(EventLevel value) { }

	public void set_Opcode(EventOpcode value) { }

	public void set_Keywords(EventKeywords value) { }

}

public class EventSource : IDisposable // TypeDefIndex: 1580
{	private byte[] providerMetadata; // 0x10
	private string m_name; // 0x18
	internal int m_id; // 0x20
	private Guid m_guid; // 0x24
	internal EventSource.EventMetadata[] m_eventData; // 0x38
	private byte[] m_rawManifest; // 0x40
	private EventHandler<EventCommandEventArgs> m_eventCommandExecuted; // 0x48
	private EventSourceSettings m_config; // 0x50
	private bool m_eventSourceEnabled; // 0x54
	internal EventLevel m_level; // 0x58
	internal EventKeywords m_matchAnyKeyword; // 0x60
	internal EventDispatcher m_Dispatchers; // 0x68
	private EventSource.OverideEventProvider m_provider; // 0x70
	private bool m_completelyInited; // 0x78
	private Exception m_constructionException; // 0x80
	private byte m_outOfBandMessageCount; // 0x88
	private EventCommandEventArgs m_deferredCommands; // 0x90
	private string[] m_traits; // 0x98
	internal static uint s_currentPid; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static byte m_EventSourceExceptionRecurenceCount; // 0x80000000
	private SessionMask m_curLiveSessions; // 0xA0
	private EtwSession[] m_etwSessionIdMap; // 0xA8
	private List<EtwSession> m_legacySessions; // 0xB0
	internal long m_keywordTriggers; // 0xB8
	internal SessionMask m_activityFilteringForETWEnabled; // 0xC0
	internal static Action<Guid> s_activityDying; // 0x8
	private ActivityTracker m_activityTracker; // 0xC8
	private static readonly byte[] namespaceBytes; // 0x10
	private static readonly Guid AspNetEventSourceGuid; // 0x18

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

	[NonEventAttribute] // RVA: 0x70080 Offset: 0x6F480 VA: 0x180070080
	[ReliabilityContractAttribute] // RVA: 0x70080 Offset: 0x6F480 VA: 0x180070080
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

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
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
{	private long length; // 0x0
	private uint[] w; // 0x8
	private int pos; // 0x10


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
{	private EventSource m_eventSource; // 0x60


	public void .ctor(EventSource eventSource) { }

	protected override void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int perEventSourceSessionId, int etwSessionId) { }

}

internal struct EventSource.EventMetadata // TypeDefIndex: 1584
{	public EventDescriptor Descriptor; // 0x0
	public EventTags Tags; // 0x10
	public bool EnabledForAnyListener; // 0x14
	public bool EnabledForETW; // 0x15
	public bool HasRelatedActivityID; // 0x16
	public byte TriggersActivityTracking; // 0x17
	public string Name; // 0x18
	public string Message; // 0x20
	public ParameterInfo[] Parameters; // 0x28
	public TraceLoggingEventTypes TraceLoggingEventTypes; // 0x30
	public EventActivityOptions ActivityOptions; // 0x38

}

public enum EventTags // TypeDefIndex: 1585
{	public int value__; // 0x0
	public const EventTags None = 0;

}

public enum EventActivityOptions // TypeDefIndex: 1596
{	public int value__; // 0x0
	public const EventActivityOptions None = 0;
	public const EventActivityOptions Disable = 2;
	public const EventActivityOptions Recursive = 4;
	public const EventActivityOptions Detachable = 8;

}

internal struct EventDescriptor // TypeDefIndex: 1597
{	private int m_traceloggingId; // 0x0
	private ushort m_id; // 0x0
	private byte m_version; // 0x2
	private byte m_channel; // 0x3
	private byte m_level; // 0x4
	private byte m_opcode; // 0x5
	private ushort m_task; // 0x6
	private long m_keywords; // 0x8

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
{	private static bool m_setInformationMissing; // 0x0
	private UnsafeNativeMethods.ManifestEtw.EtwEnableCallback m_etwCallback; // 0x10
	private GCHandle m_thisGCHandle; // 0x18
	private long m_regHandle; // 0x20
	private byte m_level; // 0x28
	private long m_anyKeywordMask; // 0x30
	private long m_allKeywordMask; // 0x38
	private List<EventProvider.SessionInfo> m_liveSessions; // 0x40
	private bool m_enabled; // 0x48
	private Guid m_providerId; // 0x4C
	internal bool m_disposed; // 0x5C
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static EventProvider.WriteEventErrorCode s_returnCode; // 0x80000000
	private static int[] nibblebits; // 0x8

	protected EventLevel Level { get; }
	protected EventKeywords MatchAnyKeyword { get; }


	internal void .ctor() { }

	internal void Register(Guid providerGuid) { }

	internal int SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS eventInfoClass, void* data, int dataSize) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	private void Deregister() { }

	[EventProvider.MonoPInvokeCallbackAttribute] // RVA: 0x70E00 Offset: 0x70200 VA: 0x180070E00
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
{	internal ulong Ptr; // 0x0
	internal uint Size; // 0x8
	internal uint Reserved; // 0xC

}

public struct EventProvider.SessionInfo // TypeDefIndex: 1601
{	internal int sessionIdBit; // 0x0
	internal int etwSessionId; // 0x4


	internal void .ctor(int sessionIdBit_, int etwSessionId_) { }

}

public enum EventProvider.WriteEventErrorCode // TypeDefIndex: 1602
{	public int value__; // 0x0
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
{	public List<EventProvider.SessionInfo> liveSessionList; // 0x10


	public void .ctor() { }

	internal void <GetSessions>b__0(int etwSessionId, long matchAllKeywords) { }

}

public enum EventSourceSettings // TypeDefIndex: 1605
{	public int value__; // 0x0
	public const EventSourceSettings Default = 0;
	public const EventSourceSettings ThrowOnEventWriteErrors = 1;
	public const EventSourceSettings EtwManifestEventFormat = 4;
	public const EventSourceSettings EtwSelfDescribingEventFormat = 8;

}

public class EventListener // TypeDefIndex: 1606
{	private static readonly object s_EventSourceCreatedLock; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler<EventSourceCreatedEventArgs> _EventSourceCreated; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler<EventWrittenEventArgs> EventWritten; // 0x18
	internal EventListener m_Next; // 0x20
	internal ActivityFilter m_activityFilter; // 0x28
	internal static EventListener s_Listeners; // 0x8
	internal static List<WeakReference> s_EventSources; // 0x10
	private static bool s_CreatingListener; // 0x18
	private static bool s_EventSourceShutdownRegistered; // 0x19

	internal static object EventListenersLock { get; }


	protected internal virtual void OnEventSourceCreated(EventSource eventSource) { }

	protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData) { }

	internal static void AddEventSource(EventSource newEventSource) { }

	private static void DisposeOnShutdown(object sender, EventArgs e) { }

	internal static object get_EventListenersLock() { }

	private static void .cctor() { }

}

public class EventCommandEventArgs : EventArgs // TypeDefIndex: 1607
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventCommand <Command>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IDictionary<string, string> <Arguments>k__BackingField; // 0x18
	internal EventSource eventSource; // 0x20
	internal EventDispatcher dispatcher; // 0x28
	internal EventListener listener; // 0x30
	internal int perEventSourceSessionId; // 0x38
	internal int etwSessionId; // 0x3C
	internal bool enable; // 0x40
	internal EventLevel level; // 0x44
	internal EventKeywords matchAnyKeyword; // 0x48
	internal EventCommandEventArgs nextCommand; // 0x50

	public EventCommand Command { get; set; }
	public IDictionary<string, string> Arguments { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventCommand get_Command() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Command(EventCommand value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IDictionary<string, string> get_Arguments() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Arguments(IDictionary<string, string> value) { }

	internal void .ctor(EventCommand command, IDictionary<string, string> arguments, EventSource eventSource, EventListener listener, int perEventSourceSessionId, int etwSessionId, bool enable, EventLevel level, EventKeywords matchAnyKeyword) { }

}

public class EventSourceCreatedEventArgs : EventArgs // TypeDefIndex: 1608
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventSource <EventSource>k__BackingField; // 0x10

	internal EventSource EventSource { set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_EventSource(EventSource value) { }

	public void .ctor() { }

}

public class EventWrittenEventArgs : EventArgs // TypeDefIndex: 1609
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <EventId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Guid <RelatedActivityId>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ReadOnlyCollection<object> <Payload>k__BackingField; // 0x28
	private string m_message; // 0x30
	private string m_eventName; // 0x38
	private EventSource m_eventSource; // 0x40
	private ReadOnlyCollection<string> m_payloadNames; // 0x48

	internal string EventName { set; }
	internal int EventId { set; }
	internal Guid RelatedActivityId { set; }
	internal ReadOnlyCollection<object> Payload { set; }
	internal ReadOnlyCollection<string> PayloadNames { set; }
	internal string Message { set; }


	internal void set_EventName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_EventId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_RelatedActivityId(Guid value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Payload(ReadOnlyCollection<object> value) { }

	internal void set_PayloadNames(ReadOnlyCollection<string> value) { }

	internal void set_Message(string value) { }

	internal void .ctor(EventSource eventSource) { }

}

public sealed class EventSourceAttribute : Attribute // TypeDefIndex: 1610
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Guid>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <LocalizationResources>k__BackingField; // 0x20

	public string Name { get; set; }
	public string Guid { get; set; }
	public string LocalizationResources { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Guid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Guid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_LocalizationResources() { }

	public void .ctor() { }

}

public sealed class EventAttribute : Attribute // TypeDefIndex: 1611
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <EventId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventLevel <Level>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventTask <Task>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte <Version>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Message>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventTags <Tags>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventActivityOptions <ActivityOptions>k__BackingField; // 0x34
	private EventOpcode m_opcode; // 0x38
	private bool m_opcodeSet; // 0x3C

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_EventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_EventId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventLevel get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Level(EventLevel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventKeywords get_Keywords() { }

	public EventOpcode get_Opcode() { }

	public void set_Opcode(EventOpcode value) { }

	internal bool get_IsOpcodeSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventTask get_Task() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Task(EventTask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public byte get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventActivityOptions get_ActivityOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_ActivityOptions(EventActivityOptions value) { }

}

public enum EventCommand // TypeDefIndex: 1613
{	public int value__; // 0x0
	public const EventCommand Update = 0;
	public const EventCommand SendManifest = -1;
	public const EventCommand Enable = -2;
	public const EventCommand Disable = -3;

}

internal class EventDispatcher // TypeDefIndex: 1622
{	internal readonly EventListener m_Listener; // 0x10
	internal bool[] m_EventEnabled; // 0x18
	internal bool m_activityFilteringEnabled; // 0x20
	internal EventDispatcher m_Next; // 0x28


	internal void .ctor(EventDispatcher next, bool[] eventEnabled, EventListener listener) { }

}

public enum EventManifestOptions // TypeDefIndex: 1623
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const EventLevel LogAlways = 0;
	public const EventLevel Critical = 1;
	public const EventLevel Error = 2;
	public const EventLevel Warning = 3;
	public const EventLevel Informational = 4;
	public const EventLevel Verbose = 5;

}

public enum EventTask // TypeDefIndex: 1631
{	public int value__; // 0x0
	public const EventTask None = 0;

}

public enum EventOpcode // TypeDefIndex: 1632
{	public int value__; // 0x0
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
{	public byte value__; // 0x0
	public const EventChannel None = 0;
	public const EventChannel Admin = 16;
	public const EventChannel Operational = 17;
	public const EventChannel Analytic = 18;
	public const EventChannel Debug = 19;

}

public enum EventKeywords // TypeDefIndex: 1634
{	public long value__; // 0x0
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
[DefaultMemberAttribute] // RVA: 0xA9640 Offset: 0xA8A40 VA: 0x1800A9640
[ComVisibleAttribute] // RVA: 0xA9640 Offset: 0xA8A40 VA: 0x1800A9640
public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 2703
	private EventDescriptor[] events; // 0x10
	private string[] namedSort; // 0x18
	private IComparer comparer; // 0x20
	private bool eventsOwned; // 0x28
	private bool needSort; // 0x29
	private int eventCount; // 0x2C
	private bool readOnly; // 0x30
	public static readonly EventDescriptorCollection Empty; // 0x0

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
{	private EventHandlerList.ListEntry head; // 0x10
	private Component parent; // 0x18

	public Delegate Item { get; }


	internal void .ctor(Component parent) { }

	public Delegate get_Item(object key) { }

	public void AddHandler(object key, Delegate value) { }

	public void Dispose() { }

	private EventHandlerList.ListEntry Find(object key) { }

	public void RemoveHandler(object key, Delegate value) { }

}

private sealed class EventHandlerList.ListEntry // TypeDefIndex: 2705
{	internal EventHandlerList.ListEntry next; // 0x10
	internal object key; // 0x18
	internal Delegate handler; // 0x20


	public void .ctor(object key, Delegate handler, EventHandlerList.ListEntry next) { }

}

public sealed class Event // TypeDefIndex: 4025
{
[NativeHeaderAttribute] // RVA: 0xC5A20 Offset: 0xC4E20 VA: 0x1800C5A20
[StaticAccessorAttribute] // RVA: 0xC5A20 Offset: 0xC4E20 VA: 0x1800C5A20
public sealed class Event // TypeDefIndex: 4025
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	[NativePropertyAttribute] // RVA: 0xC6970 Offset: 0xC5D70 VA: 0x1800C6970
	public EventType rawType { get; }
	[NativePropertyAttribute] // RVA: 0xC6AD0 Offset: 0xC5ED0 VA: 0x1800C6AD0
	public Vector2 mousePosition { get; set; }
	[NativePropertyAttribute] // RVA: 0xC6B80 Offset: 0xC5F80 VA: 0x1800C6B80
	public Vector2 delta { get; }
	[NativePropertyAttribute] // RVA: 0xC6BF0 Offset: 0xC5FF0 VA: 0x1800C6BF0
	public PointerType pointerType { get; }
	[NativePropertyAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	public int button { get; }
	[NativePropertyAttribute] // RVA: 0xC6D00 Offset: 0xC6100 VA: 0x1800C6D00
	public EventModifiers modifiers { get; set; }
	[NativePropertyAttribute] // RVA: 0xC6DA0 Offset: 0xC61A0 VA: 0x1800C6DA0
	public float pressure { get; }
	[NativePropertyAttribute] // RVA: 0xC6F00 Offset: 0xC6300 VA: 0x1800C6F00
	public int clickCount { get; }
	[NativePropertyAttribute] // RVA: 0xC7260 Offset: 0xC6660 VA: 0x1800C7260
	public char character { get; set; }
	[NativePropertyAttribute] // RVA: 0xC86F0 Offset: 0xC7AF0 VA: 0x1800C86F0
	public KeyCode keyCode { get; set; }
	[NativePropertyAttribute] // RVA: 0xC87E0 Offset: 0xC7BE0 VA: 0x1800C87E0
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

	[FreeFunctionAttribute] // RVA: 0xC5C00 Offset: 0xC5000 VA: 0x1800C5C00
	public EventType get_type() { }

	[FreeFunctionAttribute] // RVA: 0xC5C80 Offset: 0xC5080 VA: 0x1800C5C80
	public void set_type(EventType value) { }

	[FreeFunctionAttribute] // RVA: 0xC5E60 Offset: 0xC5260 VA: 0x1800C5E60
	public string get_commandName() { }

	[FreeFunctionAttribute] // RVA: 0xC5F00 Offset: 0xC5300 VA: 0x1800C5F00
	public void set_commandName(string value) { }

	[NativeMethodAttribute] // RVA: 0xC5FE0 Offset: 0xC53E0 VA: 0x1800C5FE0
	private void Internal_Use() { }

	[FreeFunctionAttribute] // RVA: 0xC6050 Offset: 0xC5450 VA: 0x1800C6050
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunctionAttribute] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xC6120 Offset: 0xC5520 VA: 0x1800C6120
	private static IntPtr Internal_Copy(IntPtr otherPtr) { }

	[FreeFunctionAttribute] // RVA: 0xC61B0 Offset: 0xC55B0 VA: 0x1800C61B0
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunctionAttribute] // RVA: 0xC6220 Offset: 0xC5620 VA: 0x1800C6220
	[VisibleToOtherModulesAttribute] // RVA: 0xC6220 Offset: 0xC5620 VA: 0x1800C6220
	internal void CopyFromPtr(IntPtr ptr) { }

	public static bool PopEvent(Event outEvent) { }

	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	public void .ctor() { }

	public void .ctor(int displayIndex) { }

	public void .ctor(Event other) { }

	protected override void Finalize() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC64A0 Offset: 0xC58A0 VA: 0x1800C64A0
	internal void CopyFrom(Event e) { }

	public bool get_shift() { }

	public bool get_control() { }

	public bool get_alt() { }

	public bool get_command() { }

	public static Event get_current() { }

	public static void set_current(Event value) { }

	public bool get_isKey() { }

	public bool get_isMouse() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC67D0 Offset: 0xC5BD0 VA: 0x1800C67D0
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
{	public int value__; // 0x0
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
	[ObsoleteAttribute] // RVA: 0xC88B0 Offset: 0xC7CB0 VA: 0x1800C88B0
	[EditorBrowsableAttribute] // RVA: 0xC88B0 Offset: 0xC7CB0 VA: 0x1800C88B0
	public const EventType mouseDown = 0;
	[EditorBrowsableAttribute] // RVA: 0xC8A10 Offset: 0xC7E10 VA: 0x1800C8A10
	[ObsoleteAttribute] // RVA: 0xC8A10 Offset: 0xC7E10 VA: 0x1800C8A10
	public const EventType mouseUp = 1;
	[ObsoleteAttribute] // RVA: 0xC8BA0 Offset: 0xC7FA0 VA: 0x1800C8BA0
	[EditorBrowsableAttribute] // RVA: 0xC8BA0 Offset: 0xC7FA0 VA: 0x1800C8BA0
	public const EventType mouseMove = 2;
	[ObsoleteAttribute] // RVA: 0xC8CF0 Offset: 0xC80F0 VA: 0x1800C8CF0
	[EditorBrowsableAttribute] // RVA: 0xC8CF0 Offset: 0xC80F0 VA: 0x1800C8CF0
	public const EventType mouseDrag = 3;
	[ObsoleteAttribute] // RVA: 0xC8E30 Offset: 0xC8230 VA: 0x1800C8E30
	[EditorBrowsableAttribute] // RVA: 0xC8E30 Offset: 0xC8230 VA: 0x1800C8E30
	public const EventType keyDown = 4;
	[EditorBrowsableAttribute] // RVA: 0xC8FA0 Offset: 0xC83A0 VA: 0x1800C8FA0
	[ObsoleteAttribute] // RVA: 0xC8FA0 Offset: 0xC83A0 VA: 0x1800C8FA0
	public const EventType keyUp = 5;
	[EditorBrowsableAttribute] // RVA: 0xC93A0 Offset: 0xC87A0 VA: 0x1800C93A0
	[ObsoleteAttribute] // RVA: 0xC93A0 Offset: 0xC87A0 VA: 0x1800C93A0
	public const EventType scrollWheel = 6;
	[ObsoleteAttribute] // RVA: 0xC9590 Offset: 0xC8990 VA: 0x1800C9590
	[EditorBrowsableAttribute] // RVA: 0xC9590 Offset: 0xC8990 VA: 0x1800C9590
	public const EventType repaint = 7;
	[EditorBrowsableAttribute] // RVA: 0xC9680 Offset: 0xC8A80 VA: 0x1800C9680
	[ObsoleteAttribute] // RVA: 0xC9680 Offset: 0xC8A80 VA: 0x1800C9680
	public const EventType layout = 8;
	[EditorBrowsableAttribute] // RVA: 0xC97F0 Offset: 0xC8BF0 VA: 0x1800C97F0
	[ObsoleteAttribute] // RVA: 0xC97F0 Offset: 0xC8BF0 VA: 0x1800C97F0
	public const EventType dragUpdated = 9;
	[ObsoleteAttribute] // RVA: 0xC9990 Offset: 0xC8D90 VA: 0x1800C9990
	[EditorBrowsableAttribute] // RVA: 0xC9990 Offset: 0xC8D90 VA: 0x1800C9990
	public const EventType dragPerform = 10;
	[ObsoleteAttribute] // RVA: 0xC9B60 Offset: 0xC8F60 VA: 0x1800C9B60
	[EditorBrowsableAttribute] // RVA: 0xC9B60 Offset: 0xC8F60 VA: 0x1800C9B60
	public const EventType ignore = 11;
	[EditorBrowsableAttribute] // RVA: 0xC9CC0 Offset: 0xC90C0 VA: 0x1800C9CC0
	[ObsoleteAttribute] // RVA: 0xC9CC0 Offset: 0xC90C0 VA: 0x1800C9CC0
	public const EventType used = 12;

}

public enum EventModifiers // TypeDefIndex: 4027
{	public int value__; // 0x0
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
{	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <wantsMouseMove>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x1

	public bool wantsMouseMove { get; }
	public bool wantsMouseEnterLeaveWindow { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_wantsMouseMove() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_wantsMouseEnterLeaveWindow() { }

	public bool WantsEvent(EventType type) { }

}

public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate> // TypeDefIndex: 4582
{	private readonly EventDispatcher m_Dispatcher; // 0x0


	public void .ctor(EventDispatcher d) { }

	public void Dispose() { }

	public bool Equals(EventDispatcherGate other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

public sealed class EventDispatcher // TypeDefIndex: 4583
{	private List<IEventDispatchingStrategy> m_DispatchingStrategies; // 0x10
	private static readonly ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool; // 0x0
	private Queue<EventDispatcher.EventRecord> m_Queue; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly PointerDispatchState <pointerState>k__BackingField; // 0x20
	private uint m_GateCount; // 0x28
	private Stack<EventDispatcher.DispatchContext> m_DispatchContexts; // 0x30
	private bool m_Immediate; // 0x38

	internal PointerDispatchState pointerState { get; }
	private bool dispatchImmediately { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	public EventBase m_Event; // 0x0
	public IPanel m_Panel; // 0x8

}

private struct EventDispatcher.DispatchContext // TypeDefIndex: 4585
{	public uint m_GateCount; // 0x0
	public Queue<EventDispatcher.EventRecord> m_Queue; // 0x8

}

public abstract class EventBase : IDisposable // TypeDefIndex: 4640
{	private static long s_LastTypeId; // 0x0
	private static ulong s_NextEventId; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private long <timestamp>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private ulong <eventId>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private ulong <triggerEventId>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private EventBase.EventPropagation <propagation>k__BackingField; // 0x28
	private PropagationPaths m_Path; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private EventBase.LifeCycleStatus <lifeCycleStatus>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private IEventHandler <leafTarget>k__BackingField; // 0x40
	private IEventHandler m_Target; // 0x48
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly List<IEventHandler> <skipElements>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private PropagationPhase <propagationPhase>k__BackingField; // 0x58
	private IEventHandler m_CurrentTarget; // 0x60
	private Event m_ImguiEvent; // 0x68
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private Vector2 <originalMousePosition>k__BackingField; // 0x70

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_timestamp(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal ulong get_eventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_eventId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_triggerEventId(ulong value) { }

	internal void SetTriggerEventId(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal EventBase.EventPropagation get_propagation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_propagation(EventBase.EventPropagation value) { }

	internal PropagationPaths get_path() { }

	internal void set_path(PropagationPaths value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventBase.LifeCycleStatus get_lifeCycleStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_lifeCycleStatus(EventBase.LifeCycleStatus value) { }

	[ObsoleteAttribute] // RVA: 0x95BD0 Offset: 0x94FD0 VA: 0x180095BD0
	protected virtual void PreDispatch() { }

	protected internal virtual void PreDispatch(IPanel panel) { }

	[ObsoleteAttribute] // RVA: 0x95C90 Offset: 0x95090 VA: 0x180095C90
	protected virtual void PostDispatch() { }

	protected internal virtual void PostDispatch(IPanel panel) { }

	public bool get_bubbles() { }

	public bool get_tricklesDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal IEventHandler get_leafTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_leafTarget(IEventHandler value) { }

	public IEventHandler get_target() { }

	public void set_target(IEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PropagationPhase get_propagationPhase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector2 get_originalMousePosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	public int value__; // 0x0
	public const EventBase.EventPropagation None = 0;
	public const EventBase.EventPropagation Bubbles = 1;
	public const EventBase.EventPropagation TricklesDown = 2;
	public const EventBase.EventPropagation Cancellable = 4;

}

private enum EventBase.LifeCycleStatus // TypeDefIndex: 4642
{	public int value__; // 0x0
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
{	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private CallbackPhase <phase>k__BackingField; // 0x10

	public CallbackPhase phase { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public CallbackPhase get_phase() { }

	public abstract void Invoke(EventBase evt);

}

internal class EventCallbackListPool // TypeDefIndex: 4646
{	private readonly Stack<EventCallbackList> m_Stack; // 0x10


	public EventCallbackList Get(EventCallbackList initializer) { }

	public void Release(EventCallbackList element) { }

	public void .ctor() { }

}

internal class EventCallbackList // TypeDefIndex: 4647
{	private List<EventCallbackFunctorBase> m_List; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private int <trickleDownCallbackCount>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <bubbleUpCallbackCount>k__BackingField; // 0x1C

	public int trickleDownCallbackCount { get; set; }
	public int bubbleUpCallbackCount { get; set; }
	public int Count { get; }
	public EventCallbackFunctorBase Item { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_trickleDownCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_trickleDownCallbackCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_bubbleUpCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_bubbleUpCallbackCount(int value) { }

	public void .ctor() { }

	public void .ctor(EventCallbackList source) { }

	public void AddRange(EventCallbackList list) { }

	public int get_Count() { }

	public EventCallbackFunctorBase get_Item(int i) { }

	public void Clear() { }

}

internal class EventCallbackRegistry // TypeDefIndex: 4648
{	private static readonly EventCallbackListPool s_ListPool; // 0x0
	private EventCallbackList m_Callbacks; // 0x10
	private EventCallbackList m_TemporaryCallbacks; // 0x18
	private int m_IsInvoking; // 0x20


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
{	public int value__; // 0x0
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;

}

public class EventSystem : UIBehaviour // TypeDefIndex: 5071
{	private List<BaseInputModule> m_SystemInputModules; // 0x18
	private BaseInputModule m_CurrentInputModule; // 0x20
	private static List<EventSystem> m_EventSystems; // 0x0
	[SerializeField] // RVA: 0x85C90 Offset: 0x85090 VA: 0x180085C90
	[FormerlySerializedAsAttribute] // RVA: 0x85C90 Offset: 0x85090 VA: 0x180085C90
	private GameObject m_FirstSelected; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_sendNavigationEvents; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_DragThreshold; // 0x34
	private GameObject m_CurrentSelected; // 0x38
	private bool m_HasFocus; // 0x40
	private bool m_SelectionGuard; // 0x41
	private BaseEventData m_DummyData; // 0x48
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8

	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[ObsoleteAttribute] // RVA: 0x85ED0 Offset: 0x852D0 VA: 0x180085ED0
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
{	[FormerlySerializedAsAttribute] // RVA: 0x86160 Offset: 0x85560 VA: 0x180086160
	[SerializeField] // RVA: 0x86160 Offset: 0x85560 VA: 0x180086160
	private List<EventTrigger.Entry> m_Delegates; // 0x18

	[EditorBrowsableAttribute] // RVA: 0x86350 Offset: 0x85750 VA: 0x180086350
	[ObsoleteAttribute] // RVA: 0x86350 Offset: 0x85750 VA: 0x180086350
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
{	public EventTriggerType eventID; // 0x10
	public EventTrigger.TriggerEvent callback; // 0x18


	public void .ctor() { }

}

public enum EventTriggerType // TypeDefIndex: 5075
{	public int value__; // 0x0
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
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void Raise<T>(EventHandler<T> eventHandler, object sender, T eventArgs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1540350 Offset: 0x153F750 VA: 0x181540350
	|-EventHandlerExtensions.Raise<LoadCompletedEventArgs>
	|-EventHandlerExtensions.Raise<LoadProgressEventArgs>
	|-EventHandlerExtensions.Raise<StateChangedEventArgs>
	|-EventHandlerExtensions.Raise<object>
	*/

}

public sealed class EventsCollection : ICollection<MidiEvent>, IEnumerable<MidiEvent>, IEnumerable // TypeDefIndex: 7514
{	internal readonly List<MidiEvent> _events; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsReadOnly>k__BackingField; // 0x18

	public MidiEvent Item { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }


	internal void .ctor() { }

	public MidiEvent get_Item(int index) { }

	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	private readonly Dictionary<byte, Type> _types; // 0x10


	public bool TryGetType(byte statusByte, out Type type) { }

}

internal static class EventReaderFactory // TypeDefIndex: 7553
{	private static readonly IEventReader MetaEventReader; // 0x0
	private static readonly IEventReader ChannelEventReader; // 0x8
	private static readonly IEventReader SysExEventReader; // 0x10
	private static readonly IEventReader SystemRealTimeEventReader; // 0x18
	private static readonly IEventReader SystemCommonEventReader; // 0x20


	internal static IEventReader GetReader(byte statusByte, bool smfOnly) { }

	private static void .cctor() { }

}

public class EventSchedule : BaseMonoBehaviour // TypeDefIndex: 9816
{	[TooltipAttribute] // RVA: 0x999A0 Offset: 0x98DA0 VA: 0x1800999A0
	public float minimumHoursBetween; // 0x18
	[TooltipAttribute] // RVA: 0x99B60 Offset: 0x98F60 VA: 0x180099B60
	public float maxmumHoursBetween; // 0x1C


	public void .ctor() { }

}

