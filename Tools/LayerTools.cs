using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LayerTools
{
    public static bool LayerInLayerMask(int layer, LayerMask layerMask)
		{
			if(((1 << layer) & layerMask) != 0)	
			{
				return true;
			}
			else
			{
				return false;
			}
		}
}
