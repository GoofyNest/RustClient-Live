public class CommandBufferDesc // TypeDefIndex: 12362
{
	[CompilerGeneratedAttribute] 
	private CameraEvent <CameraEvent>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <OrderId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<CommandBuffer> <FillDelegate>k__BackingField; 

	public CameraEvent CameraEvent { get; set; }
	public int OrderId { get; set; }
	public Action<CommandBuffer> FillDelegate { get; set; }


	[CompilerGeneratedAttribute] 
	public CameraEvent get_CameraEvent() { }

	[CompilerGeneratedAttribute] 
	private void set_CameraEvent(CameraEvent value) { }

	[CompilerGeneratedAttribute] 
	public int get_OrderId() { }

	[CompilerGeneratedAttribute] 
	private void set_OrderId(int value) { }

	[CompilerGeneratedAttribute] 
	public Action<CommandBuffer> get_FillDelegate() { }

	[CompilerGeneratedAttribute] 
	private void set_FillDelegate(Action<CommandBuffer> value) { }

	public void .ctor(CameraEvent cameraEvent, int orderId, CommandBufferDesc.FillCommandBuffer fill) { }

}

public sealed class CommandBufferDesc.FillCommandBuffer : MulticastDelegate // TypeDefIndex: 12363
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(CommandBuffer cb) { }

	public virtual IAsyncResult BeginInvoke(CommandBuffer cb, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

