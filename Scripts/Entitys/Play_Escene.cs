using Godot;
using System;

public partial class Play_Escene : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var drawButton = GetNode<Button>("DrawButton");
		drawButton.Pressed += _DrawCard;
	}

	private void _DrawCard(){
		GetNode<Player_Hand>("PlayerHand").DrawCard();
	}

}
