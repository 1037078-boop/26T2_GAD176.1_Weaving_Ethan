using UnityEngine;

public class Quests : MonoBehaviour
{
	protected string Name;

	protected bool questActive;
	public virtual void Reward()
	{
		Debug.Log("Reward collected");
	}
}
