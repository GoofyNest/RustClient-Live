public class TakeCollisionDamage : FacepunchBehaviour // TypeDefIndex: 11495
{
	[SerializeField]
	private BaseCombatEntity entity;
	[SerializeField]
	private float minDamage;
	[SerializeField]
	private float maxDamage;
	[SerializeField]
	private float forceForAnyDamage;
	[SerializeField]
	private float forceForMaxDamage;
	[SerializeField]
	private float velocityRestorePercent;

	private bool IsServer { get; }
	private bool IsClient { get; }


	private bool get_IsServer() { }

	private bool get_IsClient() { }

	public void .ctor() { }

}

