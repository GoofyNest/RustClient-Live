public class Impostor : MonoBehaviour, IClientComponent // TypeDefIndex: 10676
{	// Fields
	public ImpostorAsset asset; // 0x18
	[HeaderAttribute] // RVA: 0xF06E0 Offset: 0xEFAE0 VA: 0x1800F06E0
	public GameObject reference; // 0x20
	public float angle; // 0x28
	public int resolution; // 0x2C
	public int padding; // 0x30
	public bool spriteOutlineAsMesh; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ImpostorInstanceData <InstanceData>k__BackingField; // 0x38
	public bool keepTrying; // 0x40

	// Properties
	public ImpostorInstanceData InstanceData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public ImpostorInstanceData get_InstanceData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	private void set_InstanceData(ImpostorInstanceData value) { }

	// RVA: 0x8100D0 Offset: 0x80F4D0 VA: 0x1808100D0
	private void Awake() { }

	// RVA: 0x810830 Offset: 0x80FC30 VA: 0x180810830
	private void OnEnable() { }

	// RVA: 0x810700 Offset: 0x80FB00 VA: 0x180810700
	private void OnDisable() { }

	// RVA: 0x8100E0 Offset: 0x80F4E0 VA: 0x1808100E0
	private void InitializeInstanceData() { }

	// RVA: 0x810960 Offset: 0x80FD60 VA: 0x180810960
	public void UpdateInstance() { }

	// RVA: 0x810980 Offset: 0x80FD80 VA: 0x180810980
	public void .ctor() { }

}

