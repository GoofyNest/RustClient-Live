public class CommandBufferManager : MonoBehaviour // TypeDefIndex: 10645
{
	private Camera _targetCamera; 
	private Dictionary<int, CommandBufferManager.CommandBufferEntry> commandBuffers; 
	private bool changed; 
	public Action OnPreRenderCall; 
	public Action OnPreCullCall; 
	private static Dictionary<Camera, CommandBufferManager> instances; 

	public Camera targetCamera { get; }
	public Camera Camera { get; }
	public bool IsReady { get; }


	public Camera get_targetCamera() { }

	public Camera get_Camera() { }

	public bool get_IsReady() { }

	public static CommandBufferManager GetInstance(Camera camera) { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void AddCommands(CommandBufferDesc desc) { }

	public void RemoveCommands(CommandBufferDesc desc) { }

	private void CheckUpdateCameraEvents() { }

	private void OnPreCull() { }

	private void OnPreRender() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct CommandBufferManager.CommandBufferEntry : IEquatable<CommandBufferManager.CommandBufferEntry> // TypeDefIndex: 10646
{
	public CommandBuffer buffer; 
	public List<KeyValuePair<int, Action<CommandBuffer>>> orderedFill; 


	public void Add(int orderId, Action<CommandBuffer> value) { }

	public void Remove(int orderId) { }

	public bool Contains(int orderId) { }

	public bool Equals(CommandBufferManager.CommandBufferEntry other) { }

	public override int GetHashCode() { }

}

private sealed class CommandBufferManager.CommandBufferEntry.<>c__DisplayClass3_0 // TypeDefIndex: 10647
{
	public int orderId; 


	public void .ctor() { }

	internal bool <Remove>b__0(KeyValuePair<int, Action<CommandBuffer>> s) { }

}

