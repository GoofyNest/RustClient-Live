public class ImpostorRenderer : MonoBehaviour // TypeDefIndex: 10681
{	// Fields
	public const string MainPassName = "DEFERRED";
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

	// Properties
	private Camera Camera { get; }
	public static bool IsSupported { get; }
	public static ImpostorRenderer Instance { get; }

	// Methods

	// RVA: 0x80FA90 Offset: 0x80EE90 VA: 0x18080FA90
	private Camera get_Camera() { }

	// RVA: 0x80FB90 Offset: 0x80EF90 VA: 0x18080FB90
	public static bool get_IsSupported() { }

	// RVA: 0x80FB30 Offset: 0x80EF30 VA: 0x18080FB30
	public static ImpostorRenderer get_Instance() { }

	// RVA: 0x80E1A0 Offset: 0x80D5A0 VA: 0x18080E1A0
	private void CheckInstance() { }

	// RVA: 0x80E2A0 Offset: 0x80D6A0 VA: 0x18080E2A0
	public static void Clear() { }

	// RVA: 0x80F490 Offset: 0x80E890 VA: 0x18080F490
	public static void Register(ImpostorShadows shadows) { }

	// RVA: 0x80F7C0 Offset: 0x80EBC0 VA: 0x18080F7C0
	public static void Unregister(ImpostorShadows shadows) { }

	// RVA: 0x80F540 Offset: 0x80E940 VA: 0x18080F540
	public static void Register(Impostor impostor) { }

	// RVA: 0x80F870 Offset: 0x80EC70 VA: 0x18080F870
	public static void Unregister(Impostor impostor) { }

	// RVA: 0x80F250 Offset: 0x80E650 VA: 0x18080F250
	public static void RegisterBatching(ImpostorInstanceData data) { }

	// RVA: 0x80F620 Offset: 0x80EA20 VA: 0x18080F620
	public static void UnregisterBatching(ImpostorInstanceData data) { }

	// RVA: 0x80E120 Offset: 0x80D520 VA: 0x18080E120
	private void Awake() { }

	// RVA: 0x80E800 Offset: 0x80DC00 VA: 0x18080E800
	private void OnEnable() { }

	// RVA: 0x80E7B0 Offset: 0x80DBB0 VA: 0x18080E7B0
	private void OnDisable() { }

	// RVA: 0x80E990 Offset: 0x80DD90 VA: 0x18080E990
	public void OnPreCull() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x80F950 Offset: 0x80ED50 VA: 0x18080F950
	private static void .cctor() { }

}

