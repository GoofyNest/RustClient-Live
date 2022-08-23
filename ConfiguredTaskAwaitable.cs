public struct ConfiguredTaskAwaitable // TypeDefIndex: 1292
{	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x0


	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { }

}

public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1293
{	private readonly Task m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x8

	public bool IsCompleted { get; }


	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	public bool get_IsCompleted() { }

	public void OnCompleted(Action continuation) { }

	public void UnsafeOnCompleted(Action continuation) { }

	public void GetResult() { }

}

public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1295
{	private readonly Task<TResult> m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x0

	public bool IsCompleted { get; }


	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>..ctor
	*/

	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.get_IsCompleted
	*/

	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.OnCompleted
	*/

	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	*/

	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.GetResult
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.GetResult
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.GetResult
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.GetResult
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.GetResult
	|
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.GetResult
	*/

}

