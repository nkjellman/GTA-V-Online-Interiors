using GTA;
using GTA.Native;
using GTA.Math;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

public class OfficeAssistant : Script
{
	private bool _spawnedStuff;
	private Ped MBTOfficeAssistant;

public OfficeAssistant()
{
    Tick += OnTick;
}

void OnTick(object sender, EventArgs e)
{
    if (!_spawnedStuff)
{
	MBTOfficeAssistant = World.CreatePed((Model)PedHash.ExecutivePAFemale02, new Vector3(-72.118f, -814.50f, 242.40f));
	MBTOfficeAssistant.Task.PlayAnimation("anim@amb@office@pa@female@", "pa_base", 8f, -1, true, -1f);
	Function.Call(Hash.SET_ENTITY_HEADING, MBTOfficeAssistant, 160f);
	Function.Call(Hash.FREEZE_ENTITY_POSITION, MBTOfficeAssistant, true);
	Function.Call(Hash.SET_ENTITY_INVINCIBLE, MBTOfficeAssistant, true);
	Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, MBTOfficeAssistant, 0x6F0783F5);
	Function.Call(Hash.SET_PED_COMPONENT_VARIATION, MBTOfficeAssistant, 0, 1, 3, 0);
	Function.Call(Hash.SET_PED_COMPONENT_VARIATION, MBTOfficeAssistant, 2, 2, 0, 0);
	Function.Call(Hash.SET_PED_COMPONENT_VARIATION, MBTOfficeAssistant, 3, 2, 0, 0);
	Function.Call(Hash.SET_PED_COMPONENT_VARIATION, MBTOfficeAssistant, 4, 1, 2, 0);
	Function.Call(Hash.SET_PED_COMPONENT_VARIATION, MBTOfficeAssistant, 6, 2, 2, 0);
	Function.Call(Hash.SET_PED_COMPONENT_VARIATION, MBTOfficeAssistant, 7, 2, 0, 0);
	Function.Call(Hash.SET_PED_COMPONENT_VARIATION, MBTOfficeAssistant, 8, 0, 0, 0);
	Function.Call(Hash.SET_PED_COMPONENT_VARIATION, MBTOfficeAssistant, 11, 1, 2, 0);

    _spawnedStuff = true;
}}}