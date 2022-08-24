internal class TaskExceptionHolder // TypeDefIndex: 883
{
	private static readonly bool s_failFastOnUnobservedException; 
	private static bool s_domainUnloadStarted; 
	private static EventHandler s_adUnloadEventHandler; 
	private readonly Task m_task; 
	private List<ExceptionDispatchInfo> m_faultExceptions; 
	private ExceptionDispatchInfo m_cancellationException; 
	private bool m_isHandled; 

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

