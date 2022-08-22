public class ImpostorRenderer : MonoBehaviour // TypeDefIndex: 10681
{	public const string MainPassName = "DEFERRED";
	private Camera camera; // 0x18
	private static HashSet<ImpostorShadows> Shadows; // 0x0
	private static HashSet<Impostor> Impostors; // 0x8
	private static Dictionary<ImpostorInstanceData, ImpostorBatch> Batches; // 0x10
	private static MaterialPropertyBlock block; // 0x18
	private int treeLayer; // 0x20
	private int treeLayerMask; // 0x24
	private int impostorLayerMask; // 0x28
	private static ImpostorRenderer instance; // 0x20
	private static readonly int NaNProperty; // 0x28
	private static readonly int PositionBufferProperty; // 0x2C

	private Camera Camera { get; }
	public static bool IsSupported { get; }
	public static ImpostorRenderer Instance { get; }


	private Camera get_Camera() { }

	public static bool get_IsSupported() { }

	public static ImpostorRenderer get_Instance() { }

	private void CheckInstance() { }

	public static void Clear() { }

	public static void Register(ImpostorShadows shadows) { }

	public static void Unregister(ImpostorShadows shadows) { }

	public static void Register(Impostor impostor) { }

	public static void Unregister(Impostor impostor) { }

	public static void RegisterBatching(ImpostorInstanceData data) { }

	public static void UnregisterBatching(ImpostorInstanceData data) { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void OnPreCull() { }

	public void .ctor() { }

	private static void .cctor() { }

}

