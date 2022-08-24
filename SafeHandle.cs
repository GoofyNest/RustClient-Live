public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1351
{
	protected IntPtr handle; 
	private int _state; 
	private bool _ownsHandle; 
	private bool _fullyInitialized; 
private const int RefCount_Mask = 2147483644;
private const int RefCount_One = 4;

public bool IsClosed { get; }
public abstract bool IsInvalid { get; }


	[ReliabilityContractAttribute] 
protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

protected override void Finalize() { }

	[ReliabilityContractAttribute] 
protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] 
public IntPtr DangerousGetHandle() { }

	[ReliabilityContractAttribute] 
public bool get_IsClosed() { }

	[ReliabilityContractAttribute] 
public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] 
public void Close() { }

	[ReliabilityContractAttribute] 
public void Dispose() { }

	[ReliabilityContractAttribute] 
protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] 
protected abstract bool ReleaseHandle();

	[ReliabilityContractAttribute] 
public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] 
public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] 
public void DangerousRelease() { }

private void InternalDispose() { }

private void InternalFinalize() { }

private void DangerousReleaseInternal(bool dispose) { }

}

