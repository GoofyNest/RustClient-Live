public class WeakReference : ISerializable // TypeDefIndex: 421
{
// Namespace: System
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
[Serializable]
public class WeakReference : ISerializable // TypeDefIndex: 421
	// Fields
	private bool isLongReference; // 0x10
	private GCHandle gcHandle; // 0x14

	// Properties
	public virtual bool IsAlive { get; }
	public virtual object Target { get; set; }
	public virtual bool TrackResurrection { get; }

	// Methods

	// RVA: 0x2144500 Offset: 0x2143900 VA: 0x182144500
	private void AllocateHandle(object target) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x21446C0 Offset: 0x2143AC0 VA: 0x1821446C0
	public void .ctor(object target) { }

	// RVA: 0x2144700 Offset: 0x2143B00 VA: 0x182144700
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x2144750 Offset: 0x2143B50 VA: 0x182144750
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2144850 Offset: 0x2143C50 VA: 0x182144850 Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x2144870 Offset: 0x2143C70 VA: 0x182144870 Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x21448A0 Offset: 0x2143CA0 VA: 0x1821448A0 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20 Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x2144530 Offset: 0x2143930 VA: 0x182144530 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x21445C0 Offset: 0x21439C0 VA: 0x1821445C0 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

