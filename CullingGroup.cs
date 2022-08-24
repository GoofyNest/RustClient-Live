public class CullingGroup : IDisposable // TypeDefIndex: 3366
{
	internal IntPtr m_Ptr; 
	private CullingGroup.StateChanged m_OnStateChanged; 

public CullingGroup.StateChanged onStateChanged { set; }
public Camera targetCamera { get; set; }


public void .ctor() { }

protected override void Finalize() { }

	[FreeFunctionAttribute] 
private void DisposeInternal() { }

public void Dispose() { }

public void set_onStateChanged(CullingGroup.StateChanged value) { }

public Camera get_targetCamera() { }

public void set_targetCamera(Camera value) { }

public void SetBoundingSpheres(BoundingSphere[] array) { }

public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] 
public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] 
private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] 
private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] 
private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] 
private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(CullingGroupEvent sphere) { }

public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

