﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Entoarox.Framework.Menus
{
    public class TextureComponent : BaseMenuComponent
    {
        public TextureComponent(Rectangle area, Texture2D texture, Rectangle? crop = null) : base(area, texture, crop)
        {

        }
    }
}
