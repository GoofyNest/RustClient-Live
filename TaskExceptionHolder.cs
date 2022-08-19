internal class TaskExceptionHolder // TypeDefIndex: 883
{	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private static bool s_domainUnloadStarted; // 0x1
	private static EventHandler s_adUnloadEventHandler; // 0x8
	private readonly Task m_task; // 0x10
	private List<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x1603590 Offset: 0x1602990 VA: 0x181603590
	internal void .ctor(Task task) { }

	// RVA: 0x1603540 Offset: 0x1602940 VA: 0x181603540
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x1602BF0 Offset: 0x1601FF0 VA: 0x181602BF0
	private static void EnsureADUnloadCallbackRegistered() { }

	// RVA: 0x16029A0 Offset: 0x1601DA0 VA: 0x1816029A0
	private static void AppDomainUnloadCallback(object sender, EventArgs e) { }

	// RVA: 0x1602D20 Offset: 0x1602120 VA: 0x181602D20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1603720 Offset: 0x1602B20 VA: 0x181603720
	internal bool get_ContainsFaultList() { }

	// RVA: 0x1602880 Offset: 0x1601C80 VA: 0x181602880
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x1603440 Offset: 0x1602840 VA: 0x181603440
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x1602430 Offset: 0x1601830 VA: 0x181602430
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x16033C0 Offset: 0x16027C0 VA: 0x1816033C0
	private void MarkAsUnhandled() { }

	// RVA: 0x1603330 Offset: 0x1602730 VA: 0x181603330
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x1602A00 Offset: 0x1601E00 VA: 0x181602A00
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x1603260 Offset: 0x1602660 VA: 0x181603260
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x1603550 Offset: 0x1602950 VA: 0x181603550
	private static void .cctor() { }

}

