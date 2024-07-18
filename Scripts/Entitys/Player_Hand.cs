using Card_Game_C;
using Godot;
using System;
using System.Collections.Generic;

public partial class Player_Hand : Node2D
{
	private readonly PackedScene _resourceCard = (PackedScene)ResourceLoader.Load("Entitys//Godot_Escene//Ui_Card.tscn");

	private HBoxContainer _cardContainer;
	public override void _Ready()
	{
		_cardContainer = GetNode<HBoxContainer>("Cards");

	}

	public void DrawCard(){
		MarginContainer container = new MarginContainer();
		var new_card = _resourceCard.Instantiate();

		new_card.Connect(Ui_Card.SignalName.I_was_selected_,Callable.From(_A_Card_Was_Selected));
		
		container.AddChild(new_card);
		_cardContainer.AddChild(container);
	}

	private void _A_Card_Was_Selected(){
		GD.Print("Un carta fue seleccionada");
	}
}
