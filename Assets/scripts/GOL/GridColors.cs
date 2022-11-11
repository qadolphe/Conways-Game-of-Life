using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridColors : MonoBehaviour
{
    private gol_data grid;
    private Mesh mesh;

    void OnEnable() {
      gol_data.onUpdate += UpdateVisual;
    }

    void OnDisable() {
      gol_data.onUpdate -= UpdateVisual;
    }

    public void SetGrid(gol_data grid) {
      this.grid = grid;
      UpdateVisual();
    }

    private void Awake() {
      mesh = new Mesh();
      GetComponent<MeshFilter>().mesh = mesh;
    }


    private void UpdateVisual() {
      //CreateMeshArrays(Grid.width * Grid.height, out Vector3[] vertices,
      //                              out Vector2[] uvs, out int[] triangles);
      MeshUtils.CreateEmptyMeshArrays(Grid.width * Grid.height, out Vector3[] vertices,
                                   out Vector2[] uvs, out int[] triangles);

      for (int x = 0; x < Grid.width; x++) {
        for (int y = 0; y < Grid.height; y++) {
          int index = x * Grid.height + y;
          Vector3 squareSize = new Vector3(Grid.cellSize, Grid.cellSize);

          int gridValue = grid.getState(x,y);
          Vector2 gridUV = new Vector2(0f, (float)gridValue);
          MeshUtils.AddToMeshArrays(vertices, uvs, triangles, index, grid.GetPosition(x,y) + squareSize/2f, 0f, squareSize, gridUV, gridUV);
        }
      }
      mesh.vertices = vertices;
      mesh.uv = uvs;
      mesh.triangles = triangles;
    }

    private void CreateMeshArrays(int squareCount, out Vector3[] verticies,
                                  out Vector2[] uvs, out int[] triangles) {
      verticies = new Vector3[4 * squareCount]; //4 for points in square
      uvs = new Vector2[4 * squareCount];
      triangles = new int[6 * squareCount]; //6 for 3 points in triangle * 2 triangles
    }

    //definitnly not my work
    private void AddToMeshArrays(Vector3[] verticies, Vector2[] uvs, int[] triangles,
                  int index, Vector3 pos, float rot, Vector3 baseSize, Vector2 uv00, Vector2 uv11) {
      int[] vIndex = new int[4];
      vIndex[0] = index*4;
      for (int i = 1; i < 4; i++) {
        vIndex[i] = vIndex[i - 1] + 1;
      }

      bool skewed = baseSize.x != baseSize.y;

     //verticies
      if (skewed) {
        verticies[vIndex[0]] = pos + new Vector3(-baseSize.x, baseSize.y);
        verticies[vIndex[1]] = pos + new Vector3(-baseSize.x, -baseSize.y);
        verticies[vIndex[2]] = pos + new Vector3(baseSize.x, -baseSize.y);
        verticies[vIndex[3]] = pos + new Vector3(0,baseSize.y,0);
      } else {
        verticies[vIndex[0]] = pos + new Vector3(0,baseSize.y,0);
        verticies[vIndex[1]] = pos + new Vector3(0,baseSize.y,0);
        verticies[vIndex[2]] = pos + new Vector3(0,baseSize.y,0);
        verticies[vIndex[3]] = pos + new Vector3(0,baseSize.y,0);
      }

      //uvs
      uvs[vIndex[0]] = new Vector2(uv00.x, uv11.y);
      uvs[vIndex[1]] = new Vector2(uv00.x, uv00.y);
      uvs[vIndex[2]] = new Vector2(uv11.x, uv00.y);
      uvs[vIndex[3]] = new Vector2(uv11.x, uv11.y);

      //triangles
      int tIndex = index*6;

      triangles[tIndex+0] = vIndex[0];
      triangles[tIndex+1] = vIndex[3];
      triangles[tIndex+2] = vIndex[1];

      triangles[tIndex+3] = vIndex[1];
      triangles[tIndex+4] = vIndex[3];
      triangles[tIndex+5] = vIndex[2];
    }


}
