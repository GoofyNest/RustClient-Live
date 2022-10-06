public class RidableHorse : BaseRidableAnimal // TypeDefIndex: 10343
{
	[ServerVar] 
	public static float Population; 
	public string distanceStatName; 
	public HorseBreed[] breeds; 
	public SkinnedMeshRenderer[] bodyRenderers; 
	public SkinnedMeshRenderer[] hairRenderers; 
	private int currentBreed; 
	private ProtectionProperties riderProtection; 
	private ProtectionProperties baseHorseProtection; 
	public const BaseEntity.Flags Flag_HideHair = 1024;
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float equipmentSpeedMod; 
	private int numStorageSlots; 
	private static Material[] breedAssignmentArray; 
	private float clientRecievedRunSpeed; 

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

	[BaseEntity.RPC_Client] 
	public void GetDistanceTravelled(BaseEntity.RPCMessage msg) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	public void .ctor() { }

	private static void .cctor() { }

}

