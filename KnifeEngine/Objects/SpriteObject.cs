using SFML.Graphics;
using SFML.System;
using KnifeEngine.Engine;

namespace KnifeEngine.Objects
{
    public class SpriteObject
    {
        private Texture texture;
        private Sprite sprite;
        private double id_;
        private bool visible_;
        private string tag_;


        public SpriteObject(string imagePath, Vector2f position, Vector2f size, double id, bool visible, string tag = "")
        {
            // Load the texture
            texture = new Texture(imagePath);

            // Create the SFML sprite
            sprite = new Sprite(texture);

            // Set position
            sprite.Position = position;

            // Set scale to match desired size
            Vector2u originalSize = texture.Size;
            sprite.Scale = new Vector2f(
                size.X / originalSize.X,
                size.Y / originalSize.Y
            );

            // Writing local vars into global
            visible_ = visible;
            id_ = id;
            tag_ = tag;
        }

        /// <summary>
        /// Renders the Sprite on the Screen
        /// </summary>
        /// <param name="target"></param>
        public void Render(RenderTarget target)
        {
            if (visible_)
            {
                target.Draw(sprite);
            }
        }

        /// <summary>
        /// Return ID of curerent sprite
        /// </summary>
        /// <returns></returns>
        public double GetID()
        {
            return id_;
        }

        // Tag System
        public string GetTag()
        {
            return tag_;
        }

        public void SetTag(string name)
        {
            tag_ = name;
        }

        // Collision
        public FloatRect GetGlobalBounds()
        {
            return sprite.GetGlobalBounds(); // Возвращает границы спрайта в мировых координатах
        }

        public bool CheckCollision(SpriteObject other)
        {
            return this.GetGlobalBounds().Intersects(other.GetGlobalBounds());
        }

        public bool CheckCollisionAt(Vector2f newPosition, SpriteObject other)
        {
            FloatRect newBounds = GetFutureBounds(newPosition);
            return newBounds.Intersects(other.GetGlobalBounds());
        }

        private FloatRect GetFutureBounds(Vector2f newPosition)
        {
            FloatRect bounds = sprite.GetGlobalBounds();
            return new FloatRect(newPosition.X, newPosition.Y, bounds.Width, bounds.Height);
        }


        private Vector2f customSize; // ручной размер
        private Vector2f hitboxOffset = new Vector2f(0, 0);

        public void SetHitbox(Vector2f size, Vector2f offset)
        {
            customSize = size;
            hitboxOffset = offset;
        }

        public FloatRect GetCustomBounds()
        {
            Vector2f pos = sprite.Position - sprite.Origin + hitboxOffset;
            return new FloatRect(pos, customSize);
        }


        public bool CheckCustomCollisionAt(Vector2f newPosition, SpriteObject other)
        {
            Vector2f pos = newPosition - sprite.Origin + hitboxOffset;
            FloatRect newBounds = new FloatRect(pos, customSize);
            return newBounds.Intersects(other.GetCustomBounds());
        }

        public Vector2f[] GetRotatedHitboxPoints()
        {
            Vector2f origin = sprite.Origin;         // Точка вращения (обычно центр)
            Vector2f position = sprite.Position;     // Позиция спрайта
            float rotation = sprite.Rotation;        // Угол поворота в градусах

            // 4 вершины хитбокса в локальных координатах (относительно спрайта)
            Vector2f topLeft = hitboxOffset;
            Vector2f topRight = new Vector2f(hitboxOffset.X + customSize.X, hitboxOffset.Y);
            Vector2f bottomRight = new Vector2f(hitboxOffset.X + customSize.X, hitboxOffset.Y + customSize.Y);
            Vector2f bottomLeft = new Vector2f(hitboxOffset.X, hitboxOffset.Y + customSize.Y);

            Vector2f RotatePoint(Vector2f point, Vector2f pivot, float angleDegrees)
            {
                float angleRadians = angleDegrees * (float)(Math.PI / 180);
                float cos = (float)Math.Cos(angleRadians);
                float sin = (float)Math.Sin(angleRadians);

                // Смещаем точку относительно pivot
                float dx = point.X - pivot.X;
                float dy = point.Y - pivot.Y;

                // Поворачиваем
                float rx = dx * cos - dy * sin;
                float ry = dx * sin + dy * cos;

                // Возвращаем в мировые координаты
                return new Vector2f(rx + pivot.X, ry + pivot.Y);
            }

            Vector2f[] localPoints = new Vector2f[4];
            localPoints[0] = RotatePoint(topLeft, origin, rotation);
            localPoints[1] = RotatePoint(topRight, origin, rotation);
            localPoints[2] = RotatePoint(bottomRight, origin, rotation);
            localPoints[3] = RotatePoint(bottomLeft, origin, rotation);

            // Переводим локальные точки в мировые, прибавляя позицию спрайта
            for (int i = 0; i < 4; i++)
            {
                localPoints[i] += position;
            }

            return localPoints;
        }

        public void DrawHitbox(RenderTarget target, Color color)
        {
            var points = GetRotatedHitboxPoints();

            // Create an array of vertices forming lines between the corners of the hitbox
            Vertex[] vertices = new Vertex[5];
            for (int i = 0; i < 4; i++)
            {
                vertices[i] = new Vertex(points[i], color);
            }

            // Close the loop by connecting the last point to the first
            vertices[4] = new Vertex(points[0], color);

            // Draw the hitbox lines
            target.Draw(vertices, PrimitiveType.LineStrip);
        }


        // Vibility
        public bool GetVisible()
        {
            return visible_;
        }
        public void SetVisible(bool value)
        {
            visible_ = value;
        }

        // Position
        public void SetPosition(Vector2f position)
        {
            sprite.Position = position;
        }

        public Vector2f GetPosition()
        {
            return sprite.Position;
        }

        // Rotation

        // Setting degrees of rotation (in degrees)
        public void SetRotation(float angle)
        {
            sprite.Rotation = angle;
        }

        // getting current degrees of rotation (in degrees)
        public float GetRotation()
        {
            return sprite.Rotation;
        }

        private bool rotateAroundCenter = false; // по умолчанию - поворот от точки (0,0)

        /// <summary>
        /// Enable or Disable Rotation "Aroud Center" or "Left Corner"<br></br>
        /// Use it only after changing size of object and settiong position<br></br>
        /// Before set size or position, set "false" and after (before rotation) set "true"
        /// </summary>
        public void SetRotateAroundCenter(bool enable)
        {
            if (rotateAroundCenter == enable)
                return; // Если уже в нужном режиме — ничего не делаем

            rotateAroundCenter = enable;

            FloatRect bounds = sprite.GetLocalBounds();

            Vector2f oldOrigin = sprite.Origin;
            Vector2f newOrigin;

            if (rotateAroundCenter)
            {
                // Новый origin — центр спрайта
                newOrigin = new Vector2f(bounds.Width / 2f, bounds.Height / 2f);
            }
            else
            {
                // Новый origin — левый верхний угол
                newOrigin = new Vector2f(0, 0);
            }

            // Сохраняем позицию до смены origin
            Vector2f positionBefore = sprite.Position;

            // Вычисляем разницу origin в мировых координатах с учетом масштаба
            Vector2f originDiff = new Vector2f(
                (newOrigin.X - oldOrigin.X) * sprite.Scale.X,
                (newOrigin.Y - oldOrigin.Y) * sprite.Scale.Y
            );

            // Устанавливаем новый origin
            sprite.Origin = newOrigin;

            // Корректируем позицию, чтобы визуально спрайт не сместился
            sprite.Position = new Vector2f(
                positionBefore.X + originDiff.X,
                positionBefore.Y + originDiff.Y
            );
        }

        /// <summary>
        /// Get state, current origin is center or not
        /// </summary>
        public bool GetRotateAroundCenter()
        {
            return rotateAroundCenter;
        }

        // Size
        public void SetSize(Vector2f size)
        {
            // Set scale to match desired size
            Vector2u originalSize = texture.Size;
            sprite.Scale = new Vector2f(
                size.X / originalSize.X,
                size.Y / originalSize.Y
            );
        }

        public Vector2f GetSize()
        {
            return sprite.Scale;
        }

        // Get SFML Sprite
        public Sprite GetSpriteSFML() { return sprite; }

        // Texture
        public void SetTexture(int id)
        {
            if (id >= 0 && id < TextureManager.textures.Count)
            {
                Texture newTexture = TextureManager.textures[id];

                // Только если текстура реально изменилась
                if (sprite.Texture != newTexture)
                {
                    texture = newTexture;
                    sprite.Texture = texture;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Текстура с ID {id} не найдена");
                Console.ResetColor();
            }
        }
    }
}
