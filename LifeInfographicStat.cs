public class LifeInfographicStat : MonoBehaviour // TypeDefIndex: 12806
{
	public LifeInfographicStat.DataType dataSource; 
	[HeaderAttribute] 
	public string genericStatKey; 
	[HeaderAttribute] 
	public string targetWeaponName; 
	public LifeInfographicStat.WeaponInfoType weaponInfoType; 
	public TextMeshProUGUI targetText; 
	public Image StatImage; 
	private LifeInfographic cachedInfographic; 


	private string GetText() { }

	private void OnEnable() { }

	public virtual void InfographicUpdated() { }

	public void SetStatImage(Sprite sprite) { }

	public void .ctor() { }

}

public enum LifeInfographicStat.DataType // TypeDefIndex: 12807
{
	public int value__; 
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

public enum LifeInfographicStat.WeaponInfoType // TypeDefIndex: 12808
{
	public int value__; 
	public const LifeInfographicStat.WeaponInfoType TotalShots = 0;
	public const LifeInfographicStat.WeaponInfoType ShotsHit = 1;
	public const LifeInfographicStat.WeaponInfoType ShotsMissed = 2;
	public const LifeInfographicStat.WeaponInfoType AccuracyPercentage = 3;

}

