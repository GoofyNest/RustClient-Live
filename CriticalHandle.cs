public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1345
{
	protected IntPtr handle; 
	private bool _isClosed; 

public bool IsClosed { get; }
public abstract bool IsInvalid { get; }


	[ReliabilityContractAttribute] 
protected void .ctor(IntPtr invalidHandleValue) { }

	[ReliabilityContractAttribute] 
protected override void Finalize() { }

	[ReliabilityContractAttribute] 
private void Cleanup() { }

private static void FireCustomerDebugProbe() { }

	[ReliabilityContractAttribute] 
protected void SetHandle(IntPtr handle) { }

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

}

