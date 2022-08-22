public class TriggerPlayerForce : TriggerBase, IServerComponent // TypeDefIndex: 10040
{	public BoxCollider triggerCollider; // 0x30
	public float pushVelocity; // 0x38
	public bool requireUpAxis; // 0x3C
	private const float HACK_DISABLE_TIME = 4;


	public void .ctor() { }

}

