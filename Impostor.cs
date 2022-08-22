public class Impostor : MonoBehaviour, IClientComponent // TypeDefIndex: 10676
{	public ImpostorAsset asset; // 0x18
	[HeaderAttribute] // RVA: 0xF06E0 Offset: 0xEFAE0 VA: 0x1800F06E0
	public GameObject reference; // 0x20
	public float angle; // 0x28
	public int resolution; // 0x2C
	public int padding; // 0x30
	public bool spriteOutlineAsMesh; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ImpostorInstanceData <InstanceData>k__BackingField; // 0x38
	public bool keepTrying; // 0x40

	public ImpostorInstanceData InstanceData { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ImpostorInstanceData get_InstanceData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_InstanceData(ImpostorInstanceData value) { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void InitializeInstanceData() { }

	public void UpdateInstance() { }

	public void .ctor() { }

}

