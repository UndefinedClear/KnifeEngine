using SFML.Graphics;
using SFML.System;

namespace KnifeEngine.Engine.UI;

public class ButtonObject
{
    private RectangleShape shape;
    private Text label;
    private Action onClick;
    private bool isHovered;

    private Color backgroundColor_;
    private Color hoverColor_;

    // Color.Color(r, g, b);
    // new Color(r, g, b)
    // 70, 70, 70 | 100, 100, 100
    public ButtonObject(string text, Font font, Vector2f position, Action clickAction, Color backgroundColor, Color hoveredColor)
    {
        shape = new RectangleShape(new Vector2f(300, 50));
        shape.FillColor = new Color(backgroundColor);
        shape.Position = position;

        label = new Text(text, font, 20)
        {
            FillColor = Color.White,
            Position = new Vector2f(position.X + 20, position.Y + 10)
        };

        onClick = clickAction;

        backgroundColor_ = backgroundColor;
        hoverColor_ = hoveredColor;
    }

    public void Update(Vector2i mousePos)
    {
        FloatRect bounds = shape.GetGlobalBounds();
        isHovered = bounds.Contains(mousePos.X, mousePos.Y);

        shape.FillColor = isHovered ? backgroundColor_ : hoverColor_;
    }

    public void CheckClick(Vector2i mousePos)
    {
        if (shape.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
            onClick?.Invoke();
    }

    public void Render(RenderTarget target)
    {
        target.Draw(shape);
        target.Draw(label);
    }
}
