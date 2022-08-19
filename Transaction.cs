public class Transaction : IDisposable, ISerializable // TypeDefIndex: 3983
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	internal List<IEnlistmentNotification> Volatiles { get; }
	internal List<ISinglePhaseNotification> Durables { get; }
	public static Transaction Current { get; }
	internal static Transaction CurrentInternal { get; }
	public TransactionInformation TransactionInformation { get; }
	private bool Aborted { set; }
	internal TransactionScope Scope { get; }

	// Methods

	// RVA: 0x2308660 Offset: 0x2307A60 VA: 0x182308660
	internal List<IEnlistmentNotification> get_Volatiles() { }

	// RVA: 0x23085D0 Offset: 0x23079D0 VA: 0x1823085D0
	internal List<ISinglePhaseNotification> get_Durables() { }

	// RVA: 0x23083B0 Offset: 0x23077B0 VA: 0x1823083B0
	internal void .ctor() { }

	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2308360 Offset: 0x2307760 VA: 0x182308360 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2308590 Offset: 0x2307990 VA: 0x182308590
	public static Transaction get_Current() { }

	// RVA: 0x2308550 Offset: 0x2307950 VA: 0x182308550
	internal static Transaction get_CurrentInternal() { }

	// RVA: 0x2308640 Offset: 0x2307A40 VA: 0x182308640
	public TransactionInformation get_TransactionInformation() { }

	// RVA: 0x2307B60 Offset: 0x2306F60 VA: 0x182307B60 Slot: 4
	public void Dispose() { }

	[MonoTODOAttribute] // RVA: 0xA7EF0 Offset: 0xA72F0 VA: 0x1800A7EF0
	// RVA: 0x2307BB0 Offset: 0x2306FB0 VA: 0x182307BB0
	public Enlistment EnlistVolatile(IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions) { }

	// RVA: 0x2307BB0 Offset: 0x2306FB0 VA: 0x182307BB0
	private Enlistment EnlistVolatileInternal(IEnlistmentNotification notification, EnlistmentOptions options) { }

	// RVA: 0x2307DD0 Offset: 0x23071D0 VA: 0x182307DD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2307DA0 Offset: 0x23071A0 VA: 0x182307DA0
	private bool Equals(Transaction t) { }

	// RVA: 0x23086D0 Offset: 0x2307AD0 VA: 0x1823086D0
	public static bool op_Equality(Transaction x, Transaction y) { }

	// RVA: 0x2308700 Offset: 0x2307B00 VA: 0x182308700
	public static bool op_Inequality(Transaction x, Transaction y) { }

	// RVA: 0x2307F40 Offset: 0x2307340 VA: 0x182307F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2307FF0 Offset: 0x23073F0 VA: 0x182307FF0
	public void Rollback() { }

	// RVA: 0x2307FB0 Offset: 0x23073B0 VA: 0x182307FB0
	public void Rollback(Exception e) { }

	// RVA: 0x2308020 Offset: 0x2307420 VA: 0x182308020
	internal void Rollback(Exception ex, object abortingEnlisted) { }

	// RVA: 0x2308730 Offset: 0x2307B30 VA: 0x182308730
	private void set_Aborted(bool value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal TransactionScope get_Scope() { }

	// RVA: 0x2307E80 Offset: 0x2307280 VA: 0x182307E80
	private void FireCompleted() { }

	// RVA: 0x2307C90 Offset: 0x2307090 VA: 0x182307C90
	private static void EnsureIncompleteCurrentScope() { }

}

