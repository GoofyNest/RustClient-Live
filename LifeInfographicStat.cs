public class LifeInfographicStat : MonoBehaviour // TypeDefIndex: 11072
{	public LifeInfographicStat.DataType dataSource; // 0x18
	[HeaderAttribute] // RVA: 0x94B40 Offset: 0x93F40 VA: 0x180094B40
	public string genericStatKey; // 0x20
	[HeaderAttribute] // RVA: 0x94BD0 Offset: 0x93FD0 VA: 0x180094BD0
	public string targetWeaponName; // 0x28
	public LifeInfographicStat.WeaponInfoType weaponInfoType; // 0x30
	public TextMeshProUGUI targetText; // 0x38
	public Image StatImage; // 0x40
	private LifeInfographic cachedInfographic; // 0x48


	private string GetText() { }

	private void OnEnable() { }

	public virtual void InfographicUpdated() { }

	public void SetStatImage(Sprite sprite) { }

	public void .ctor() { }

}

public enum LifeInfographicStat.DataType // TypeDefIndex: 11073
{	public int value__; // 0x0
	public const LifeInfographicStat.DataType None = 0;
	public const LifeInfographicStat.DataType AliveTime_Short = 1;
	public const LifeInfographicStat.DataType SleepingTime_Short = 2;
	public const LifeInfographicStat.DataType KillerName = 3;
	public const LifeInfographicStat.DataType KillerWeapon = 4;
	public const LifeInfographicStat.DataType AliveTime_Long = 5;
	public const LifeInfographicStat.DataType KillerDistance = 6;
	public const LifeInfographicStat.DataType GenericStat = 7;
	public const LifeInfographicStat.DataType DistanceTravelledWalk = 8;
	public const LifeInfographicStat.DataType DistanceTravelledRun = 9;
	public const LifeInfographicStat.DataType DamageTaken = 10;
	public const LifeInfographicStat.DataType DamageHealed = 11;
	public const LifeInfographicStat.DataType WeaponInfo = 12;
	public const LifeInfographicStat.DataType SecondsWilderness = 13;
	public const LifeInfographicStat.DataType SecondsSwimming = 14;
	public const LifeInfographicStat.DataType SecondsInBase = 15;
	public const LifeInfographicStat.DataType SecondsInMonument = 16;
	public const LifeInfographicStat.DataType SecondsFlying = 17;
	public const LifeInfographicStat.DataType SecondsBoating = 18;
	public const LifeInfographicStat.DataType PlayersKilled = 19;
	public const LifeInfographicStat.DataType ScientistsKilled = 20;
	public const LifeInfographicStat.DataType AnimalsKilled = 21;
	public const LifeInfographicStat.DataType SecondsDriving = 22;

}

public enum LifeInfographicStat.WeaponInfoType // TypeDefIndex: 11074
{	public int value__; // 0x0
	public const LifeInfographicStat.WeaponInfoType TotalShots = 0;
	public const LifeInfographicStat.WeaponInfoType ShotsHit = 1;
	public const LifeInfographicStat.WeaponInfoType ShotsMissed = 2;
	public const LifeInfographicStat.WeaponInfoType AccuracyPercentage = 3;

}

