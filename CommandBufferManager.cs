public class CommandBufferManager : MonoBehaviour // TypeDefIndex: 10645
{	// Fields
	private Camera _targetCamera; // 0x18
	private Dictionary<int, CommandBufferManager.CommandBufferEntry> commandBuffers; // 0x20
	private bool changed; // 0x28
	public Action OnPreRenderCall; // 0x30
	public Action OnPreCullCall; // 0x38
	private static Dictionary<Camera, CommandBufferManager> instances; // 0x0

	// Properties
	public Camera targetCamera { get; }
	public Camera Camera { get; }
	public bool IsReady { get; }

	// Methods

	// RVA: 0x5977C0 Offset: 0x596BC0 VA: 0x1805977C0
	public Camera get_targetCamera() { }

	// RVA: 0x597740 Offset: 0x596B40 VA: 0x180597740
	public Camera get_Camera() { }

	// RVA: 0x597750 Offset: 0x596B50 VA: 0x180597750
	public bool get_IsReady() { }

	// RVA: 0x597060 Offset: 0x596460 VA: 0x180597060
	public static CommandBufferManager GetInstance(Camera camera) { }

	// RVA: 0x596D90 Offset: 0x596190 VA: 0x180596D90
	private void Awake() { }

	// RVA: 0x5970F0 Offset: 0x5964F0 VA: 0x1805970F0
	private void OnDestroy() { }

	// RVA: 0x597350 Offset: 0x596750 VA: 0x180597350
	private void OnEnable() { }

	// RVA: 0x5971C0 Offset: 0x5965C0 VA: 0x1805971C0
	private void OnDisable() { }

	// RVA: 0x596BD0 Offset: 0x595FD0 VA: 0x180596BD0
	public void AddCommands(CommandBufferDesc desc) { }

	// RVA: 0x597580 Offset: 0x596980 VA: 0x180597580
	public void RemoveCommands(CommandBufferDesc desc) { }

	// RVA: 0x596E20 Offset: 0x596220 VA: 0x180596E20
	private void CheckUpdateCameraEvents() { }

	// RVA: 0x5973E0 Offset: 0x5967E0 VA: 0x1805973E0
	private void OnPreCull() { }

	// RVA: 0x597560 Offset: 0x596960 VA: 0x180597560
	private void OnPreRender() { }

	// RVA: 0x5976D0 Offset: 0x596AD0 VA: 0x1805976D0
	public void .ctor() { }

	// RVA: 0x597670 Offset: 0x596A70 VA: 0x180597670
	private static void .cctor() { }

}

private struct CommandBufferManager.CommandBufferEntry : IEquatable<CommandBufferManager.CommandBufferEntry> // TypeDefIndex: 10646
{	// Fields
	public CommandBuffer buffer; // 0x0
	public List<KeyValuePair<int, Action<CommandBuffer>>> orderedFill; // 0x8

	// Methods

	// RVA: 0xF2E40 Offset: 0xF2240 VA: 0x1800F2E40
	public void Add(int orderId, Action<CommandBuffer> value) { }

	// RVA: 0xF2EA0 Offset: 0xF22A0 VA: 0x1800F2EA0
	public void Remove(int orderId) { }

	// RVA: 0xF2E50 Offset: 0xF2250 VA: 0x1800F2E50
	public bool Contains(int orderId) { }

	// RVA: 0xF2E60 Offset: 0xF2260 VA: 0x1800F2E60 Slot: 4
	public bool Equals(CommandBufferManager.CommandBufferEntry other) { }

	// RVA: 0xF2E70 Offset: 0xF2270 VA: 0x1800F2E70 Slot: 2
	public override int GetHashCode() { }

}

private sealed class CommandBufferManager.CommandBufferEntry.<>c__DisplayClass3_0 // TypeDefIndex: 10647
{	// Fields
	public int orderId; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5A3520 Offset: 0x5A2920 VA: 0x1805A3520
	internal bool <Remove>b__0(KeyValuePair<int, Action<CommandBuffer>> s) { }

}

