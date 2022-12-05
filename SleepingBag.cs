public class SleepingBag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6325
{
	public bool ShouldPool;
	private bool _disposed;
	public string name;
	public ulong deployerID;


	public static void ResetToPool(SleepingBag instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SleepingBag instance) { }

	public SleepingBag Copy() { }

	public static SleepingBag Deserialize(Stream stream) { }

	public static SleepingBag DeserializeLengthDelimited(Stream stream) { }

	public static SleepingBag DeserializeLength(Stream stream, int length) { }

	public static SleepingBag Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SleepingBag previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SleepingBag Deserialize(byte[] buffer, SleepingBag instance, bool isDelta = False) { }

	public static SleepingBag Deserialize(Stream stream, SleepingBag instance, bool isDelta) { }

	public static SleepingBag DeserializeLengthDelimited(Stream stream, SleepingBag instance, bool isDelta) { }

	public static SleepingBag DeserializeLength(Stream stream, int length, SleepingBag instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SleepingBag instance, SleepingBag previous) { }

	public static void Serialize(Stream stream, SleepingBag instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SleepingBag instance) { }

	public static void SerializeLengthDelimited(Stream stream, SleepingBag instance) { }

	public void .ctor() { }

}

public class SleepingBag : DecayEntity // TypeDefIndex: 10167
{
	private Option __menuOption_Menu_AssignToFriend;
	private Option __menuOption_Menu_CloseDoor;
	private Option __menuOption_Menu_MakeBed;
	private Option __menuOption_Menu_MakePrivate;
	private Option __menuOption_Menu_MakePublic;
	public ulong deployerUserID;
	public GameObject renameDialog;
	public GameObject assignDialog;
	public float secondsBetweenReuses;
	public string niceName;
	public Vector3 spawnOffset;
	public RespawnInformation.SpawnOptions.RespawnType RespawnType;
	public bool isStatic;
	public bool canBePublic;
	public const BaseEntity.Flags IsPublicFlag = 512;
	public static Translate.Phrase bagLimitPhrase;
	public static Translate.Phrase bagLimitReachedPhrase;
	public Translate.Phrase assignOtherBagPhrase;
	public Translate.Phrase assignedBagPhrase;
	public Translate.Phrase cannotAssignBedPhrase;
	public Translate.Phrase cannotMakeBedPhrase;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPublic() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void ClientRename(string newName) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void Menu_CloseDoor(BasePlayer player) { }

	public virtual bool CanRename_Test(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void Menu_AssignToFriend(BasePlayer player) { }

	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void Menu_MakePublic(BasePlayer player) { }

	public bool Menu_MakePublic_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void Menu_MakePrivate(BasePlayer player) { }

	public virtual bool Menu_MakePrivate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void Menu_MakeBed(BasePlayer player) { }

	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	public override bool CanPickup(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute]
	private void <Menu_AssignToFriend>

}

