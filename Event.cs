public class EventArgs // TypeDefIndex: 215
{	// Fields
	public static readonly EventArgs Empty; // 0x12F30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10D69D0 Offset: 0x10D5DD0 VA: 0x1810D69D0
	private static void .cctor() { }

}

public sealed class EventHandler : MulticastDelegate // TypeDefIndex: 216
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class EventHandler<TEventArgs> : MulticastDelegate // TypeDefIndex: 217
{	// Methods

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1 Slot: 12
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

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, TEventArgs e, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10
	|-EventHandler<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-EventHandler<object>.EndInvoke
	*/

}

public enum EventAttributes // TypeDefIndex: 524
{	// Fields
	public int value__; // 0x0
	public const EventAttributes None = 0;
	public const EventAttributes SpecialName = 512;
	public const EventAttributes ReservedMask = 1024;
	public const EventAttributes RTSpecialName = 1024;

}

public abstract class EventInfo : MemberInfo, _EventInfo // TypeDefIndex: 565
{	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public virtual Type EventHandlerType { get; }
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x18C3A60 Offset: 0x18C2E60 VA: 0x1818C3A60 Slot: 17
	public virtual Type get_EventHandlerType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: 0x128C380 Offset: 0x128B780 VA: 0x18128C380 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C11E0 Offset: 0x18C05E0 VA: 0x1818C11E0
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x18C1230 Offset: 0x18C0630 VA: 0x1818C1230
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x18C3AE0 Offset: 0x18C2EE0 VA: 0x1818C3AE0
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x18C39A0 Offset: 0x18C2DA0 VA: 0x1818C39A0
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

}

private sealed class EventInfo.AddEventAdapter : MulticastDelegate // TypeDefIndex: 566
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object _this, Delegate dele) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object _this, Delegate dele, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum EventResetMode // TypeDefIndex: 778
{	// Fields
	public int value__; // 0x0
	public const EventResetMode AutoReset = 0;
	public const EventResetMode ManualReset = 1;

}

public class EventWaitHandle : WaitHandle // TypeDefIndex: 779
{	// Methods

	// RVA: 0x148D880 Offset: 0x148CC80 VA: 0x18148D880
	public void .ctor(bool initialState, EventResetMode mode) { }

	// RVA: 0x148D8A0 Offset: 0x148CCA0 VA: 0x18148D8A0
	public void .ctor(bool initialState, EventResetMode mode, string name) { }

	// RVA: 0x148D7A0 Offset: 0x148CBA0 VA: 0x18148D7A0
	public bool Reset() { }

	// RVA: 0x148D810 Offset: 0x148CC10 VA: 0x18148D810
	public bool Set() { }

}

public enum EventFieldTags // TypeDefIndex: 1516
{	// Fields
	public int value__; // 0x0
	public const EventFieldTags None = 0;

}

public class EventFieldAttribute : Attribute // TypeDefIndex: 1517
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventFieldTags <Tags>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventFieldFormat <Format>k__BackingField; // 0x20

	// Properties
	public EventFieldTags Tags { get; }
	internal string Name { get; }
	public EventFieldFormat Format { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public EventFieldFormat get_Format() { }

}

public enum EventFieldFormat // TypeDefIndex: 1518
{	// Fields
	public int value__; // 0x0
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
// Namespace: System.Diagnostics.Tracing
[DefaultMemberAttribute] // RVA: 0x70A90 Offset: 0x6FE90 VA: 0x180070A90
internal class EventPayload : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable // TypeDefIndex: 1520
	// Fields
	private List<string> m_names; // 0x10
	private List<object> m_values; // 0x18

	// Properties
	public ICollection<string> Keys { get; }
	public ICollection<object> Values { get; }
	public object Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(List<string> payloadNames, List<object> payloadValues) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public ICollection<string> get_Keys() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	public ICollection<object> get_Values() { }

	// RVA: 0xD701A0 Offset: 0xD6F5A0 VA: 0x180D701A0 Slot: 4
	public object get_Item(string key) { }

	// RVA: 0xD70390 Offset: 0xD6F790 VA: 0x180D70390 Slot: 5
	public void set_Item(string key, object value) { }

	// RVA: 0xD6FB50 Offset: 0xD6EF50 VA: 0x180D6FB50 Slot: 9
	public void Add(string key, object value) { }

	// RVA: 0xD6FB00 Offset: 0xD6EF00 VA: 0x180D6FB00 Slot: 14
	public void Add(KeyValuePair<string, object> payloadEntry) { }

	// RVA: 0xD6FBA0 Offset: 0xD6EFA0 VA: 0x180D6FBA0 Slot: 15
	public void Clear() { }

	// RVA: 0xD6FD80 Offset: 0xD6F180 VA: 0x180D6FD80 Slot: 16
	public bool Contains(KeyValuePair<string, object> entry) { }

	// RVA: 0xD6FBF0 Offset: 0xD6EFF0 VA: 0x180D6FBF0 Slot: 8
	public bool ContainsKey(string key) { }

	// RVA: 0xD70160 Offset: 0xD6F560 VA: 0x180D70160 Slot: 12
	public int get_Count() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	public bool get_IsReadOnly() { }

	[IteratorStateMachineAttribute] // RVA: 0xF0A10 Offset: 0xEFE10 VA: 0x1800F0A10
	// RVA: 0xD6FE20 Offset: 0xD6F220 VA: 0x180D6FE20 Slot: 19
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator() { }

	// RVA: 0xD6FF30 Offset: 0xD6F330 VA: 0x180D6FF30 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD6FDD0 Offset: 0xD6F1D0 VA: 0x180D6FDD0 Slot: 17
	public void CopyTo(KeyValuePair<string, object>[] payloadEntries, int count) { }

	// RVA: 0xD6FE90 Offset: 0xD6F290 VA: 0x180D6FE90 Slot: 10
	public bool Remove(string key) { }

	// RVA: 0xD6FEE0 Offset: 0xD6F2E0 VA: 0x180D6FEE0 Slot: 18
	public bool Remove(KeyValuePair<string, object> entry) { }

	// RVA: 0xD6FF70 Offset: 0xD6F370 VA: 0x180D6FF70 Slot: 11
	public bool TryGetValue(string key, out object value) { }

}

private sealed class EventPayload.<GetEnumerator>d__17 : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator // TypeDefIndex: 1521
{	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, object> <>2__current; // 0x18
	public EventPayload <>4__this; // 0x28
	private int <i>5__1; // 0x30

	// Properties
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD820D0 Offset: 0xD814D0 VA: 0x180D820D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0C9C0 Offset: 0xB0BDC0 VA: 0x180B0C9C0 Slot: 4
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD82210 Offset: 0xD81610 VA: 0x180D82210 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD82260 Offset: 0xD81660 VA: 0x180D82260 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public struct EventSourceOptions // TypeDefIndex: 1522
{	// Fields
	internal EventKeywords keywords; // 0x0
	internal EventTags tags; // 0x8
	internal EventActivityOptions activityOptions; // 0xC
	internal byte level; // 0x10
	internal byte opcode; // 0x11
	internal byte valuesSet; // 0x12

	// Properties
	public EventLevel Level { set; }
	public EventOpcode Opcode { set; }
	public EventKeywords Keywords { set; }

	// Methods

	// RVA: 0x19F420 Offset: 0x19E820 VA: 0x18019F420
	public void set_Level(EventLevel value) { }

	// RVA: 0x19F480 Offset: 0x19E880 VA: 0x18019F480
	public void set_Opcode(EventOpcode value) { }

	// RVA: 0x19F410 Offset: 0x19E810 VA: 0x18019F410
	public void set_Keywords(EventKeywords value) { }

}

public class EventSource : IDisposable // TypeDefIndex: 1580
{	// Fields
	private byte[] providerMetadata; // 0x10
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

	// Properties
	public string Name { get; }
	public Guid Guid { get; }
	public static Guid CurrentThreadActivityId { get; }
	internal static Guid InternalCurrentThreadActivityId { get; }
	internal static Guid FallbackActivityId { get; }
	private bool IsDisposed { get; }
	private bool ThrowOnEventWriteErrors { get; }
	private bool SelfDescribingEvents { get; }

	// Methods

	// RVA: 0xD7F800 Offset: 0xD7EC00 VA: 0x180D7F800
	private void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, object[] values) { }

	// RVA: 0xD7F2D0 Offset: 0xD7E6D0 VA: 0x180D7F2D0
	private void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, object[] values) { }

	// RVA: 0xD7F890 Offset: 0xD7EC90 VA: 0x180D7F890
	internal void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventSource.EventData* data) { }

	[NonEventAttribute] // RVA: 0x70080 Offset: 0x6F480 VA: 0x180070080
	[ReliabilityContractAttribute] // RVA: 0x70080 Offset: 0x6F480 VA: 0x180070080
	// RVA: 0xD7CA80 Offset: 0xD7BE80 VA: 0x180D7CA80
	private void WriteCleanup(GCHandle* pPins, int cPins) { }

	// RVA: 0xD79C50 Offset: 0xD79050 VA: 0x180D79C50
	private void InitializeProviderMetadata() { }

	// RVA: 0xD73EC0 Offset: 0xD732C0 VA: 0x180D73EC0
	private static int AddValueToMetaData(List<byte> metaData, string value) { }

	// RVA: 0xD79B50 Offset: 0xD78F50 VA: 0x180D79B50
	private static int HexDigit(char c) { }

	// RVA: 0xD7C470 Offset: 0xD7B870 VA: 0x180D7C470
	private NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Name() { }

	// RVA: 0xD80C60 Offset: 0xD80060 VA: 0x180D80C60
	public Guid get_Guid() { }

	// RVA: 0xABA180 Offset: 0xAB9580 VA: 0x180ABA180
	public bool IsEnabled() { }

	// RVA: 0xD7A7E0 Offset: 0xD79BE0 VA: 0x180D7A7E0
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	// RVA: 0xD7A7E0 Offset: 0xD79BE0 VA: 0x180D7A7E0
	public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel) { }

	// RVA: 0xD791D0 Offset: 0xD785D0 VA: 0x180D791D0
	public static Guid GetGuid(Type eventSourceType) { }

	// RVA: 0xD79800 Offset: 0xD78C00 VA: 0x180D79800
	public static string GetName(Type eventSourceType) { }

	// RVA: 0xD7B9B0 Offset: 0xD7ADB0 VA: 0x180D7B9B0
	public static void SetCurrentThreadActivityId(Guid activityId) { }

	// RVA: 0xD80B70 Offset: 0xD7FF70 VA: 0x180D80B70
	public static Guid get_CurrentThreadActivityId() { }

	// RVA: 0xD80C70 Offset: 0xD80070 VA: 0x180D80C70
	internal static Guid get_InternalCurrentThreadActivityId() { }

	// RVA: 0xD80BA0 Offset: 0xD7FFA0 VA: 0x180D80BA0
	internal static Guid get_FallbackActivityId() { }

	// RVA: 0xD7C270 Offset: 0xD7B670 VA: 0x180D7C270 Slot: 3
	public override string ToString() { }

	// RVA: 0xD80770 Offset: 0xD7FB70 VA: 0x180D80770
	protected void .ctor() { }

	// RVA: 0xD80880 Offset: 0xD7FC80 VA: 0x180D80880
	protected void .ctor(EventSourceSettings settings) { }

	// RVA: 0xD809F0 Offset: 0xD7FDF0 VA: 0x180D809F0
	protected void .ctor(EventSourceSettings settings, string[] traits) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected virtual void OnEventCommand(EventCommandEventArgs command) { }

	// RVA: 0xD7EEE0 Offset: 0xD7E2E0 VA: 0x180D7EEE0
	protected void WriteEvent(int eventId, int arg1) { }

	// RVA: 0xD7EDF0 Offset: 0xD7E1F0 VA: 0x180D7EDF0
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	// RVA: 0xD7ED40 Offset: 0xD7E140 VA: 0x180D7ED40
	protected void WriteEvent(int eventId, long arg1) { }

	// RVA: 0xD7F0A0 Offset: 0xD7E4A0 VA: 0x180D7F0A0
	protected void WriteEvent(int eventId, string arg1) { }

	// RVA: 0xD7F180 Offset: 0xD7E580 VA: 0x180D7F180
	protected void WriteEvent(int eventId, string arg1, string arg2) { }

	// RVA: 0xD7EBB0 Offset: 0xD7DFB0 VA: 0x180D7EBB0
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	// RVA: 0xD7EF90 Offset: 0xD7E390 VA: 0x180D7EF90
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xD7CB30 Offset: 0xD7BF30 VA: 0x180D7CB30
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xD7DED0 Offset: 0xD7D2D0 VA: 0x180D7DED0
	protected void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventSource.EventData* data) { }

	// RVA: 0xD7EB90 Offset: 0xD7DF90 VA: 0x180D7EB90
	protected void WriteEvent(int eventId, object[] args) { }

	// RVA: 0xD770B0 Offset: 0xD764B0 VA: 0x180D770B0 Slot: 4
	public void Dispose() { }

	// RVA: 0xD77120 Offset: 0xD76520 VA: 0x180D77120 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD782B0 Offset: 0xD776B0 VA: 0x180D782B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xD7FFA0 Offset: 0xD7F3A0 VA: 0x180D7FFA0
	internal void WriteStringToListener(EventListener listener, string msg, SessionMask m) { }

	// RVA: 0xD7CB60 Offset: 0xD7BF60 VA: 0x180D7CB60
	private void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD7A110 Offset: 0xD79510 VA: 0x180D7A110
	private void Initialize(Guid eventSourceGuid, string eventSourceName, string[] traits) { }

	// RVA: 0xD79860 Offset: 0xD78C60 VA: 0x180D79860
	private static string GetName(Type eventSourceType, EventManifestOptions flags) { }

	// RVA: 0xD78350 Offset: 0xD77750 VA: 0x180D78350
	private static Guid GenerateGuidFromName(string name) { }

	// RVA: 0xD765B0 Offset: 0xD759B0 VA: 0x180D765B0
	private object DecodeObject(int eventId, int parameterId, ref EventSource.EventData* data) { }

	// RVA: 0xD78C70 Offset: 0xD78070 VA: 0x180D78C70
	private EventDispatcher GetDispatcher(EventListener listener) { }

	// RVA: 0xD7D0D0 Offset: 0xD7C4D0 VA: 0x180D7D0D0
	private void WriteEventVarargs(int eventId, Guid* childActivityID, object[] args) { }

	// RVA: 0xD7B730 Offset: 0xD7AB30 VA: 0x180D7B730
	private object[] SerializeEventArgs(int eventId, object[] args) { }

	// RVA: 0xD7A810 Offset: 0xD79C10 VA: 0x180D7A810
	private void LogEventArgsMismatches(ParameterInfo[] infos, object[] args) { }

	// RVA: 0xD79A50 Offset: 0xD78E50 VA: 0x180D79A50
	private int GetParamLengthIncludingByteArray(ParameterInfo[] parameters) { }

	// RVA: 0xD80260 Offset: 0xD7F660 VA: 0x180D80260
	private void WriteToAllListeners(int eventId, Guid* childActivityID, int eventDataCount, EventSource.EventData* data) { }

	// RVA: 0xD800F0 Offset: 0xD7F4F0 VA: 0x180D800F0
	private void WriteToAllListeners(int eventId, Guid* childActivityID, object[] args) { }

	// RVA: 0xD76EA0 Offset: 0xD762A0 VA: 0x180D76EA0
	private void DispatchToAllListeners(int eventId, Guid* childActivityID, EventWrittenEventArgs eventCallbackArgs) { }

	// RVA: 0xD7CC60 Offset: 0xD7C060 VA: 0x180D7CC60
	private void WriteEventString(EventLevel level, long keywords, string msgString) { }

	// RVA: 0xD7FD80 Offset: 0xD7F180 VA: 0x180D7FD80
	private void WriteStringToAllListeners(string eventName, string msg) { }

	// RVA: 0xD78CB0 Offset: 0xD780B0 VA: 0x180D78CB0
	private SessionMask GetEtwSessionMask(int eventId, Guid* childActivityID) { }

	// RVA: 0xD7A6B0 Offset: 0xD79AB0 VA: 0x180D7A6B0
	private bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword) { }

	// RVA: 0xD7A7B0 Offset: 0xD79BB0 VA: 0x180D7A7B0
	private bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel) { }

	// RVA: 0xD7BBC0 Offset: 0xD7AFC0 VA: 0x180D7BBC0
	private void ThrowEventSourceException(string eventName, Exception innerEx) { }

	// RVA: 0xD7C9C0 Offset: 0xD7BDC0 VA: 0x180D7C9C0
	private void ValidateEventOpcodeForTransfer(ref EventSource.EventMetadata eventData, string eventName) { }

	// RVA: 0xD799C0 Offset: 0xD78DC0 VA: 0x180D799C0
	internal static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName) { }

	// RVA: 0xD7B2C0 Offset: 0xD7A6C0 VA: 0x180D7B2C0
	internal void SendCommand(EventListener listener, int perEventSourceSessionId, int etwSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> commandArguments) { }

	// RVA: 0xD77250 Offset: 0xD76650 VA: 0x180D77250
	internal void DoCommand(EventCommandEventArgs commandArgs) { }

	// RVA: 0xD7C5B0 Offset: 0xD7B9B0 VA: 0x180D7C5B0
	internal void UpdateEtwSession(int sessionIdBit, int etwSessionId, bool bEnable, string activityFilters, bool participateInSampling) { }

	// RVA: 0xD7AA50 Offset: 0xD79E50 VA: 0x180D7AA50
	internal static bool ParseCommandArgs(IDictionary<string, string> commandArguments, out bool participateInSampling, out string activityFilters, out int sessionIdBit) { }

	// RVA: 0xD7C8F0 Offset: 0xD7BCF0 VA: 0x180D7C8F0
	internal void UpdateKwdTriggers(bool enable) { }

	// RVA: 0xD77DB0 Offset: 0xD771B0 VA: 0x180D77DB0
	internal bool EnableEventForDispatcher(EventDispatcher dispatcher, int eventId, bool value) { }

	// RVA: 0xD74170 Offset: 0xD73570 VA: 0x180D74170
	private bool AnyEventEnabled() { }

	// RVA: 0xD80D70 Offset: 0xD80170 VA: 0x180D80D70
	private bool get_IsDisposed() { }

	// RVA: 0xD77EB0 Offset: 0xD772B0 VA: 0x180D77EB0
	private void EnsureDescriptorsInitialized() { }

	// RVA: 0xD7B4D0 Offset: 0xD7A8D0 VA: 0x180D7B4D0
	private bool SendManifest(byte[] rawManifest) { }

	// RVA: 0xD784A0 Offset: 0xD778A0 VA: 0x180D784A0
	internal static Attribute GetCustomAttributeHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = 0) { }

	// RVA: 0xD74240 Offset: 0xD73640 VA: 0x180D74240
	private static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType) { }

	// RVA: 0xD78FB0 Offset: 0xD783B0 VA: 0x180D78FB0
	private static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly) { }

	// RVA: 0xD743D0 Offset: 0xD737D0 VA: 0x180D743D0
	private static byte[] CreateManifestAndDescriptors(Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = 0) { }

	// RVA: 0xD7AC50 Offset: 0xD7A050 VA: 0x180D7AC50
	private static bool RemoveFirstArgIfRelatedActivityId(ref ParameterInfo[] args) { }

	// RVA: 0xD738B0 Offset: 0xD72CB0 VA: 0x180D738B0
	private static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind) { }

	// RVA: 0xD73370 Offset: 0xD72770 VA: 0x180D73370
	private static void AddEventDescriptor(ref EventSource.EventMetadata[] eventData, string eventName, EventAttribute eventAttribute, ParameterInfo[] eventParameters, bool hasRelatedActivityID) { }

	// RVA: 0xD7C3B0 Offset: 0xD7B7B0 VA: 0x180D7C3B0
	private static void TrimEventDescriptors(ref EventSource.EventMetadata[] eventData) { }

	// RVA: 0xD736E0 Offset: 0xD72AE0 VA: 0x180D736E0
	internal void AddListener(EventListener listener) { }

	// RVA: 0xD75CB0 Offset: 0xD750B0 VA: 0x180D75CB0
	private static void DebugCheckEvent(ref Dictionary<string, string> eventsByName, EventSource.EventMetadata[] eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options) { }

	// RVA: 0xD79550 Offset: 0xD78950 VA: 0x180D79550
	private static int GetHelperCallFirstArg(MethodInfo method) { }

	// RVA: 0xD7B1D0 Offset: 0xD7A5D0 VA: 0x180D7B1D0
	internal void ReportOutOfBandMessage(string msg, bool flush) { }

	// RVA: 0xD7C9F0 Offset: 0xD7BDF0 VA: 0x180D7C9F0
	private EventSourceSettings ValidateSettings(EventSourceSettings settings) { }

	// RVA: 0xD80DD0 Offset: 0xD801D0 VA: 0x180D80DD0
	private bool get_ThrowOnEventWriteErrors() { }

	// RVA: 0xD80DC0 Offset: 0xD801C0 VA: 0x180D80DC0
	private bool get_SelfDescribingEvents() { }

	// RVA: 0xD7ADF0 Offset: 0xD7A1F0 VA: 0x180D7ADF0
	private void ReportActivitySamplingInfo(EventListener listener, SessionMask sessions) { }

	// RVA: 0xD806C0 Offset: 0xD7FAC0 VA: 0x180D806C0
	private static void .cctor() { }

}

private struct EventSource.Sha1ForNonSecretPurposes // TypeDefIndex: 1582
{	// Fields
	private long length; // 0x0
	private uint[] w; // 0x8
	private int pos; // 0x10

	// Methods

	// RVA: 0x19F660 Offset: 0x19EA60 VA: 0x18019F660
	public void Start() { }

	// RVA: 0x19F570 Offset: 0x19E970 VA: 0x18019F570
	public void Append(byte input) { }

	// RVA: 0x19F580 Offset: 0x19E980 VA: 0x18019F580
	public void Append(byte[] input) { }

	// RVA: 0x19F650 Offset: 0x19EA50 VA: 0x18019F650
	public void Finish(byte[] output) { }

	// RVA: 0x19F640 Offset: 0x19EA40 VA: 0x18019F640
	private void Drain() { }

	// RVA: 0x10E0550 Offset: 0x10DF950 VA: 0x1810E0550
	private static uint Rol1(uint input) { }

	// RVA: 0x10E0570 Offset: 0x10DF970 VA: 0x1810E0570
	private static uint Rol5(uint input) { }

	// RVA: 0x10E0560 Offset: 0x10DF960 VA: 0x1810E0560
	private static uint Rol30(uint input) { }

}

private class EventSource.OverideEventProvider : EventProvider // TypeDefIndex: 1583
{	// Fields
	private EventSource m_eventSource; // 0x60

	// Methods

	// RVA: 0x10DF6B0 Offset: 0x10DEAB0 VA: 0x1810DF6B0
	public void .ctor(EventSource eventSource) { }

	// RVA: 0x10DF650 Offset: 0x10DEA50 VA: 0x1810DF650 Slot: 6
	protected override void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int perEventSourceSessionId, int etwSessionId) { }

}

internal struct EventSource.EventMetadata // TypeDefIndex: 1584
{	// Fields
	public EventDescriptor Descriptor; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const EventTags None = 0;

}

public enum EventActivityOptions // TypeDefIndex: 1596
{	// Fields
	public int value__; // 0x0
	public const EventActivityOptions None = 0;
	public const EventActivityOptions Disable = 2;
	public const EventActivityOptions Recursive = 4;
	public const EventActivityOptions Detachable = 8;

}

internal struct EventDescriptor // TypeDefIndex: 1597
{	// Fields
	private int m_traceloggingId; // 0x0
	private ushort m_id; // 0x0
	private byte m_version; // 0x2
	private byte m_channel; // 0x3
	private byte m_level; // 0x4
	private byte m_opcode; // 0x5
	private ushort m_task; // 0x6
	private long m_keywords; // 0x8

	// Properties
	public int EventId { get; }
	public byte Version { get; }
	public byte Channel { get; }
	public byte Level { get; }
	public byte Opcode { get; }
	public int Task { get; }
	public long Keywords { get; }

	// Methods

	// RVA: 0x120EB0 Offset: 0x1202B0 VA: 0x180120EB0
	public void .ctor(int traceloggingId, byte level, byte opcode, long keywords) { }

	// RVA: 0x120EE0 Offset: 0x1202E0 VA: 0x180120EE0
	public void .ctor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords) { }

	// RVA: 0x120F10 Offset: 0x120310 VA: 0x180120F10
	public int get_EventId() { }

	// RVA: 0x120F50 Offset: 0x120350 VA: 0x180120F50
	public byte get_Version() { }

	// RVA: 0x120F00 Offset: 0x120300 VA: 0x180120F00
	public byte get_Channel() { }

	// RVA: 0x120F20 Offset: 0x120320 VA: 0x180120F20
	public byte get_Level() { }

	// RVA: 0x120F30 Offset: 0x120330 VA: 0x180120F30
	public byte get_Opcode() { }

	// RVA: 0x120F40 Offset: 0x120340 VA: 0x180120F40
	public int get_Task() { }

	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public long get_Keywords() { }

	// RVA: 0x120DA0 Offset: 0x1201A0 VA: 0x180120DA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x120E80 Offset: 0x120280 VA: 0x180120E80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x120D40 Offset: 0x120140 VA: 0x180120D40
	public bool Equals(EventDescriptor other) { }

}

internal class EventProvider : IDisposable // TypeDefIndex: 1599
{	// Fields
	private static bool m_setInformationMissing; // 0x0
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

	// Properties
	protected EventLevel Level { get; }
	protected EventKeywords MatchAnyKeyword { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0xD72260 Offset: 0xD71660 VA: 0x180D72260
	internal void Register(Guid providerGuid) { }

	// RVA: 0xD723A0 Offset: 0xD717A0 VA: 0x180D723A0
	internal int SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS eventInfoClass, void* data, int dataSize) { }

	// RVA: 0xD70550 Offset: 0xD6F950 VA: 0x180D70550 Slot: 4
	public void Dispose() { }

	// RVA: 0xD70420 Offset: 0xD6F820 VA: 0x180D70420 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xD703E0 Offset: 0xD6F7E0 VA: 0x180D703E0
	private void Deregister() { }

	[EventProvider.MonoPInvokeCallbackAttribute] // RVA: 0x70E00 Offset: 0x70200 VA: 0x180070E00
	// RVA: 0xD71680 Offset: 0xD70A80 VA: 0x180D71680
	private static void EtwEnableCallBack(in Guid sourceId, [In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

	// RVA: 0xD71120 Offset: 0xD70520 VA: 0x180D71120
	private void EtwEnableCallBackImpl([In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	protected virtual void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int sessionId, int etwSessionId) { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	protected EventLevel get_Level() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	protected EventKeywords get_MatchAnyKeyword() { }

	// RVA: 0xD717D0 Offset: 0xD70BD0 VA: 0x180D717D0
	private static int FindNull(byte[] buffer, int idx) { }

	// RVA: 0xD71CD0 Offset: 0xD710D0 VA: 0x180D71CD0
	private List<Tuple<EventProvider.SessionInfo, bool>> GetSessions() { }

	// RVA: 0xD719D0 Offset: 0xD70DD0 VA: 0x180D719D0
	private static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<EventProvider.SessionInfo> sessionList) { }

	// RVA: 0xD71B60 Offset: 0xD70F60 VA: 0x180D71B60
	private void GetSessionInfo(Action<int, long> action) { }

	// RVA: 0xD72190 Offset: 0xD71590 VA: 0x180D72190
	private static int IndexOfSessionInList(List<EventProvider.SessionInfo> sessions, int etwSessionId) { }

	// RVA: 0xD71820 Offset: 0xD70C20 VA: 0x180D71820
	private bool GetDataFromController(int etwSessionId, UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out byte[] data, out int dataStart) { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	public bool IsEnabled() { }

	// RVA: 0xD72220 Offset: 0xD71620 VA: 0x180D72220
	public bool IsEnabled(byte level, long keywords) { }

	// RVA: 0xD71930 Offset: 0xD70D30 VA: 0x180D71930
	public static EventProvider.WriteEventErrorCode GetLastWriteEventError() { }

	// RVA: 0xD724A0 Offset: 0xD718A0 VA: 0x180D724A0
	private static void SetLastError(int error) { }

	// RVA: 0xD705C0 Offset: 0xD6F9C0 VA: 0x180D705C0
	private static object EncodeObject(ref object data, ref EventProvider.EventData* dataDescriptor, ref byte* dataBuffer, ref uint totalEventSize) { }

	// RVA: 0xD726D0 Offset: 0xD71AD0 VA: 0x180D726D0
	internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, object[] eventPayload) { }

	// RVA: 0xD72610 Offset: 0xD71A10 VA: 0x180D72610
	protected internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD72550 Offset: 0xD71950 VA: 0x180D72550
	internal bool WriteEventRaw(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	// RVA: 0xD717A0 Offset: 0xD70BA0 VA: 0x180D717A0
	private uint EventUnregister() { }

	// RVA: 0xD732B0 Offset: 0xD726B0 VA: 0x180D732B0
	private static int bitcount(uint n) { }

	// RVA: 0xD73350 Offset: 0xD72750 VA: 0x180D73350
	private static int bitindex(uint n) { }

	// RVA: 0xD73240 Offset: 0xD72640 VA: 0x180D73240
	private static void .cctor() { }

}

public struct EventProvider.EventData // TypeDefIndex: 1600
{	// Fields
	internal ulong Ptr; // 0x0
	internal uint Size; // 0x8
	internal uint Reserved; // 0xC

}

public struct EventProvider.SessionInfo // TypeDefIndex: 1601
{	// Fields
	internal int sessionIdBit; // 0x0
	internal int etwSessionId; // 0x4

	// Methods

	// RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
	internal void .ctor(int sessionIdBit_, int etwSessionId_) { }

}

public enum EventProvider.WriteEventErrorCode // TypeDefIndex: 1602
{	// Fields
	public int value__; // 0x0
	public const EventProvider.WriteEventErrorCode NoError = 0;
	public const EventProvider.WriteEventErrorCode NoFreeBuffers = 1;
	public const EventProvider.WriteEventErrorCode EventTooBig = 2;
	public const EventProvider.WriteEventErrorCode NullInput = 3;
	public const EventProvider.WriteEventErrorCode TooManyArgs = 4;
	public const EventProvider.WriteEventErrorCode Other = 5;

}

private sealed class EventProvider.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 1603
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor(Type t) { }

}

private sealed class EventProvider.<>c__DisplayClass44_0 // TypeDefIndex: 1604
{	// Fields
	public List<EventProvider.SessionInfo> liveSessionList; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xD82780 Offset: 0xD81B80 VA: 0x180D82780
	internal void <GetSessions>b__0(int etwSessionId, long matchAllKeywords) { }

}

public enum EventSourceSettings // TypeDefIndex: 1605
{	// Fields
	public int value__; // 0x0
	public const EventSourceSettings Default = 0;
	public const EventSourceSettings ThrowOnEventWriteErrors = 1;
	public const EventSourceSettings EtwManifestEventFormat = 4;
	public const EventSourceSettings EtwSelfDescribingEventFormat = 8;

}

public class EventListener // TypeDefIndex: 1606
{	// Fields
	private static readonly object s_EventSourceCreatedLock; // 0x0
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

	// Properties
	internal static object EventListenersLock { get; }

	// Methods

	// RVA: 0xD6F880 Offset: 0xD6EC80 VA: 0x180D6F880 Slot: 4
	protected internal virtual void OnEventSourceCreated(EventSource eventSource) { }

	// RVA: 0xD6F920 Offset: 0xD6ED20 VA: 0x180D6F920 Slot: 5
	protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData) { }

	// RVA: 0xD6F1B0 Offset: 0xD6E5B0 VA: 0x180D6F1B0
	internal static void AddEventSource(EventSource newEventSource) { }

	// RVA: 0xD6F640 Offset: 0xD6EA40 VA: 0x180D6F640
	private static void DisposeOnShutdown(object sender, EventArgs e) { }

	// RVA: 0xD6FA00 Offset: 0xD6EE00 VA: 0x180D6FA00
	internal static object get_EventListenersLock() { }

	// RVA: 0xD6F980 Offset: 0xD6ED80 VA: 0x180D6F980
	private static void .cctor() { }

}

public class EventCommandEventArgs : EventArgs // TypeDefIndex: 1607
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	public EventCommand Command { get; set; }
	public IDictionary<string, string> Arguments { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public EventCommand get_Command() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	internal void set_Command(EventCommand value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public IDictionary<string, string> get_Arguments() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_Arguments(IDictionary<string, string> value) { }

	// RVA: 0xD6ED90 Offset: 0xD6E190 VA: 0x180D6ED90
	internal void .ctor(EventCommand command, IDictionary<string, string> arguments, EventSource eventSource, EventListener listener, int perEventSourceSessionId, int etwSessionId, bool enable, EventLevel level, EventKeywords matchAnyKeyword) { }

}

public class EventSourceCreatedEventArgs : EventArgs // TypeDefIndex: 1608
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventSource <EventSource>k__BackingField; // 0x10

	// Properties
	internal EventSource EventSource { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_EventSource(EventSource value) { }

	// RVA: 0x10D6AF0 Offset: 0x10D5EF0 VA: 0x1810D6AF0
	public void .ctor() { }

}

public class EventWrittenEventArgs : EventArgs // TypeDefIndex: 1609
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <EventId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Guid <RelatedActivityId>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ReadOnlyCollection<object> <Payload>k__BackingField; // 0x28
	private string m_message; // 0x30
	private string m_eventName; // 0x38
	private EventSource m_eventSource; // 0x40
	private ReadOnlyCollection<string> m_payloadNames; // 0x48

	// Properties
	internal string EventName { set; }
	internal int EventId { set; }
	internal Guid RelatedActivityId { set; }
	internal ReadOnlyCollection<object> Payload { set; }
	internal ReadOnlyCollection<string> PayloadNames { set; }
	internal string Message { set; }

	// Methods

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void set_EventName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	internal void set_EventId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10D6ED0 Offset: 0x10D62D0 VA: 0x1810D6ED0
	internal void set_RelatedActivityId(Guid value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	internal void set_Payload(ReadOnlyCollection<object> value) { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	internal void set_PayloadNames(ReadOnlyCollection<string> value) { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_Message(string value) { }

	// RVA: 0x10D6E60 Offset: 0x10D6260 VA: 0x1810D6E60
	internal void .ctor(EventSource eventSource) { }

}

public sealed class EventSourceAttribute : Attribute // TypeDefIndex: 1610
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Guid>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <LocalizationResources>k__BackingField; // 0x20

	// Properties
	public string Name { get; set; }
	public string Guid { get; set; }
	public string LocalizationResources { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Guid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Guid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_LocalizationResources() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public sealed class EventAttribute : Attribute // TypeDefIndex: 1611
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	// RVA: 0xD6ED40 Offset: 0xD6E140 VA: 0x180D6ED40
	public void .ctor(int eventId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_EventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	private void set_EventId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public EventLevel get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596250 Offset: 0x595650 VA: 0x180596250
	public void set_Level(EventLevel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public EventKeywords get_Keywords() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public EventOpcode get_Opcode() { }

	// RVA: 0xD6ED80 Offset: 0xD6E180 VA: 0x180D6ED80
	public void set_Opcode(EventOpcode value) { }

	// RVA: 0xC45090 Offset: 0xC44490 VA: 0x180C45090
	internal bool get_IsOpcodeSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public EventTask get_Task() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	public void set_Task(EventTask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7723F0 Offset: 0x7717F0 VA: 0x1807723F0
	public byte get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public EventTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public EventActivityOptions get_ActivityOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD6ED70 Offset: 0xD6E170 VA: 0x180D6ED70
	public void set_ActivityOptions(EventActivityOptions value) { }

}

public enum EventCommand // TypeDefIndex: 1613
{	// Fields
	public int value__; // 0x0
	public const EventCommand Update = 0;
	public const EventCommand SendManifest = -1;
	public const EventCommand Enable = -2;
	public const EventCommand Disable = -3;

}

internal class EventDispatcher // TypeDefIndex: 1622
{	// Fields
	internal readonly EventListener m_Listener; // 0x10
	internal bool[] m_EventEnabled; // 0x18
	internal bool m_activityFilteringEnabled; // 0x20
	internal EventDispatcher m_Next; // 0x28

	// Methods

	// RVA: 0xD6F140 Offset: 0xD6E540 VA: 0x180D6F140
	internal void .ctor(EventDispatcher next, bool[] eventEnabled, EventListener listener) { }

}

public enum EventManifestOptions // TypeDefIndex: 1623
{	// Fields
	public int value__; // 0x0
	public const EventManifestOptions None = 0;
	public const EventManifestOptions Strict = 1;
	public const EventManifestOptions AllCultures = 2;
	public const EventManifestOptions OnlyIfNeededForRegistration = 4;
	public const EventManifestOptions AllowEventSourceOverride = 8;

}

public class EventSourceException : Exception // TypeDefIndex: 1629
{	// Methods

	// RVA: 0x10D6D10 Offset: 0x10D6110 VA: 0x1810D6D10
	public void .ctor() { }

	// RVA: 0x10D6C70 Offset: 0x10D6070 VA: 0x1810D6C70
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10D6BF0 Offset: 0x10D5FF0 VA: 0x1810D6BF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10D6B50 Offset: 0x10D5F50 VA: 0x1810D6B50
	internal void .ctor(Exception innerException) { }

}

public enum EventLevel // TypeDefIndex: 1630
{	// Fields
	public int value__; // 0x0
	public const EventLevel LogAlways = 0;
	public const EventLevel Critical = 1;
	public const EventLevel Error = 2;
	public const EventLevel Warning = 3;
	public const EventLevel Informational = 4;
	public const EventLevel Verbose = 5;

}

public enum EventTask // TypeDefIndex: 1631
{	// Fields
	public int value__; // 0x0
	public const EventTask None = 0;

}

public enum EventOpcode // TypeDefIndex: 1632
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public byte value__; // 0x0
	public const EventChannel None = 0;
	public const EventChannel Admin = 16;
	public const EventChannel Operational = 17;
	public const EventChannel Analytic = 18;
	public const EventChannel Debug = 19;

}

public enum EventKeywords // TypeDefIndex: 1634
{	// Fields
	public long value__; // 0x0
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
// Namespace: System.ComponentModel
[DefaultMemberAttribute] // RVA: 0xA9640 Offset: 0xA8A40 VA: 0x1800A9640
[ComVisibleAttribute] // RVA: 0xA9640 Offset: 0xA8A40 VA: 0x1800A9640
public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 2703
	// Fields
	private EventDescriptor[] events; // 0x10
	private string[] namedSort; // 0x18
	private IComparer comparer; // 0x20
	private bool eventsOwned; // 0x28
	private bool needSort; // 0x29
	private int eventCount; // 0x2C
	private bool readOnly; // 0x30
	public static readonly EventDescriptorCollection Empty; // 0x0

	// Properties
	public int Count { get; }
	public virtual EventDescriptor Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: 0x159FA40 Offset: 0x159EE40 VA: 0x18159FA40
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x159FAE0 Offset: 0x159EEE0 VA: 0x18159FAE0
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public int get_Count() { }

	// RVA: 0x159FB90 Offset: 0x159EF90 VA: 0x18159FB90 Slot: 19
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x159E4D0 Offset: 0x159D8D0 VA: 0x18159E4D0
	public int Add(EventDescriptor value) { }

	// RVA: 0x159E5D0 Offset: 0x159D9D0 VA: 0x18159E5D0
	public void Clear() { }

	// RVA: 0x159E630 Offset: 0x159DA30 VA: 0x18159E630
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x159F0C0 Offset: 0x159E4C0 VA: 0x18159F0C0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x159E690 Offset: 0x159DA90 VA: 0x18159E690
	private void EnsureEventsOwned() { }

	// RVA: 0x159E740 Offset: 0x159DB40 VA: 0x18159E740
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x159E910 Offset: 0x159DD10 VA: 0x18159E910
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x159E970 Offset: 0x159DD70 VA: 0x18159E970
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x159F000 Offset: 0x159E400 VA: 0x18159F000
	public void Remove(EventDescriptor value) { }

	// RVA: 0x159EF20 Offset: 0x159E320 VA: 0x18159EF20
	public void RemoveAt(int index) { }

	// RVA: 0x159E860 Offset: 0x159DC60 VA: 0x18159E860
	public IEnumerator GetEnumerator() { }

	// RVA: 0x159EB10 Offset: 0x159DF10 VA: 0x18159EB10
	protected void InternalSort(string[] names) { }

	// RVA: 0x159EA90 Offset: 0x159DE90 VA: 0x18159EA90
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x159F110 Offset: 0x159E510 VA: 0x18159F110 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x159F7A0 Offset: 0x159EBA0 VA: 0x18159F7A0 Slot: 8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x159F7C0 Offset: 0x159EBC0 VA: 0x18159F7C0 Slot: 9
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x159F1C0 Offset: 0x159E5C0 VA: 0x18159F1C0 Slot: 10
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x159E5D0 Offset: 0x159D9D0 VA: 0x18159E5D0 Slot: 12
	private void System.Collections.IList.Clear() { }

	// RVA: 0x159F330 Offset: 0x159E730 VA: 0x18159F330 Slot: 11
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x159F400 Offset: 0x159E800 VA: 0x18159F400 Slot: 15
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x159F4D0 Offset: 0x159E8D0 VA: 0x18159F4D0 Slot: 16
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x159F670 Offset: 0x159EA70 VA: 0x18159F670 Slot: 17
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x159F660 Offset: 0x159EA60 VA: 0x18159F660 Slot: 18
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0 Slot: 13
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0 Slot: 14
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x159F980 Offset: 0x159ED80 VA: 0x18159F980
	private static void .cctor() { }

}

public sealed class EventHandlerList : IDisposable // TypeDefIndex: 2704
{	// Fields
	private EventHandlerList.ListEntry head; // 0x10
	private Component parent; // 0x18

	// Properties
	public Delegate Item { get; }

	// Methods

	// RVA: 0x10B06F0 Offset: 0x10AFAF0 VA: 0x1810B06F0
	internal void .ctor(Component parent) { }

	// RVA: 0x159FDA0 Offset: 0x159F1A0 VA: 0x18159FDA0
	public Delegate get_Item(object key) { }

	// RVA: 0x159FC30 Offset: 0x159F030 VA: 0x18159FC30
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0xE31A20 Offset: 0xE30E20 VA: 0x180E31A20 Slot: 4
	public void Dispose() { }

	// RVA: 0x159FD20 Offset: 0x159F120 VA: 0x18159FD20
	private EventHandlerList.ListEntry Find(object key) { }

	// RVA: 0x159FD40 Offset: 0x159F140 VA: 0x18159FD40
	public void RemoveHandler(object key, Delegate value) { }

}

private sealed class EventHandlerList.ListEntry // TypeDefIndex: 2705
{	// Fields
	internal EventHandlerList.ListEntry next; // 0x10
	internal object key; // 0x18
	internal Delegate handler; // 0x20

	// Methods

	// RVA: 0x15A3BF0 Offset: 0x15A2FF0 VA: 0x1815A3BF0
	public void .ctor(object key, Delegate handler, EventHandlerList.ListEntry next) { }

}

public sealed class Event // TypeDefIndex: 4025
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xC5A20 Offset: 0xC4E20 VA: 0x1800C5A20
[StaticAccessorAttribute] // RVA: 0xC5A20 Offset: 0xC4E20 VA: 0x1800C5A20
public sealed class Event // TypeDefIndex: 4025
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
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

	// Methods

	// RVA: 0x1A5C940 Offset: 0x1A5BD40 VA: 0x181A5C940
	public EventType get_rawType() { }

	// RVA: 0x1A5C870 Offset: 0x1A5BC70 VA: 0x181A5C870
	public Vector2 get_mousePosition() { }

	// RVA: 0x1A5CC50 Offset: 0x1A5C050 VA: 0x181A5CC50
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x1A5C5F0 Offset: 0x1A5B9F0 VA: 0x181A5C5F0
	public Vector2 get_delta() { }

	// RVA: 0x1A5C8C0 Offset: 0x1A5BCC0 VA: 0x181A5C8C0
	public PointerType get_pointerType() { }

	// RVA: 0x1A5C3E0 Offset: 0x1A5B7E0 VA: 0x181A5C3E0
	public int get_button() { }

	// RVA: 0x1A5C7E0 Offset: 0x1A5BBE0 VA: 0x181A5C7E0
	public EventModifiers get_modifiers() { }

	// RVA: 0x1A5CBC0 Offset: 0x1A5BFC0 VA: 0x181A5CBC0
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x1A5C900 Offset: 0x1A5BD00 VA: 0x181A5C900
	public float get_pressure() { }

	// RVA: 0x1A5C460 Offset: 0x1A5B860 VA: 0x181A5C460
	public int get_clickCount() { }

	// RVA: 0x1A5C420 Offset: 0x1A5B820 VA: 0x181A5C420
	public char get_character() { }

	// RVA: 0x1A5CA00 Offset: 0x1A5BE00 VA: 0x181A5CA00
	public void set_character(char value) { }

	// RVA: 0x1A5C7A0 Offset: 0x1A5BBA0 VA: 0x181A5C7A0
	public KeyCode get_keyCode() { }

	// RVA: 0x1A5CB80 Offset: 0x1A5BF80 VA: 0x181A5CB80
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x1A5C640 Offset: 0x1A5BA40 VA: 0x181A5C640
	public int get_displayIndex() { }

	// RVA: 0x1A5CB40 Offset: 0x1A5BF40 VA: 0x181A5CB40
	public void set_displayIndex(int value) { }

	[FreeFunctionAttribute] // RVA: 0xC5C00 Offset: 0xC5000 VA: 0x1800C5C00
	// RVA: 0x1A5C9C0 Offset: 0x1A5BDC0 VA: 0x181A5C9C0
	public EventType get_type() { }

	[FreeFunctionAttribute] // RVA: 0xC5C80 Offset: 0xC5080 VA: 0x1800C5C80
	// RVA: 0x1A5CC90 Offset: 0x1A5C090 VA: 0x181A5CC90
	public void set_type(EventType value) { }

	[FreeFunctionAttribute] // RVA: 0xC5E60 Offset: 0xC5260 VA: 0x1800C5E60
	// RVA: 0x1A5C4A0 Offset: 0x1A5B8A0 VA: 0x181A5C4A0
	public string get_commandName() { }

	[FreeFunctionAttribute] // RVA: 0xC5F00 Offset: 0xC5300 VA: 0x1800C5F00
	// RVA: 0x1A5CA50 Offset: 0x1A5BE50 VA: 0x181A5CA50
	public void set_commandName(string value) { }

	[NativeMethodAttribute] // RVA: 0xC5FE0 Offset: 0xC53E0 VA: 0x1800C5FE0
	// RVA: 0x1A5A2C0 Offset: 0x1A596C0 VA: 0x181A5A2C0
	private void Internal_Use() { }

	[FreeFunctionAttribute] // RVA: 0xC6050 Offset: 0xC5450 VA: 0x1800C6050
	// RVA: 0x1A5A0C0 Offset: 0x1A594C0 VA: 0x181A5A0C0
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunctionAttribute] // RVA: 0xC60E0 Offset: 0xC54E0 VA: 0x1800C60E0
	// RVA: 0x1A5A100 Offset: 0x1A59500 VA: 0x181A5A100
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xC6120 Offset: 0xC5520 VA: 0x1800C6120
	// RVA: 0x1A5A080 Offset: 0x1A59480 VA: 0x181A5A080
	private static IntPtr Internal_Copy(IntPtr otherPtr) { }

	[FreeFunctionAttribute] // RVA: 0xC61B0 Offset: 0xC55B0 VA: 0x1800C61B0
	// RVA: 0x1A5A040 Offset: 0x1A59440 VA: 0x181A5A040
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunctionAttribute] // RVA: 0xC6220 Offset: 0xC5620 VA: 0x1800C6220
	[VisibleToOtherModulesAttribute] // RVA: 0xC6220 Offset: 0xC5620 VA: 0x1800C6220
	// RVA: 0x1A59B20 Offset: 0x1A58F20 VA: 0x181A59B20
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x1A5B590 Offset: 0x1A5A990 VA: 0x181A5B590
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x1A5A280 Offset: 0x1A59680 VA: 0x181A5A280
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A5A140 Offset: 0x1A59540 VA: 0x181A5A140
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x1A5C310 Offset: 0x1A5B710 VA: 0x181A5C310
	public void .ctor() { }

	// RVA: 0x1A5C350 Offset: 0x1A5B750 VA: 0x181A5C350
	public void .ctor(int displayIndex) { }

	// RVA: 0x1A5C260 Offset: 0x1A5B660 VA: 0x181A5C260
	public void .ctor(Event other) { }

	// RVA: 0x1A59E30 Offset: 0x1A59230 VA: 0x181A59E30 Slot: 1
	protected override void Finalize() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC64A0 Offset: 0xC58A0 VA: 0x1800C64A0
	// RVA: 0x1A59B70 Offset: 0x1A58F70 VA: 0x181A59B70
	internal void CopyFrom(Event e) { }

	// RVA: 0x1A5C980 Offset: 0x1A5BD80 VA: 0x181A5C980
	public bool get_shift() { }

	// RVA: 0x1A5C520 Offset: 0x1A5B920 VA: 0x181A5C520
	public bool get_control() { }

	// RVA: 0x1A5C3A0 Offset: 0x1A5B7A0 VA: 0x181A5C3A0
	public bool get_alt() { }

	// RVA: 0x1A5C4E0 Offset: 0x1A5B8E0 VA: 0x181A5C4E0
	public bool get_command() { }

	// RVA: 0x1A5C560 Offset: 0x1A5B960 VA: 0x181A5C560
	public static Event get_current() { }

	// RVA: 0x1A5CAA0 Offset: 0x1A5BEA0 VA: 0x181A5CAA0
	public static void set_current(Event value) { }

	// RVA: 0x1A5C6F0 Offset: 0x1A5BAF0 VA: 0x181A5C6F0
	public bool get_isKey() { }

	// RVA: 0x1A5C740 Offset: 0x1A5BB40 VA: 0x181A5C740
	public bool get_isMouse() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC67D0 Offset: 0xC5BD0 VA: 0x1800C67D0
	// RVA: 0x1A5C680 Offset: 0x1A5BA80 VA: 0x181A5C680
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x1A5A300 Offset: 0x1A59700 VA: 0x181A5A300
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x1A59F10 Offset: 0x1A59310 VA: 0x181A59F10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A59BE0 Offset: 0x1A58FE0 VA: 0x181A59BE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A5B5D0 Offset: 0x1A5A9D0 VA: 0x181A5B5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A5C0B0 Offset: 0x1A5B4B0 VA: 0x181A5C0B0
	public void Use() { }

	// RVA: 0x1A5C820 Offset: 0x1A5BC20 VA: 0x181A5C820
	private void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0x1A5CC00 Offset: 0x1A5C000 VA: 0x181A5CC00
	private void set_mousePosition_Injected(ref Vector2 value) { }

	// RVA: 0x1A5C5A0 Offset: 0x1A5B9A0 VA: 0x181A5C5A0
	private void get_delta_Injected(out Vector2 ret) { }

}

public enum EventType // TypeDefIndex: 4026
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <wantsMouseMove>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x1

	// Properties
	public bool wantsMouseMove { get; }
	public bool wantsMouseEnterLeaveWindow { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14CAA0 Offset: 0x14BEA0 VA: 0x18014CAA0
	public bool get_wantsMouseMove() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1FA030 Offset: 0x1F9430 VA: 0x1801FA030
	public bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x22AAF0 Offset: 0x229EF0 VA: 0x18022AAF0
	public bool WantsEvent(EventType type) { }

}

public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate> // TypeDefIndex: 4582
{	// Fields
	private readonly EventDispatcher m_Dispatcher; // 0x0

	// Methods

	// RVA: 0x139E60 Offset: 0x139260 VA: 0x180139E60
	public void .ctor(EventDispatcher d) { }

	// RVA: 0x139D80 Offset: 0x139180 VA: 0x180139D80 Slot: 4
	public void Dispose() { }

	// RVA: 0x139D90 Offset: 0x139190 VA: 0x180139D90 Slot: 5
	public bool Equals(EventDispatcherGate other) { }

	// RVA: 0x139DA0 Offset: 0x1391A0 VA: 0x180139DA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139E30 Offset: 0x139230 VA: 0x180139E30 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EventDispatcher // TypeDefIndex: 4583
{	// Fields
	private List<IEventDispatchingStrategy> m_DispatchingStrategies; // 0x10
	private static readonly ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool; // 0x0
	private Queue<EventDispatcher.EventRecord> m_Queue; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly PointerDispatchState <pointerState>k__BackingField; // 0x20
	private uint m_GateCount; // 0x28
	private Stack<EventDispatcher.DispatchContext> m_DispatchContexts; // 0x30
	private bool m_Immediate; // 0x38

	// Properties
	internal PointerDispatchState pointerState { get; }
	private bool dispatchImmediately { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal PointerDispatchState get_pointerState() { }

	// RVA: 0xEC2240 Offset: 0xEC1640 VA: 0x180EC2240
	internal void .ctor() { }

	// RVA: 0xEC2530 Offset: 0xEC1930 VA: 0x180EC2530
	private bool get_dispatchImmediately() { }

	// RVA: 0xEC18E0 Offset: 0xEC0CE0 VA: 0x180EC18E0
	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0xEC18D0 Offset: 0xEC0CD0 VA: 0x180EC18D0
	internal void CloseGate() { }

	// RVA: 0xEC1AB0 Offset: 0xEC0EB0 VA: 0x180EC1AB0
	internal void OpenGate() { }

	// RVA: 0xEC1B30 Offset: 0xEC0F30 VA: 0x180EC1B30
	private void ProcessEventQueue() { }

	// RVA: 0xEC1DF0 Offset: 0xEC11F0 VA: 0x180EC1DF0
	private void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0xEC1660 Offset: 0xEC0A60 VA: 0x180EC1660
	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	// RVA: 0xEC21D0 Offset: 0xEC15D0 VA: 0x180EC21D0
	private static void .cctor() { }

}

private struct EventDispatcher.EventRecord // TypeDefIndex: 4584
{	// Fields
	public EventBase m_Event; // 0x0
	public IPanel m_Panel; // 0x8

}

private struct EventDispatcher.DispatchContext // TypeDefIndex: 4585
{	// Fields
	public uint m_GateCount; // 0x0
	public Queue<EventDispatcher.EventRecord> m_Queue; // 0x8

}

public abstract class EventBase : IDisposable // TypeDefIndex: 4640
{	// Fields
	private static long s_LastTypeId; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0xEBF7B0 Offset: 0xEBEBB0 VA: 0x180EBF7B0
	protected static long RegisterEventType() { }

	// RVA: 0xEBF9B0 Offset: 0xEBEDB0 VA: 0x180EBF9B0 Slot: 5
	public virtual long get_eventTypeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1160 Offset: 0x8B0560 VA: 0x1808B1160
	private void set_timestamp(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal ulong get_eventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E60 Offset: 0x497260 VA: 0x180497E60
	private void set_eventId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE87960 Offset: 0xE86D60 VA: 0x180E87960
	private void set_triggerEventId(ulong value) { }

	// RVA: 0xE87960 Offset: 0xE86D60 VA: 0x180E87960
	internal void SetTriggerEventId(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	internal EventBase.EventPropagation get_propagation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	internal void set_propagation(EventBase.EventPropagation value) { }

	// RVA: 0xEBFA30 Offset: 0xEBEE30 VA: 0x180EBFA30
	internal PropagationPaths get_path() { }

	// RVA: 0xEBFE60 Offset: 0xEBF260 VA: 0x180EBFE60
	internal void set_path(PropagationPaths value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	private EventBase.LifeCycleStatus get_lifeCycleStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	private void set_lifeCycleStatus(EventBase.LifeCycleStatus value) { }

	[ObsoleteAttribute] // RVA: 0x95BD0 Offset: 0x94FD0 VA: 0x180095BD0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	protected virtual void PreDispatch() { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210 Slot: 7
	protected internal virtual void PreDispatch(IPanel panel) { }

	[ObsoleteAttribute] // RVA: 0x95C90 Offset: 0x95090 VA: 0x180095C90
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected virtual void PostDispatch() { }

	// RVA: 0xEBF770 Offset: 0xEBEB70 VA: 0x180EBF770 Slot: 9
	protected internal virtual void PostDispatch(IPanel panel) { }

	// RVA: 0xEBF970 Offset: 0xEBED70 VA: 0x180EBF970
	public bool get_bubbles() { }

	// RVA: 0xEBFB70 Offset: 0xEBEF70 VA: 0x180EBFB70
	public bool get_tricklesDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal IEventHandler get_leafTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	private void set_leafTarget(IEventHandler value) { }

	// RVA: 0xEBFB60 Offset: 0xEBEF60 VA: 0x180EBFB60
	public IEventHandler get_target() { }

	// RVA: 0xEC0020 Offset: 0xEBF420 VA: 0x180EC0020
	public void set_target(IEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	internal List<IEventHandler> get_skipElements() { }

	// RVA: 0xEBF810 Offset: 0xEBEC10 VA: 0x180EBF810
	internal bool Skip(IEventHandler h) { }

	// RVA: 0xEBFA00 Offset: 0xEBEE00 VA: 0x180EBFA00
	public bool get_isPropagationStopped() { }

	// RVA: 0xEBFE30 Offset: 0xEBF230 VA: 0x180EBFE30
	private void set_isPropagationStopped(bool value) { }

	// RVA: 0xEBF880 Offset: 0xEBEC80 VA: 0x180EBF880
	public void StopPropagation() { }

	// RVA: 0xEBF9F0 Offset: 0xEBEDF0 VA: 0x180EBF9F0
	public bool get_isImmediatePropagationStopped() { }

	// RVA: 0xEBFE10 Offset: 0xEBF210 VA: 0x180EBFE10
	private void set_isImmediatePropagationStopped(bool value) { }

	// RVA: 0xEBF870 Offset: 0xEBEC70 VA: 0x180EBF870
	public void StopImmediatePropagation() { }

	// RVA: 0xEBF9E0 Offset: 0xEBEDE0 VA: 0x180EBF9E0
	public bool get_isDefaultPrevented() { }

	// RVA: 0xEBFDF0 Offset: 0xEBF1F0 VA: 0x180EBFDF0
	private void set_isDefaultPrevented(bool value) { }

	// RVA: 0xEBF7A0 Offset: 0xEBEBA0 VA: 0x180EBF7A0
	public void PreventDefault() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	public PropagationPhase get_propagationPhase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD229D0 Offset: 0xD21DD0 VA: 0x180D229D0
	internal void set_propagationPhase(PropagationPhase value) { }

	// RVA: 0xEBF980 Offset: 0xEBED80 VA: 0x180EBF980 Slot: 10
	public virtual IEventHandler get_currentTarget() { }

	// RVA: 0xEBFB80 Offset: 0xEBEF80 VA: 0x180EBFB80 Slot: 11
	internal virtual void set_currentTarget(IEventHandler value) { }

	// RVA: 0xEBF990 Offset: 0xEBED90 VA: 0x180EBF990
	public bool get_dispatch() { }

	// RVA: 0xEBFCB0 Offset: 0xEBF0B0 VA: 0x180EBFCB0
	internal void set_dispatch(bool value) { }

	// RVA: 0xEBF6F0 Offset: 0xEBEAF0 VA: 0x180EBF6F0
	internal void MarkReceivedByDispatcher() { }

	// RVA: 0xEBF9A0 Offset: 0xEBEDA0 VA: 0x180EBF9A0
	private bool get_dispatched() { }

	// RVA: 0xEBFCD0 Offset: 0xEBF0D0 VA: 0x180EBFCD0
	private void set_dispatched(bool value) { }

	// RVA: 0xEBFB30 Offset: 0xEBEF30 VA: 0x180EBFB30
	internal bool get_processed() { }

	// RVA: 0xEBFFC0 Offset: 0xEBF3C0 VA: 0x180EBFFC0
	private void set_processed(bool value) { }

	// RVA: 0xEBFB50 Offset: 0xEBEF50 VA: 0x180EBFB50
	internal bool get_stopDispatch() { }

	// RVA: 0xEC0000 Offset: 0xEBF400 VA: 0x180EC0000
	internal void set_stopDispatch(bool value) { }

	// RVA: 0xEBFB40 Offset: 0xEBEF40 VA: 0x180EBFB40
	internal bool get_propagateToIMGUI() { }

	// RVA: 0xEBFFE0 Offset: 0xEBF3E0 VA: 0x180EBFFE0
	internal void set_propagateToIMGUI(bool value) { }

	// RVA: 0xEBF9C0 Offset: 0xEBEDC0 VA: 0x180EBF9C0
	private bool get_imguiEventIsValid() { }

	// RVA: 0xEBFCF0 Offset: 0xEBF0F0 VA: 0x180EBFCF0
	private void set_imguiEventIsValid(bool value) { }

	// RVA: 0xEBF9D0 Offset: 0xEBEDD0 VA: 0x180EBF9D0
	public Event get_imguiEvent() { }

	// RVA: 0xEBFD10 Offset: 0xEBF110 VA: 0x180EBFD10
	protected void set_imguiEvent(Event value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEBFA10 Offset: 0xEBEE10 VA: 0x180EBFA10
	public Vector2 get_originalMousePosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEBFE50 Offset: 0xEBF250 VA: 0x180EBFE50
	private void set_originalMousePosition(Vector2 value) { }

	// RVA: 0xEBF4B0 Offset: 0xEBE8B0 VA: 0x180EBF4B0 Slot: 12
	protected virtual void Init() { }

	// RVA: 0xEBF4C0 Offset: 0xEBE8C0 VA: 0x180EBF4C0
	private void LocalInit() { }

	// RVA: 0xEBF8E0 Offset: 0xEBECE0 VA: 0x180EBF8E0
	protected void .ctor() { }

	// RVA: 0xEBFB20 Offset: 0xEBEF20 VA: 0x180EBFB20
	protected bool get_pooled() { }

	// RVA: 0xEBFFA0 Offset: 0xEBF3A0 VA: 0x180EBFFA0
	protected void set_pooled(bool value) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void Acquire();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Dispose();

	// RVA: 0xEBF890 Offset: 0xEBEC90 VA: 0x180EBF890
	private static void .cctor() { }

}

internal enum EventBase.EventPropagation // TypeDefIndex: 4641
{	// Fields
	public int value__; // 0x0
	public const EventBase.EventPropagation None = 0;
	public const EventBase.EventPropagation Bubbles = 1;
	public const EventBase.EventPropagation TricklesDown = 2;
	public const EventBase.EventPropagation Cancellable = 4;

}

private enum EventBase.LifeCycleStatus // TypeDefIndex: 4642
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private CallbackPhase <phase>k__BackingField; // 0x10

	// Properties
	public CallbackPhase phase { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public CallbackPhase get_phase() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(EventBase evt);

}

internal class EventCallbackListPool // TypeDefIndex: 4646
{	// Fields
	private readonly Stack<EventCallbackList> m_Stack; // 0x10

	// Methods

	// RVA: 0xEC0060 Offset: 0xEBF460 VA: 0x180EC0060
	public EventCallbackList Get(EventCallbackList initializer) { }

	// RVA: 0xEC01C0 Offset: 0xEBF5C0 VA: 0x180EC01C0
	public void Release(EventCallbackList element) { }

	// RVA: 0xEC0250 Offset: 0xEBF650 VA: 0x180EC0250
	public void .ctor() { }

}

internal class EventCallbackList // TypeDefIndex: 4647
{	// Fields
	private List<EventCallbackFunctorBase> m_List; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private int <trickleDownCallbackCount>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <bubbleUpCallbackCount>k__BackingField; // 0x1C

	// Properties
	public int trickleDownCallbackCount { get; set; }
	public int bubbleUpCallbackCount { get; set; }
	public int Count { get; }
	public EventCallbackFunctorBase Item { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_trickleDownCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	private void set_trickleDownCallbackCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_bubbleUpCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	private void set_bubbleUpCallbackCount(int value) { }

	// RVA: 0xEC0460 Offset: 0xEBF860 VA: 0x180EC0460
	public void .ctor() { }

	// RVA: 0xEC04D0 Offset: 0xEBF8D0 VA: 0x180EC04D0
	public void .ctor(EventCallbackList source) { }

	// RVA: 0xEC02C0 Offset: 0xEBF6C0 VA: 0x180EC02C0
	public void AddRange(EventCallbackList list) { }

	// RVA: 0xEC0560 Offset: 0xEBF960 VA: 0x180EC0560
	public int get_Count() { }

	// RVA: 0xEC05A0 Offset: 0xEBF9A0 VA: 0x180EC05A0
	public EventCallbackFunctorBase get_Item(int i) { }

	// RVA: 0xEC0410 Offset: 0xEBF810 VA: 0x180EC0410
	public void Clear() { }

}

internal class EventCallbackRegistry // TypeDefIndex: 4648
{	// Fields
	private static readonly EventCallbackListPool s_ListPool; // 0x0
	private EventCallbackList m_Callbacks; // 0x10
	private EventCallbackList m_TemporaryCallbacks; // 0x18
	private int m_IsInvoking; // 0x20

	// Methods

	// RVA: 0xEC0600 Offset: 0xEBFA00 VA: 0x180EC0600
	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0xEC0970 Offset: 0xEBFD70 VA: 0x180EC0970
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0xEC0800 Offset: 0xEBFC00 VA: 0x180EC0800
	public void InvokeCallbacks(EventBase evt) { }

	// RVA: 0xEC07E0 Offset: 0xEBFBE0 VA: 0x180EC07E0
	public bool HasTrickleDownHandlers() { }

	// RVA: 0xEC07C0 Offset: 0xEBFBC0 VA: 0x180EC07C0
	public bool HasBubbleHandlers() { }

	// RVA: 0xEC0A50 Offset: 0xEBFE50 VA: 0x180EC0A50
	private static void .cctor() { }

}

internal static class EventDispatchUtilities // TypeDefIndex: 4658
{	// Methods

	// RVA: 0xEC0C10 Offset: 0xEC0010 VA: 0x180EC0C10
	public static void PropagateEvent(EventBase evt) { }

	// RVA: 0xEC1370 Offset: 0xEC0770 VA: 0x180EC1370
	internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

	// RVA: 0xEC0B00 Offset: 0xEBFF00 VA: 0x180EC0B00
	public static void ExecuteDefaultAction(EventBase evt, IPanel panel) { }

}

internal struct EventDebuggerLogIMGUICall : IDisposable // TypeDefIndex: 4703
{	// Methods

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	public void .ctor(EventBase evt) { }

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0 Slot: 4
	public void Dispose() { }

}

internal struct EventDebuggerLogExecuteDefaultAction : IDisposable // TypeDefIndex: 4704
{	// Methods

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	public void .ctor(EventBase evt) { }

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0 Slot: 4
	public void Dispose() { }

}

internal class EventDebugger // TypeDefIndex: 4705
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void LogPropagationPaths(EventBase evt, PropagationPaths paths) { }

}

public enum EventHandle // TypeDefIndex: 5052
{	// Fields
	public int value__; // 0x0
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;

}

public class EventSystem : UIBehaviour // TypeDefIndex: 5071
{	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x18
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

	// Properties
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

	// Methods

	// RVA: 0x10BF180 Offset: 0x10BE580 VA: 0x1810BF180
	public static EventSystem get_current() { }

	// RVA: 0x10BF240 Offset: 0x10BE640 VA: 0x1810BF240
	public static void set_current(EventSystem value) { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool get_sendNavigationEvents() { }

	// RVA: 0x829920 Offset: 0x828D20 VA: 0x180829920
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public int get_pixelDragThreshold() { }

	// RVA: 0xD6ED70 Offset: 0xD6E170 VA: 0x180D6ED70
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_isFocused() { }

	// RVA: 0x10BF070 Offset: 0x10BE470 VA: 0x1810BF070
	protected void .ctor() { }

	// RVA: 0x10BEA40 Offset: 0x10BDE40 VA: 0x1810BEA40
	public void UpdateModules() { }

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40
	public bool get_alreadySelecting() { }

	// RVA: 0x10BE580 Offset: 0x10BD980 VA: 0x1810BE580
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x10BF0F0 Offset: 0x10BE4F0 VA: 0x1810BF0F0
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x10BE780 Offset: 0x10BDB80 VA: 0x1810BE780
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x10BE0D0 Offset: 0x10BD4D0 VA: 0x1810BE0D0
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x10BDEF0 Offset: 0x10BD2F0 VA: 0x1810BDEF0
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x10BDCE0 Offset: 0x10BD0E0 VA: 0x1810BDCE0
	public bool IsPointerOverGameObject() { }

	// RVA: 0x10BDC30 Offset: 0x10BD030 VA: 0x1810BDC30
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10BDE70 Offset: 0x10BD270 VA: 0x1810BDE70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10BDD80 Offset: 0x10BD180 VA: 0x1810BDD80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10BE820 Offset: 0x10BDC20 VA: 0x1810BE820
	private void TickModules() { }

	// RVA: 0x80DB50 Offset: 0x80CF50 VA: 0x18080DB50 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x10BEB70 Offset: 0x10BDF70 VA: 0x1810BEB70 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x10BDB00 Offset: 0x10BCF00 VA: 0x1810BDB00
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x10BE930 Offset: 0x10BDD30 VA: 0x1810BE930 Slot: 3
	public override string ToString() { }

	// RVA: 0x10BEFC0 Offset: 0x10BE3C0 VA: 0x1810BEFC0
	private static void .cctor() { }

}

public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5072
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x86160 Offset: 0x85560 VA: 0x180086160
	[SerializeField] // RVA: 0x86160 Offset: 0x85560 VA: 0x180086160
	private List<EventTrigger.Entry> m_Delegates; // 0x18

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x86350 Offset: 0x85750 VA: 0x180086350
	[ObsoleteAttribute] // RVA: 0x86350 Offset: 0x85750 VA: 0x180086350
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x10BF5E0 Offset: 0x10BE9E0 VA: 0x1810BF5E0
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

	// RVA: 0x10BF5E0 Offset: 0x10BE9E0 VA: 0x1810BF5E0
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x10BF340 Offset: 0x10BE740 VA: 0x1810BF340
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x10BF570 Offset: 0x10BE970 VA: 0x1810BF570 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x10BF580 Offset: 0x10BE980 VA: 0x1810BF580 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x10BF500 Offset: 0x10BE900 VA: 0x1810BF500 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x10BF510 Offset: 0x10BE910 VA: 0x1810BF510 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x10BF560 Offset: 0x10BE960 VA: 0x1810BF560 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x10BF590 Offset: 0x10BE990 VA: 0x1810BF590 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x10BF550 Offset: 0x10BE950 VA: 0x1810BF550 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10BF5B0 Offset: 0x10BE9B0 VA: 0x1810BF5B0 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x10BF4F0 Offset: 0x10BE8F0 VA: 0x1810BF4F0 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x10BF5A0 Offset: 0x10BE9A0 VA: 0x1810BF5A0 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x10BF540 Offset: 0x10BE940 VA: 0x1810BF540 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x10BF5D0 Offset: 0x10BE9D0 VA: 0x1810BF5D0 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x10BF530 Offset: 0x10BE930 VA: 0x1810BF530 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x10BF4D0 Offset: 0x10BE8D0 VA: 0x1810BF4D0 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x10BF520 Offset: 0x10BE920 VA: 0x1810BF520 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x10BF5C0 Offset: 0x10BE9C0 VA: 0x1810BF5C0 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x10BF4E0 Offset: 0x10BE8E0 VA: 0x1810BF4E0 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }

}

public class EventTrigger.TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 5073
{	// Methods

	// RVA: 0x10C9AA0 Offset: 0x10C8EA0 VA: 0x1810C9AA0
	public void .ctor() { }

}

public class EventTrigger.Entry // TypeDefIndex: 5074
{	// Fields
	public EventTriggerType eventID; // 0x10
	public EventTrigger.TriggerEvent callback; // 0x18

	// Methods

	// RVA: 0x10BDA70 Offset: 0x10BCE70 VA: 0x1810BDA70
	public void .ctor() { }

}

public enum EventTriggerType // TypeDefIndex: 5075
{	// Fields
	public int value__; // 0x0
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
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
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
{	// Fields
	internal readonly List<MidiEvent> _events; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsReadOnly>k__BackingField; // 0x18

	// Properties
	public MidiEvent Item { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1392F20 Offset: 0x1392320 VA: 0x181392F20
	internal void .ctor() { }

	// RVA: 0x1392FD0 Offset: 0x13923D0 VA: 0x181392FD0
	public MidiEvent get_Item(int index) { }

	// RVA: 0x1392F90 Offset: 0x1392390 VA: 0x181392F90 Slot: 4
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1392B80 Offset: 0x1391F80 VA: 0x181392B80 Slot: 6
	public void Add(MidiEvent midiEvent) { }

	// RVA: 0x1392DE0 Offset: 0x13921E0 VA: 0x181392DE0 Slot: 10
	public bool Remove(MidiEvent midiEvent) { }

	// RVA: 0x1392C40 Offset: 0x1392040 VA: 0x181392C40 Slot: 7
	public void Clear() { }

	// RVA: 0x1392D60 Offset: 0x1392160 VA: 0x181392D60 Slot: 11
	public IEnumerator<MidiEvent> GetEnumerator() { }

	// RVA: 0x1392EA0 Offset: 0x13922A0 VA: 0x181392EA0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1392C90 Offset: 0x1392090 VA: 0x181392C90 Slot: 8
	public bool Contains(MidiEvent item) { }

	// RVA: 0x1392CF0 Offset: 0x13920F0 VA: 0x181392CF0 Slot: 9
	public void CopyTo(MidiEvent[] array, int arrayIndex) { }

}

public sealed class EventTypesCollection // TypeDefIndex: 7530
{	// Fields
	private readonly Dictionary<byte, Type> _types; // 0x10

	// Methods

	// RVA: 0x1392B10 Offset: 0x1391F10 VA: 0x181392B10
	public bool TryGetType(byte statusByte, out Type type) { }

}

internal static class EventReaderFactory // TypeDefIndex: 7553
{	// Fields
	private static readonly IEventReader MetaEventReader; // 0x0
	private static readonly IEventReader ChannelEventReader; // 0x8
	private static readonly IEventReader SysExEventReader; // 0x10
	private static readonly IEventReader SystemRealTimeEventReader; // 0x18
	private static readonly IEventReader SystemCommonEventReader; // 0x20

	// Methods

	// RVA: 0x1392840 Offset: 0x1391C40 VA: 0x181392840
	internal static IEventReader GetReader(byte statusByte, bool smfOnly) { }

	// RVA: 0x13929E0 Offset: 0x1391DE0 VA: 0x1813929E0
	private static void .cctor() { }

}

public class EventSchedule : BaseMonoBehaviour // TypeDefIndex: 9816
{	// Fields
	[TooltipAttribute] // RVA: 0x999A0 Offset: 0x98DA0 VA: 0x1800999A0
	public float minimumHoursBetween; // 0x18
	[TooltipAttribute] // RVA: 0x99B60 Offset: 0x98F60 VA: 0x180099B60
	public float maxmumHoursBetween; // 0x1C

	// Methods

	// RVA: 0x8BBEA0 Offset: 0x8BB2A0 VA: 0x1808BBEA0
	public void .ctor() { }

}

