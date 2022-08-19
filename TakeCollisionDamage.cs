public class TakeCollisionDamage : FacepunchBehaviour // TypeDefIndex: 9752
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	private bool IsServer { get; }
	private bool IsClient { get; }

	// Methods

	// RVA: 0x7A67E0 Offset: 0x7A5BE0 VA: 0x1807A67E0
	private bool get_IsServer() { }

	// RVA: 0x7A67C0 Offset: 0x7A5BC0 VA: 0x1807A67C0
	private bool get_IsClient() { }

	// RVA: 0x7A6790 Offset: 0x7A5B90 VA: 0x1807A6790
	public void .ctor() { }

}

