public class MovementSounds : MonoBehaviour, IOnParentDestroying, ISoundBudgetedUpdate // TypeDefIndex: 10227
{	public SoundDefinition waterMovementDef; // 0x18
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


	public void OnParentDestroying() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void DoUpdate() { }

	public void UpdateVelocity(Vector3 velocity) { }

	public bool IsSyncedToParent() { }

	public void .ctor() { }

}

