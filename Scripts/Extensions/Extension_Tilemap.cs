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
        public static Vector3Int GetTileCellPositionAtCursor(this Tilemap hTilemap)
        {
            return hTilemap.WorldToCell(InputUtility.GetCursorWorldPosition());
        }

        /// <summary>
        /// Get tile world position center at cursor position.
        /// </summary>
        /// <param name="hTilemap">Tilemap</param>
        /// <returns>Tile world position center</returns>
        public static Vector3 GetTileWorldPositionCenterAtCursor(this Tilemap hTilemap)
        {
            return hTilemap.GetCellCenterWorld(hTilemap.GetTileCellPositionAtCursor());
        }
    }
}
