public class WeakReference : ISerializable // TypeDefIndex: 421
{
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
[Serializable]
public class WeakReference : ISerializable // TypeDefIndex: 421
	private bool isLongReference; // 0x10
	private GCHandle gcHandle; // 0x14

	public virtual bool IsAlive { get; }
	public virtual object Target { get; set; }
	public virtual bool TrackResurrection { get; }


	private void AllocateHandle(object target) { }

	protected void .ctor() { }

	public void .ctor(object target) { }

	public void .ctor(object target, bool trackResurrection) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public virtual bool get_IsAlive() { }

	public virtual object get_Target() { }

	public virtual void set_Target(object value) { }

	public virtual bool get_TrackResurrection() { }

	protected override void Finalize() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

