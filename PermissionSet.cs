public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 902
{
	private static object[] psUnrestricted; 
	private PermissionState state; 
	private ArrayList list; 
	private bool _declsec; 
	private bool[] _ignored; 
	private static object[] action; 

	public virtual int Count { get; }
	public virtual object SyncRoot { get; }


	internal void .ctor() { }

	public void .ctor(PermissionState state) { }

	internal void .ctor(IPermission perm) { }

	public virtual void CopyTo(Array array, int index) { }

	public void Demand() { }

	internal void CasOnlyDemand(int skip) { }

	public IEnumerator GetEnumerator() { }

	public bool IsEmpty() { }

	public bool IsUnrestricted() { }

	public override string ToString() { }

	public virtual SecurityElement ToXml() { }

	public virtual int get_Count() { }

	public virtual object get_SyncRoot() { }

	[MonoTODOAttribute] 
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisibleAttribute] 
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] 
	public override int GetHashCode() { }

	private static void .cctor() { }

}

