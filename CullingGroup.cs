public class CullingGroup : IDisposable // TypeDefIndex: 3366
{	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	public CullingGroup.StateChanged onStateChanged { set; }
	public Camera targetCamera { get; set; }


	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x78690 Offset: 0x77A90 VA: 0x180078690
	private void DisposeInternal() { }

	public void Dispose() { }

	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	public Camera get_targetCamera() { }

	public void set_targetCamera(Camera value) { }

	public void SetBoundingSpheres(BoundingSphere[] array) { }

	public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] // RVA: 0x79B10 Offset: 0x78F10 VA: 0x180079B10
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0x79E00 Offset: 0x79200 VA: 0x180079E00
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0x7A1C0 Offset: 0x795C0 VA: 0x18007A1C0
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0x7A2A0 Offset: 0x796A0 VA: 0x18007A2A0
	private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(CullingGroupEvent sphere) { }

	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

