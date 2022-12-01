public struct CancellationToken // TypeDefIndex: 749
{
	private CancellationTokenSource m_source;
	private static readonly Action<object> s_ActionToActionObjShunt;

	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }


	public static CancellationToken get_None() { }

	public bool get_IsCancellationRequested() { }

	public bool get_CanBeCanceled() { }

	internal void .ctor(CancellationTokenSource source) { }

	public void .ctor(bool canceled) { }

	private static void ActionToActionObjShunt(object obj) { }

	public CancellationTokenRegistration Register(Action<object> callback, object state) { }

	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	private CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	public bool Equals(CancellationToken other) { }

	public override bool Equals(object other) { }

	public override int GetHashCode() { }

	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	public void ThrowIfCancellationRequested() { }

	internal void ThrowIfSourceDisposed() { }

	private void ThrowOperationCanceledException() { }

	private static void ThrowObjectDisposedException() { }

	private static void .cctor() { }

}

