public class RidableHorse : BaseRidableAnimal // TypeDefIndex: 8635
{	[ServerVar] // RVA: 0xB4180 Offset: 0xB3580 VA: 0x1800B4180
	public static float Population; // 0x0
	public string distanceStatName; // 0x6E8
	public HorseBreed[] breeds; // 0x6F0
	public SkinnedMeshRenderer[] bodyRenderers; // 0x6F8
	public SkinnedMeshRenderer[] hairRenderers; // 0x700
	private int currentBreed; // 0x708
	private ProtectionProperties riderProtection; // 0x710
	private ProtectionProperties baseHorseProtection; // 0x718
	public const BaseEntity.Flags Flag_HideHair = 1024;
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float equipmentSpeedMod; // 0x720
	private int numStorageSlots; // 0x724
	private static Material[] breedAssignmentArray; // 0x8
	private float clientRecievedRunSpeed; // 0x728

	public override float RealisticMass { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int GetStorageSlotCount() { }

	public override float get_RealisticMass() { }

	public void ApplyBreed(int index) { }

	protected void ApplyBreedInternal(HorseBreed breed) { }

	public HorseBreed GetBreed() { }

	public override float GetTrotSpeed() { }

	public override float GetRunSpeed() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void GetDistanceTravelled(BaseEntity.RPCMessage msg) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	public void .ctor() { }

	private static void .cctor() { }

}

