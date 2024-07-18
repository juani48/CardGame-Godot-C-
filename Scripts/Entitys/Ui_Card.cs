using System;
using Card_Game_C;
using Godot;

public partial class Ui_Card : Node2D
{
	private Label _labelName;
	private Label _labelDamage;
	private Label _labelHealt;
	private Label _labelCost;
	private MarginContainer _cardArea;
	private TextureButton _selectedButton;

	//
	private Color _colorSelect = new Color((float)0.851, (float)0.886, 0); //Amarillo
	private Color _colorDefault = new Color((float)0.191, (float)0.191, (float)0.191); //Gris
	private ColorRect _borderColor;

	private Card _card;
	public override void _Ready()
	{
		//Sets child nodes
		_cardArea = GetNode<MarginContainer>("CardArea");
		_labelName = this.GetNode<Label>("CardArea/Bars/NameContainer/Name");
		_labelDamage = this.GetNode<Label>("CardArea/Bars/MidleContainer/MidleBar/Damage");
		_labelHealt = this.GetNode<Label>("CardArea/Bars/MidleContainer/MidleBar/Healt");
		_labelCost = this.GetNode<Label>("CardArea/Bars/CostContainer/Cost");
		_selectedButton = GetNode<TextureButton>("SelectedButton");
		_borderColor = this.GetNode<ColorRect>("BackColor2/Border");

		Position = Position - _cardArea.PivotOffset;
		Scale *= new Vector2((float)0.7, (float)0.7);

		_card = CardDataBase.getUnitCard();

		_labelName.Text = _card.Name;
		_labelDamage.Text = _card.Damage.ToString();
		_labelHealt.Text = _card.Healt.ToString();
		_labelCost.Text = _card.Cost.ToString();

		_borderColor.Color = _colorDefault;

		_selectedButton.Pressed += ()=> _CardSelect();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private bool _selected = false;
	public bool Selectable {get; set;} = true;
	[Signal] public delegate void I_was_selected_EventHandler();
	private void _CardSelect(){
		if(Selectable){
			if(!_selected){
				_borderColor.Color = _colorSelect;
			}
			else{
				_borderColor.Color = _colorDefault;
			}
			_selected = !_selected;
			EmitSignal(SignalName.I_was_selected_);
		}
		
	}
}
