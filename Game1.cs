﻿using Microsoft.Xna.Framework;using Microsoft.Xna.Framework.Graphics;using Microsoft.Xna.Framework.Input;using System;using System.Reflection.Metadata;namespace BrickBreakerV3{public class Game1:Game{static Game1 gba;GraphicsDeviceManager g;SpriteBatch ba;Texture2D t;RB rp;bo b;pa p;Texture2D bt;public Game1(){gba=this;g=new GraphicsDeviceManager(this);Content.RootDirectory="Content";IsMouseVisible=true;}protected override void Initialize(){g.PreferredBackBufferWidth=420;g.PreferredBackBufferHeight=980;g.ApplyChanges();t=new Texture2D(GraphicsDevice,1,1);t.SetData(new Color[]{Color.LightGoldenrodYellow});rp=new RB(50,70);b=new bo();p=new pa();base.Initialize();}protected override void LoadContent(){ba=new SpriteBatch(GraphicsDevice);bt=Content.Load<Texture2D>("ball");}protected override void Update(GameTime ti){if(GamePad.GetState(PlayerIndex.One).Buttons.Back==ButtonState.Pressed||Keyboard.GetState().IsKeyDown(Keys.Escape))Exit();base.Update(ti);}protected override void Draw(GameTime gt){GraphicsDevice.Clear(Color.Yellow);ba.Begin();ba.Draw(t,new Rectangle(50,70,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,100,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,130,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,160,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,190,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,220,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,250,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,280,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,310,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,340,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,370,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,400,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,430,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,460,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(50,490,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,70,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,100,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,130,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,160,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,190,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,220,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,250,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,280,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,310,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,340,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,370,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,400,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,430,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,460,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(130,490,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,70,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,100,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,130,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,160,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,190,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,220,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,250,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,280,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,310,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,340,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,370,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,400,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,430,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,460,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(210,490,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,70,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,100,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,130,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,160,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,190,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,220,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,250,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,280,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,310,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,340,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,370,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,400,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,430,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,460,75,25),new Color(218,165,32));ba.Draw(t,new Rectangle(290,490,75,25),new Color(218,165,32));Color color=new Color(218,165,32);ba.Draw(bt,new Vector2((GraphicsDevice.Viewport.Bounds.Width/2)-16,GraphicsDevice.Viewport.Bounds.Height-200),Color.White);ba.End();base.Draw(gt);}}}
