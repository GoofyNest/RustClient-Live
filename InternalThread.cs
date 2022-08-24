internal sealed class InternalThread : CriticalFinalizerObject // TypeDefIndex: 831
{
	private int lock_thread_id; 
	private IntPtr handle; 
	private IntPtr native_handle; 
	private IntPtr unused3; 
	private IntPtr name; 
	private int name_len; 
	private ThreadState state; 
	private object abort_exc; 
	private int abort_state_handle; 
	internal long thread_id; 
	private IntPtr debugger_thread; 
	private UIntPtr static_data; 
	private IntPtr runtime_thread_info; 
	private object current_appcontext; 
	private object root_domain_thread; 
	internal byte[] _serialized_principal; 
	internal int _serialized_principal_version; 
	private IntPtr appdomain_refs; 
	private int interruption_requested; 
	private IntPtr synch_cs; 
	internal bool threadpool_thread; 
	private bool thread_interrupt_requested; 
	internal int stack_size; 
	internal byte apartment_state; 
	internal int critical_region_level; 
	internal int managed_id; 
	private int small_id; 
	private IntPtr manage_callback; 
	private IntPtr unused4; 
	private IntPtr flags; 
	private IntPtr thread_pinning_ref; 
	private IntPtr abort_protected_block_count; 
	private int priority; 
	private IntPtr owned_mutex; 
	private IntPtr suspended_event; 
	private int self_suspended; 
	private IntPtr unused1; 
	private IntPtr unused2; 
	private IntPtr last; 


private void Thread_free_internal() { }

	[ReliabilityContractAttribute] 
protected override void Finalize() { }

public void .ctor() { }

}

