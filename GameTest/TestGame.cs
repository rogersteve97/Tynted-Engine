﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ECSEngine;
using ECSEngine.Components;
using ECSEngine.SFML.Graphics;
using ECSEngine.SFML.System;

using Box2DNet.Common;
using ECSEngine.Systems;

namespace GameTest
{
	class TestGame : Game
	{
		public TestGame(GameOptions options) : base(options)
		{

		}

		protected override void Initialize()
		{
			SystemManager.RegisterEntityComponents(new List<KeyValuePair<int, IComponent>>()
			{
				new KeyValuePair<int, IComponent>(0, new SpriteRenderee(new Texture("Art/AirShip.png"))),
				new KeyValuePair<int, IComponent>(0, new ECSEngine.Components.Transform(new Vec2(1, 1))),
				new KeyValuePair<int, IComponent>(0, new RigidBody(new Vec2(10, 10), PhysicsManager.World)),

				new KeyValuePair<int, IComponent>(1, new SpriteRenderee(new Texture("Art/AirShip.png"))),
				new KeyValuePair<int, IComponent>(1, new ECSEngine.Components.Transform(new Vec2(300, 300))),
			});

			base.Initialize();
		}

		protected override void Update(GameTime gameTime)
		{

			base.Update(gameTime);
		}

		protected override void Draw(RenderWindow window)
		{


			base.Draw(window);
		}
	}
}
