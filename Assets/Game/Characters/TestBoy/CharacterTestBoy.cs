using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class CharacterTestBoy : CharacterScript<CharacterTestBoy>
{


	IEnumerator OnLookAt()
	{

		yield return E.Break;
	}
}