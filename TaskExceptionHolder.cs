internal class TaskExceptionHolder // TypeDefIndex: 883
{	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private static bool s_domainUnloadStarted; // 0x1
	private static EventHandler s_adUnloadEventHandler; // 0x8
	private readonly Task m_task; // 0x10
	private List<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	internal bool ContainsFaultList { get; }


	internal void .ctor(Task task) { }

	private static bool ShouldFailFastOnUnobservedException() { }

	private static void EnsureADUnloadCallbackRegistered() { }

	private static void AppDomainUnloadCallback(object sender, EventArgs e) { }

	protected override void Finalize() { }

	internal bool get_ContainsFaultList() { }

	internal void Add(object exceptionObject, bool representsCancellation) { }

	private void SetCancellationException(object exceptionObject) { }

	private void AddFaultException(object exceptionObject) { }

	private void MarkAsUnhandled() { }

	internal void MarkAsHandled(bool calledFromFinalizer) { }

	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	private static void .cctor() { }

}

