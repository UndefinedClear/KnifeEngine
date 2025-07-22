using SFML.Graphics;
using SFML.System;

namespace KnifeEngine.Engine.UI;

public class TextObject
{
    private Text label;
    private Action onClick;
    private bool isHovered;

    public TextObject(string text, Font font, Vector2f position, Action clickAction, Color textColor, uint fontSize)
    {
        label = new Text(text, font, fontSize)
        {
            FillColor = textColor,
            Position = new Vector2f(position.X, position.Y)
        };

        onClick = clickAction;

        // clickAction like:
        // () =>
        //{
        //    Console.WriteLine("Starting Platformer...");
        //    Examples.PlatformerGameScene.Load();
        //}
    }

    public void Update(Vector2i mousePos)
    {
        FloatRect bounds = label.GetGlobalBounds();
        isHovered = bounds.Contains(mousePos.X, mousePos.Y);

        if (isHovered)
            Hovered();
    }

    public void CheckClick(Vector2i mousePos)
    {
        if (label.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
            onClick?.Invoke();
    }

    public void Hovered()
    {
        //shape.FillColor = isHovered ? new Color(100, 100, 100) : new Color(70, 70, 70);
    }

    public void Render(RenderTarget target)
    {
        target.Draw(label);
    }
}
