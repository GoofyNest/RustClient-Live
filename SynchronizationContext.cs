public class SynchronizationContext // TypeDefIndex: 793
{
	private SynchronizationContextProperties _props; 
	private static Type s_cachedPreparedType1; 
	private static Type s_cachedPreparedType2; 
	private static Type s_cachedPreparedType3; 
	private static Type s_cachedPreparedType4; 
	private static Type s_cachedPreparedType5; 

public static SynchronizationContext Current { get; }
internal static SynchronizationContext CurrentNoFlow { get; }


public void .ctor() { }

public virtual void Send(SendOrPostCallback d, object state) { }

public virtual void Post(SendOrPostCallback d, object state) { }

public virtual void OperationStarted() { }

public virtual void OperationCompleted() { }

public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

public static SynchronizationContext get_Current() { }

	[FriendAccessAllowedAttribute] 
internal static SynchronizationContext get_CurrentNoFlow() { }

private static SynchronizationContext GetThreadLocalContext() { }

public virtual SynchronizationContext CreateCopy() { }

}

