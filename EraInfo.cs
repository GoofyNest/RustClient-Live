internal class EraInfo // TypeDefIndex: 703
{
	internal int era; 
	internal long ticks; 
	internal int yearOffset; 
	internal int minEraYear; 
	internal int maxEraYear; 
	[OptionalFieldAttribute] 
	internal string eraName; 
	[OptionalFieldAttribute] 
	internal string abbrevEraName; 
	[OptionalFieldAttribute] 
	internal string englishEraName; 


	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

