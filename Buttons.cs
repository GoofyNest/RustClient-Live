public class Buttons // TypeDefIndex: 9270
{
	[ClientVar] 
	public static Buttons.ConButton Console; 
	[ClientVar] 
	public static Buttons.ConButton Forward; 
	[ClientVar] 
	public static Buttons.ConButton Backward; 
	[ClientVar] 
	public static Buttons.ConButton Left; 
	[ClientVar] 
	public static Buttons.ConButton Right; 
	[ClientVar] 
	public static Buttons.ConButton Jump; 
	[ClientVar] 
	public static Buttons.ConButton Duck; 
	[ClientVar] 
	public static Buttons.ConButton Sprint; 
	[ClientVar] 
	public static Buttons.ConButton Use; 
	[ClientVar] 
	public static Buttons.ConButton Inventory; 
	[ClientVar] 
	public static Buttons.ConButton Chat; 
	[ClientVar] 
	public static Buttons.ConButton Reload; 
	[ClientVar] 
	public static Buttons.ConButton Voice; 
	[ClientVar] 
	public static Buttons.ConButton DropItemStack; 
	[ClientVar] 
	public static Buttons.ConButton DropItemSingle; 
	[ClientVar] 
	public static Buttons.ConButton HoverLoot; 
	[ClientVar] 
	public static Buttons.ConButton AutoWalk; 
	[ClientVar] 
	public static Buttons.ConButton InvNext; 
	[ClientVar] 
	public static Buttons.ConButton InvPrev; 
	[ClientVar] 
	public static Buttons.ConButton Slot1; 
	[ClientVar] 
	public static Buttons.ConButton Slot2; 
	[ClientVar] 
	public static Buttons.ConButton Slot3; 
	[ClientVar] 
	public static Buttons.ConButton Slot4; 
	[ClientVar] 
	public static Buttons.ConButton Slot5; 
	[ClientVar] 
	public static Buttons.ConButton Slot6; 
	[ClientVar] 
	public static Buttons.ConButton HolsterItem; 
	[ClientVar] 
	public static Buttons.ConButton Attack; 
	[ClientVar] 
	public static Buttons.ConButton Attack2; 
	[ClientVar] 
	public static Buttons.ConButton Attack3; 
	[ClientVar] 
	public static Buttons.ConButton AltLook; 
	[ClientVar] 
	public static Buttons.ConButton Map; 
	[ClientVar] 
	public static Buttons.ConButton FocusMap; 
	[ClientVar] 
	public static Buttons.ConButton Compass; 
	[ClientVar] 
	public static Buttons.ConButton NoteA; 
	[ClientVar] 
	public static Buttons.ConButton NoteB; 
	[ClientVar] 
	public static Buttons.ConButton NoteC; 
	[ClientVar] 
	public static Buttons.ConButton NoteD; 
	[ClientVar] 
	public static Buttons.ConButton NoteE; 
	[ClientVar] 
	public static Buttons.ConButton NoteF; 
	[ClientVar] 
	public static Buttons.ConButton NoteG; 
	[ClientVar] 
	public static Buttons.ConButton NoteASharp; 
	[ClientVar] 
	public static Buttons.ConButton NoteBSharp; 
	[ClientVar] 
	public static Buttons.ConButton NoteCSharp; 
	[ClientVar] 
	public static Buttons.ConButton NoteDSharp; 
	[ClientVar] 
	public static Buttons.ConButton NoteESharp; 
	[ClientVar] 
	public static Buttons.ConButton NoteFSharp; 
	[ClientVar] 
	public static Buttons.ConButton NoteGSharp; 
	[ClientVar] 
	public static Buttons.ConButton NoteSharpMod; 
	[ClientVar] 
	public static Buttons.ConButton NoteOctaveUpMod; 
	[ClientVar] 
	public static Buttons.ConButton Gestures; 
	[ClientVar] 
	public static Buttons.ConButton Pets; 


	public void .ctor() { }

	private static void .cctor() { }

}

public class Buttons.ConButton : ConsoleSystem.IConsoleButton // TypeDefIndex: 9271
{
	[CompilerGeneratedAttribute] 
	private bool <IsDown>k__BackingField; 
	private int frame; 

	public bool IsDown { get; set; }
	public bool JustPressed { get; }
	public bool JustReleased { get; }
	public bool IsPressed { get; set; }


	[CompilerGeneratedAttribute] 
	public bool get_IsDown() { }

	[CompilerGeneratedAttribute] 
	public void set_IsDown(bool value) { }

	public bool get_JustPressed() { }

	public bool get_JustReleased() { }

	public void Call(ConsoleSystem.Arg arg) { }

	public bool get_IsPressed() { }

	public void set_IsPressed(bool value) { }

	public void .ctor() { }

}

