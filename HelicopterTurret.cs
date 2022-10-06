public class HelicopterTurret : MonoBehaviour // TypeDefIndex: 11310
{
	public PatrolHelicopterAI _heliAI; 
	public float fireRate; 
	public float burstLength; 
	public float timeBetweenBursts; 
	public float maxTargetRange; 
	public float loseTargetAfter; 
	public Transform gun_yaw; 
	public Transform gun_pitch; 
	public Transform muzzleTransform; 
	public bool left; 
	public BaseCombatEntity _target; 


	public void .ctor() { }

}

