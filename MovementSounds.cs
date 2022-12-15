public class MovementSounds : MonoBehaviour, IOnParentDestroying, ISoundBudgetedUpdate // TypeDefIndex: 11992
{
	public SoundDefinition waterMovementDef;
	public float waterMovementFadeInSpeed;
	public float waterMovementFadeOutSpeed;
	public SoundDefinition enterWaterSmall;
	public SoundDefinition enterWaterMedium;
	public SoundDefinition enterWaterLarge;
	private Sound waterMovement;
	private SoundModulation.Modulator waterGainMod;
	public bool inWater;
	public float waterLevel;
	public bool mute;
	private BaseEntity ent;
	private Vector3 velocity;
	private int velocityReadings;
	private float movementYSmoothed;
	private bool wasInWater;
	private float lastTime;


	public void OnParentDestroying() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void DoUpdate() { }

	public void UpdateVelocity(Vector3 velocity) { }

	public bool IsSyncedToParent() { }

	public void .ctor() { }

}

