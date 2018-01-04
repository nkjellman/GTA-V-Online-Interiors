using GTA;
using GTA.Native;
using GTA.Math;
using System;
using System.Collections.Generic;

public class OnlineInteriorsProps : GTA.Script
{
	
	public OnlineInteriorsProps()
	{
		List<int> Props = new List<int>();
		int LodDistance = 3000;            

		Func<int, Vector3, Vector3, bool, int> createProp = new Func<int, Vector3, Vector3, bool, int>(delegate(int hash, Vector3 pos, Vector3 rot, bool dynamic)
		{
			Model model = new Model(hash);
			model.Request(10000);
			Prop prop = GTA.World.CreateProp(model, pos, rot, dynamic, false);
			prop.Position = pos;
			prop.LodDistance = LodDistance;
			if (!dynamic)
				prop.FreezePosition = true;
			return prop.Handle;
		});
		bool Initialized = false;
		
		base.Tick += delegate (object sender, EventArgs args)
		{
			if (!Initialized)
			{
				//mbt office assistant chair
				Props.Add(createProp(1580642483, new GTA.Math.Vector3(-72.15f, -814.35f, 242.9929f), new GTA.Math.Vector3(1.272221E-14f, -8.036917E-15f, -19.99986f), false));
				//vehicle warehouse
				//office chair
				Props.Add(createProp(-853526657, new GTA.Math.Vector3(964.6f, -3002.7f, -40.05f), new GTA.Math.Vector3(1.00179E-05f, 5.008956E-06f, -51.99982f), false));
				//covered vehicles
				Props.Add(createProp(1171954070, new GTA.Math.Vector3(954.7f, -3018.3f, -37.88f), new GTA.Math.Vector3(0f, 0f, -89.99969f), false));
				Props.Add(createProp(-239044249, new GTA.Math.Vector3(954.7f, -3023.6f, -37.88f), new GTA.Math.Vector3(-5.97114E-13f, -5.008956E-06f, -89.99999f), false));
				Props.Add(createProp(-2063295939, new GTA.Math.Vector3(954.7f, -3028.65f, -37.88f), new GTA.Math.Vector3(1.001791E-05f, -5.008956E-06f, -89.99999f), false));
				Props.Add(createProp(726001049, new GTA.Math.Vector3(959.35f, -3035.9f, -37.88f), new GTA.Math.Vector3(1.001791E-05f, -5.008956E-06f, 0.2500072f), false));
				Props.Add(createProp(-556906753, new GTA.Math.Vector3(963.5f, -3036f, -37.88152f), new GTA.Math.Vector3(1.001791E-05f, 2.231179E-05f, 1.000003f), false));
				Props.Add(createProp(-758434067, new GTA.Math.Vector3(967.7f, -3035.9f, -37.88f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(-812602640, new GTA.Math.Vector3(971.85f, -3035.8f, -37.88f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(1171954070, new GTA.Math.Vector3(975.95f, -3036.2f, -37.88152f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(-239044249, new GTA.Math.Vector3(980.15f, -3036f, -37.88152f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(-2063295939, new GTA.Math.Vector3(993.15f, -3027.098f, -37.88f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(726001049, new GTA.Math.Vector3(998.5f, -3026.85f, -37.88152f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(-556906753, new GTA.Math.Vector3(1004f, -3026.995f, -37.88152f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(-758434067, new GTA.Math.Vector3(1009.25f, -3026.95f, -37.88152f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(-812602640, new GTA.Math.Vector3(978.15f, -3009.6f, -40.65f), new GTA.Math.Vector3(0f, 0f, 0f), false));
				Props.Add(createProp(1171954070, new GTA.Math.Vector3(978.05f, -2994.05f, -40.65f), new GTA.Math.Vector3(0f, 0f, 179.001f), false));
				//bunker desk chair
				Props.Add(createProp(1840382115, new GTA.Math.Vector3(908.6f, -3207.25f, -97.59f), new GTA.Math.Vector3(1.001791E-05f, -5.008955E-06f, 23.24998f), false));
				//hangar 
				//fake havok
				Props.Add(createProp(1210660950, new GTA.Math.Vector3(-1294.5f, -3004.25f, -49.5f), new GTA.Math.Vector3(1.001791E-05f, 5.008956E-06f, -89.99969f), false));
				//chilliad base secret door
				Props.Add(createProp(630616933, new GTA.Math.Vector3(-362.3418f, 4829.795f, 142.776f), new GTA.Math.Vector3(0f, 0f, -39.506f), false));
				//submarine
				Props.Add(createProp(1723871309, new GTA.Math.Vector3(-1291.835f, 6907.326f, -105.2364f), new GTA.Math.Vector3(0f, 0f, 90f), false));
				//Props.Add(createProp(2618681486, new GTA.Math.Vector3(-1291.835f, 6907.326f, -105.2364f), new GTA.Math.Vector3(0f, 0f, 90f), false));
				Props.Add(createProp(-1676285810, new GTA.Math.Vector3(-1291.835f, 6907.326f, -105.2364f), new GTA.Math.Vector3(0f, 0f, 90f), false));
				Initialized = true;
			}
			Prop returnedProp;

		};
	}
}