using UnityEngine;

namespace TheBonwater.Rebuild {
    public static class MapPlacementService {
        public static float playableXMin = 0.30f;
        public static float playableXMax = 0.88f;
        public static float playableYMin = 0.12f;
        public static float playableYMax = 0.88f;

        // Note: The prompt implies Y=0 is Top, Y=1 is Bottom.
        // top edge: y 0.18
        // bottom edge: y 0.84
        // Unity world Y: max.y is top, min.y is bottom.
        public static Vector2 MapNormalizedToWorld(float nx, float ny, Bounds mapBounds) {
            float worldX = Mathf.Lerp(mapBounds.min.x, mapBounds.max.x, nx);
            float worldY = Mathf.Lerp(mapBounds.max.y, mapBounds.min.y, ny);
            return new Vector2(worldX, worldY);
        }

        public static Vector2 ClampToPlayableArea(Vector2 worldPos, Bounds mapBounds) {
            float minX = Mathf.Lerp(mapBounds.min.x, mapBounds.max.x, playableXMin);
            float maxX = Mathf.Lerp(mapBounds.min.x, mapBounds.max.x, playableXMax);
            
            // Because Y is inverted (ny=0 is max.y, ny=1 is min.y)
            float maxY = Mathf.Lerp(mapBounds.max.y, mapBounds.min.y, playableYMin); // This is higher world Y
            float minY = Mathf.Lerp(mapBounds.max.y, mapBounds.min.y, playableYMax); // This is lower world Y

            worldPos.x = Mathf.Clamp(worldPos.x, minX, maxX);
            worldPos.y = Mathf.Clamp(worldPos.y, minY, maxY);
            return worldPos;
        }

        public static bool IsInsidePlayableArea(Vector2 worldPos, Bounds mapBounds) {
            float minX = Mathf.Lerp(mapBounds.min.x, mapBounds.max.x, playableXMin);
            float maxX = Mathf.Lerp(mapBounds.min.x, mapBounds.max.x, playableXMax);
            
            float maxY = Mathf.Lerp(mapBounds.max.y, mapBounds.min.y, playableYMin);
            float minY = Mathf.Lerp(mapBounds.max.y, mapBounds.min.y, playableYMax);

            return worldPos.x >= minX && worldPos.x <= maxX && worldPos.y >= minY && worldPos.y <= maxY;
        }

        public static Vector2 GetRandomEdgeSpawn() {
            int edge = Random.Range(0, 3);
            float nx = 0.5f;
            float ny = 0.5f;

            switch(edge) {
                case 0: // top edge
                    nx = Random.Range(0.35f, 0.82f);
                    ny = 0.18f;
                    break;
                case 1: // right edge
                    nx = 0.84f;
                    ny = Random.Range(0.25f, 0.76f);
                    break;
                case 2: // bottom edge
                    nx = Random.Range(0.35f, 0.82f);
                    ny = 0.84f;
                    break;
            }
            return new Vector2(nx, ny);
        }
    }
}
