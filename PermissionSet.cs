public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 902
{	// Fields
	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

	// Properties
	public virtual int Count { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x17B1120 Offset: 0x17B0520 VA: 0x1817B1120
	internal void .ctor() { }

	// RVA: 0x17B10A0 Offset: 0x17B04A0 VA: 0x1817B10A0
	public void .ctor(PermissionState state) { }

	// RVA: 0x17B1190 Offset: 0x17B0590 VA: 0x1817B1190
	internal void .ctor(IPermission perm) { }

	// RVA: 0x17B0300 Offset: 0x17AF700 VA: 0x1817B0300 Slot: 10
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x17B0460 Offset: 0x17AF860 VA: 0x1817B0460 Slot: 11
	public void Demand() { }

	// RVA: 0x17B0280 Offset: 0x17AF680 VA: 0x1817B0280
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x17B0820 Offset: 0x17AFC20 VA: 0x1817B0820 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x17B08A0 Offset: 0x17AFCA0 VA: 0x1817B08A0
	public bool IsEmpty() { }

	// RVA: 0x17B0B10 Offset: 0x17AFF10 VA: 0x1817B0B10
	public bool IsUnrestricted() { }

	// RVA: 0x17B0B20 Offset: 0x17AFF20 VA: 0x1817B0B20 Slot: 3
	public override string ToString() { }

	// RVA: 0x17B0B60 Offset: 0x17AFF60 VA: 0x1817B0B60 Slot: 12
	public virtual SecurityElement ToXml() { }

	// RVA: 0x154E6F0 Offset: 0x154DAF0 VA: 0x18154E6F0 Slot: 13
	public virtual int get_Count() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 14
	public virtual object get_SyncRoot() { }

	[MonoTODOAttribute] // RVA: 0xC1920 Offset: 0xC0D20 VA: 0x1800C1920
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17B0660 Offset: 0x17AFA60 VA: 0x1817B0660 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17B0850 Offset: 0x17AFC50 VA: 0x1817B0850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17B0F20 Offset: 0x17B0320 VA: 0x1817B0F20
	private static void .cctor() { }

}

