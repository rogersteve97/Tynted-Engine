﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.System;
using SFML.Graphics;

using ECSEngine;
using ECSEngine.Components;

namespace GameTest
{
	class TestGame : Game
	{
		public TestGame(GameOptions options) : base(options)
		{

		}

		protected override void Initialize()
		{
			SystemManager.AddEntityComponent(0, new SpriteRenderee(new Texture("Art/AirShip.png")));
			SystemManager.AddEntityComponent(0, new ECSEngine.Components.Transform(new Vector2f(0, 0)));

			SystemManager.AddEntityComponent(1, new SpriteRenderee(new Texture("Art/AirShip.png")));
			SystemManager.AddEntityComponent(1, new ECSEngine.Components.Transform(new Vector2f(300, 300)));

			base.Initialize();
		}

		protected override void Update(GameTime gameTime)
		{
			Console.WriteLine(1/gameTime.elapsedTime.AsSeconds());

			base.Update(gameTime);
		}

		protected override void Draw(RenderWindow window)
		{


			base.Draw(window);
		}
	}
}
