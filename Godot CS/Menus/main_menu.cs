using Godot;
using System;
using System.IO;

public partial class main_menu : Control
{
    PackedScene mainLevel = GD.Load<PackedScene>("res://Scenes/main_game.tscn");


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{

    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_start_button_button_down()
	{
		GetTree().ChangeSceneToPacked(mainLevel);
        GD.Print("Glorp!");
	}

	private void _on_exit_button_button_down()
	{
		GD.Print("Nope!");
		GetTree().Quit();
	}
}
