internal struct RegisterGameEvent // TypeDefIndex: 7723
{
	[CompilerGeneratedAttribute] 
	private string <GameId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Event>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <IconId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <ValueOptional>k__BackingField; 

	[JsonPropertyAttribute] 
	public string GameId { get; set; }
	[JsonPropertyAttribute] 
	public string Event { get; set; }
	[JsonPropertyAttribute] 
	public int IconId { get; set; }
	[JsonPropertyAttribute] 
	public bool ValueOptional { get; set; }


	[CompilerGeneratedAttribute] 
	public string get_GameId() { }

	[CompilerGeneratedAttribute] 
	public void set_GameId(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Event() { }

	[CompilerGeneratedAttribute] 
	public void set_Event(string value) { }

	[CompilerGeneratedAttribute] 
	public int get_IconId() { }

	[CompilerGeneratedAttribute] 
	public void set_IconId(int value) { }

	[CompilerGeneratedAttribute] 
	public bool get_ValueOptional() { }

	[CompilerGeneratedAttribute] 
	public void set_ValueOptional(bool value) { }

}

