public class Transaction : IDisposable, ISerializable // TypeDefIndex: 3983
{	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Transaction ambient; // 0x80000000
	private IsolationLevel level; // 0x10
	private TransactionInformation info; // 0x18
	private ArrayList dependents; // 0x20
	private List<IEnlistmentNotification> volatiles; // 0x28
	private List<ISinglePhaseNotification> durables; // 0x30
	private IPromotableSinglePhaseNotification pspe; // 0x38
	private bool aborted; // 0x40
	private TransactionScope scope; // 0x48
	private Exception innerException; // 0x50
	private Guid tag; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TransactionCompletedEventHandler TransactionCompleted; // 0x68

	internal List<IEnlistmentNotification> Volatiles { get; }
	internal List<ISinglePhaseNotification> Durables { get; }
	public static Transaction Current { get; }
	internal static Transaction CurrentInternal { get; }
	public TransactionInformation TransactionInformation { get; }
	private bool Aborted { set; }
	internal TransactionScope Scope { get; }


	internal List<IEnlistmentNotification> get_Volatiles() { }

	internal List<ISinglePhaseNotification> get_Durables() { }

	internal void .ctor() { }

	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public static Transaction get_Current() { }

	internal static Transaction get_CurrentInternal() { }

	public TransactionInformation get_TransactionInformation() { }

	public void Dispose() { }

	[MonoTODOAttribute] // RVA: 0xA7EF0 Offset: 0xA72F0 VA: 0x1800A7EF0
	public Enlistment EnlistVolatile(IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions) { }

	private Enlistment EnlistVolatileInternal(IEnlistmentNotification notification, EnlistmentOptions options) { }

	public override bool Equals(object obj) { }

	private bool Equals(Transaction t) { }

	public static bool op_Equality(Transaction x, Transaction y) { }

	public static bool op_Inequality(Transaction x, Transaction y) { }

	public override int GetHashCode() { }

	public void Rollback() { }

	public void Rollback(Exception e) { }

	internal void Rollback(Exception ex, object abortingEnlisted) { }

	private void set_Aborted(bool value) { }

	internal TransactionScope get_Scope() { }

	private void FireCompleted() { }

	private static void EnsureIncompleteCurrentScope() { }

}

