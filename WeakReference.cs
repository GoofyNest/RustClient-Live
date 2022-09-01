public class WeakReference : ISerializable // TypeDefIndex: 421
{

[ComVisibleAttribute] 
[Serializable]
public class WeakReference : ISerializable
	private bool isLongReference; 
	private GCHandle gcHandle; 

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

