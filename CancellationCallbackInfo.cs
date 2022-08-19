internal class CancellationCallbackInfo // TypeDefIndex: 753
{	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly SynchronizationContext TargetSyncContext; // 0x20
	internal readonly ExecutionContext TargetExecutionContext; // 0x28
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x30
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x148AB10 Offset: 0x1489F10 VA: 0x18148AB10
	internal void .ctor(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x148A840 Offset: 0x1489C40 VA: 0x18148A840
	internal void ExecuteCallback() { }

	// RVA: 0x148AA80 Offset: 0x1489E80 VA: 0x18148AA80
	private static void ExecutionContextCallback(object obj) { }

}

