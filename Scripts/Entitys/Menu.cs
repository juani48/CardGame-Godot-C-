using Godot;
using System;

public partial class Menu : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Button playButton = GetNode<Button>("PlayButton");
		playButton.Pressed += () => _ChangeScene();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _ChangeScene(){
		GetTree().ChangeSceneToFile("res://Entitys/Godot_Escene/Play_Escene.tscn");
		
	}
}
