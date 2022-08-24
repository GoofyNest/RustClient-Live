internal sealed class HeaderChunk : MidiChunk // TypeDefIndex: 7508
{
	[CompilerGeneratedAttribute] 
	private ushort <FileFormat>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TimeDivision <TimeDivision>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ushort <TracksNumber>k__BackingField; 

public ushort FileFormat { get; set; }
public TimeDivision TimeDivision { get; set; }
public ushort TracksNumber { get; set; }


internal void .ctor() { }

	[CompilerGeneratedAttribute] 
public ushort get_FileFormat() { }

	[CompilerGeneratedAttribute] 
public void set_FileFormat(ushort value) { }

	[CompilerGeneratedAttribute] 
public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] 
public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] 
public ushort get_TracksNumber() { }

	[CompilerGeneratedAttribute] 
public void set_TracksNumber(ushort value) { }

public override string ToString() { }

protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

}

