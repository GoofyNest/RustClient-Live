public class RottingFlies : MonoBehaviour, IClientComponent // TypeDefIndex: 9358
{	// Fields
	public GameObjectRef effect; // 0x18
	public SoundDefinition soundDef; // 0x20
	public Transform rootBone; // 0x28
	[ClientVar] // RVA: 0xE7A70 Offset: 0xE6E70 VA: 0x1800E7A70
	public static bool Hide; // 0x0
	private GameObject particleInstance; // 0x30
	private Sound sound; // 0x38
	private const float maxDistSq = 10000;

	// Methods

	// RVA: 0x4C5260 Offset: 0x4C4660 VA: 0x1804C5260
	private void OnEnable() { }

	// RVA: 0x4C54F0 Offset: 0x4C48F0 VA: 0x1804C54F0
	private void Update() { }

	// RVA: 0x4C50F0 Offset: 0x4C44F0 VA: 0x1804C50F0
	private void OnDisable() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

