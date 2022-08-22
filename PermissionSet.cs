public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 902
{	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

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

	[MonoTODOAttribute] // RVA: 0xC1920 Offset: 0xC0D20 VA: 0x1800C1920
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override int GetHashCode() { }

	private static void .cctor() { }

}

