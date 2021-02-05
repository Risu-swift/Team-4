using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace Health
{
   public class Damage : MonoBehaviour
   {
      /// <summary>
      /// Example implementation of Damage Script 
      /// </summary>
      public int damageAmt;

      public LayerMask layerMask;
     
      private HealthController _healthController;
      
      

      private void OnTriggerEnter(Collider other)
      {
         _healthController = other.gameObject.GetComponent<HealthController>();
         if ( _healthController != null)
         {
            _healthController.Damage(damageAmt);
            Debug.Log(this.gameObject + " Does " + damageAmt + " to " + other.gameObject.name);
         }
         else
         {
            Debug.LogError(other.gameObject + " Doesn't contain health Controller");
         }
        
            
      }
   }
}
