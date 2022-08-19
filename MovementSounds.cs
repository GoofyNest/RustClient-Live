public class MovementSounds : MonoBehaviour, IOnParentDestroying, ISoundBudgetedUpdate // TypeDefIndex: 10227
{	// Fields
	public SoundDefinition waterMovementDef; // 0x18
	public float waterMovementFadeInSpeed; // 0x20
	public float waterMovementFadeOutSpeed; // 0x24
	public SoundDefinition enterWaterSmall; // 0x28
	public SoundDefinition enterWaterMedium; // 0x30
	public SoundDefinition enterWaterLarge; // 0x38
	private Sound waterMovement; // 0x40
	private SoundModulation.Modulator waterGainMod; // 0x48
	public bool inWater; // 0x50
	public float waterLevel; // 0x54
	public bool mute; // 0x58
	private BaseEntity ent; // 0x60
	private Vector3 velocity; // 0x68
	private int velocityReadings; // 0x74
	private float movementYSmoothed; // 0x78
	private bool wasInWater; // 0x7C
	private float lastTime; // 0x80

	// Methods

	// RVA: 0x7BAC30 Offset: 0x7BA030 VA: 0x1807BAC30 Slot: 4
	public void OnParentDestroying() { }

	// RVA: 0x7BABF0 Offset: 0x7B9FF0 VA: 0x1807BABF0
	protected void OnEnable() { }

	// RVA: 0x7BAB80 Offset: 0x7B9F80 VA: 0x1807BAB80
	protected void OnDisable() { }

	// RVA: 0x7BA590 Offset: 0x7B9990 VA: 0x1807BA590 Slot: 5
	public void DoUpdate() { }

	// RVA: 0x7BAC70 Offset: 0x7BA070 VA: 0x1807BAC70
	public void UpdateVelocity(Vector3 velocity) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 6
	public bool IsSyncedToParent() { }

	// RVA: 0x692610 Offset: 0x691A10 VA: 0x180692610
	public void .ctor() { }

}

