public class ClaimsIdentity : IIdentity // TypeDefIndex: 935
{
	private byte[] m_userSerializationData; 
	private List<Claim> m_instanceClaims; 
	private Collection<IEnumerable<Claim>> m_externalClaims; 
	private string m_nameType; 
	private string m_roleType; 
	[OptionalFieldAttribute] 
	private string m_version; 
	[OptionalFieldAttribute] 
	private ClaimsIdentity m_actor; 
	[OptionalFieldAttribute] 
	private string m_authenticationType; 
	[OptionalFieldAttribute] 
	private object m_bootstrapContext; 
	[OptionalFieldAttribute] 
	private string m_label; 
	[OptionalFieldAttribute] 
	private string m_serializedNameType; 
	[OptionalFieldAttribute] 
	private string m_serializedRoleType; 
	[OptionalFieldAttribute] 
	private string m_serializedClaims; 

	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }


	public void .ctor() { }

	public void .ctor(IEnumerable<Claim> claims) { }

	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public virtual string get_AuthenticationType() { }

	public ClaimsIdentity get_Actor() { }

	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachineAttribute] 
	public virtual IEnumerable<Claim> get_Claims() { }

	public virtual string get_Name() { }

	public virtual ClaimsIdentity Clone() { }

	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	private void SafeAddClaim(Claim claim) { }

	public virtual Claim FindFirst(string type) { }

	[OnSerializingAttribute] 
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserializedAttribute] 
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializingAttribute] 
	private void OnDeserializingMethod(StreamingContext context) { }

	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void DeserializeClaims(string serializedClaims) { }

	private string SerializeClaims() { }

	private bool IsCircular(ClaimsIdentity subject) { }

	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }

}

private sealed class ClaimsIdentity.<get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator // TypeDefIndex: 936
{
	private int <>1__state; 
	private Claim <>2__current; 
	private int <>l__initialThreadId; 
	public ClaimsIdentity <>4__this; 
	private int <i>5__1; 
	private int <j>5__2; 
	private IEnumerator<Claim> <>7__wrap1; 

	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

