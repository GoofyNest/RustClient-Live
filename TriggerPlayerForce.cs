public class TriggerPlayerForce : TriggerBase, IServerComponent // TypeDefIndex: 11753
{
	public BoxCollider triggerCollider; 
	public float pushVelocity; 
	public bool requireUpAxis; 
	private const float HACK_DISABLE_TIME = 4;


	public void .ctor() { }

}

