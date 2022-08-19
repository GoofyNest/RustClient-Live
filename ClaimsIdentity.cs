public class ClaimsIdentity : IIdentity // TypeDefIndex: 935
{	// Fields
	private byte[] m_userSerializationData; // 0x10
	private List<Claim> m_instanceClaims; // 0x18
	private Collection<IEnumerable<Claim>> m_externalClaims; // 0x20
	private string m_nameType; // 0x28
	private string m_roleType; // 0x30
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_version; // 0x38
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private ClaimsIdentity m_actor; // 0x40
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_authenticationType; // 0x48
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private object m_bootstrapContext; // 0x50
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_label; // 0x58
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_serializedNameType; // 0x60
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_serializedRoleType; // 0x68
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_serializedClaims; // 0x70

	// Properties
	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }

	// Methods

	// RVA: 0x16F2FE0 Offset: 0x16F23E0 VA: 0x1816F2FE0
	public void .ctor() { }

	// RVA: 0x16F3010 Offset: 0x16F2410 VA: 0x1816F3010
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x16F2FB0 Offset: 0x16F23B0 VA: 0x1816F2FB0
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x16F2A30 Offset: 0x16F1E30 VA: 0x1816F2A30
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x16F3040 Offset: 0x16F2440 VA: 0x1816F3040
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x16F3230 Offset: 0x16F2630 VA: 0x1816F3230
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachineAttribute] // RVA: 0xC62E0 Offset: 0xC56E0 VA: 0x1800C62E0
	// RVA: 0x16F3190 Offset: 0x16F2590 VA: 0x1816F3190 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x16F3200 Offset: 0x16F2600 VA: 0x1816F3200 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x16F13E0 Offset: 0x16F07E0 VA: 0x1816F13E0 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x16F26B0 Offset: 0x16F1AB0 VA: 0x1816F26B0
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x16F2610 Offset: 0x16F1A10 VA: 0x1816F2610
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x16F1DF0 Offset: 0x16F11F0 VA: 0x1816F1DF0 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16F2590 Offset: 0x16F1990 VA: 0x1816F2590
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16F2410 Offset: 0x16F1810 VA: 0x1816F2410
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16F24E0 Offset: 0x16F18E0 VA: 0x1816F24E0
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x16F1FB0 Offset: 0x16F13B0 VA: 0x1816F1FB0 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16F1570 Offset: 0x16F0970 VA: 0x1816F1570
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x16F28A0 Offset: 0x16F1CA0 VA: 0x1816F28A0
	private string SerializeClaims() { }

	// RVA: 0x16F23C0 Offset: 0x16F17C0 VA: 0x1816F23C0
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x16F17D0 Offset: 0x16F0BD0 VA: 0x1816F17D0
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }

}

private sealed class ClaimsIdentity.<get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator // TypeDefIndex: 936
{	// Fields
	private int <>1__state; // 0x10
	private Claim <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ClaimsIdentity <>4__this; // 0x28
	private int <i>5__1; // 0x30
	private int <j>5__2; // 0x34
	private IEnumerator<Claim> <>7__wrap1; // 0x38

	// Properties
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1706220 Offset: 0x1705620 VA: 0x181706220 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1705E90 Offset: 0x1705290 VA: 0x181705E90 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x17062D0 Offset: 0x17056D0 VA: 0x1817062D0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x17061D0 Offset: 0x17055D0 VA: 0x1817061D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1706130 Offset: 0x1705530 VA: 0x181706130 Slot: 4
	private IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1706130 Offset: 0x1705530 VA: 0x181706130 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

