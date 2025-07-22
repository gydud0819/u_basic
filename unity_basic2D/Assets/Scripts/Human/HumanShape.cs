using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class HumanShape : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        [SerializeField] private Color legColor;
        [SerializeField] private int legSortingOrder = 0;

        private void Awake()
        {
            if (spriteRenderer == null)
            {
                spriteRenderer = GetComponent<SpriteRenderer>();
            }

        }

        public void SetRenderProperty(Color _color, int _orderCount)
        {
            spriteRenderer.color = _color;
            spriteRenderer.sortingOrder = _orderCount;
        }
    }

