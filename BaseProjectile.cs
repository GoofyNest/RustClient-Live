public class BaseProjectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6318
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Magazine primaryMagazine; // 0x18

	// Methods

	// RVA: 0x1F60030 Offset: 0x1F5F430 VA: 0x181F60030
	public static void ResetToPool(BaseProjectile instance) { }

	// RVA: 0x1F5FF90 Offset: 0x1F5F390 VA: 0x181F5FF90
	public void ResetToPool() { }

	// RVA: 0x1F5FE30 Offset: 0x1F5F230 VA: 0x181F5FE30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F5F390 Offset: 0x1F5E790 VA: 0x181F5F390
	public void CopyTo(BaseProjectile instance) { }

	// RVA: 0x1F5F400 Offset: 0x1F5E800 VA: 0x181F5F400
	public BaseProjectile Copy() { }

	// RVA: 0x1F5FB90 Offset: 0x1F5EF90 VA: 0x181F5FB90
	public static BaseProjectile Deserialize(Stream stream) { }

	// RVA: 0x1F5F710 Offset: 0x1F5EB10 VA: 0x181F5F710
	public static BaseProjectile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F5F790 Offset: 0x1F5EB90 VA: 0x181F5F790
	public static BaseProjectile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F5FD10 Offset: 0x1F5F110 VA: 0x181F5FD10
	public static BaseProjectile Deserialize(byte[] buffer) { }

	// RVA: 0x1F5FF50 Offset: 0x1F5F350 VA: 0x181F5FF50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F605C0 Offset: 0x1F5F9C0 VA: 0x181F605C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F605E0 Offset: 0x1F5F9E0 VA: 0x181F605E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseProjectile previous) { }

	// RVA: 0x1F5FF70 Offset: 0x1F5F370 VA: 0x181F5FF70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F5FC10 Offset: 0x1F5F010 VA: 0x181F5FC10
	public static BaseProjectile Deserialize(byte[] buffer, BaseProjectile instance, bool isDelta = False) { }

	// RVA: 0x1F5FA30 Offset: 0x1F5EE30 VA: 0x181F5FA30
	public static BaseProjectile Deserialize(Stream stream, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F5F4D0 Offset: 0x1F5E8D0 VA: 0x181F5F4D0
	public static BaseProjectile DeserializeLengthDelimited(Stream stream, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F5F820 Offset: 0x1F5EC20 VA: 0x181F5F820
	public static BaseProjectile DeserializeLength(Stream stream, int length, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F600D0 Offset: 0x1F5F4D0 VA: 0x181F600D0
	public static void SerializeDelta(Stream stream, BaseProjectile instance, BaseProjectile previous) { }

	// RVA: 0x1F60430 Offset: 0x1F5F830 VA: 0x181F60430
	public static void Serialize(Stream stream, BaseProjectile instance) { }

	// RVA: 0x1F605B0 Offset: 0x1F5F9B0 VA: 0x181F605B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F605C0 Offset: 0x1F5F9C0 VA: 0x181F605C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F60320 Offset: 0x1F5F720 VA: 0x181F60320
	public static byte[] SerializeToBytes(BaseProjectile instance) { }

	// RVA: 0x1F60270 Offset: 0x1F5F670 VA: 0x181F60270
	public static void SerializeLengthDelimited(Stream stream, BaseProjectile instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Attack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6483
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 pointStart; // 0x14
	public Vector3 pointEnd; // 0x20
	public uint hitID; // 0x2C
	public uint hitBone; // 0x30
	public Vector3 hitNormalLocal; // 0x34
	public Vector3 hitPositionLocal; // 0x40
	public Vector3 hitNormalWorld; // 0x4C
	public Vector3 hitPositionWorld; // 0x58
	public uint hitPartID; // 0x64
	public uint hitMaterialID; // 0x68
	public uint hitItem; // 0x6C

	// Methods

	// RVA: 0x1FF0C40 Offset: 0x1FF0040 VA: 0x181FF0C40
	public static void ResetToPool(Attack instance) { }

	// RVA: 0x1FF0B10 Offset: 0x1FEFF10 VA: 0x181FF0B10
	public void ResetToPool() { }

	// RVA: 0x1FF05A0 Offset: 0x1FEF9A0 VA: 0x181FF05A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FEE9A0 Offset: 0x1FEDDA0 VA: 0x181FEE9A0
	public void CopyTo(Attack instance) { }

	// RVA: 0x1FEEA40 Offset: 0x1FEDE40 VA: 0x181FEEA40
	public Attack Copy() { }

	// RVA: 0x1FEFD50 Offset: 0x1FEF150 VA: 0x181FEFD50
	public static Attack Deserialize(Stream stream) { }

	// RVA: 0x1FEEFA0 Offset: 0x1FEE3A0 VA: 0x181FEEFA0
	public static Attack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FEF020 Offset: 0x1FEE420 VA: 0x181FEF020
	public static Attack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FEF500 Offset: 0x1FEE900 VA: 0x181FEF500
	public static Attack Deserialize(byte[] buffer) { }

	// RVA: 0x1FF0750 Offset: 0x1FEFB50 VA: 0x181FF0750
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF2030 Offset: 0x1FF1430 VA: 0x181FF2030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF2050 Offset: 0x1FF1450 VA: 0x181FF2050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Attack previous) { }

	// RVA: 0x1FF0AF0 Offset: 0x1FEFEF0 VA: 0x181FF0AF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF0120 Offset: 0x1FEF520 VA: 0x181FF0120
	public static Attack Deserialize(byte[] buffer, Attack instance, bool isDelta = False) { }

	// RVA: 0x1FEF9B0 Offset: 0x1FEEDB0 VA: 0x181FEF9B0
	public static Attack Deserialize(Stream stream, Attack instance, bool isDelta) { }

	// RVA: 0x1FEEB30 Offset: 0x1FEDF30 VA: 0x181FEEB30
	public static Attack DeserializeLengthDelimited(Stream stream, Attack instance, bool isDelta) { }

	// RVA: 0x1FEF0B0 Offset: 0x1FEE4B0 VA: 0x181FEF0B0
	public static Attack DeserializeLength(Stream stream, int length, Attack instance, bool isDelta) { }

	// RVA: 0x1FF0D70 Offset: 0x1FF0170 VA: 0x181FF0D70
	public static void SerializeDelta(Stream stream, Attack instance, Attack previous) { }

	// RVA: 0x1FF1A30 Offset: 0x1FF0E30 VA: 0x181FF1A30
	public static void Serialize(Stream stream, Attack instance) { }

	// RVA: 0x1FF2020 Offset: 0x1FF1420 VA: 0x181FF2020
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF2030 Offset: 0x1FF1430 VA: 0x181FF2030
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF1920 Offset: 0x1FF0D20 VA: 0x181FF1920
	public static byte[] SerializeToBytes(Attack instance) { }

	// RVA: 0x1FF1870 Offset: 0x1FF0C70 VA: 0x181FF1870
	public static void SerializeLengthDelimited(Stream stream, Attack instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ProjectileShoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6488
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int ammoType; // 0x14
	public List<ProjectileShoot.Projectile> projectiles; // 0x18

	// Methods

	// RVA: 0x2044660 Offset: 0x2043A60 VA: 0x182044660
	public static void ResetToPool(ProjectileShoot instance) { }

	// RVA: 0x2044820 Offset: 0x2043C20 VA: 0x182044820
	public void ResetToPool() { }

	// RVA: 0x20445A0 Offset: 0x20439A0 VA: 0x1820445A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2043620 Offset: 0x2042A20 VA: 0x182043620
	public void CopyTo(ProjectileShoot instance) { }

	// RVA: 0x20437D0 Offset: 0x2042BD0 VA: 0x1820437D0
	public ProjectileShoot Copy() { }

	// RVA: 0x20440D0 Offset: 0x20434D0 VA: 0x1820440D0
	public static ProjectileShoot Deserialize(Stream stream) { }

	// RVA: 0x20439D0 Offset: 0x2042DD0 VA: 0x1820439D0
	public static ProjectileShoot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2044040 Offset: 0x2043440 VA: 0x182044040
	public static ProjectileShoot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2044480 Offset: 0x2043880 VA: 0x182044480
	public static ProjectileShoot Deserialize(byte[] buffer) { }

	// RVA: 0x2044620 Offset: 0x2043A20 VA: 0x182044620
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2045010 Offset: 0x2044410 VA: 0x182045010 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2045030 Offset: 0x2044430 VA: 0x182045030 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot previous) { }

	// RVA: 0x2044640 Offset: 0x2043A40 VA: 0x182044640 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2044150 Offset: 0x2043550 VA: 0x182044150
	public static ProjectileShoot Deserialize(byte[] buffer, ProjectileShoot instance, bool isDelta = False) { }

	// RVA: 0x2044250 Offset: 0x2043650 VA: 0x182044250
	public static ProjectileShoot Deserialize(Stream stream, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x2043A50 Offset: 0x2042E50 VA: 0x182043A50
	public static ProjectileShoot DeserializeLengthDelimited(Stream stream, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x2043D60 Offset: 0x2043160 VA: 0x182043D60
	public static ProjectileShoot DeserializeLength(Stream stream, int length, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x20449E0 Offset: 0x2043DE0 VA: 0x1820449E0
	public static void SerializeDelta(Stream stream, ProjectileShoot instance, ProjectileShoot previous) { }

	// RVA: 0x2044DE0 Offset: 0x20441E0 VA: 0x182044DE0
	public static void Serialize(Stream stream, ProjectileShoot instance) { }

	// RVA: 0x2045000 Offset: 0x2044400 VA: 0x182045000
	public byte[] ToProtoBytes() { }

	// RVA: 0x2045010 Offset: 0x2044410 VA: 0x182045010
	public void ToProto(Stream stream) { }

	// RVA: 0x2044CD0 Offset: 0x20440D0 VA: 0x182044CD0
	public static byte[] SerializeToBytes(ProjectileShoot instance) { }

	// RVA: 0x2044C20 Offset: 0x2044020 VA: 0x182044C20
	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ProjectileShoot.Projectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6489
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 startPos; // 0x18
	public Vector3 startVel; // 0x24
	public int seed; // 0x30

	// Methods

	// RVA: 0x2046420 Offset: 0x2045820 VA: 0x182046420
	public static void ResetToPool(ProjectileShoot.Projectile instance) { }

	// RVA: 0x20464D0 Offset: 0x20458D0 VA: 0x1820464D0
	public void ResetToPool() { }

	// RVA: 0x2046180 Offset: 0x2045580 VA: 0x182046180 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2038160 Offset: 0x2037560 VA: 0x182038160
	public void CopyTo(ProjectileShoot.Projectile instance) { }

	// RVA: 0x2045050 Offset: 0x2044450 VA: 0x182045050
	public ProjectileShoot.Projectile Copy() { }

	// RVA: 0x2045C70 Offset: 0x2045070 VA: 0x182045C70
	public static ProjectileShoot.Projectile Deserialize(Stream stream) { }

	// RVA: 0x20450F0 Offset: 0x20444F0 VA: 0x1820450F0
	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2045440 Offset: 0x2044840 VA: 0x182045440
	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2045990 Offset: 0x2044D90 VA: 0x182045990
	public static ProjectileShoot.Projectile Deserialize(byte[] buffer) { }

	// RVA: 0x2046200 Offset: 0x2045600 VA: 0x182046200
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2046E30 Offset: 0x2046230 VA: 0x182046E30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2046E50 Offset: 0x2046250 VA: 0x182046E50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot.Projectile previous) { }

	// RVA: 0x2046400 Offset: 0x2045800 VA: 0x182046400 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2045EB0 Offset: 0x20452B0 VA: 0x182045EB0
	public static ProjectileShoot.Projectile Deserialize(byte[] buffer, ProjectileShoot.Projectile instance, bool isDelta = False) { }

	// RVA: 0x2045780 Offset: 0x2044B80 VA: 0x182045780
	public static ProjectileShoot.Projectile Deserialize(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x2045170 Offset: 0x2044570 VA: 0x182045170
	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x20454D0 Offset: 0x20448D0 VA: 0x1820454D0
	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x2046580 Offset: 0x2045980 VA: 0x182046580
	public static void SerializeDelta(Stream stream, ProjectileShoot.Projectile instance, ProjectileShoot.Projectile previous) { }

	// RVA: 0x2046B90 Offset: 0x2045F90 VA: 0x182046B90
	public static void Serialize(Stream stream, ProjectileShoot.Projectile instance) { }

	// RVA: 0x2046E20 Offset: 0x2046220 VA: 0x182046E20
	public byte[] ToProtoBytes() { }

	// RVA: 0x2046E30 Offset: 0x2046230 VA: 0x182046E30
	public void ToProto(Stream stream) { }

	// RVA: 0x2046A80 Offset: 0x2045E80 VA: 0x182046A80
	public static byte[] SerializeToBytes(ProjectileShoot.Projectile instance) { }

	// RVA: 0x20469D0 Offset: 0x2045DD0 VA: 0x1820469D0
	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BaseProjectile : AttackEntity // TypeDefIndex: 8529
{	// Fields
	[HeaderAttribute] // RVA: 0xA5CC0 Offset: 0xA50C0 VA: 0x1800A5CC0
	public float NoiseRadius; // 0x280
	[HeaderAttribute] // RVA: 0xA70C0 Offset: 0xA64C0 VA: 0x1800A70C0
	public float damageScale; // 0x284
	public float distanceScale; // 0x288
	public float projectileVelocityScale; // 0x28C
	public bool automatic; // 0x290
	public bool usableByTurret; // 0x291
	[TooltipAttribute] // RVA: 0xA70F0 Offset: 0xA64F0 VA: 0x1800A70F0
	public float turretDamageScale; // 0x294
	[HeaderAttribute] // RVA: 0x785E0 Offset: 0x779E0 VA: 0x1800785E0
	public GameObjectRef attackFX; // 0x298
	public GameObjectRef silencedAttack; // 0x2A0
	public GameObjectRef muzzleBrakeAttack; // 0x2A8
	public Transform MuzzlePoint; // 0x2B0
	[HeaderAttribute] // RVA: 0xA7250 Offset: 0xA6650 VA: 0x1800A7250
	public float reloadTime; // 0x2B8
	public bool canUnloadAmmo; // 0x2BC
	public BaseProjectile.Magazine primaryMagazine; // 0x2C0
	public bool fractionalReload; // 0x2C8
	public float reloadStartDuration; // 0x2CC
	public float reloadFractionDuration; // 0x2D0
	public float reloadEndDuration; // 0x2D4
	[HeaderAttribute] // RVA: 0x7BF80 Offset: 0x7B380 VA: 0x18007BF80
	public float aimSway; // 0x2D8
	public float aimSwaySpeed; // 0x2DC
	public RecoilProperties recoil; // 0x2E0
	[HeaderAttribute] // RVA: 0x7C050 Offset: 0x7B450 VA: 0x18007C050
	public AnimationCurve aimconeCurve; // 0x2E8
	public float aimCone; // 0x2F0
	public float hipAimCone; // 0x2F4
	public float aimconePenaltyPerShot; // 0x2F8
	public float aimConePenaltyMax; // 0x2FC
	public float aimconePenaltyRecoverTime; // 0x300
	public float aimconePenaltyRecoverDelay; // 0x304
	public float stancePenaltyScale; // 0x308
	[HeaderAttribute] // RVA: 0xA7350 Offset: 0xA6750 VA: 0x1800A7350
	public bool hasADS; // 0x30C
	public bool noAimingWhileCycling; // 0x30D
	public bool manualCycle; // 0x30E
	protected bool needsCycle; // 0x30F
	protected bool isCycling; // 0x310
	public bool aiming; // 0x311
	public float resetDuration; // 0x314
	public int numShotsFired; // 0x318
	private float nextReloadTime; // 0x31C
	private float startReloadTime; // 0x320
	private float stancePenalty; // 0x324
	private float aimconePenalty; // 0x328
	private uint cachedModHash; // 0x32C
	private float sightAimConeScale; // 0x330
	private float sightAimConeOffset; // 0x334
	private float hipAimConeScale; // 0x338
	private float hipAimConeOffset; // 0x33C
	protected bool isReloading; // 0x340
	private float swaySampleTime; // 0x344
	private float lastShotTime; // 0x348
	public float reloadPressTime; // 0x34C
	private ItemDefinition ammoTypePreReload; // 0x350
	private int fractionalReloadDesiredCount; // 0x358
	private int fractionalReloadNumAdded; // 0x35C
	private bool triggerReady; // 0x360
	private float nextHeightCheckTime; // 0x364
	private bool cachedUnderground; // 0x368
	private List<Projectile> createdProjectiles; // 0x370

	// Properties
	public RecoilProperties recoilProperties { get; }
	public bool isSemiAuto { get; }
	private bool UsingInfiniteAmmoCheat { get; }

	// Methods

	// RVA: 0x905B20 Offset: 0x904F20 VA: 0x180905B20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x907680 Offset: 0x906A80 VA: 0x180907680
	public RecoilProperties get_recoilProperties() { }

	// RVA: 0x903120 Offset: 0x902520 VA: 0x180903120 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x903100 Offset: 0x902500 VA: 0x180903100 Slot: 160
	public virtual float GetDamageScale(bool getMax = False) { }

	// RVA: 0x903110 Offset: 0x902510 VA: 0x180903110 Slot: 161
	public virtual float GetDistanceScale(bool getMax = False) { }

	// RVA: 0x903900 Offset: 0x902D00 VA: 0x180903900 Slot: 162
	public virtual float GetProjectileVelocityScale(bool getMax = False) { }

	// RVA: 0x907300 Offset: 0x906700 VA: 0x180907300
	protected void StartReloadCooldown(float cooldown) { }

	// RVA: 0x906720 Offset: 0x905B20 VA: 0x180906720
	protected void ResetReloadCooldown() { }

	// RVA: 0x904020 Offset: 0x903420 VA: 0x180904020
	protected bool HasReloadCooldown() { }

	// RVA: 0x903920 Offset: 0x902D20 VA: 0x180903920
	protected float GetReloadCooldown() { }

	// RVA: 0x903A80 Offset: 0x902E80 VA: 0x180903A80
	protected float GetReloadIdle() { }

	// RVA: 0x905360 Offset: 0x904760 VA: 0x180905360
	private void OnDrawGizmos() { }

	// RVA: 0x903910 Offset: 0x902D10 VA: 0x180903910 Slot: 163
	public virtual RecoilProperties GetRecoil() { }

	// RVA: 0x907670 Offset: 0x906A70 VA: 0x180907670
	public bool get_isSemiAuto() { }

	// RVA: 0x902610 Offset: 0x901A10 VA: 0x180902610 Slot: 164
	public virtual float GetAimCone() { }

	// RVA: 0x906730 Offset: 0x905B30 VA: 0x180906730
	public float ScaleRepeatDelay(float delay) { }

	// RVA: 0x9032C0 Offset: 0x9026C0 VA: 0x1809032C0
	public Projectile.Modifier GetProjectileModifier() { }

	// RVA: 0x900B00 Offset: 0x8FFF00 VA: 0x180900B00 Slot: 165
	public virtual void DidAttackClientside() { }

	// RVA: 0x903170 Offset: 0x902570 VA: 0x180903170 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x900820 Offset: 0x8FFC20 VA: 0x180900820
	public bool ClientIsReloading() { }

	// RVA: 0x905310 Offset: 0x904710 VA: 0x180905310
	public void NotifySpectatorReloading(bool state) { }

	// RVA: 0x901C10 Offset: 0x901010 VA: 0x180901C10 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x905730 Offset: 0x904B30 VA: 0x180905730 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x906A60 Offset: 0x905E60 VA: 0x180906A60 Slot: 166
	public virtual void ShotFired() { }

	// RVA: 0x906AC0 Offset: 0x905EC0 VA: 0x180906AC0 Slot: 167
	public virtual void SimulateAimcone() { }

	// RVA: 0x900620 Offset: 0x8FFA20 VA: 0x180900620 Slot: 168
	public virtual bool CanAttack() { }

	// RVA: 0x9005F0 Offset: 0x8FF9F0 VA: 0x1809005F0 Slot: 169
	public virtual bool CanAim() { }

	// RVA: 0x905740 Offset: 0x904B40 VA: 0x180905740 Slot: 138
	public override void OnInput() { }

	// RVA: 0x906670 Offset: 0x905A70 VA: 0x180906670
	public bool ReadyToAim() { }

	// RVA: 0x9066C0 Offset: 0x905AC0 VA: 0x1809066C0
	public bool ReadyToFire() { }

	// RVA: 0x9004D0 Offset: 0x8FF8D0 VA: 0x1809004D0
	public void AmmoTypeClicked(ItemDefinition newAmmoType) { }

	// RVA: 0x900320 Offset: 0x8FF720 VA: 0x180900320
	private void AddAmmoOption(ItemDefinition ammo, List<Option> opts, int order = 0) { }

	// RVA: 0x903B00 Offset: 0x902F00 VA: 0x180903B00
	public List<Option> GetReloadMenu(BasePlayer player) { }

	// RVA: 0x9062D0 Offset: 0x9056D0 VA: 0x1809062D0
	private void PredictAmmoType() { }

	// RVA: 0x903D70 Offset: 0x903170 VA: 0x180903D70 Slot: 170
	public virtual bool HasMoreThanOneAmmoType(AmmoTypes ammoType) { }

	// RVA: 0x905320 Offset: 0x904720 VA: 0x180905320 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x901690 Offset: 0x900A90 VA: 0x180901690
	private void DoReload() { }

	// RVA: 0x904050 Offset: 0x903450 VA: 0x180904050
	protected void InsertAmmoFraction() { }

	// RVA: 0x900640 Offset: 0x8FFA40 VA: 0x180900640
	public void CancelFractionalReloading() { }

	// RVA: 0x9006E0 Offset: 0x8FFAE0 VA: 0x1809006E0
	protected void ClientFinishFractionalReload() { }

	// RVA: 0x900830 Offset: 0x8FFC30 VA: 0x180900830
	protected void ClientSingleReload() { }

	// RVA: 0x900BD0 Offset: 0x8FFFD0 VA: 0x180900BD0 Slot: 171
	public virtual void DoAttack() { }

	// RVA: 0x900560 Offset: 0x8FF960 VA: 0x180900560
	public void BeginCycle() { }

	// RVA: 0x905120 Offset: 0x904520 VA: 0x180905120 Slot: 172
	public virtual void LaunchProjectile() { }

	// RVA: 0x901B50 Offset: 0x900F50 VA: 0x180901B50
	public void DryFire() { }

	// RVA: 0x906610 Offset: 0x905A10 VA: 0x180906610 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x906500 Offset: 0x905900 VA: 0x180906500 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x9039A0 Offset: 0x902DA0 VA: 0x1809039A0
	public float GetReloadDuration() { }

	// RVA: 0x902EF0 Offset: 0x9022F0 VA: 0x180902EF0
	public int GetAvailableAmmo() { }

	// RVA: 0x9040B0 Offset: 0x9034B0 VA: 0x1809040B0
	public bool IsSilenced() { }

	// RVA: 0x902580 Offset: 0x901980 VA: 0x180902580
	public bool FiredUnderground() { }

	// RVA: 0x905C10 Offset: 0x905010 VA: 0x180905C10 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x904290 Offset: 0x903690 VA: 0x180904290
	internal void LaunchProjectileClientside(ItemDefinition ammo, int projectileCount, float projSpreadaimCone) { }

	// RVA: 0x900970 Offset: 0x8FFD70 VA: 0x180900970
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	// RVA: 0x907350 Offset: 0x906750 VA: 0x180907350 Slot: 173
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private bool get_UsingInfiniteAmmoCheat() { }

	// RVA: 0x905270 Offset: 0x904670 VA: 0x180905270 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x907400 Offset: 0x906800 VA: 0x180907400
	public void .ctor() { }

}

public class BaseProjectile.Magazine // TypeDefIndex: 8530
{	// Fields
	public BaseProjectile.Magazine.Definition definition; // 0x10
	public int capacity; // 0x18
	public int contents; // 0x1C
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition ammoType; // 0x20

	// Methods

	// RVA: 0x919D50 Offset: 0x919150 VA: 0x180919D50
	public void ServerInit() { }

	// RVA: 0x919C80 Offset: 0x919080 VA: 0x180919C80
	public Magazine Save() { }

	// RVA: 0x919C30 Offset: 0x919030 VA: 0x180919C30
	public void Load(Magazine mag) { }

	// RVA: 0x919BF0 Offset: 0x918FF0 VA: 0x180919BF0
	public bool CanReload(BasePlayer owner) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public struct BaseProjectile.Magazine.Definition // TypeDefIndex: 8531
{	// Fields
	[TooltipAttribute] // RVA: 0xA7500 Offset: 0xA6900 VA: 0x1800A7500
	public int builtInSize; // 0x0
	[TooltipAttribute] // RVA: 0xA7830 Offset: 0xA6C30 VA: 0x1800A7830
	[InspectorFlagsAttribute] // RVA: 0xA7830 Offset: 0xA6C30 VA: 0x1800A7830
	public AmmoTypes ammoTypes; // 0x4

}

private sealed class BaseProjectile.<>c // TypeDefIndex: 8532
{	// Fields
	public static readonly BaseProjectile.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_0; // 0x8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_1; // 0x10
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_2; // 0x18
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_3; // 0x20
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_4; // 0x28
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_5; // 0x30
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_6; // 0x38
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_7; // 0x40
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__64_0; // 0x48
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__64_1; // 0x50
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__64_2; // 0x58
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__64_3; // 0x60
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__65_0; // 0x68
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__65_1; // 0x70
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__65_2; // 0x78
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__65_3; // 0x80
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__65_4; // 0x88
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__65_5; // 0x90
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__65_6; // 0x98
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__65_7; // 0xA0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_0; // 0xA8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_1; // 0xB0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_2; // 0xB8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_3; // 0xC0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_4; // 0xC8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_5; // 0xD0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_6; // 0xD8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_7; // 0xE0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__76_0; // 0xE8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__76_1; // 0xF0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__76_2; // 0xF8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__76_3; // 0x100
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__98_0; // 0x108
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__98_1; // 0x110
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__98_2; // 0x118
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__98_3; // 0x120
	public static Func<ProjectileWeaponMod, bool> <>9__110_0; // 0x128
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__112_0; // 0x130
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__112_1; // 0x138
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__112_2; // 0x140
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__112_3; // 0x148

	// Methods

	// RVA: 0x91A890 Offset: 0x919C90 VA: 0x18091A890
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x91A580 Offset: 0x919980 VA: 0x18091A580
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_0(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <GetAimCone>b__63_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A580 Offset: 0x919980 VA: 0x18091A580
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_2(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <GetAimCone>b__63_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A5B0 Offset: 0x9199B0 VA: 0x18091A5B0
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_4(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <GetAimCone>b__63_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A5B0 Offset: 0x9199B0 VA: 0x18091A5B0
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_6(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <GetAimCone>b__63_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A710 Offset: 0x919B10 VA: 0x18091A710
	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_0(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <ScaleRepeatDelay>b__64_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A710 Offset: 0x919B10 VA: 0x18091A710
	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_2(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <ScaleRepeatDelay>b__64_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A5E0 Offset: 0x9199E0 VA: 0x18091A5E0
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_0(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <GetProjectileModifier>b__65_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A5E0 Offset: 0x9199E0 VA: 0x18091A5E0
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_2(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <GetProjectileModifier>b__65_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A610 Offset: 0x919A10 VA: 0x18091A610
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_4(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <GetProjectileModifier>b__65_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A610 Offset: 0x919A10 VA: 0x18091A610
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_6(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <GetProjectileModifier>b__65_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A520 Offset: 0x919920 VA: 0x18091A520
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_0(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <EditViewAngles>b__72_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A520 Offset: 0x919920 VA: 0x18091A520
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_2(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <EditViewAngles>b__72_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A550 Offset: 0x919950 VA: 0x18091A550
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_4(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <EditViewAngles>b__72_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A550 Offset: 0x919950 VA: 0x18091A550
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_6(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <EditViewAngles>b__72_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A4C0 Offset: 0x9198C0 VA: 0x18091A4C0
	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_0(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <SimulateAimcone>b__76_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A4C0 Offset: 0x9198C0 VA: 0x18091A4C0
	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_2(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <SimulateAimcone>b__76_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A4C0 Offset: 0x9198C0 VA: 0x18091A4C0
	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_0(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <DoAttack>b__98_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A4C0 Offset: 0x9198C0 VA: 0x18091A4C0
	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_2(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <DoAttack>b__98_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A6B0 Offset: 0x919AB0 VA: 0x18091A6B0
	internal bool <OnSignal>b__110_0(ProjectileWeaponMod x) { }

	// RVA: 0x91A640 Offset: 0x919A40 VA: 0x18091A640
	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_0(ProjectileWeaponMod x) { }

	// RVA: 0x91A4F0 Offset: 0x9198F0 VA: 0x18091A4F0
	internal float <LaunchProjectileClientside>b__112_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x91A640 Offset: 0x919A40 VA: 0x18091A640
	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_2(ProjectileWeaponMod x) { }

	// RVA: 0x91A500 Offset: 0x919900 VA: 0x18091A500
	internal float <LaunchProjectileClientside>b__112_3(ProjectileWeaponMod.Modifier y) { }

}

private sealed class BaseProjectile.<>c__DisplayClass84_0 // TypeDefIndex: 8533
{	// Fields
	public BaseProjectile <>4__this; // 0x10
	public ItemDefinition ammoType; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x91A7F0 Offset: 0x919BF0 VA: 0x18091A7F0
	internal void <AddAmmoOption>b__0(BasePlayer ply) { }

}

public class Projectile : BaseMonoBehaviour // TypeDefIndex: 9222
{	// Fields
	public const float moveDeltaTime = 0,03125;
	public const float lifeTime = 8;
	[HeaderAttribute] // RVA: 0xDA1B0 Offset: 0xD95B0 VA: 0x1800DA1B0
	public Vector3 initialVelocity; // 0x18
	public float drag; // 0x24
	public float gravityModifier; // 0x28
	public float thickness; // 0x2C
	[TooltipAttribute] // RVA: 0xDA3B0 Offset: 0xD97B0 VA: 0x1800DA3B0
	public float initialDistance; // 0x30
	[HeaderAttribute] // RVA: 0xDA530 Offset: 0xD9930 VA: 0x1800DA530
	public bool remainInWorld; // 0x34
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float stickProbability; // 0x38
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float breakProbability; // 0x3C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float conditionLoss; // 0x40
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float ricochetChance; // 0x44
	public float penetrationPower; // 0x48
	[HeaderAttribute] // RVA: 0xCB4E0 Offset: 0xCA8E0 VA: 0x1800CB4E0
	public DamageProperties damageProperties; // 0x50
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public MinMax damageDistances; // 0x58
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public MinMax damageMultipliers; // 0x60
	public List<DamageTypeEntry> damageTypes; // 0x68
	[HeaderAttribute] // RVA: 0xDAAB0 Offset: 0xD9EB0 VA: 0x1800DAAB0
	public ScaleRenderer rendererToScale; // 0x70
	public ScaleRenderer firstPersonRenderer; // 0x78
	public bool createDecals; // 0x80
	[HeaderAttribute] // RVA: 0x785E0 Offset: 0x779E0 VA: 0x1800785E0
	public bool doDefaultHitEffects; // 0x81
	[HeaderAttribute] // RVA: 0x71F00 Offset: 0x71300 VA: 0x180071F00
	public SoundDefinition flybySound; // 0x88
	public float flybySoundDistance; // 0x90
	public SoundDefinition closeFlybySound; // 0x98
	public float closeFlybyDistance; // 0xA0
	[HeaderAttribute] // RVA: 0xDAD50 Offset: 0xDA150 VA: 0x1800DAD50
	public float tumbleSpeed; // 0xA4
	public Vector3 tumbleAxis; // 0xA8
	[HeaderAttribute] // RVA: 0xDAEC0 Offset: 0xDA2C0 VA: 0x1800DAEC0
	public Vector3 swimScale; // 0xB4
	public Vector3 swimSpeed; // 0xC0
	public BasePlayer owner; // 0xD0
	public AttackEntity sourceWeaponPrefab; // 0xD8
	public Projectile sourceProjectilePrefab; // 0xE0
	public ItemModProjectile mod; // 0xE8
	public int projectileID; // 0xF0
	public int seed; // 0xF4
	public bool clientsideEffect; // 0xF8
	public bool clientsideAttack; // 0xF9
	public float integrity; // 0xFC
	public float maxDistance; // 0x100
	public Projectile.Modifier modifier; // 0x104
	public bool invisible; // 0x114
	private Vector3 currentVelocity; // 0x118
	private Vector3 currentPosition; // 0x124
	private float traveledDistance; // 0x130
	private float traveledTime; // 0x134
	private float launchTime; // 0x138
	private Vector3 sentPosition; // 0x13C
	private Vector3 previousPosition; // 0x148
	private Vector3 previousVelocity; // 0x154
	private float previousTraveledTime; // 0x160
	private bool isRicochet; // 0x164
	private bool isRetiring; // 0x165
	private bool flybyPlayed; // 0x166
	private bool wasFacingPlayer; // 0x167
	private Plane flybyPlane; // 0x168
	private Ray flybyRay; // 0x178
	private Action cleanupAction; // 0x190
	private HitTest hitTest; // 0x198
	private float swimRandom; // 0x1A0
	private static uint _fleshMaterialID; // 0x0
	private static uint _waterMaterialID; // 0x4
	private static uint cachedWaterString; // 0x8

	// Properties
	public bool isAuthoritative { get; }
	private bool isAlive { get; }

	// Methods

	// RVA: 0x693D50 Offset: 0x693150 VA: 0x180693D50
	public void CalculateDamage(HitInfo info, Projectile.Modifier mod, float scale) { }

	// RVA: 0x698B00 Offset: 0x697F00 VA: 0x180698B00
	public bool get_isAuthoritative() { }

	// RVA: 0x698AC0 Offset: 0x697EC0 VA: 0x180698AC0
	private bool get_isAlive() { }

	// RVA: 0x6978B0 Offset: 0x696CB0 VA: 0x1806978B0
	private void Retire() { }

	// RVA: 0x6942A0 Offset: 0x6936A0 VA: 0x1806942A0
	private void Cleanup() { }

	// RVA: 0x693AE0 Offset: 0x692EE0 VA: 0x180693AE0
	public void AdjustVelocity(Vector3 delta) { }

	// RVA: 0x696AF0 Offset: 0x695EF0 VA: 0x180696AF0
	public void InitializeVelocity(Vector3 overrideVel) { }

	// RVA: 0x696D60 Offset: 0x696160 VA: 0x180696D60
	protected void OnDisable() { }

	// RVA: 0x698720 Offset: 0x697B20 VA: 0x180698720
	protected void Update() { }

	// RVA: 0x697E80 Offset: 0x697280 VA: 0x180697E80
	private void SetEffectScale(float eScale) { }

	// RVA: 0x6944A0 Offset: 0x6938A0 VA: 0x1806944A0
	private void DoFlybySound() { }

	// RVA: 0x694200 Offset: 0x693600 VA: 0x180694200 Slot: 6
	protected virtual float CalculateEffectScale() { }

	// RVA: 0x698440 Offset: 0x697840 VA: 0x180698440
	private void UpdateVelocity(float deltaTime) { }

	// RVA: 0x696300 Offset: 0x695700 VA: 0x180696300
	private void DoVelocityUpdate(float deltaTime) { }

	// RVA: 0x6951C0 Offset: 0x6945C0 VA: 0x1806951C0
	private void DoMovement(float deltaTime) { }

	// RVA: 0x6966E0 Offset: 0x695AE0 VA: 0x1806966E0
	private bool DoWaterHit(ref HitTest test, Vector3 targetPosition) { }

	// RVA: 0x695EE0 Offset: 0x6952E0 VA: 0x180695EE0
	private bool DoRicochet(HitTest test, Vector3 point, Vector3 normal) { }

	// RVA: 0x694AB0 Offset: 0x693EB0 VA: 0x180694AB0
	private bool DoHit(HitTest test, Vector3 point, Vector3 normal) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	protected virtual void AdditiveImpactEffect(HitInfo info) { }

	// RVA: 0x697030 Offset: 0x696430 VA: 0x180697030
	private bool Reflect(ref uint seed, Vector3 point, Vector3 normal) { }

	// RVA: 0x697380 Offset: 0x696780 VA: 0x180697380
	private bool Refract(ref uint seed, Vector3 point, Vector3 normal, float resistance) { }

	// RVA: 0x697750 Offset: 0x696B50 VA: 0x180697750
	private Vector3 Refract(Vector3 v, Vector3 n, float f) { }

	// RVA: 0x696F30 Offset: 0x696330 VA: 0x180696F30
	private Quaternion RandomRotation(ref uint seed, float range) { }

	// RVA: 0x696CD0 Offset: 0x6960D0 VA: 0x180696CD0
	internal void Launch() { }

	// RVA: 0x6969F0 Offset: 0x695DF0 VA: 0x1806969F0
	public static uint FleshMaterialID() { }

	// RVA: 0x698820 Offset: 0x697C20 VA: 0x180698820
	public static uint WaterMaterialID() { }

	// RVA: 0x696BA0 Offset: 0x695FA0 VA: 0x180696BA0
	public static bool IsWaterMaterial(string hitMaterial) { }

	// RVA: 0x698380 Offset: 0x697780 VA: 0x180698380
	public static bool ShouldStopProjectile(RaycastHit hit) { }

	// RVA: 0x698920 Offset: 0x697D20 VA: 0x180698920
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public struct Projectile.Modifier // TypeDefIndex: 9223
{	// Fields
	public float damageScale; // 0x0
	public float damageOffset; // 0x4
	public float distanceScale; // 0x8
	public float distanceOffset; // 0xC
	public static Projectile.Modifier Default; // 0x0

	// Methods

	// RVA: 0x690AD0 Offset: 0x68FED0 VA: 0x180690AD0
	private static void .cctor() { }

}

public class ProjectileTestSpawner : MonoBehaviour // TypeDefIndex: 9322
{	// Fields
	public Projectile TargetProjectile; // 0x18
	public float RepeatTime; // 0x20
	public float VelocityScale; // 0x24

	// Methods

	// RVA: 0x692610 Offset: 0x691A10 VA: 0x180692610
	public void .ctor() { }

}

public class AttackTickAIEvent : BaseAIEvent // TypeDefIndex: 9390
{	// Methods

	// RVA: 0x833270 Offset: 0x832670 VA: 0x180833270
	public void .ctor() { }

}

public class AttackedAIEvent : BaseAIEvent // TypeDefIndex: 9391
{	// Fields
	protected float lastExecuteTime; // 0x40
	private BaseCombatEntity combatEntity; // 0x48

	// Methods

	// RVA: 0x8332A0 Offset: 0x8326A0 VA: 0x1808332A0
	public void .ctor() { }

}

public class AttackEntity : HeldEntity // TypeDefIndex: 9459
{	// Fields
	[HeaderAttribute] // RVA: 0x71440 Offset: 0x70840 VA: 0x180071440
	public float deployDelay; // 0x1F8
	public float repeatDelay; // 0x1FC
	public float animationDelay; // 0x200
	[HeaderAttribute] // RVA: 0x715C0 Offset: 0x709C0 VA: 0x1800715C0
	public float effectiveRange; // 0x204
	public float npcDamageScale; // 0x208
	public float attackLengthMin; // 0x20C
	public float attackLengthMax; // 0x210
	public float attackSpacing; // 0x214
	public float aiAimSwayOffset; // 0x218
	public float aiAimCone; // 0x21C
	public bool aiOnlyInRange; // 0x220
	public float CloseRangeAddition; // 0x224
	public float MediumRangeAddition; // 0x228
	public float LongRangeAddition; // 0x22C
	public bool CanUseAtMediumRange; // 0x230
	public bool CanUseAtLongRange; // 0x231
	public SoundDefinition[] reloadSounds; // 0x238
	public SoundDefinition thirdPersonMeleeSound; // 0x240
	[HeaderAttribute] // RVA: 0x716D0 Offset: 0x70AD0 VA: 0x1800716D0
	public float recoilCompDelayOverride; // 0x248
	public bool wantsRecoilComp; // 0x24C
	private float nextAttackTime; // 0x250
	private float lastTickTime; // 0x254
	private float nextTickTime; // 0x258
	private float timeSinceDeploy; // 0x25C
	public static Vector3 reductionSpeedScalars; // 0x0
	private float lastRecoilCompTime; // 0x260
	private Vector3 startAimingDirection; // 0x264
	private bool wasDoingRecoilComp; // 0x270
	private Vector3 reductionSpeed; // 0x274

	// Properties
	public float NextAttackTime { get; }

	// Methods

	// RVA: 0x832D30 Offset: 0x832130 VA: 0x180832D30 Slot: 157
	public virtual Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x833260 Offset: 0x832660 VA: 0x180833260
	public float get_NextAttackTime() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 158
	public virtual void GetAttackStats(HitInfo info) { }

	// RVA: 0x832FA0 Offset: 0x8323A0 VA: 0x180832FA0
	protected void StartAttackCooldownRaw(float cooldown) { }

	// RVA: 0x832FD0 Offset: 0x8323D0 VA: 0x180832FD0
	protected void StartAttackCooldown(float cooldown) { }

	// RVA: 0x832F40 Offset: 0x832340 VA: 0x180832F40
	protected void ResetAttackCooldown() { }

	// RVA: 0x832DA0 Offset: 0x8321A0 VA: 0x180832DA0
	public bool HasAttackCooldown() { }

	// RVA: 0x832C30 Offset: 0x832030 VA: 0x180832C30
	protected float GetAttackCooldown() { }

	// RVA: 0x832CB0 Offset: 0x8320B0 VA: 0x180832CB0
	protected float GetAttackIdle() { }

	// RVA: 0x832060 Offset: 0x831460 VA: 0x180832060
	protected float CalculateCooldownTime(float nextTime, float cooldown, bool catchup) { }

	// RVA: 0x832DD0 Offset: 0x8321D0 VA: 0x180832DD0 Slot: 159
	public virtual bool IsFullyDeployed() { }

	// RVA: 0x832E70 Offset: 0x832270 VA: 0x180832E70
	protected void ProcessInputTime() { }

	// RVA: 0x832E10 Offset: 0x832210 VA: 0x180832E10 Slot: 138
	public override void OnInput() { }

	// RVA: 0x832DF0 Offset: 0x8321F0 VA: 0x180832DF0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x832F50 Offset: 0x832350 VA: 0x180832F50
	public void SpectatorNotifyDeploy() { }

	// RVA: 0x832F60 Offset: 0x832360 VA: 0x180832F60
	public void SpectatorNotifyTick() { }

	// RVA: 0x832EC0 Offset: 0x8322C0 VA: 0x180832EC0
	public bool RecoilCompReady() { }

	// RVA: 0x831EB0 Offset: 0x8312B0 VA: 0x180831EB0 Slot: 131
	public override void AddPunch(Vector3 amount, float duration) { }

	// RVA: 0x8321A0 Offset: 0x8315A0 VA: 0x1808321A0 Slot: 132
	public override void DoRecoilCompensation() { }

	// RVA: 0x833170 Offset: 0x832570 VA: 0x180833170
	public void .ctor() { }

	// RVA: 0x833100 Offset: 0x832500 VA: 0x180833100
	private static void .cctor() { }

}

public class ProjectileWeaponMod : BaseEntity // TypeDefIndex: 9625
{	// Fields
	[HeaderAttribute] // RVA: 0x7BDA0 Offset: 0x7B1A0 VA: 0x18007BDA0
	public GameObjectRef defaultSilencerEffect; // 0x168
	public bool isSilencer; // 0x170
	[HeaderAttribute] // RVA: 0x7BEF0 Offset: 0x7B2F0 VA: 0x18007BEF0
	public ProjectileWeaponMod.Modifier repeatDelay; // 0x174
	public ProjectileWeaponMod.Modifier projectileVelocity; // 0x180
	public ProjectileWeaponMod.Modifier projectileDamage; // 0x18C
	public ProjectileWeaponMod.Modifier projectileDistance; // 0x198
	[HeaderAttribute] // RVA: 0x7BF80 Offset: 0x7B380 VA: 0x18007BF80
	public ProjectileWeaponMod.Modifier aimsway; // 0x1A4
	public ProjectileWeaponMod.Modifier aimswaySpeed; // 0x1B0
	public ProjectileWeaponMod.Modifier recoil; // 0x1BC
	[HeaderAttribute] // RVA: 0x7C050 Offset: 0x7B450 VA: 0x18007C050
	public ProjectileWeaponMod.Modifier sightAimCone; // 0x1C8
	public ProjectileWeaponMod.Modifier hipAimCone; // 0x1D4
	[HeaderAttribute] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	public bool isLight; // 0x1E0
	[HeaderAttribute] // RVA: 0x7C2F0 Offset: 0x7B6F0 VA: 0x18007C2F0
	public bool isMuzzleBrake; // 0x1E1
	[HeaderAttribute] // RVA: 0x7C430 Offset: 0x7B830 VA: 0x18007C430
	public bool isMuzzleBoost; // 0x1E2
	[HeaderAttribute] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	public bool isScope; // 0x1E3
	public float zoomAmountDisplayOnly; // 0x1E4
	[HeaderAttribute] // RVA: 0x7C6C0 Offset: 0x7BAC0 VA: 0x18007C6C0
	public ProjectileWeaponMod.Modifier magazineCapacity; // 0x1E8
	public bool needsOnForEffects; // 0x1F4

	// Methods

	// RVA: 0x6938D0 Offset: 0x692CD0 VA: 0x1806938D0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x6939A0 Offset: 0x692DA0 VA: 0x1806939A0 Slot: 131
	public virtual void SetAiming(bool isAiming) { }

	// RVA: 0x693340 Offset: 0x692740 VA: 0x180693340
	public float GetZoomAmount() { }

	// RVA: 0x6936F0 Offset: 0x692AF0 VA: 0x1806936F0
	public static float Mult(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x6939E0 Offset: 0x692DE0 VA: 0x1806939E0
	public static float Sum(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693080 Offset: 0x692480 VA: 0x180693080
	public static float Average(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x6935B0 Offset: 0x6929B0 VA: 0x1806935B0
	public static float Max(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693650 Offset: 0x692A50 VA: 0x180693650
	public static float Min(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693120 Offset: 0x692520 VA: 0x180693120
	public static IEnumerable<float> GetMods(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value) { }

	// RVA: 0x693480 Offset: 0x692880 VA: 0x180693480
	public static bool HasBrokenWeaponMod(BaseEntity parentEnt) { }

	// RVA: 0x693A80 Offset: 0x692E80 VA: 0x180693A80
	public void .ctor() { }

}

public struct ProjectileWeaponMod.Modifier // TypeDefIndex: 9626
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0x7C720 Offset: 0x7BB20 VA: 0x18007C720
	public float scalar; // 0x4
	[TooltipAttribute] // RVA: 0x7C850 Offset: 0x7BC50 VA: 0x18007C850
	public float offset; // 0x8

}

private sealed class ProjectileWeaponMod.<>c // TypeDefIndex: 9627
{	// Fields
	public static readonly ProjectileWeaponMod.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__27_0; // 0x8
	public static Func<ProjectileWeaponMod.Modifier, bool> <>9__27_1; // 0x10
	public static Func<ProjectileWeaponMod, bool> <>9__28_0; // 0x18

	// Methods

	// RVA: 0x6AC910 Offset: 0x6ABD10 VA: 0x1806AC910
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6AC780 Offset: 0x6ABB80 VA: 0x1806AC780
	internal bool <GetMods>b__27_0(ProjectileWeaponMod x) { }

	// RVA: 0x6AC810 Offset: 0x6ABC10 VA: 0x1806AC810
	internal bool <GetMods>b__27_1(ProjectileWeaponMod.Modifier x) { }

	// RVA: 0x6AC820 Offset: 0x6ABC20 VA: 0x1806AC820
	internal bool <HasBrokenWeaponMod>b__28_0(ProjectileWeaponMod x) { }

}

public class AttackTickEventUI : BaseEventUI // TypeDefIndex: 10786
{	// Methods

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class AttackedEventUI : BaseEventUI // TypeDefIndex: 10787
{	// Methods

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class ProjectileWeaponInformationPanel : ItemInformationPanel // TypeDefIndex: 11042
{	// Fields
	public ItemStatValue damageDisplay; // 0x18
	public ItemStatValue recoilDisplay; // 0x20
	public ItemStatValue rofDisplay; // 0x28
	public ItemStatValue accuracyDisplay; // 0x30
	public ItemStatValue rangeDisplay; // 0x38

	// Methods

	// RVA: 0x692630 Offset: 0x691A30 VA: 0x180692630 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x692720 Offset: 0x691B20 VA: 0x180692720 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

