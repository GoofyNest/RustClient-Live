public class Transaction : IDisposable, ISerializable // TypeDefIndex: 3983
{
	[ThreadStaticAttribute] 
	private static Transaction ambient; 
	private IsolationLevel level; 
	private TransactionInformation info; 
	private ArrayList dependents; 
	private List<IEnlistmentNotification> volatiles; 
	private List<ISinglePhaseNotification> durables; 
	private IPromotableSinglePhaseNotification pspe; 
	private bool aborted; 
	private TransactionScope scope; 
	private Exception innerException; 
	private Guid tag; 
	[CompilerGeneratedAttribute] 
	private TransactionCompletedEventHandler TransactionCompleted; 

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

	[MonoTODOAttribute] 
private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

public static Transaction get_Current() { }

internal static Transaction get_CurrentInternal() { }

public TransactionInformation get_TransactionInformation() { }

public void Dispose() { }

	[MonoTODOAttribute] 
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

