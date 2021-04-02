using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSC.Core;
using UnityEngine.Tilemaps;

namespace DSC.Tilemap2D
{
    public static class Extension_Tilemap
    {
        /// <summary>
        /// Get tile cell position at cursor position.
        /// </summary>
        /// <param name="hTilemap">Tilemap</param>
        /// <returns>Tile cell position</returns>
        public static Vector3Int CellAtCursor(this Tilemap hTilemap)
        {
            return hTilemap.WorldToCell(InputUtility.GetCursorWorldPosition());
        }

        /// <summary>
        /// Get tile world position center at cursor position.
        /// </summary>
        /// <param name="hTilemap">Tilemap</param>
        /// <returns>Tile world position center</returns>
        public static Vector3 GetCellCenterWorldAtCursor(this Tilemap hTilemap)
        {
            return hTilemap.GetCellCenterWorld(hTilemap.CellAtCursor());
        }

        /// <summary>
        /// Get tile world position center at this position.
        /// </summary>
        /// <param name="hTilemap">Tilemap</param>
        /// <param name="vPos">World Position</param>
        /// <returns>Tile world position center</returns>
        public static Vector3 GetCellCenterWorldAtPosition(this Tilemap hTilemap,Vector3 vPos)
        {
            return hTilemap.GetCellCenterWorld(hTilemap.WorldToCell(vPos));
        }
    }
}
