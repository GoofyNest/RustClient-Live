public sealed class MidiTimeCodeEvent : SystemCommonEvent // TypeDefIndex: 7535
{
	private static readonly Dictionary<MidiTimeCodeComponent, byte> ComponentValueMasks; 
	[CompilerGeneratedAttribute] 
	private MidiTimeCodeComponent <Component>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private FourBitNumber <ComponentValue>k__BackingField; 

	public MidiTimeCodeComponent Component { get; set; }
	public FourBitNumber ComponentValue { get; set; }


	public void .ctor() { }

	public void .ctor(MidiTimeCodeComponent component, FourBitNumber componentValue) { }

	[CompilerGeneratedAttribute] 
	public MidiTimeCodeComponent get_Component() { }

	[CompilerGeneratedAttribute] 
	public void set_Component(MidiTimeCodeComponent value) { }

	[CompilerGeneratedAttribute] 
	public FourBitNumber get_ComponentValue() { }

	[CompilerGeneratedAttribute] 
	public void set_ComponentValue(FourBitNumber value) { }

	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

	private static void .cctor() { }

}

