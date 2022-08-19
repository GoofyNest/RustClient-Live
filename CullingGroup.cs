public class CullingGroup : IDisposable // TypeDefIndex: 3366
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Properties
	public CullingGroup.StateChanged onStateChanged { set; }
	public Camera targetCamera { get; set; }

	// Methods

	// RVA: 0x18228B0 Offset: 0x1821CB0 VA: 0x1818228B0
	public void .ctor() { }

	// RVA: 0x18225B0 Offset: 0x18219B0 VA: 0x1818225B0 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x78690 Offset: 0x77A90 VA: 0x180078690
	// RVA: 0x1822510 Offset: 0x1821910 VA: 0x181822510
	private void DisposeInternal() { }

	// RVA: 0x1822550 Offset: 0x1821950 VA: 0x181822550 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	// RVA: 0x1822910 Offset: 0x1821D10 VA: 0x181822910
	public Camera get_targetCamera() { }

	// RVA: 0x1822950 Offset: 0x1821D50 VA: 0x181822950
	public void set_targetCamera(Camera value) { }

	// RVA: 0x1822810 Offset: 0x1821C10 VA: 0x181822810
	public void SetBoundingSpheres(BoundingSphere[] array) { }

	// RVA: 0x18227D0 Offset: 0x1821BD0 VA: 0x1818227D0
	public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] // RVA: 0x79B10 Offset: 0x78F10 VA: 0x180079B10
	// RVA: 0x1822780 Offset: 0x1821B80 VA: 0x181822780
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0x79E00 Offset: 0x79200 VA: 0x180079E00
	// RVA: 0x1822860 Offset: 0x1821C60 VA: 0x181822860
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	// RVA: 0x1822860 Offset: 0x1821C60 VA: 0x181822860
	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1822710 Offset: 0x1821B10 VA: 0x181822710
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0x7A1C0 Offset: 0x795C0 VA: 0x18007A1C0
	// RVA: 0x18226D0 Offset: 0x1821AD0 VA: 0x1818226D0
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0x7A2A0 Offset: 0x796A0 VA: 0x18007A2A0
	// RVA: 0x1822690 Offset: 0x1821A90 VA: 0x181822690
	private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x182DBC0 Offset: 0x182CFC0 VA: 0x18182DBC0 Slot: 12
	public virtual void Invoke(CullingGroupEvent sphere) { }

	// RVA: 0x182DB40 Offset: 0x182CF40 VA: 0x18182DB40 Slot: 13
	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

