public class RegionInfo // TypeDefIndex: 746
{
	private static RegionInfo currentRegion;
	private int regionId;
	private string iso2Name;
	private string iso3Name;
	private string win3Name;
	private string englishName;
	private string nativeName;
	private string currencySymbol;
	private string isoCurrencySymbol;
	private string currencyEnglishName;
	private string currencyNativeName;

	public static RegionInfo CurrentRegion { get; }
	[ComVisibleAttribute]
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODOAttribute]
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisibleAttribute]
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisibleAttribute]
	public virtual string NativeName { get; }
	[ComVisibleAttribute]
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }


	public static RegionInfo get_CurrentRegion() { }

	public void .ctor(int culture) { }

	public void .ctor(string name) { }

	private void .ctor(CultureInfo ci) { }

	private bool GetByTerritory(CultureInfo ci) { }

	private bool construct_internal_region_from_name(string name) { }

	public virtual string get_CurrencyEnglishName() { }

	public virtual string get_CurrencySymbol() { }

	public virtual string get_DisplayName() { }

	public virtual string get_EnglishName() { }

	public virtual int get_GeoId() { }

	public virtual bool get_IsMetric() { }

	public virtual string get_ISOCurrencySymbol() { }

	public virtual string get_NativeName() { }

	public virtual string get_CurrencyNativeName() { }

	public virtual string get_Name() { }

	public virtual string get_ThreeLetterISORegionName() { }

	public virtual string get_ThreeLetterWindowsRegionName() { }

	public virtual string get_TwoLetterISORegionName() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	internal static void ClearCachedData() { }

}

