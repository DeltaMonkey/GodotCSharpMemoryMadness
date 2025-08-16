using Godot;
using System;

public partial class ResouceLoader : Node
{
	[Export] private Weapon _weapon;
	[Export] private Sprite2D _sprite;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print(_weapon);
		_sprite.Texture = _weapon.Texture;
	}
}
