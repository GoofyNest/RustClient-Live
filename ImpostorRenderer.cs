public class ImpostorRenderer : MonoBehaviour // TypeDefIndex: 12440
{
	public const string MainPassName = "DEFERRED";
	private Camera camera;
	private static HashSet<ImpostorShadows> Shadows;
	private static HashSet<Impostor> Impostors;
	private static Dictionary<ImpostorInstanceData, ImpostorBatch> Batches;
	private static MaterialPropertyBlock block;
	private int treeLayer;
	private int treeLayerMask;
	private int impostorLayerMask;
	private static ImpostorRenderer instance;
	private static readonly int NaNProperty;
	private static readonly int PositionBufferProperty;

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

