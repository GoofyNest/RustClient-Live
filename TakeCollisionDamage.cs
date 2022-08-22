public class TakeCollisionDamage : FacepunchBehaviour // TypeDefIndex: 9752
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseCombatEntity entity; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float minDamage; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxDamage; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float forceForAnyDamage; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float forceForMaxDamage; // 0x2C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float velocityRestorePercent; // 0x30

	private bool IsServer { get; }
	private bool IsClient { get; }


	private bool get_IsServer() { }

	private bool get_IsClient() { }

	public void .ctor() { }

}

