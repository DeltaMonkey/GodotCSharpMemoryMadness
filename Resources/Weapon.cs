using Godot;

[GlobalClass]
public partial class Weapon : Resource
{
    [Export] private int _damage;
    [Export] private int _delay;
    [Export] private string _weaponName;
    [Export] private Texture2D _texture;
    public Texture2D Texture { get { return _texture; } }
    public override string ToString()
    {
        return $"{_weaponName} - {_damage} - {_delay}";
    }
}
