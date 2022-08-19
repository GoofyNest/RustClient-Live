public class SoundOcclusion : MonoBehaviour // TypeDefIndex: 9038
{	// Fields
	public LayerMask occlusionLayerMask; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isOccluded>k__BackingField; // 0x1C
	private float occlusionAmount; // 0x20
	private Sound sound; // 0x28
	private OnePoleLowpassFilter lowpass; // 0x30
	private SoundModulation.Modulator gainMod; // 0x38
	private Vector3 soundOffset; // 0x40
	private float lastOcclusionCheck; // 0x4C
	private float occlusionCheckInterval; // 0x50
	private Ray ray; // 0x54
	private List<RaycastHit> hits; // 0x70

	// Properties
	public bool isOccluded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DD0 Offset: 0x7E81D0 VA: 0x1807E8DD0
	public bool get_isOccluded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E40 Offset: 0x7E8240 VA: 0x1807E8E40
	private void set_isOccluded(bool value) { }

	// RVA: 0xA754E0 Offset: 0xA748E0 VA: 0x180A754E0
	public void Awake() { }

	// RVA: 0xA75B80 Offset: 0xA74F80 VA: 0x180A75B80
	public void Init() { }

	// RVA: 0xA75CA0 Offset: 0xA750A0 VA: 0x180A75CA0
	public void UpdateOcclusion(bool lerp = False) { }

	// RVA: 0xA75550 Offset: 0xA74950 VA: 0x180A75550
	public void DoOcclusionCheck() { }

	// RVA: 0xA75F90 Offset: 0xA75390 VA: 0x180A75F90
	public void .ctor() { }

}

